using System;
using System.Windows.Forms;
using WindowsFormsApplication2;

public class Movingballs
{
    public static void Mapin()
    {
        Console.WriteLine("Main - ball animation");
        ObjectFrame application = new ObjectFrame();
        Application.Run(application);
        System.Console.WriteLine("Main - End of the Main()");
    }
}

