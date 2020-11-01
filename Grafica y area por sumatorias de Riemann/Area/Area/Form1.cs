using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Form1 : Form
    {
        public double a= 0, b=0, n=0, r=0, h = 0, p=0, j=0, x;
        public Form1()
        {
            InitializeComponent();
            Button1.Click += new EventHandler(Button1_Click);
            Button2.Click += new EventHandler(Button2_Click);
            Button3.Click += new EventHandler(Button3_Click);
        }
        private double Function(double x)
        {

            return (Math.Pow(x, 3) - 4 * Math.Pow(x, 2) + 3 * x - 2);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-10, 10);
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(-10, 10);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.Series[0].Color = Color.Black;
            chart1.Series[1].Color = Color.Red;
            for(double i= a;i <= b; i = i+0.01)
            {
                chart1.Series[1].Points.AddXY(i, Function(i));
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
                a = double.Parse(TextBox1.Text);
                b = double.Parse(TextBox2.Text);
                n = double.Parse(TextBox3.Text);
                p = double.Parse(TextBox4.Text);
                if (a == b)
                {
                    Label6.Text = "El Area es 0";
                }
                else if (a > b)
                {
                    Label6.Text = "El límite inferior debe ser menor o igual al límite superior";
                }
                else
                {
                    h = ((b - a) / n);
                    if (p == 1)
                    {
                    x = a;
                    for (j = 1; j <= n; j++)
                        {
                            if (j == 1)
                            {
                            
                            r = (h * ((Math.Pow(x, 3)) - 4 * (Math.Pow(x, 2)) + 3 * (x) - 2));
                            }
                            else
                            {

                                x = x + h;
                                r = r + (h * ((Math.Pow(x, 3)) - 4 * (Math.Pow(x, 2)) + 3 * (x) - 2));
                            }
                        }
                        r = Math.Round(r, 3);
                        Label6.Text = "El area por arriba es " + r;
                    }
                    if (p == 2)
                    {
                    x = b;
                        for (j = 1; j <= n; j++)
                        {
                            if (j == 1)
                            {

                                r = (h * ((Math.Pow(x, 3)) - 4 * (Math.Pow(x, 2)) + 3 * (x) - 2));

                            }
                            else
                            {
                                x = x - h;

                                r = r + (h * ((Math.Pow(x, 3)) - 4 * (Math.Pow(x, 2)) + 3 * (x) - 2));

                            }
                        }
                        r = Math.Round(r, 3);
                        Label6.Text = "El area por abajo es " + r;
                    }
                }
         }

           
        private void Button3_Click(object sender, System.EventArgs e)
        {
            a = 0;
            b = 0;
            n = 0;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label6.Text = "El area es";
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

        }
        
    }
    }
        