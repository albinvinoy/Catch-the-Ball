namespace WindowsFormsApplication2
{
    partial class ObjectFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Top_lbl = new System.Windows.Forms.Label();
            this.Bottom_lbl = new System.Windows.Forms.Label();
            this.Basket = new System.Windows.Forms.PictureBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Score_lbl = new System.Windows.Forms.TextBox();
            this.MissedBox = new System.Windows.Forms.TextBox();
            this.Success_lbl = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_lbl
            // 
            this.Top_lbl.BackColor = System.Drawing.Color.Gold;
            this.Top_lbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top_lbl.ForeColor = System.Drawing.Color.Black;
            this.Top_lbl.Location = new System.Drawing.Point(0, 0);
            this.Top_lbl.Name = "Top_lbl";
            this.Top_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Top_lbl.Size = new System.Drawing.Size(1366, 36);
            this.Top_lbl.TabIndex = 0;
            this.Top_lbl.Text = "Catch the falling ball";
            this.Top_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bottom_lbl
            // 
            this.Bottom_lbl.BackColor = System.Drawing.Color.Turquoise;
            this.Bottom_lbl.Location = new System.Drawing.Point(2, 579);
            this.Bottom_lbl.Name = "Bottom_lbl";
            this.Bottom_lbl.Size = new System.Drawing.Size(1366, 141);
            this.Bottom_lbl.TabIndex = 1;
            // 
            // Basket
            // 
            this.Basket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Basket.BackColor = System.Drawing.Color.Chocolate;
            this.Basket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Basket.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Basket.Location = new System.Drawing.Point(638, 542);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(74, 34);
            this.Basket.TabIndex = 3;
            this.Basket.TabStop = false;
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(47, 596);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(97, 32);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.TabStop = false;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(266, 663);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(97, 32);
            this.Exit_btn.TabIndex = 0;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Pause_btn
            // 
            this.Pause_btn.Location = new System.Drawing.Point(266, 596);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(97, 32);
            this.Pause_btn.TabIndex = 0;
            this.Pause_btn.TabStop = false;
            this.Pause_btn.Text = "Pause";
            this.Pause_btn.UseVisualStyleBackColor = true;
            this.Pause_btn.Click += new System.EventHandler(this.Pause_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(47, 663);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(97, 32);
            this.Clear_btn.TabIndex = 0;
            this.Clear_btn.TabStop = false;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(615, 596);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Ball Caught";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1045, 596);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Ball Missed";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(837, 596);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Success Percent";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Score_lbl
            // 
            this.Score_lbl.BackColor = System.Drawing.Color.Turquoise;
            this.Score_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Score_lbl.Cursor = System.Windows.Forms.Cursors.No;
            this.Score_lbl.Enabled = false;
            this.Score_lbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_lbl.ForeColor = System.Drawing.Color.Chartreuse;
            this.Score_lbl.Location = new System.Drawing.Point(657, 622);
            this.Score_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Score_lbl.MaxLength = 20;
            this.Score_lbl.Multiline = true;
            this.Score_lbl.Name = "Score_lbl";
            this.Score_lbl.ReadOnly = true;
            this.Score_lbl.Size = new System.Drawing.Size(62, 47);
            this.Score_lbl.TabIndex = 0;
            this.Score_lbl.TabStop = false;
            this.Score_lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MissedBox
            // 
            this.MissedBox.BackColor = System.Drawing.Color.Turquoise;
            this.MissedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MissedBox.Cursor = System.Windows.Forms.Cursors.No;
            this.MissedBox.Enabled = false;
            this.MissedBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissedBox.ForeColor = System.Drawing.Color.Red;
            this.MissedBox.Location = new System.Drawing.Point(1087, 622);
            this.MissedBox.Margin = new System.Windows.Forms.Padding(0);
            this.MissedBox.MaxLength = 20;
            this.MissedBox.Multiline = true;
            this.MissedBox.Name = "MissedBox";
            this.MissedBox.ReadOnly = true;
            this.MissedBox.Size = new System.Drawing.Size(62, 47);
            this.MissedBox.TabIndex = 0;
            this.MissedBox.TabStop = false;
            // 
            // Success_lbl
            // 
            this.Success_lbl.BackColor = System.Drawing.Color.Turquoise;
            this.Success_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Success_lbl.Cursor = System.Windows.Forms.Cursors.No;
            this.Success_lbl.Enabled = false;
            this.Success_lbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Success_lbl.ForeColor = System.Drawing.Color.Purple;
            this.Success_lbl.Location = new System.Drawing.Point(849, 622);
            this.Success_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Success_lbl.MaxLength = 100;
            this.Success_lbl.Multiline = true;
            this.Success_lbl.Name = "Success_lbl";
            this.Success_lbl.ReadOnly = true;
            this.Success_lbl.Size = new System.Drawing.Size(127, 47);
            this.Success_lbl.TabIndex = 0;
            this.Success_lbl.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Crimson;
            this.progressBar1.Location = new System.Drawing.Point(989, 7);
            this.progressBar1.Maximum = 15;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 23);
            this.progressBar1.Step = -1;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 15;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Gold;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(921, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 19);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Life :";
            // 
            // ObjectFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1297, 707);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Success_lbl);
            this.Controls.Add(this.MissedBox);
            this.Controls.Add(this.Score_lbl);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Pause_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.Bottom_lbl);
            this.Controls.Add(this.Top_lbl);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "ObjectFrame";
            this.Text = "Catch the ball";
            this.Load += new System.EventHandler(this.ObjectFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Top_lbl;
        private System.Windows.Forms.Label Bottom_lbl;
        private System.Windows.Forms.PictureBox Basket;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Pause_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Score_lbl;
        private System.Windows.Forms.TextBox MissedBox;
        private System.Windows.Forms.TextBox Success_lbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox4;
    }
}

