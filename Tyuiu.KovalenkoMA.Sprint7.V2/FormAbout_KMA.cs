using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KovalenkoMA.Sprint7.V2
{
    public partial class FormAbout_KMA : Form
    {
        public FormAbout_KMA()
        {
            InitializeComponent();
        }
        private void buttonCloseAbout_KMA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
