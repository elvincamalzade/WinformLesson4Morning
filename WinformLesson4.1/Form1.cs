using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLesson4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.AutoScroll = true;



            //NUMERIC UP DOWN

            numericUpDown1.Minimum = 10;
            numericUpDown1.Maximum = 30;

            numericUpDown1.Increment = 0.5M;
            numericUpDown1.DecimalPlaces = 2;




            //TOOLTIP

            toolTip1.SetToolTip(pictureBox1, "Information on Picture");

            guna2HtmlToolTip1.SetToolTip(button1, "Ela tooltip");


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //label1.Text = vScrollBar1.Value.ToString();
           
        }
        int scroll = 0;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (scroll >= hScrollBar1.Value)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 6, pictureBox1.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 6, pictureBox1.Location.Y);
            }
            scroll = hScrollBar1.Value;
        }
        int scroll2 = 0;
        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (scroll2 >= vScrollBar1.Value)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-6);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+6);
            }
            scroll2 = vScrollBar1.Value;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = progressBar1.Value.ToString();
            progressBar1.PerformStep();
            
            
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }
    }
}
