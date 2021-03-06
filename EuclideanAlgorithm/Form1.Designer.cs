﻿namespace EuclideanAlgorithm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_b = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Results = new System.Windows.Forms.TextBox();
            this.button_loops = new System.Windows.Forms.Button();
            this.numericUpDown_loops = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Method = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_getGCD = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LineGraph = new System.Windows.Forms.Button();
            this.Ftestbutton = new System.Windows.Forms.Button();
            this.Ttestbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Location = new System.Drawing.Point(66, 16);
            this.numericUpDown_a.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown_a.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericUpDown_a.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_a.TabIndex = 1;
            this.numericUpDown_a.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.Location = new System.Drawing.Point(66, 42);
            this.numericUpDown_b.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown_b.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericUpDown_b.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_b.Name = "numericUpDown_b";
            this.numericUpDown_b.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_b.TabIndex = 2;
            this.numericUpDown_b.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_b.ValueChanged += new System.EventHandler(this.numericUpDown_b_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "x=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "n=";
            // 
            // textBox_Results
            // 
            this.textBox_Results.Location = new System.Drawing.Point(12, 156);
            this.textBox_Results.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Results.Multiline = true;
            this.textBox_Results.Name = "textBox_Results";
            this.textBox_Results.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Results.Size = new System.Drawing.Size(338, 224);
            this.textBox_Results.TabIndex = 6;
            // 
            // button_loops
            // 
            this.button_loops.Location = new System.Drawing.Point(254, 38);
            this.button_loops.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_loops.Name = "button_loops";
            this.button_loops.Size = new System.Drawing.Size(84, 24);
            this.button_loops.TabIndex = 7;
            this.button_loops.Text = "BarGraph";
            this.button_loops.UseVisualStyleBackColor = true;
            this.button_loops.Click += new System.EventHandler(this.button_loops_Click);
            // 
            // numericUpDown_loops
            // 
            this.numericUpDown_loops.Location = new System.Drawing.Point(254, 15);
            this.numericUpDown_loops.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown_loops.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_loops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_loops.Name = "numericUpDown_loops";
            this.numericUpDown_loops.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown_loops.TabIndex = 8;
            this.numericUpDown_loops.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "loops=";
            // 
            // comboBox_Method
            // 
            this.comboBox_Method.FormattingEnabled = true;
            this.comboBox_Method.Items.AddRange(new object[] {
            "function 1",
            "function 2",
            "function 3",
            "Math.Pow"});
            this.comboBox_Method.Location = new System.Drawing.Point(66, 68);
            this.comboBox_Method.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_Method.Name = "comboBox_Method";
            this.comboBox_Method.Size = new System.Drawing.Size(122, 21);
            this.comboBox_Method.TabIndex = 10;
            this.comboBox_Method.SelectedIndexChanged += new System.EventHandler(this.comboBox_Method_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Method:";
            // 
            // button_getGCD
            // 
            this.button_getGCD.Location = new System.Drawing.Point(66, 95);
            this.button_getGCD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_getGCD.Name = "button_getGCD";
            this.button_getGCD.Size = new System.Drawing.Size(120, 23);
            this.button_getGCD.TabIndex = 12;
            this.button_getGCD.Text = "Go";
            this.button_getGCD.UseVisualStyleBackColor = true;
            this.button_getGCD.Click += new System.EventHandler(this.button_getGCD_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(354, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(472, 366);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(254, 97);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(84, 24);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearGraph_Click);
            // 
            // LineGraph
            // 
            this.LineGraph.Location = new System.Drawing.Point(254, 68);
            this.LineGraph.Name = "LineGraph";
            this.LineGraph.Size = new System.Drawing.Size(84, 23);
            this.LineGraph.TabIndex = 15;
            this.LineGraph.Text = "LineGraph";
            this.LineGraph.UseVisualStyleBackColor = true;
            this.LineGraph.Click += new System.EventHandler(this.lineGraph_Click);
            // 
            // Ftestbutton
            // 
            this.Ftestbutton.Location = new System.Drawing.Point(68, 127);
            this.Ftestbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Ftestbutton.Name = "Ftestbutton";
            this.Ftestbutton.Size = new System.Drawing.Size(120, 23);
            this.Ftestbutton.TabIndex = 16;
            this.Ftestbutton.Text = "F-Test";
            this.Ftestbutton.UseVisualStyleBackColor = true;
            this.Ftestbutton.Click += new System.EventHandler(this.Ftestbutton_Click);
            // 
            // Ttestbutton
            // 
            this.Ttestbutton.Location = new System.Drawing.Point(218, 127);
            this.Ttestbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Ttestbutton.Name = "Ttestbutton";
            this.Ttestbutton.Size = new System.Drawing.Size(120, 23);
            this.Ttestbutton.TabIndex = 17;
            this.Ttestbutton.Text = "T-Test";
            this.Ttestbutton.UseVisualStyleBackColor = true;
            this.Ttestbutton.Click += new System.EventHandler(this.Ttestbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 385);
            this.Controls.Add(this.Ttestbutton);
            this.Controls.Add(this.Ftestbutton);
            this.Controls.Add(this.LineGraph);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_getGCD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Method);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_loops);
            this.Controls.Add(this.button_loops);
            this.Controls.Add(this.textBox_Results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_b);
            this.Controls.Add(this.numericUpDown_a);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "GCD";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.NumericUpDown numericUpDown_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Results;
        private System.Windows.Forms.Button button_loops;
        private System.Windows.Forms.NumericUpDown numericUpDown_loops;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Method;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_getGCD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button LineGraph;
        private System.Windows.Forms.Button Ftestbutton;
        private System.Windows.Forms.Button Ttestbutton;
    }
}

