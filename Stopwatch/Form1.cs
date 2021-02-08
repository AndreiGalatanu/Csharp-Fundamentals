using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        int ms01 = 0;
        int ms10 = 0;
        int sec01 = 0;
        int sec10 = 0;
        int min01 = 0;
        int min10 = 0;
        int h01 = 0;
        bool running = false;
        public Form1()
        {
         
            InitializeComponent();
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (running == false)
            {
                timer1.Start();
                running = true;
                button1.Text = "Stop";
                button1.BackColor = Color.FromArgb(223, 51, 154);

            }
            else if (true)
            {
                timer1.Stop();
                running = false;
                button1.Text = "Start";
                button1.BackColor = Color.FromArgb(97, 227, 232);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ms01 = 0;
            ms10 = 0;
            sec01 = 0;
            sec10 = 0;
            min01 = 0;
            min10 = 0;
            h01 = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            // miliseconds
            ms01++;
            if (ms01 == 10 && ms10 != 5)
            {
                ms10++;
                ms01 = 0;
            }
            else if (ms01 == 9 && ms10 == 5)
            {
                sec01++;
                ms01 = 0;
                ms10 = 0;
            }

            //seconds
            if (sec01 == 10 && sec10 != 5)
            {
                sec10++;
                sec01 = 0;
            }
            else if (sec01 == 9 && sec10 == 5)
            {
                min01++;
                sec01 = 0;
                sec10 = 0;

            }

            //minutes


            if (min01 == 10 && min10 != 5)
            {
                min10++;
                min01 = 0;

            }
            else if (min01 == 9 && min10 == 5)
            {
                h01++;
                min01 = 0;
                min10 = 0;
            }

            label2.Text = Convert.ToString(h01);
            label3.Text = min10.ToString();
            label4.Text = min01.ToString();
            label5.Text = sec10.ToString();
            label6.Text = Convert.ToString(sec01);
            label9.Text = Convert.ToString(ms10);
            label10.Text = Convert.ToString(ms01);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            label1.Text = time.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();

        }
    }
}
