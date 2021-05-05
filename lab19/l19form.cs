using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double h = 0.1;
            double y1, y2;
            double x1, x2;
            double x, y;
            x = a;
            this.chart1.Series[0].Points.Clear();
            while ( x <= b ){
                x1 = 2 * x;
                x2 = 5 * x1;
                y1 = Math.Sin(x1) + Math.Pow(x1, 0.5) - 1.3 * Math.Pow(x1, 3);
                y2 = Math.Pow(x2, 3);
                y = y1 - y2;
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }

        private void Form1_Load(object sender, EventArgs e){
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 50);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-1, 1);
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
        }
    }
}
