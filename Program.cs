using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Kel5_Manajemen_Travel
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the FromLogin form
            FromLogin form = new FromLogin();

            // Set the form to be full screen
            Screen screen = Screen.FromHandle(form.Handle);
            Rectangle bounds = screen.Bounds;
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Size = new Size(bounds.Width, bounds.Height);

            // Run the application with the full screen form
            Application.Run(form);
        }
    }
}
