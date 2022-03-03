using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_4
{
    public partial class Form1 : Form
    {
        Padding pad = new Padding();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (pad.Left != 0)
            {
                pad.Right += 5;
                pad.Left -= 5;
                ShowText.Padding = pad;
            }
            else if (pad.Left == 0)
            {
                pad.Left = pad.Right;
                pad.Right = 0;
                ShowText.Padding = pad;
            }

            if (timer1.Interval == 10)
            {
                btnFast.Enabled = false;
            }
            else
            {
                btnFast.Enabled = true;
            }

            if (timer1.Interval == 200)
            {
                btnSlow.Enabled = false;
            }
            else
            {
                btnSlow.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (pad.Right != 0)
            {
                pad.Right -= 5;
                pad.Left += 5;
                ShowText.Padding = pad;
            }
            else if (pad.Right == 0)
            {
                pad.Right = pad.Left;
                pad.Left = 0;
                ShowText.Padding = pad;
            }

            if (timer2.Interval == 10)
            {
                btnFast.Enabled = false;
            }
            else
            {
                btnFast.Enabled = true;
            }

            if (timer2.Interval == 200)
            {
                btnSlow.Enabled = false;
            }
            else
            {
                btnSlow.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pad.Left = 275;
            pad.Right = 275;
            ShowText.Padding = pad;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            timer1.Interval -= 10;
            timer2.Interval -= 10;
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            timer1.Interval += 10;
            timer2.Interval += 10;
        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {
            ShowText.Text = txtShow.Text;
        }
    }
}
