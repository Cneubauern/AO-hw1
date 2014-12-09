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
using System.Windows.Forms.DataVisualization.Charting;

namespace EuclideanAlgorithm
{
    public partial class Form1 : Form
    {
        public static int numIterations;
        public static int graphMinimum = 100;

        public Form1()
        {
            InitializeComponent();

            comboBox_Method.SelectedIndex = 0;  //Sub
        }

        private void button_getGCD_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericUpDown_a.Value);
            ulong n = Convert.ToUInt64(numericUpDown_b.Value);

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
                case 3:
                    res = Math.Pow(x, n);
                    break;
                default:
                    return;
            }

            timer.Stop();
            String name = comboBox_Method.SelectedItem.ToString();
            textBox_Results.AppendText("\r\n" + name);
            textBox_Results.AppendText("\r\n Func Value: " + res);

            textBox_Results.AppendText("\r\n CPU-time(ticks):" + timer.ElapsedTicks);
            textBox_Results.AppendText("\r\n CPU-time(ms):" + (double)timer.ElapsedMilliseconds);
            textBox_Results.AppendText("\r\n Number of iterations:" + numIterations);
            timer.Reset();
        }

        double function_1(int x, ulong n)
        {
            double res = 1;
            while (n > 0) {
                ++numIterations;
                res *= x;
                n -= 1;
            }
            return res;
        }

        double function_2(int x, ulong n)
        {
           ++numIterations;

            if (n == 1)
                return x;
            else
                return x * function_2(x, n - 1);
        }

        double function_3(double x, ulong n)
        {
            ++numIterations;

            if (n == 1)
            {
                return x;
            }

            if ((n & 1) == 0)
            {
                return function_3(x * x, n>> 1);
            }
            else
            {
                return x * function_3(x * x, (n - 1)>> 1);
            }
        }

        /** LOOPS */
        private void button_loops_Click(object sender, EventArgs e)
        {
            String buttonName = (sender as Button).Text.ToString();
            int x = Convert.ToInt32(numericUpDown_a.Value);
            ulong n = Convert.ToUInt64(numericUpDown_b.Value);

            List<long> listCPUTimes = new List<long>();
            List<int> listIterations = new List<int>();

            int numOfLoops = (int)numericUpDown_loops.Value;

            Stopwatch timer = new Stopwatch();   //other way to initialize: Stopwatch timer = Stopwatch.StartNew();
            String funcName = comboBox_Method.SelectedItem.ToString();

            double res = 0;
            for (int i = 0; i < numOfLoops; i++)
            {
                timer.Reset();
                timer.Start();

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
                    case 3:
                        res = Math.Pow(x, n);
                        break;
                    default:
                        return;
                }

                timer.Stop();

                if (i != 0)
                {
                    listCPUTimes.Add(timer.ElapsedTicks);
                    listIterations.Add(numIterations);

                  //  textBox_Results.AppendText("\r\n Iteration " + i.ToString() + ", CPU-time(ticks):" + timer.ElapsedTicks);
                  //  textBox_Results.AppendText("\r\n Number of iterations:" + numIterations);
                  //  textBox_Results.AppendText("\r\n");
                }

                numIterations = 0;
            }

            //Get Mean and SD
            double meanCPUTicks = getMean(listCPUTimes);
            double varianceCPUTicks = getVariance(listCPUTimes);
            double standardDeviationCPUTicks = Math.Sqrt(varianceCPUTicks);

            textBox_Results.AppendText("\r\n Mean CPU-time(ticks):" + meanCPUTicks);
            textBox_Results.AppendText("\r\n variance CPU-time(ticks):" +varianceCPUTicks);
            textBox_Results.AppendText("\r\n Standard Deviation CPU-time(ticks):" + standardDeviationCPUTicks);

            //Get Median
			//ToDo: your implementation
            double medianCPUTicks = getMedian(listCPUTimes);

            //Get Histogram
			//ToDo: your implementation
            ulong startHisto = getMinValue(listCPUTimes); //get min value
            ulong endHisto = getMaxValue(listCPUTimes); //get max value
            double[] histoNormalized = getNormalizedHistogram(startHisto, endHisto, listCPUTimes);

            switch (buttonName)
            {
                case "BarGraph":
                    drawGraph(chart1, histoNormalized, funcName,n,startHisto,endHisto);
                    break;
                case "LineGraph":
                    drawLineGraph(chart1, listCPUTimes, funcName);
                    break;
            }
            listCPUTimes.Clear();
        }

        public static void drawGraph(Chart chart1, double[] histo, String funcName, ulong n, ulong start, ulong end)
        {
            //if (chart1.Series.Count != 0 && chart1.Series[0].ChartType != SeriesChartType.Bar)
            //    chart1.Series.Clear();

            Series series;
            String seriesname = funcName + "n = " + n;
            double bin_size = (end - start)/(ulong)histo.Count();
            double cpuTicksHistoCounter = 0;

            //Console.Write("chart1.Series[0].ChartType: " + chart1.Series[0].ChartType);

            if (!chart1.Series.IsUniqueName(seriesname))
            {
                chart1.Series[seriesname].Points.Clear();
                //chart1.Series.Remove(chart1.Series[seriesArr[i]]);
            }
            else
            {
                series = chart1.Series.Add(seriesname);
            }

            foreach (double probCPUTicks in histo)
            {
                //add datapoint X,Y to chart
      //          chart1.Series[seriesname].Points.AddXY(cpuTicksHistoCounter, probCPUTicks);
                chart1.Series[seriesname].Points.AddXY(cpuTicksHistoCounter*bin_size+start, probCPUTicks);
                ++cpuTicksHistoCounter;
                
            }
        }

        public static void drawLineGraph(Chart chart1, List<long> cputTimes, String funcName)
        {
            if (chart1.Series.Count != 0 && chart1.Series[0].ChartType != SeriesChartType.Spline)
                chart1.Series.Clear();

            Series series;
            double cpuTicksHistoCounter = 0;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = getYMinimum(cputTimes);

            if (!chart1.Series.IsUniqueName(funcName))
            {
                chart1.Series[funcName].Points.Clear();
                 //chart1.Series.Remove(chart1.Series[seriesArr[i]]);
            }
            else
            {
                series = chart1.Series.Add(funcName);
                series.ChartType = SeriesChartType.Spline;
            }

            foreach (long cpuTicks in cputTimes)
            {
                //add datapoint X,Y to chart
                chart1.Series[funcName].Points.AddXY(cpuTicksHistoCounter, cpuTicks);
                ++cpuTicksHistoCounter;
            }
        }

        private static int getYMinimum(List<long> cpuTimes)
        {
            int newMinimum = 0;

            foreach(long cpuTime in cpuTimes)
            {
                if(cpuTime < graphMinimum)
                {
                    graphMinimum = (int)cpuTime;
                    newMinimum = (int)cpuTime;
                }
            }

            return newMinimum;
        }

        public static double getMedian(List<long> resultset)
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

        public static double getMode(List<long> resultset)
        {
            return 0;
        }

        public static double getMean(List<long> resultset)
        {
            //ToDo: your implementation
            ulong number = Convert.ToUInt64(resultset.Count);
            ulong x = 0;
            foreach (ulong result in resultset)
            {
              x += result;
            }
          return x / number;
        }

        public static double getOnlineMean( double counter, double old_mean, double new_result)
        {
          double mean = 0.0;
          double s = 0.0;
            //ToDo: your implementation
            if(counter <= 0)
              mean= ((counter-1)*old_mean+new_result)/counter;
            return mean;
        }

        public static double getVariance(List<long> resultSet)
        {
            //ToDo: your implementation
            double v = 0.0;
            double n = resultSet.Count();
            double m = getMean(resultSet);

            foreach (ulong x in resultSet)
            {
                v += x*x - 2*x*m + m*m;
            }

            return v/n;
        }

        private static ulong getMinValue(List<long> resultset)
        {
            if (resultset.Count == 0)
                throw new InvalidOperationException("Empty list");

            ulong minValue = long.MaxValue;

            foreach (ulong t in resultset)
                if (t < minValue)
                    minValue = t;

            return minValue;
        }

        private static ulong getMaxValue(List<long> resultset)
        {
            if (resultset.Count == 0)
                throw new InvalidOperationException("Empty list");

            ulong maxValue = 0;
            foreach (ulong t in resultset)
                if (t > maxValue)
                    maxValue = t;
            return maxValue;
        }

        public static double[] getNormalizedHistogram(double start, double end, List<long> data)
        {

			//ToDo: your implementation
            int num_bins = (int)Math.Round(Math.Sqrt(data.Count()));
            double bin_size = (end - start) / num_bins;

          //  double[] bins = {0, 0.01, 0.1, 1.0, 10.0, 100.0, 1000.0, 10000.0 };
          //  int num_bins = bins.Count();

            double[] histo = new double[num_bins];

            for (int k = 0; k < data.Count(); ++k)
            {
                for (int i = 0; i < num_bins; ++i)
                {
               //     double bin_size = bins[i];
                    if ((data[k] >= (start + (i * bin_size)) && (data[k] < (end + (i+1)* bin_size))))
               //      if ((data[k]>=bins[i])&&(data[k]<bins[i+1]))
                    {
                        histo[i]++;
                    }
                }
            }

            double num_data = 0.0 ;
            for (int i = 0; i < histo.Count(); ++i)
                num_data += histo[i];
            for (int j = 0; j < histo.Count(); ++j)
                histo[j] /= num_data;

            return histo;
        }

        private void comboBox_Method_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearGraph_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void lineGraph_Click(object sender, EventArgs e)
        {
            button_loops_Click(sender, e);
        }

        private void Ttestbutton_Click(object sender, EventArgs e)
        {
            String series_1 = chart1.Series[0].Name.ToString();
            String series_2 = chart1.Series[1].Name.ToString();

            TTestResult result = chart1.DataManipulator.Statistics.TTestPaired(0.2, 0.05,series_1,series_2);
            textBox_Results.AppendText("\r\n T-Test:" + result.TValue);
        }

        private void Ftestbutton_Click(object sender, EventArgs e)
        {
            String series_1 = chart1.Series[0].Name.ToString();
            String series_2 = chart1.Series[1].Name.ToString();

            FTestResult result = chart1.DataManipulator.Statistics.FTest(0.05, series_1, series_2);
            textBox_Results.AppendText("\r\n F-Test: " + result.FValue);
        }
    }
}
