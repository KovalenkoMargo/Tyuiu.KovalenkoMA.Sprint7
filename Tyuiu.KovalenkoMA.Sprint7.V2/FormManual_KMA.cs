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
            richTextBoxManual_KMA.Text = @"КРАТКОЕ РУКОВОДСТВО

1. Загрузка данных:
   - Нажмите 'Загрузить' или выберите Файл->Загрузить
   - Выберите CSV файл

2. Редактирование:
   - Дважды кликните по ячейке в таблице для редактирования
   - Для добавления нажмите кнопку '+'
   - Для удаления выделите строку и нажмите 'Удалить'

3. Поиск:
   - Введите текст в поле поиска
   - Выберите поле для поиска из выпадающего списка
   - Нажмите 'Найти'

4. Сортировка:
   - Нажмите 'Сортировка' для сортировки по капиталу

5. График:
   - Нажмите 'График' для визуализации данных

6. Сохранение:
   - Все изменения сохраняются в исходный файл 
   - Для принудительного сохранения нажмите 'Сохранить'";
        }
        private void buttonCloseManal_KMA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
