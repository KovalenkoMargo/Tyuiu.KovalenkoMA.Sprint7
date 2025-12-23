using System;
using System.Drawing;
using System.Globalization;
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


        public FormMain_KMA()
        {
            InitializeComponent();
            InitializeDataGridViewColumns();

            comboBoxSearchField_KMA.SelectedIndex = 0;

            LoadDataFromFile();
            UpdateStatistics();


            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void Timer_Tick(object? sender, EventArgs e)
        {
            statusLabelTime_KMA.Text = DateTime.Now.ToString("HH:mm:ss");
        }



        private void LoadDataFromFile()
        {
            try
            {
                owners = ds.LoadFromFile(currentFilePath);

                if (owners.Length == 0)
                {
                    // Создаем тестовые данные, если файл пустой
                    owners = CreateSampleData();
                    statusLabelInfo_KMA.Text = "Загружено 0 записей. Созданы тестовые данные.";
                }
                else
                {
                    statusLabelInfo_KMA.Text = $"Загружено записей: {owners.Length}";
                }

                DisplayData(owners);
                UpdateStatistics(); // ← ОБЯЗАТЕЛЬНО ВЫЗЫВАЙ ЗДЕСЬ!
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Создаем тестовые данные при ошибке
                owners = CreateSampleData();
                DisplayData(owners);
                UpdateStatistics();
            }
        }

        // Добавь метод для создания тестовых данных:
        private DataService.Owner[] CreateSampleData()
        {
            return new DataService.Owner[]
    {
        new DataService.Owner { Id = 1, FullName = "Иванов Иван Иванович", Address = "Москва", Phone = "+79991234567", Capital = 1500000 },
        new DataService.Owner { Id = 2, FullName = "Петров Петр Петрович", Address = "Санкт-Петербург", Phone = "+78121234567", Capital = 850000 },
        new DataService.Owner { Id = 3, FullName = "Сидорова Анна Сергеевна", Address = "Казань", Phone = "+78431234567", Capital = 3200000 },
        new DataService.Owner { Id = 4, FullName = "Козлов Алексей Викторович", Address = "Екатеринбург", Phone = "+73431234567", Capital = 2100000 },
        new DataService.Owner { Id = 5, FullName = "Николаева Мария Дмитриевна", Address = "Новосибирск", Phone = "+73831234567", Capital = 950000 }
    };
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
                    dataToDisplay[i].Capital
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

        private void toolStripButtonSearch_KMA_Click(object sender, EventArgs e)
        {
            // Просим ввести текст для поиска
            string searchTerm = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите ФИО для поиска:",
                "Быстрый поиск по ФИО",
                "",
                this.Location.X + 100,
                this.Location.Y + 100
            );

            if (!string.IsNullOrEmpty(searchTerm))
            {
                var searchResults = ds.SearchOwners(owners, searchTerm, "FullName");
                DisplayData(searchResults);
                UpdateStatisticsForResults(searchResults);
                statusLabelInfo_KMA.Text = $"Найдено: {searchResults.Length} записей по ФИО";
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


        private void buttonSearch_KMA_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch_KMA.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Введите текст для поиска!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Определяем поле для поиска из ComboBox
            string searchField = "FullName";

            switch (comboBoxSearchField_KMA.SelectedIndex)
            {
                case 0: searchField = "FullName"; break;
                case 1: searchField = "Address"; break;
                case 2: searchField = "Phone"; break;
                case 3: searchField = "Id"; break;
                case 4: searchField = "Capital"; break;
                default: searchField = "FullName"; break;
            }

            var searchResults = ds.SearchOwners(owners, searchTerm, searchField);
            DisplayData(searchResults);

            // Обновляем статистику для найденных записей
            UpdateStatisticsForResults(searchResults);

            statusLabelInfo_KMA.Text = $"Найдено: {searchResults.Length} записей (поиск по: {comboBoxSearchField_KMA.Text})";
        }

        // Добавь этот метод для обновления статистики поиска:
        private void UpdateStatisticsForResults(DataService.Owner[] results)
        {
            textBoxTotalCount_KMA.Text = ds.GetCount(results).ToString();
            textBoxTotalCapital_KMA.Text = ds.GetTotalCapital(results).ToString("C");
            textBoxAverageCapital_KMA.Text = ds.GetAverageCapital(results).ToString("C");
            textBoxMinCapital_KMA.Text = ds.GetMinCapital(results).ToString("C");
            textBoxMaxCapital_KMA.Text = ds.GetMaxCapital(results).ToString("C");
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

            // Показываем ВСЕ данные
            DisplayData(owners);

            // Обновляем статистику для ВСЕХ данных
            UpdateStatistics(); // Это метод должен обновлять статистику из массива owners

            statusLabelInfo_KMA.Text = $"Загружено: {owners.Length} записей";
            comboBoxSearchField_KMA.SelectedIndex = 0;
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

        private void buttonManual_KMA_Click(object sender, EventArgs e)
        {
            FormManual_KMA formManual = new FormManual_KMA();
            formManual.ShowDialog();
        }



        private void DataGridViewMain_KMA_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что изменение не в заголовке и есть данные
            if (e.RowIndex >= 0 && e.RowIndex < owners.Length && e.ColumnIndex >= 0)
            {
                try
                {
                    var row = dataGridViewMain_KMA.Rows[e.RowIndex];
                    var owner = owners[e.RowIndex];

                    // Обновляем объект Owner в зависимости от того, какой столбец изменился
                    switch (e.ColumnIndex)
                    {
                        case 0: // ID - не меняем
                                // ID нельзя менять, восстанавливаем старое значение
                            row.Cells[0].Value = owner.Id;
                            MessageBox.Show("ID нельзя изменять!", "Предупреждение",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;

                        case 1: // FullName
                            owner.FullName = row.Cells[1].Value?.ToString() ?? "";
                            break;

                        case 2: // Address
                            owner.Address = row.Cells[2].Value?.ToString() ?? "";
                            break;

                        case 3: // Phone
                            owner.Phone = row.Cells[3].Value?.ToString() ?? "";
                            break;

                        case 4: // Capital
                            if (decimal.TryParse(row.Cells[4].Value?.ToString(), out decimal capital))
                            {
                                owner.Capital = capital;
                            }
                            else
                            {
                                // Если ввели не число, восстанавливаем старое значение
                                row.Cells[4].Value = owner.Capital;
                                MessageBox.Show("Капитал должен быть числом!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                    }

                    // Обновляем статистику
                    UpdateStatistics();

                    // Показываем сообщение в статус-баре
                    statusLabelInfo_KMA.Text = $"Запись #{owner.Id} обновлена";

                    // Автоматически сохраняем изменения
                    SaveChangesAuto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveChangesAuto()
        {
            try
            {
                string errorMessage;
                bool success = ds.SaveToFile(currentFilePath, owners, out errorMessage);

                if (!success)
                {
                    // Не показываем ошибку пользователю при автосохранении, только в статус-баре
                    statusLabelInfo_KMA.Text = "Не удалось автосохранить";
                }
            }
            catch
            {
                // Игнорируем ошибки при автосохранении
            }
        }


        private void InitializeDataGridViewColumns()
        {
            // Очищаем старые столбцы
            dataGridViewMain_KMA.Columns.Clear();

            // Создаем столбцы
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.HeaderText = "ID";
            colId.Width = 50;
            colId.ReadOnly = true;

            DataGridViewTextBoxColumn colFullName = new DataGridViewTextBoxColumn();
            colFullName.Name = "FullName";
            colFullName.HeaderText = "ФИО владельца";
            colFullName.Width = 200;

            DataGridViewTextBoxColumn colAddress = new DataGridViewTextBoxColumn();
            colAddress.Name = "Address";
            colAddress.HeaderText = "Адрес";
            colAddress.Width = 150;

            DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
            colPhone.Name = "Phone";
            colPhone.HeaderText = "Телефон";
            colPhone.Width = 120;

            DataGridViewTextBoxColumn colCapital = new DataGridViewTextBoxColumn();
            colCapital.Name = "Capital";
            colCapital.HeaderText = "Капитал (руб.)";
            colCapital.Width = 120;
            colCapital.DefaultCellStyle.Format = "N2";
            colCapital.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Добавляем столбцы
            dataGridViewMain_KMA.Columns.AddRange(new DataGridViewColumn[] {
        colId, colFullName, colAddress, colPhone, colCapital
    });

            // Настройки таблицы
            dataGridViewMain_KMA.AllowUserToAddRows = false;
            dataGridViewMain_KMA.AllowUserToDeleteRows = false;
            dataGridViewMain_KMA.ReadOnly = false; // Разрешаем редактирование
            dataGridViewMain_KMA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMain_KMA.MultiSelect = false;

            // Подписываемся на событие изменения ячейки
            dataGridViewMain_KMA.CellValueChanged += DataGridViewMain_KMA_CellValueChanged;
        }



        private void menuItemExit_KMA_Click(object sender, EventArgs e)
        {
            // Спрашиваем подтверждение
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите выйти?",
                "Подтверждение выхода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Сохраняем данные перед выходом (опционально)
                string errorMessage = "";
                bool saved = ds.SaveToFile(currentFilePath, owners, out errorMessage);

                if (!saved)
                {
                    MessageBox.Show($"Не удалось сохранить: {errorMessage}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Закрываем приложение
                Application.Exit();
            }
        }

        private void buttonFilter_KMA_Click(object sender, EventArgs e)
        {
            try
            {
                // Парсим значения из TextBox с поддержкой разных форматов
                decimal minCapital = ParseDecimalFromTextBox(textBoxMinFilter_KMA.Text);
                decimal maxCapital = ParseDecimalFromTextBox(textBoxMaxFilter_KMA.Text);

                // Проверяем, что оба значения валидны
                if (minCapital < 0 || maxCapital < 0)
                {
                    MessageBox.Show("Значения капитала не могут быть отрицательными!",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (minCapital > maxCapital)
                {
                    MessageBox.Show("Минимальное значение не может быть больше максимального!",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (owners == null || owners.Length == 0)
                {
                    MessageBox.Show("Нет данных для фильтрации!",
                                  "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Используем метод из DataService
                var filteredOwners = ds.FilterByCapitalRange(owners, minCapital, maxCapital);

                // Отображаем отфильтрованные данные
                DisplayData(filteredOwners);

                // Обновляем статистику для отфильтрованных данных
                UpdateStatisticsForFiltered(filteredOwners);

                // Показываем информацию в Label
                labelFilterResult_KMA.Text =
                    $"Найдено: {filteredOwners.Length} записей\n" +
                    $"Капитал: от {minCapital:N0} до {maxCapital:N0} руб.";
                labelFilterResult_KMA.ForeColor = Color.DarkGreen;

                statusLabelInfo_KMA.Text =
                    $"Применен фильтр: капитал от {minCapital:C} до {maxCapital:C}. " +
                    $"Найдено: {filteredOwners.Length} записей";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения!\n" +
                               "Пример: 1000000 или 1 000 000 или 1.000.000",
                               "Ошибка ввода",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при фильтрации: {ex.Message}", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearFilter_KMA_Click(object sender, EventArgs e)
        {
            // Сбрасываем значения фильтра
    textBoxMinFilter_KMA.Text = "0";
            textBoxMaxFilter_KMA.Text = "1000000";

            // Сбрасываем подсветку
            textBoxMinFilter_KMA.BackColor = SystemColors.Window;
            textBoxMaxFilter_KMA.BackColor = SystemColors.Window;

            // Показываем все данные
            DisplayData(owners);

            // Обновляем общую статистику
            UpdateStatistics();

            // Сбрасываем Label
            labelFilterResult_KMA.Text = "Фильтр не применен";
            labelFilterResult_KMA.ForeColor = Color.Gray;

            statusLabelInfo_KMA.Text = $"Загружено: {owners.Length} записей (фильтр сброшен)";
        }


        // Метод для обновления статистики отфильтрованных данных
        private void UpdateStatisticsForFiltered(DataService.Owner[] filteredOwners)
        {
            if (filteredOwners.Length > 0)
            {
                textBoxTotalCount_KMA.Text = filteredOwners.Length.ToString();
                textBoxTotalCapital_KMA.Text = ds.GetTotalCapital(filteredOwners).ToString("C");
                textBoxAverageCapital_KMA.Text = ds.GetAverageCapital(filteredOwners).ToString("C");
                textBoxMinCapital_KMA.Text = ds.GetMinCapital(filteredOwners).ToString("C");
                textBoxMaxCapital_KMA.Text = ds.GetMaxCapital(filteredOwners).ToString("C");
            }
            else
            {
                textBoxTotalCount_KMA.Text = "0";
                textBoxTotalCapital_KMA.Text = "0 руб.";
                textBoxAverageCapital_KMA.Text = "0 руб.";
                textBoxMinCapital_KMA.Text = "0 руб.";
                textBoxMaxCapital_KMA.Text = "0 руб.";
            }
        }

        private decimal ParseDecimalFromTextBox(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            // Убираем пробелы, точки как разделители тысяч, заменяем запятые на точки
            string cleaned = text.Trim()
                                .Replace(" ", "")
                                .Replace(".", "")
                                .Replace(",", ".");

            return decimal.Parse(cleaned, CultureInfo.InvariantCulture);
        }

        // Метод проверки валидности decimal
        private bool IsValidDecimal(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return true; // Пустая строка = 0

            try
            {
                ParseDecimalFromTextBox(text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Валидация при изменении текста
        private void textBoxMinFilter_KMA_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(textBoxMinFilter_KMA);
        }

        private void textBoxMaxFilter_KMA_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(textBoxMaxFilter_KMA);
        }

        // Метод валидации TextBox
        private void ValidateTextBox(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = SystemColors.Window;
                return;
            }

            if (IsValidDecimal(textBox.Text))
            {
                textBox.BackColor = Color.LightGreen; // Зеленый = валидно
            }
            else
            {
                textBox.BackColor = Color.LightPink; // Розовый = ошибка
            }
        }
    }
}