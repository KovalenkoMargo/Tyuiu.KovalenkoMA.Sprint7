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

        public FormMain_КМА()
        {
            InitializeComponent();
            LoadDataFromFile();
            SetupToolTips();
            UpdateStatistics();
        }


        private void LoadDataFromFile()
        {
            try
            {
                owners = ds.LoadFromFile(currentFilePath);
                DisplayData(owners);
                statusLabelInfo_КМА.Text = $"Загружено записей: {owners.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        private void DisplayData(DataService.Owner[] dataToDisplay)
        {
            dataGridViewMain_КМА.Rows.Clear();

            for (int i = 0; i < dataToDisplay.Length; i++)
            {
                dataGridViewMain_КМА.Rows.Add(
                    dataToDisplay[i].Id,
                    dataToDisplay[i].FullName,
                    dataToDisplay[i].Address,
                    dataToDisplay[i].Phone,
                    dataToDisplay[i].Capital.ToString("C")
                );
            }
        }
\
        private void UpdateStatistics()
        {
            textBoxTotalCount_КМА.Text = ds.GetCount(owners).ToString();
            textBoxTotalCapital_КМА.Text = ds.GetTotalCapital(owners).ToString("C");
            textBoxAverageCapital_КМА.Text = ds.GetAverageCapital(owners).ToString("C");
            textBoxMinCapital_КМА.Text = ds.GetMinCapital(owners).ToString("C");
            textBoxMaxCapital_КМА.Text = ds.GetMaxCapital(owners).ToString("C");
        }


        private void SetupToolTips()
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(buttonLoadFile_КМА, "Загрузить данные из файла");
            toolTip.SetToolTip(buttonSaveFile_КМА, "Сохранить изменения");
            toolTip.SetToolTip(buttonSearch_КМА, "Поиск по ФИО");
            toolTip.SetToolTip(buttonSort_КМА, "Сортировка по капиталу");
            toolTip.SetToolTip(buttonChart_КМА, "Показать график");
            toolTip.SetToolTip(buttonHelp_КМА, "Справка");
        }


        private void buttonLoadFile_КМА_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    LoadDataFromFile();
                }
            }
        }

  
        private void buttonSaveFile_КМА_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            bool success = ds.SaveToFile(currentFilePath, owners, out errorMessage);

            if (success)
            {
                MessageBox.Show("Данные сохранены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMessage, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void buttonSearch_КМА_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch_КМА.Text;
            var searchResults = ds.SearchOwners(owners, searchTerm);
            DisplayData(searchResults);
            statusLabelInfo_КМА.Text = $"Найдено: {searchResults.Length} записей";
        }

   
        private void buttonSort_КМА_Click(object sender, EventArgs e)
        {
            owners = ds.SortOwnersByCapital(owners);
            DisplayData(owners);
            statusLabelInfo_КМА.Text = "Отсортировано по капиталу";
        }

   
        private void buttonClearSearch_КМА_Click(object sender, EventArgs e)
        {
            textBoxSearch_КМА.Clear();
            DisplayData(owners);
            statusLabelInfo_КМА.Text = $"Загружено: {owners.Length} записей";
        }


        private void buttonAdd_КМА_Click(object sender, EventArgs e)
        {
            try
            {
              
                int maxId = 0;
                for (int i = 0; i < owners.Length; i++)
                {
                    if (owners[i].Id > maxId) maxId = owners[i].Id;
                }

              
                DataService.Owner[] newOwners = new DataService.Owner[owners.Length + 1];

            
                for (int i = 0; i < owners.Length; i++)
                {
                    newOwners[i] = owners[i];
                }

       
                newOwners[owners.Length] = new DataService.Owner
                {
                    Id = maxId + 1,
                    FullName = "Новый владелец",
                    Address = "Адрес",
                    Phone = "Телефон",
                    Capital = 0
                };

                owners = newOwners;
                DisplayData(owners);
                UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void buttonDelete_КМА_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain_КМА.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridViewMain_КМА.SelectedRows[0].Cells[0].Value;

                if (MessageBox.Show("Удалить запись?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
            
                    int newSize = owners.Length - 1;
                    DataService.Owner[] newOwners = new DataService.Owner[newSize];

                    int index = 0;
                    for (int i = 0; i < owners.Length; i++)
                    {
                        if (owners[i].Id != selectedId)
                        {
                            newOwners[index] = owners[i];
                            index++;
                        }
                    }

                    owners = newOwners;
                    DisplayData(owners);
                    UpdateStatistics();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    
        private void buttonChart_КМА_Click(object sender, EventArgs e)
        {
            FormChart_КМА formChart = new FormChart_КМА(owners);
            formChart.ShowDialog();
        }

      
        private void buttonHelp_КМА_Click(object sender, EventArgs e)
        {
            FormAbout_КМА formAbout = new FormAbout_КМА();
            formAbout.ShowDialog();
        }
    }
}
