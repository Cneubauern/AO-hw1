namespace EuclideanAlgorithm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Location = new System.Drawing.Point(132, 31);
            this.numericUpDown_a.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.numericUpDown_a.Size = new System.Drawing.Size(240, 31);
            this.numericUpDown_a.TabIndex = 1;
            this.numericUpDown_a.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.Location = new System.Drawing.Point(132, 81);
            this.numericUpDown_b.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.numericUpDown_b.Size = new System.Drawing.Size(240, 31);
            this.numericUpDown_b.TabIndex = 2;
            this.numericUpDown_b.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "x=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "n=";
            // 
            // textBox_Results
            // 
            this.textBox_Results.Location = new System.Drawing.Point(24, 239);
            this.textBox_Results.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_Results.Multiline = true;
            this.textBox_Results.Name = "textBox_Results";
            this.textBox_Results.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Results.Size = new System.Drawing.Size(672, 489);
            this.textBox_Results.TabIndex = 6;
            // 
            // button_loops
            // 
            this.button_loops.Location = new System.Drawing.Point(415, 74);
            this.button_loops.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_loops.Name = "button_loops";
            this.button_loops.Size = new System.Drawing.Size(269, 149);
            this.button_loops.TabIndex = 7;
            this.button_loops.Text = "Over Loops";
            this.button_loops.UseVisualStyleBackColor = true;
            this.button_loops.Click += new System.EventHandler(this.button_loops_Click);
            // 
            // numericUpDown_loops
            // 
            this.numericUpDown_loops.Location = new System.Drawing.Point(509, 29);
            this.numericUpDown_loops.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.numericUpDown_loops.Size = new System.Drawing.Size(189, 31);
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
            this.label3.Location = new System.Drawing.Point(421, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "loops=";
            // 
            // comboBox_Method
            // 
            this.comboBox_Method.FormattingEnabled = true;
            this.comboBox_Method.Items.AddRange(new object[] {
            "function 1",
            "function 2",
            "function 3"});
            this.comboBox_Method.Location = new System.Drawing.Point(131, 131);
            this.comboBox_Method.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox_Method.Name = "comboBox_Method";
            this.comboBox_Method.Size = new System.Drawing.Size(239, 33);
            this.comboBox_Method.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Method:";
            // 
            // button_getGCD
            // 
            this.button_getGCD.Location = new System.Drawing.Point(132, 182);
            this.button_getGCD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_getGCD.Name = "button_getGCD";
            this.button_getGCD.Size = new System.Drawing.Size(240, 44);
            this.button_getGCD.TabIndex = 12;
            this.button_getGCD.Text = "Go";
            this.button_getGCD.UseVisualStyleBackColor = true;
            this.button_getGCD.Click += new System.EventHandler(this.button_getGCD_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(708, 29);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(944, 704);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 745);
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
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
    }
}

