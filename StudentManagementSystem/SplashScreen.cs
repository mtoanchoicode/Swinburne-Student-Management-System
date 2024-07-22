using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class SplashScreen : Form
    {
        private System.Windows.Forms.Timer Timer;

        public SplashScreen()
        {
            InitializeComponent();
            Timer = new System.Windows.Forms.Timer();  // Initialize the Timer
            Timer.Interval = 20;  // Set the interval
            Timer.Tick += new EventHandler(SplashTimer_Tick);  // Subscribe to the Tick event
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SlidePanel.Width += 15;
            if (SlidePanel.Width >= 600)  // Stop the Timer once the panel width reaches the form width
            {
                Timer.Stop();
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SlidePanel.Width = 0;
            Timer.Start();
        }
    }
}
