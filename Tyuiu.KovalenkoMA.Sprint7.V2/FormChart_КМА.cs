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

namespace Tyuiu.KovalenkoMA.Sprint7.V2
{
    public partial class FormChart_КМА : Form
    {
        private DataService.Owner[] owners;

        public FormChart_КМА(DataService.Owner[] ownersList)
        {
            InitializeComponent();
            owners = ownersList;
            CreateChart();
        }

        private void CreateChart()
        {
            chartCapital_КМА.Series.Clear();

            Series series = new Series("Капитал");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.Blue;

            for (int i = 0; i < owners.Length; i++)
            {
                series.Points.AddXY(owners[i].FullName, (double)owners[i].Capital);
            }

            chartCapital_КМА.Series.Add(series);
            chartCapital_КМА.Titles.Add("Капитал владельцев магазинов");
        }
    }
}
