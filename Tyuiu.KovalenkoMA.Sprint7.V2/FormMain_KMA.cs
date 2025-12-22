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
        private ComboBox comboBoxSearchField_KMA;
        private Label labelSearchField_KMA;

        public FormMain_KMA()
        {
            InitializeComponent();
            InitializeSearchComboBox();

            LoadDataFromFile();
            SetupToolTips();
            UpdateStatistics();
        }

        private void InitializeSearchComboBox()
        {
            // Создаем метку
            labelSearchField_KMA = new Label();
            labelSearchField_KMA.Text = "Искать по:";
            labelSearchField_KMA.Location = new Point(320, 10);
            labelSearchField_KMA.Size = new Size(80, 20);
            labelSearchField_KMA.Name = "labelSearchField_KMA";

            // Создаем ComboBox
            comboBoxSearchField_KMA = new ComboBox();
            comboBoxSearchField_KMA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchField_KMA.Items.AddRange(new string[] {
                "По ФИО",
                "По адресу",
                "По телефону",
                "По ID",
                "По капиталу"
            });
            comboBoxSearchField_KMA.SelectedIndex = 0;
            comboBoxSearchField_KMA.Location = new Point(400, 10);
            comboBoxSearchField_KMA.Size = new Size(120, 21);
            comboBoxSearchField_KMA.Name = "comboBoxSearchField_KMA";

            // Добавляем на форму
            this.Controls.Add(labelSearchField_KMA);
            this.Controls.Add(comboBoxSearchField_KMA);
        }

        private void LoadDataFromFile()
        {
            try
            {
                owners = ds.LoadFromFile(currentFilePath);
                DisplayData(owners);
                statusLabelInfo_KMA.Text = $"Загружено записей: {owners.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DisplayData(DataService.Owner[] dataToDisplay)
        {
            dataGridViewMain_KMA.Rows.Clear();

            for (int i = 0; i < dataToDisplay.Length; i++)
            {
                dataGridViewMain_KMA.Rows.Add(
                    dataToDisplay[i].Id,
                    dataToDisplay[i].FullName,
                    dataToDisplay[i].Address,
                    dataToDisplay[i].Phone,
                    dataToDisplay[i].Capital.ToString("C")
                );
            }
        }

        private void UpdateStatistics()
        {
            textBoxTotalCount_KMA.Text = ds.GetCount(owners).ToString();
            textBoxTotalCapital_KMA.Text = ds.GetTotalCapital(owners).ToString("C");
            textBoxAverageCapital_KMA.Text = ds.GetAverageCapital(owners).ToString("C");
            textBoxMinCapital_KMA.Text = ds.GetMinCapital(owners).ToString("C");
            textBoxMaxCapital_KMA.Text = ds.GetMaxCapital(owners).ToString("C");
        }

        private void SetupToolTips()
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(buttonLoadFile_KMA, "Загрузить данные из файла");
            toolTip.SetToolTip(buttonSaveFile_KMA, "Сохранить изменения");
            toolTip.SetToolTip(buttonSearch_KMA, "Поиск по выбранному полю");
            toolTip.SetToolTip(buttonSort_KMA, "Сортировка по капиталу");
            toolTip.SetToolTip(buttonChart_KMA, "Показать график");
            toolTip.SetToolTip(buttonHelp_KMA, "Справка");
            // Добавляем подсказку для ComboBox
            toolTip.SetToolTip(comboBoxSearchField_KMA, "Выберите поле для поиска");
        }

        private void buttonLoadFile_KMA_Click(object sender, EventArgs e)
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

        private void buttonSaveFile_KMA_Click(object sender, EventArgs e)
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

        // ПОИСК - МЕТОД С ВЫБОРОМ ПОЛЯ
        private void buttonSearch_KMA_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch_KMA.Text;

            // Определяем поле для поиска из ComboBox
            string searchField = "FullName";

            switch (comboBoxSearchField_KMA.SelectedIndex)
            {
                case 0: searchField = "FullName"; break;
                case 1: searchField = "Address"; break;
                case 2: searchField = "Phone"; break;
                case 3: searchField = "Id"; break;
                case 4: searchField = "Capital"; break;
            }

            var searchResults = ds.SearchOwners(owners, searchTerm, searchField);
            DisplayData(searchResults);
            statusLabelInfo_KMA.Text = $"Найдено: {searchResults.Length} записей (поиск по: {comboBoxSearchField_KMA.Text})";
        }

        private void buttonSort_KMA_Click(object sender, EventArgs e)
        {
            owners = ds.SortOwnersByCapital(owners);
            DisplayData(owners);
            statusLabelInfo_KMA.Text = "Отсортировано по капиталу";
        }

        private void buttonClearSearch_KMA_Click(object sender, EventArgs e)
        {
            textBoxSearch_KMA.Clear();
            DisplayData(owners);
            statusLabelInfo_KMA.Text = $"Загружено: {owners.Length} записей";
        }

        private void buttonAdd_KMA_Click(object sender, EventArgs e)
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

        private void buttonDelete_KMA_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain_KMA.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridViewMain_KMA.SelectedRows[0].Cells[0].Value;

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

        private void buttonChart_KMA_Click(object sender, EventArgs e)
        {
            FormChart_KMA formChart = new FormChart_KMA(owners);
            formChart.ShowDialog();
        }

        private void buttonHelp_KMA_Click(object sender, EventArgs e)
        {
            FormAbout_KMA formAbout = new FormAbout_KMA();
            formAbout.ShowDialog();
        }
    }
}