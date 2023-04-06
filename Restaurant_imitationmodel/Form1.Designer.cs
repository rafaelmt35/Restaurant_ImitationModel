namespace Restaurant_imitationmodel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.NBE = new System.Windows.Forms.NumericUpDown();
            this.NGE = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NGC = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.COM = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.AC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NBF = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.SC = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NBE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество плохих сотрудников";
            // 
            // NBE
            // 
            this.NBE.DecimalPlaces = 1;
            this.NBE.Location = new System.Drawing.Point(215, 41);
            this.NBE.Name = "NBE";
            this.NBE.Size = new System.Drawing.Size(91, 20);
            this.NBE.TabIndex = 1;
            // 
            // NGE
            // 
            this.NGE.DecimalPlaces = 1;
            this.NGE.Location = new System.Drawing.Point(528, 43);
            this.NGE.Name = "NGE";
            this.NGE.Size = new System.Drawing.Size(91, 20);
            this.NGE.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество хороших сотрудников";
            // 
            // NGC
            // 
            this.NGC.DecimalPlaces = 1;
            this.NGC.Location = new System.Drawing.Point(838, 48);
            this.NGC.Name = "NGC";
            this.NGC.Size = new System.Drawing.Size(91, 20);
            this.NGC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество хороших поваров";
            // 
            // COM
            // 
            this.COM.DecimalPlaces = 1;
            this.COM.Location = new System.Drawing.Point(838, 92);
            this.COM.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.COM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(91, 20);
            this.COM.TabIndex = 11;
            this.COM.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Реклама (0.1 - 0.8)";
            // 
            // AC
            // 
            this.AC.DecimalPlaces = 1;
            this.AC.Location = new System.Drawing.Point(528, 87);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(91, 20);
            this.AC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Доступные клиенты";
            // 
            // NBF
            // 
            this.NBF.DecimalPlaces = 1;
            this.NBF.Location = new System.Drawing.Point(215, 85);
            this.NBF.Name = "NBF";
            this.NBF.Size = new System.Drawing.Size(91, 20);
            this.NBF.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Количество плохой еды";
            // 
            // SC
            // 
            this.SC.DecimalPlaces = 1;
            this.SC.Location = new System.Drawing.Point(215, 137);
            this.SC.Name = "SC";
            this.SC.Size = new System.Drawing.Size(91, 20);
            this.SC.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Сидящие клиенты";
            // 
            // chart1
            // 
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(26, 199);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1181, 584);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(1059, 53);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(109, 76);
            this.btRun.TabIndex = 15;
            this.btRun.Text = "RUN";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 815);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.SC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.COM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NBF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NGC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NGE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NBE);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NBE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NBE;
        private System.Windows.Forms.NumericUpDown NGE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NGC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown COM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NBF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown SC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Timer timer1;
    }
}

