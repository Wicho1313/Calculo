using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_entre_2_funciones
{
    public partial class Form1 : Form
    {
        public double m = 0, b=0, a1=0, b1=0, c1=0, x1=0, x2=0, r=0, k=0, q=0;
        private void button3_Click(object sender, EventArgs e)
        {
            m = 0;
            b = 0;
            a1 = 0;
            b1 = 0;
            c1 = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            a1 = double.Parse(textBox3.Text);
            b1 = double.Parse(textBox4.Text);
            c1 = double.Parse(textBox5.Text);
            k = (b1 - m);
            q = (c1 - b);
            x1 = (-k + Math.Sqrt(k * k - 4 * a1 * q)) / (2 * a1);
            x2 = (-k - Math.Sqrt(k * k - 4 * a1 * q)) / (2 * a1);
            if (x1 > x2)
            {
                x1 = Math.Round(x1, 3);
                textBox7.Text = "" + x1;
                x2 = Math.Round(x2, 3);
                textBox6.Text = "" + x2;
        
                r = ((((a1 * Math.Pow(x1, 3)) / (3)) + ((k * Math.Pow(x1, 2)) / (2)) + ((q * x1))) - (((a1 * Math.Pow(x2, 3)) / (3)) + ((k * Math.Pow(x2, 2)) / (2)) + ((q * x2))));
                if (r < 0)
                {
                    r = r * -1;
                    r = Math.Round(r, 3);
                    textBox8.Text = "" + r;
                }
                else
                {
                    r = Math.Round(r, 3);
                    textBox8.Text = "" + r;
                }
            }
            else if (x2 > x1)
            {
                x2 = Math.Round(x2, 3);
                textBox7.Text = "" + x2;
                x1 = Math.Round(x1, 3);
                textBox6.Text = "" + x1;
               
                r = ((((a1 * Math.Pow(x2, 3)) / (3)) + ((k * Math.Pow(x2, 2)) / (2)) + ((q * x2))) - (((a1 * Math.Pow(x1, 3)) / (3)) + ((k * Math.Pow(x1, 2)) / (2)) + ((q * x1))));
                if (r < 0)
                {
                    r = r * -1;
                    r = Math.Round(r, 3);
                    textBox8.Text = "" + r;
                }
                else
                {
                    r = Math.Round(r, 3);
                    textBox8.Text = "" + r;
                }
            }
            else
            {
                x1 = Math.Round(x1, 3);
                textBox7.Text = "0" + x1;
                x2 = Math.Round(x2, 3);
                textBox6.Text = "0" + x2;

                textBox8.Text = "No se puede factorizar la ecuacion con numeros reales";
            }
        }

        public Form1()
        {
           
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
        }
        double Function (double x)
        {
        
            return (a1*Math.Pow(x,2)+b1*x+c1);
            
        }
        double Recta (double x)
        {
            return (m*x+b);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            m = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            a1 = double.Parse(textBox3.Text);
            b1 = double.Parse(textBox4.Text);
            c1 = double.Parse(textBox5.Text);
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-5, 5);
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(-10, 10);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.Series[0].Color = Color.Black;
            chart1.Series[1].Color = Color.Red;
            chart1.Series[2].Color = Color.Blue;
            if (x1 > x2)
            {
                for (double i = x2 -1; i <= x1+1; i = i + 0.01)
                {
                    chart1.Series[0].Points.AddXY(i, Function(i));
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }
                for (double i = x2-1 ; i <= x1  +1; i = i + 0.01)
                {
                    chart1.Series[1].Points.AddXY(i, Recta(i));
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
                for (double i = x2 ; i <= x1 ; i = i + 0.01)
                {
                    chart1.Series[2].Points.AddXY(i, Function(i));
                    chart1.Series[2].Points.AddXY(i, Recta(i));
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }
            }
            if (x2 > x1)
            {
                for (double i = x1-1 ; i <= x2+1 ; i = i + 0.01)
                {
                    chart1.Series[0].Points.AddXY(i, Function(i));
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }
                for (double i = x1 -1; i <= x2+1 ; i = i + 0.01)
                {
                    chart1.Series[1].Points.AddXY(i, Recta(i));
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
                for (double i = x1; i <= x2; i = i + 0.01)
                {
                    chart1.Series[2].Points.AddXY(i, Function(i));
                    chart1.Series[2].Points.AddXY(i, Recta(i));
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }
            }
            else
            {
                for (double i = -10; i <= 10; i = i + 0.01)
                {
                    chart1.Series[0].Points.AddXY(i, Function(i));
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
                for (double i = -10; i <= 10; i = i + 0.01)
                {
                    chart1.Series[1].Points.AddXY(i, Recta(i));
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
            }
        }
    }
}
