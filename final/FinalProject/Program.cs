using System;
using System.Windows.Forms;

namespace YourGameProject
{
    static class Program
    {
        // [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}