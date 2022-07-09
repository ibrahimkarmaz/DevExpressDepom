using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders13GaugeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // linearScaleComponent1.Value = 100;
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("a");
            digitalGauge1.Text = DateTime.Now.ToShortTimeString();
            linearScaleComponent1.Value += 1;
            linearScaleComponent2.Value += 1;
            linearScaleComponent3.Value += 1;
        }

        private void gaugeControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
