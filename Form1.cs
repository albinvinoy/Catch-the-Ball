using System;
using System.Drawing;
using System.Timers;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ObjectFrame : Form
    {

        FindResolution res = new FindResolution();
        public  int formheight;
        public  int formwidth/* = 1366*/;
        private int score = 0;
        private double percent = 0.0;
        private int missed = 0;

        // set ball conditions
        public const int radius_of_ball = 10;
        // How fast it will fall
        private double distance_move_per_refresh = 2.5;

        // This will start ball at 50 pixes to the right
       private double ball_real_cord_x = 50;
        // This will start the ball Y down
        // The value is randomly generated below
        private double ball_real_cord_y;

        private int ball_int_x_cord;
        private int ball_int_y_cord;
        private double ball_horizontal_delta;
        private double ball_vertical_delta;
        private double ball_radians;
        private static System.Timers.Timer ball_refresh_clock = new System.Timers.Timer();
        private bool ball_clock_active = false;
        
        // graphical area setting
        private double graphicalarearefresh = 60.0; //TRIAL AND ERROR
        public static System.Timers.Timer graphical_area_refresh_clock = new System.Timers.Timer();
        public const double ball_update_rate = 60; //TRIAL AND ERROR
        
        public ObjectFrame()
        {
            //ball_refresh_clock.Close();
            //graphical_area_refresh_clock.Dispose();

            //This is not how you should do it...// but oh well!!!
            formwidth = res.sizeOfScreen().Width;
            formheight = res.sizeOfScreen().Height;
            InitializeComponent();
         //this.BackColor = Color.AliceBlue;

            //Return a random location for the x axis of the ball
            RandomXLocation location = new RandomXLocation();
            ball_real_cord_x = location.get_ball_x_start_coord();
            ball_int_y_cord = (int)(ball_real_cord_y);
            ball_int_x_cord = (int)(ball_real_cord_x);
            ball_refresh_clock.Enabled = false;

            // ball direction logic
            Logic algorithm = new Logic();
            ball_radians = algorithm.get_direction_for_ball();
            ball_horizontal_delta = distance_move_per_refresh * Math.Cos(ball_radians);
            ball_vertical_delta = distance_move_per_refresh * Math.Sin(ball_radians);

            // graphical refresh setting
            graphical_area_refresh_clock.Enabled = false;

            //Threads
     
            // event handlers
            graphical_area_refresh_clock.Elapsed += Graphical_area_refresh_clock_Elapsed;
            ball_refresh_clock.Elapsed += Ball_control_clock_Elapsed;
            KeyDown += ObjectFrame_KeyDown1;
            // functions
            //Start_a_clock(ball_update_rate);
            //Start_graphic_clock(graphicalarearefresh);
        }
        private void ObjectFrame_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           
            MessageBox.Show("Use 'A' to move the basket left\nUse 'D' to move the basket right\nPress the 'Start Button' to Start the Game\nYou have - 15 - Life\n"
                , "Instructions V1.0", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        protected void Start_graphic_clock(double graphicalarearefresh)
        {
            double elapsed_time_between_tics;
            if (graphicalarearefresh < 1.0) graphicalarearefresh = 1.0;
            elapsed_time_between_tics = 1000.0 / graphicalarearefresh;
            graphical_area_refresh_clock.Interval = (int)System.Math.Round(elapsed_time_between_tics);
            graphical_area_refresh_clock.Enabled = true;
            Console.WriteLine("Start Graphics Clock");
            // throw new NotImplementedException();
        }
        protected void Graphical_area_refresh_clock_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invalidate();
            if (!(ball_clock_active))
            {
                graphical_area_refresh_clock.Enabled = false;
                System.Console.WriteLine("Graphical Area Refresh Clock: {0}", graphical_area_refresh_clock.Enabled);
            }
            //throw new NotImplementedException();
        }
        protected void Ball_control_clock_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            ball_real_cord_x = ball_real_cord_x + ball_horizontal_delta;
            //the y-axis cartesian points are inverted than standard points
            ball_real_cord_y = ball_real_cord_y - ball_vertical_delta;
            ball_int_y_cord = (int)System.Math.Round(ball_real_cord_y);
            ball_int_x_cord = (int)System.Math.Round(ball_real_cord_x);
            System.Console.WriteLine("The location of the ball : {0}x - {1}y", ball_int_x_cord, ball_int_y_cord);
            if (((ball_int_x_cord+radius_of_ball) >= Basket.Left && ball_int_x_cord <= Basket.Right) && ball_int_y_cord >= formheight - (formheight - Basket.Top))
            {

                Thread start_again = new Thread(Start_Again);
                score++;
                /*
                *** IMPORTANT : THIS IS HOW YOU PERFORM CROSS THREAD CALL ***
                */

                UpdateScoreBox();
                UpdatePercentScore();
                System.Console.WriteLine("Score is: {0}", score);
                ball_clock_active = false;
                ball_refresh_clock.Enabled = false;
                graphical_area_refresh_clock.Enabled = false;

                start_again.Start();
                while (!start_again.IsAlive)
                {
                    Thread.Sleep(2);
                }
                // Thread start_again = new Thread(Start_Again);
            }
            else if (ball_int_x_cord >= formwidth || ball_int_y_cord + 2 * radius_of_ball <= 0 || ball_int_y_cord >= formheight - (formheight - Bottom_lbl.Top) /*- 2 * radius_of_ball*/)
            {
                Thread start_again = new Thread(Start_Again);
                missed++;
                progressBar1.PerformStep();
                if(progressBar1.Value == 0)
                {
                    ball_clock_active = false;
                    ball_refresh_clock.Enabled = false;
                    graphical_area_refresh_clock.Enabled = false;
                    string message = "Thank you for Playing. \nYour score is: " + score.ToString() + " points.\nThe Program will now Exit!";
                    MessageBox.Show(message, "Exit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                UpdateMissedBox();
                UpdatePercentScore();
                ball_clock_active = false;
                ball_refresh_clock.Enabled = false;
                graphical_area_refresh_clock.Enabled = false;
                start_again.Start();

                //need to properly understand what this does
                while (!start_again.IsAlive)
                {
                    Thread.Sleep(2);
                }

               // Start_Again();
            }
        }
        private void UpdateMissedBox()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(UpdateMissedBox);
                Invoke(method);
                return;
            }
            MissedBox.Text = "";
            MissedBox.Text = missed.ToString();
        }
        private void UpdateFrom()
        {
            if (InvokeRequired)
            {
                MethodInvoker update = new MethodInvoker(UpdateFrom);
                Invoke(update);
                return;
            }
            else
            {
                Invalidate();
                Update();
            }
        }
        private void ObjectFrame_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if(Basket.Left >= 0)
                Basket.Left -= 20;
                //  Console.WriteLine("Left");
            }
            if (e.KeyCode == Keys.D)
            {
                if(Basket.Right <= formwidth)
                Basket.Left += 20;
                // Console.WriteLine("Right");
            }
            if (e.KeyCode == Keys.W)
            {
                Basket.Top += 0;
                //  Console.WriteLine("Up");
            }
            if (e.KeyCode == Keys.S)
            {
                Basket.Left -= 0;
                //Console.WriteLine("Down");
            }
        }
        protected void Start_a_clock(double refresh_clock)
        {
            double elapsed_time_between_moves;
            if (refresh_clock < 1.0) refresh_clock = 1.0;
            elapsed_time_between_moves = 1000.0 / refresh_clock;
            ball_refresh_clock.Interval = (int)System.Math.Round(elapsed_time_between_moves);
            ball_refresh_clock.Enabled = true;
            ball_clock_active = true;
            System.Console.WriteLine("Start ball clock: started");
            //throw new NotImplementedException();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            graph.FillEllipse(Brushes.Red, ball_int_x_cord, ball_int_y_cord, 2 * radius_of_ball, 2 * radius_of_ball);
            base.OnPaint(e);
        }
        // ***This is how you peform a cross thread call: w/o parameters***
        private void UpdateScoreBox()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(UpdateScoreBox);
                Invoke(method);
                return;
            }
            Score_lbl.Text = "";
            Score_lbl.Text = score.ToString();
        }
        private void Start_Again()
        {
            ball_real_cord_y = 0;
            // lets try this
            RandomXLocation location = new RandomXLocation(); //new thread
            ball_real_cord_x = location.get_ball_x_start_coord();
            ball_int_y_cord = (int)(ball_real_cord_y);                      ////////// this back to 0
            ball_int_x_cord = (int)(ball_real_cord_x);
            ball_refresh_clock.Enabled = false;

            // ball direction logic
            Logic algorithm = new Logic();
            ball_radians = algorithm.get_direction_for_ball();
            ball_horizontal_delta = distance_move_per_refresh * Math.Cos(ball_radians);
            ball_vertical_delta = distance_move_per_refresh * Math.Sin(ball_radians);

            // end of lets try this
            distance_move_per_refresh += .25;
            ball_clock_active = false;
            graphical_area_refresh_clock.Close();
            ball_refresh_clock.Close();
            //CreateGraphics().Clear(ActiveForm.BackColor);
            UpdateFrom();
            ball_clock_active = true;
            ball_refresh_clock.Enabled = true;
            graphical_area_refresh_clock.Enabled = true;

            Start_a_clock(ball_update_rate);
            Start_graphic_clock(graphicalarearefresh);
        }
        private void UpdatePercentScore()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(UpdatePercentScore);
                Invoke(method);
                return;
            }
            else
            {
                percent = ((double)(score / ((double)score + missed)))*100;
                Success_lbl.Text = "";
                percent = Math.Round(percent, 2);
                Success_lbl.Text = percent.ToString() + "%";
            }
        }

        #region Buttons
        //buttons
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            graphical_area_refresh_clock.Dispose();
            ball_refresh_clock.Dispose();
            this.CreateGraphics().Clear(Form.ActiveForm.BackColor);
        }
        private void Pause_btn_Click(object sender, EventArgs e)
        {
            graphical_area_refresh_clock.Dispose();
            ball_refresh_clock.Dispose();
        }
        private void Start_btn_Click(object sender, EventArgs e)
        {
            Start_a_clock(ball_update_rate);
            Start_graphic_clock(graphicalarearefresh);
            Start_btn.Enabled = false;
        }



        #endregion

       
    }
}

