namespace Area
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(15, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(870, 30);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Programa que calcula el area de la función x^3 - 4x^2 + 3x - 2";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(15, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(110, 30);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Límite inferior";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(15, 105);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(110, 30);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Límite superior";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(15, 150);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(110, 30);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Particiones";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(15, 195);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(110, 30);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Bool";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(25, 280);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(250, 30);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Area es";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(140, 60);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(70, 24);
            this.TextBox1.TabIndex = 1;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(140, 105);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(70, 24);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(140, 150);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(70, 24);
            this.TextBox3.TabIndex = 1;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(140, 195);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(70, 24);
            this.TextBox4.TabIndex = 1;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(15, 240);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(110, 30);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Calcular area";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(25, 315);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(175, 30);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Graficar";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(25, 360);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(175, 30);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "Limpiar";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(265, 60);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Funcion";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Area";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(623, 328);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

