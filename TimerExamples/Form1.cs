using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimerExamples
{
    public partial class Form1 : Form
    {
        int counter = 0;
        Random rnd = new Random();

        Stopwatch myWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Start")
            {
                countTimer.Enabled = true;
                startButton.Text = "Pause";

                myWatch.Reset();
                myWatch.Start();
            }
            else
            {
                countTimer.Enabled = false;
                startButton.Text = "Start";

                myWatch.Stop();
                stopwatchLabel.Text = myWatch.Elapsed.ToString(@"ss\:ff");
            }
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            countLabel.Text = $"{counter}";


            if(counter %3 == 0)
            {
                int r = rnd.Next(0, 255);
                int g = rnd.Next(0, 255);
                int b = rnd.Next(0, 255);

                colourLabel.BackColor = Color.FromArgb(r, g, b);
            }

            //if(counter %3 == 0)
            //{
            //    colourLabel.BackColor = Color.Blue;
            //}
            //else if (counter %3 == 1)
            //{
            //    colourLabel.BackColor = Color.Green;
            //}
            //else
            //{
            //    colourLabel.BackColor = Color.White;
            //}
        }
    }
}
