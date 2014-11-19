using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuclideanAlgorithm
{
    public partial class Form1 : Form
    {
        public static int numIterations;

        public Form1()
        {
            InitializeComponent();

            comboBox_Method.SelectedIndex = 0;  //Sub
        }

        private void button_getGCD_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericUpDown_a.Value);
            int n = Convert.ToInt32(numericUpDown_b.Value);

            Stopwatch timer = new Stopwatch();   //other way to initialize: Stopwatch timer = Stopwatch.StartNew();

            timer.Start();

            numIterations = 0;

            double res = 0;
            switch (comboBox_Method.SelectedIndex)
            {
                case 0:
                    res = function_1(x, n);
                    break;
                case 1:
                    res = function_2(x, n);
                    break;
                case 2:
                    res = function_3(x, n);
                    break;
                default:
                    return;
            }

            timer.Stop();
            textBox_Results.AppendText("\r\n Func Value: " + res);

            //textBox_Results.AppendText("\r\n CPU-time(ticks):" + timer.ElapsedTicks);
            //textBox_Results.AppendText("\r\n CPU-time(ms):" + timer.ElapsedMilliseconds);
            //textBox_Results.AppendText("\r\n Number of iterations:" + numIterations);
        }

        double function_1(int x, int n)
        {
            double res = 1;
            while (n > 0) {
                res *= x;
                n -= 1;
            }
            return res;
        }

        double function_2(int x, int n)
        {
            if (n == 1)
                return x;
            else
                return x * function_2(x, n - 1);
        }

        double function_3(double x, double n)
        {
            if (n == 0)
                return x;
            if (n % 2 == 0)
                return x * function_3(x, n / 2);
            else
                return x * function_3(x, n - 1);
        }

        /** LOOPS */
        private void button_loops_Click(object sender, EventArgs e)
        {
            ulong l_a = Convert.ToUInt64(numericUpDown_a.Value);
            ulong l_b = Convert.ToUInt64(numericUpDown_b.Value);

            List<long> listCPUTimes = new List<long>();

            int numOfLoops = (int)numericUpDown_loops.Value;

            Stopwatch timer = new Stopwatch();   //other way to initialize: Stopwatch timer = Stopwatch.StartNew();

            for (int i = 0; i < numOfLoops; i++)
            {
                timer.Reset();
                timer.Start();

                switch (comboBox_Method.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    default:
                        return;
                }

                timer.Stop();
                listCPUTimes.Add(timer.ElapsedTicks);
                textBox_Results.AppendText("\r\n Iteration " + i.ToString() + ", CPU-time(ticks):" + timer.ElapsedTicks);
            }

            //Get Mean and SD
            double meanCPUTicks = getMean(listCPUTimes);
            double varianceCPUTicks = getVariance(listCPUTimes);
            double standardDeviationCPUTicks = Math.Sqrt(varianceCPUTicks);

            textBox_Results.AppendText("\r\n Mean CPU-time(ticks):" + meanCPUTicks);
            textBox_Results.AppendText("\r\n Standard Deviation CPU-time(ticks):" + standardDeviationCPUTicks);

            //Get Median
			//ToDo: your implementation
            double medianCPUTicks = getMedian(listCPUTimes);

            //Get Histogram
			//ToDo: your implementation
            long startHisto = 0; //get min value
            long endHisto = 0; //get max value

            List<int> histo = getHistogram(startHisto, endHisto, listCPUTimes);

            //Get Mode
			//ToDo: your implementation



            //show normalized histogram, probability density of CPU-time (ticks)
            double[] histoNormalized = getNormalizedHistogram(startHisto, endHisto, listCPUTimes);
            textBox_Results.AppendText("\r\n Normalized histogram:");
            for (int i = 0; i < histoNormalized.Count(); i++)
                textBox_Results.AppendText("\r\n" + i.ToString() + ": " + histoNormalized[i]);

            //add data to chart
            chart1.Series[0].Points.Clear();

            //ToDo: your implementation
            double cpuTicksHistoCounter=0;

            foreach (double probCPUTicks in histoNormalized)
            {
                //add datapoint X,Y to chart
                chart1.Series[0].Points.AddXY(cpuTicksHistoCounter, probCPUTicks);

                //compute next counter
                //ToDo: your implementation
            }
        }

        public static double getMedian(List<long resultset)
        {
          long d = 0;
          foreach (long t in resultset)
          {
            d += t;
          }
          if (resultset.Count!= 0)
              return d / resultset.Count;
          else
              return d;
        }

        public static double getMode(List<long resultset)
        {
        return 0;
        }

        public static double getMean(List<long> resultset)
        {
            //ToDo: your implementation
            ulong number = Convert.ToUInt64(resultset.Count);
            ulong x = 0;
            foreach (ulong time in resultset)
            {
              x += time;
            }
          return x / number;
        }

        public static double getOnlineMean( double counter, double old_mean, double new_result)
        {
          double mean = 0.0;
          double s = 0.0
            //ToDo: your implementation
            if(counter <= allIterations)
              mean= ((counter-1)*old_mean+new_result)/counter;
            return mean;
        }

        public static double getVariance(List<long> resultSet)
        {
            //ToDo: your implementation
            int v = 0;
            int n = resultSet.Count();
            int m = (int)getMean(resultSet);
            foreach (int x in resultSet)
            {
                v += (x - m) * (x-m);
            }
            return v/n;
        }

        public static List<int> getHistogram(double start, double end, List<long> data)
        {
			//ToDo: your implementation
            int num_bins = 1;

            List<int> histo = new List<int>(num_bins);

            return histo;
        }

        public static double[] getNormalizedHistogram(double start, double end, List<long> data)
        {
        
			//ToDo: your implementation
            int num_bins = (int)Math.Round(Math.Sqrt(data.Count));

            double[] histo = new double[num_bins];


            return histo;
        }

    }
}
