using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.KovalenkoMA.Sprint7.V2.Lib;
using static Tyuiu.KovalenkoMA.Sprint7.V2.Lib.DataService;

namespace Tyuiu.KovalenkoMA.Sprint7.V2
{
    public partial class FormMain_KMA : Form
    {
        private DataService ds = new DataService();
        private DataService.Owner[] owners = new DataService.Owner[0];
        private string currentFilePath = "Owners.csv";

        public FormMain_ Ã¿()
        {
            InitializeComponent();
            LoadDataFromFile();
            SetupToolTips();
            UpdateStatistics();
        }

        
    }
}
