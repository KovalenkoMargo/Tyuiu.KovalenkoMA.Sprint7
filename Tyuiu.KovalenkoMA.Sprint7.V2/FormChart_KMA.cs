using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KovalenkoMA.Sprint7.V2.Lib;
using static Tyuiu.KovalenkoMA.Sprint7.V2.Lib.DataService;

namespace Tyuiu.KovalenkoMA.Sprint7.V2
{
    public partial class FormChart_KMA : Form
    {
        private DataService.Owner[] owners;
        public FormChart_KMA(DataService.Owner[] ownersList)
        {
            InitializeComponent();
            owners = ownersList;
            CreateChart();

            //buttonCloseChart_KMA.Click += buttonCloseChart_KMA_Click;
        }

        private void CreateChart()
        {
            chartCapital_КМА.Series.Clear();

            Series series = new Series("Капитал");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.Blue;

            int count = Math.Min(owners.Length, 10);
            for (int i = 0; i < count; i++)
            {
                series.Points.AddXY(owners[i].FullName, (double)owners[i].Capital);
            }

            chartCapital_КМА.Series.Add(series);
            chartCapital_КМА.Titles.Add("Капитал владельцев магазинов");
            //chartCapital_KMA.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            //chartCapital_KMA.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
        }

        private void buttonCloseChart_KMA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
