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

        }

        private void CreateChart()
        {
            chartCapital_КМА.Series.Clear();
            chartCapital_КМА.Titles.Clear();
            chartCapital_КМА.ChartAreas.Clear();

            ChartArea area = new ChartArea("MainArea");

            area.AxisX.IsMarginVisible = true;
            area.AxisX.LabelStyle.Interval = 1;
            area.AxisX.LabelStyle.Font = new Font("Arial", 9);
            area.AxisX.Title = "Владельцы";
            area.AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);

            area.AxisY.LabelStyle.Format = "C0";
            area.AxisY.Title = "Капитал (руб.)";
            area.AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            area.AxisY.LabelStyle.Font = new Font("Arial", 9);

            chartCapital_КМА.ChartAreas.Add(area);

            Series series = new Series("Капитал владельцев");
            series.ChartType = SeriesChartType.Column;
            series.ChartArea = "MainArea";
            series.BorderWidth = 2;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "C0";
            series.Font = new Font("Arial", 9, FontStyle.Bold);

            for (int i = 0; i < owners.Length; i++)
            {
                int pointIndex = series.Points.AddXY(i, (double)owners[i].Capital);

                string shortName = owners[i].FullName;
                if (shortName.Length > 10)
                    shortName = shortName.Substring(0, 8) + "...";

                series.Points[pointIndex].AxisLabel = shortName;

                series.Points[pointIndex].Color = GetColorForValue((double)owners[i].Capital);

                series.Points[pointIndex].ToolTip = $"{owners[i].FullName}\nКапитал: {owners[i].Capital:C0}\nАдрес: {owners[i].Address}";
            }

            chartCapital_КМА.Series.Add(series);

            Title title = new Title($"Капитал владельцев магазинов (всего: {owners.Length})");
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.DarkBlue;
            chartCapital_КМА.Titles.Add(title);

            chartCapital_КМА.Legends.Clear();
            Legend legend = new Legend("CapitalLegend");
            legend.Font = new Font("Arial", 9);
            legend.Docking = Docking.Bottom;
            chartCapital_КМА.Legends.Add(legend);
        }

        private Color GetColorForValue(double value)
        {
            if (value > 2500000) return Color.DarkGreen;
            if (value > 1500000) return Color.Green;
            if (value > 1000000) return Color.LightGreen;
            if (value > 500000) return Color.Orange;
            return Color.OrangeRed;
        }

        private void buttonCloseChart_KMA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

