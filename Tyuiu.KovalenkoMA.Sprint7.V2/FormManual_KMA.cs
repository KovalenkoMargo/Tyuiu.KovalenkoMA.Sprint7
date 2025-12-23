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
    public partial class FormManual_KMA : Form
    {
        public FormManual_KMA()
        {
            InitializeComponent();
            SetupManualContent();
            SetupToolTips();
        }

        private void SetupManualContent()
        {
            // Настраиваем RichTextBox
            richTextBoxManual_KMA.Font = new Font("Segoe UI", 10);
            richTextBoxManual_KMA.BackColor = Color.White;
            richTextBoxManual_KMA.BorderStyle = BorderStyle.None;

            // Очищаем и устанавливаем содержимое
            richTextBoxManual_KMA.Clear();

            // ЗАГОЛОВОК
            richTextBoxManual_KMA.SelectionFont = new Font("Segoe UI", 16, FontStyle.Bold);
            richTextBoxManual_KMA.SelectionColor = Color.DarkBlue;
            richTextBoxManual_KMA.SelectionAlignment = HorizontalAlignment.Center;
            richTextBoxManual_KMA.AppendText("РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ\n");

            richTextBoxManual_KMA.SelectionFont = new Font("Segoe UI", 10, FontStyle.Italic);
            richTextBoxManual_KMA.SelectionColor = Color.Gray;
            richTextBoxManual_KMA.AppendText("Программа \"Сеть магазинов\"\n");
            richTextBoxManual_KMA.AppendText("Версия 1.0 | Спринт 7 | Вариант 2\n\n");

            // РАЗДЕЛЫ
            AddSection("1. НАЗНАЧЕНИЕ ПРОГРАММЫ",
                "Программа предназначена для управления данными о владельцах магазинов.\n" +
                "\nОсновные возможности:\n" +
                "• Хранение информации о владельцах\n" +
                "• Статистический анализ капитала\n" +
                "• Поиск и фильтрация записей\n" +
                "• Визуализация данных\n" +
                "• Работа с файлами CSV\n");

            AddSection("2. НАЧАЛО РАБОТЫ",
                "При запуске программы автоматически загружается файл 'Owners.csv'.\n" +
                "Если файл отсутствует, создаются тестовые данные.\n" +
                "\nСтруктура интерфейса:\n" +
                "• Меню и панель инструментов\n" +
                "• Основная таблица данных\n" +
                "• Панель статистики\n" +
                "• Панель поиска\n");

            AddSection(" 3. РАБОТА С ДАННЫМИ",
                "    ЗАГРУЗКА ДАННЫХ:\n" +
                "   • Нажмите кнопку 'Загрузить' или Файл - Загрузить\n" +
                "   • Выберите CSV файл\n" +
                "\n  РЕДАКТИРОВАНИЕ:\n" +
                "   • Кликните дважды по ячейке\n" +
                "   • Измените значение\n" +
                "   • Нажмите Enter\n" +
                "   • Автосохранение включено\n" +
                "\n   ДОБАВЛЕНИЕ:\n" +
                "   • Нажмите кнопку 'Добавить'\n" +
                "   • ID создаётся автоматически\n" +
                "\n   УДАЛЕНИЕ:\n" +
                "   • Выделите строку\n" +
                "   • Нажмите кнопку 'Удалить'\n" +
                "   • Подтвердите действие\n");

            AddSection(" 4. ПОИСК И ФИЛЬТРАЦИЯ",
                "    ПРОСТОЙ ПОИСК:\n" +
                "   • Выберите поле для поиска\n" +
                "   • Введите текст\n" +
                "   • Нажмите 'Найти'\n" +
                "   • 'Очистить' - сброс поиска\n" +
                "\n   ФИЛЬТРАЦИЯ ПО КАПИТАЛУ:\n" +
                "   • Введите минимальное значение\n" +
                "   • Введите максимальное значение\n" +
                "   • Нажмите 'Применить фильтр'\n" +
                "\n   ИНДИКАТОРЫ ВАЛИДАЦИИ:\n" +
                "   • Зеленый фон - корректные данные\n" +
                "   • Розовый фон - ошибка ввода\n");

            AddSection(" 5. СТАТИСТИКА И АНАЛИЗ",
                "Автоматически рассчитывается:\n" +
                "• Общее количество записей\n" +
                "• Суммарный капитал\n" +
                "• Средний капитал\n" +
                "• Минимальный капитал\n" +
                "• Максимальный капитал\n" +
                "\nСтатистика обновляется при:\n" +
                "• Загрузке данных\n" +
                "• Изменении данных\n" +
                "• Поиске и фильтрации\n" +
                "• Добавлении/удалении\n");

            AddSection(" 6. ВИЗУАЛИЗАЦИЯ",
                "     СОРТИРОВКА:\n" +
                "   • Нажмите кнопку 'Сортировка'\n" +
                "   • Данные сортируются по капиталу\n" +
                "\n   ГРАФИК КАПИТАЛА:\n" +
                "   • Нажмите кнопку 'График'\n" +
                "   • Откроется гистограмма\n" );

            AddSection(" 7. СОХРАНЕНИЕ",
                "     АВТОСОХРАНЕНИЕ:\n" +
                "   • Все изменения сохраняются автоматически\n" +
                "\n   РУЧНОЕ СОХРАНЕНИЕ:\n" +
                "   • Нажмите кнопку 'Сохранить'\n" +
                "   • Данные сохраняются в текущий файл\n");

            AddSection(" 8. ФОРМАТ ДАННЫХ",
                "CSV файл должен содержать столбцы:\n" +
                "1. Id - целое число\n" +
                "2. FullName - ФИО\n" +
                "3. Address - адрес\n" +
                "4. Phone - телефон\n" +
                "5. Capital - капитал\n" +
                "\nПример содержимого:\n" +
                "Id,FullName,Address,Phone,Capital\n" +
                "1,Иванов И.И.,Москва,+79991234567,1500000\n" +
                "2,Петров П.П.,Санкт-Петербург,+78121234567,850000\n");

            AddSection(" 9. СПРАВОЧНАЯ ИНФОРМАЦИЯ",
                "• О программе - сведения о разработчике\n" +
                "• Руководство - это окно\n" +
                "• Выход - завершение работы\n");

            // ПОДВАЛ
            richTextBoxManual_KMA.AppendText("\n");
            richTextBoxManual_KMA.SelectionFont = new Font("Segoe UI", 9, FontStyle.Italic);
            richTextBoxManual_KMA.SelectionColor = Color.DarkGray;
            richTextBoxManual_KMA.SelectionAlignment = HorizontalAlignment.Center;
            richTextBoxManual_KMA.AppendText("———————————————————————\n");
            richTextBoxManual_KMA.AppendText("© 2025 | Разработчик: Коваленко М.А.\n");
            richTextBoxManual_KMA.AppendText("Тюменский индустриальный университет\n");

            // Прокручиваем в начало
            richTextBoxManual_KMA.SelectionStart = 0;
        }

        private void AddSection(string title, string content)
        {
            // Заголовок раздела
            richTextBoxManual_KMA.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            richTextBoxManual_KMA.SelectionColor = Color.DarkGreen;
            richTextBoxManual_KMA.SelectionAlignment = HorizontalAlignment.Left;
            richTextBoxManual_KMA.AppendText(title + "\n");

            // Содержание
            richTextBoxManual_KMA.SelectionFont = new Font("Segoe UI", 10);
            richTextBoxManual_KMA.SelectionColor = Color.Black;
            richTextBoxManual_KMA.AppendText(content + "\n");
        }

        private void SetupToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonCloseManual_KMA, "Закрыть руководство");
            toolTip.SetToolTip(richTextBoxManual_KMA, "Используйте колесико мыши для прокрутки");
        }

        private void buttonCloseManual_KMA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}