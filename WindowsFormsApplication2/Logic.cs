using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication2;

class Logic
{
    public double get_direction_for_ball()
    {
        double direction = Math.PI * 1.5;
        return direction;
    }
}

class RandomXLocation
{
    public System.Random start_X = new System.Random();
    FindResolution res = new FindResolution();
    public double get_ball_x_start_coord()
    {
        double number = start_X.Next(ObjectFrame.radius_of_ball * 2 + 5, res.sizeOfScreen().Width- ObjectFrame.radius_of_ball * 2);
        return number;
    }
}

class FindResolution
{
    public System.Drawing.Size size_;

    public System.Drawing.Size sizeOfScreen()
    {
        System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;

        // Set the size of the form slightly less than size of 
        // working rectangle.
        size_ = new System.Drawing.Size(workingRectangle.Width, workingRectangle.Height);

        return size_;
        // Set the location so the entire form is visible.
        //this.Location = new System.Drawing.Point(5, 5);
    }
}
