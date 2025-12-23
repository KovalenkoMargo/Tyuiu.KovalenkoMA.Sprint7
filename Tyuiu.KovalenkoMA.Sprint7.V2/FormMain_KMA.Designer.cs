namespace Tyuiu.KovalenkoMA.Sprint7.V2
{
    partial class FormMain_KMA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KMA));
            menuStripMain_KMA = new MenuStrip();
            menuItemFile_KMA = new ToolStripMenuItem();
            menuItemLoad_KMA = new ToolStripMenuItem();
            menuItemSave_KMA = new ToolStripMenuItem();
            menuItemExit_KMA = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuItemEdit_KMA = new ToolStripMenuItem();
            menuItemAdd_KMA = new ToolStripMenuItem();
            menuItemDelete_KMA = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            menuItemView_KMA = new ToolStripMenuItem();
            menuItemChart_KMA = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            menuItemHelp_KMA = new ToolStripMenuItem();
            menuItemAbout_KMA = new ToolStripMenuItem();
            menuItemManual_KMA = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            toolStripMain_KMA = new ToolStrip();
            toolStripButtonLoad_KMA = new ToolStripButton();
            toolStripButtonSave_KMA = new ToolStripButton();
            toolStripSeparator1_KMA = new ToolStripSeparator();
            toolStripButtonAdd_KMA = new ToolStripButton();
            toolStripButtonDelete_KMA = new ToolStripButton();
            toolStripSeparator2_KMA = new ToolStripSeparator();
            toolStripButtonSearch_KMA = new ToolStripButton();
            toolStripButtonSort_KMA = new ToolStripButton();
            toolStripButtonChart_KMA = new ToolStripButton();
            toolStripButtonHelp_KMA = new ToolStripButton();
            groupBoxStatistics_KMA = new GroupBox();
            labelMaxCapital_KMA = new Label();
            labelMinCapital_KMA = new Label();
            labelAverageCapital_KMA = new Label();
            textBoxMaxCapital_KMA = new TextBox();
            textBoxMinCapital_KMA = new TextBox();
            textBoxAverageCapital_KMA = new TextBox();
            textBoxTotalCapital_KMA = new TextBox();
            labelTotalCapital_KMA = new Label();
            textBoxTotalCount_KMA = new TextBox();
            labelTotalCount_KMA = new Label();
            groupBoxSearch_KMA = new GroupBox();
            textBoxMaxFilter_KMA = new TextBox();
            textBoxMinFilter_KMA = new TextBox();
            labelFilterResult_KMA = new Label();
            buttonClearFilter_KMA = new Button();
            buttonFilter_KMA = new Button();
            labelMaxCapitalFilter_KMA = new Label();
            labelMinCapitalFilter_KMA = new Label();
            labelFilter_KMA = new Label();
            labelSeparator_KMA = new Label();
            buttonClearSearch_KMA = new Button();
            buttonSearch_KMA = new Button();
            comboBoxSearchField_KMA = new ComboBox();
            textBoxSearch_KMA = new TextBox();
            toolTipButtons_KMA = new ToolTip(components);
            statusStripMain_KMA = new StatusStrip();
            statusLabelInfo_KMA = new ToolStripStatusLabel();
            statusLabelTime_KMA = new ToolStripStatusLabel();
            dataGridViewMain_KMA = new DataGridView();
            menuStripMain_KMA.SuspendLayout();
            toolStripMain_KMA.SuspendLayout();
            groupBoxStatistics_KMA.SuspendLayout();
            groupBoxSearch_KMA.SuspendLayout();
            statusStripMain_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_KMA).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain_KMA
            // 
            menuStripMain_KMA.ImageScalingSize = new Size(20, 20);
            menuStripMain_KMA.Items.AddRange(new ToolStripItem[] { menuItemFile_KMA, menuItemEdit_KMA, menuItemView_KMA, menuItemHelp_KMA });
            menuStripMain_KMA.Location = new Point(0, 0);
            menuStripMain_KMA.Name = "menuStripMain_KMA";
            menuStripMain_KMA.Size = new Size(1236, 28);
            menuStripMain_KMA.TabIndex = 0;
            menuStripMain_KMA.Text = "menuStrip1";
            // 
            // menuItemFile_KMA
            // 
            menuItemFile_KMA.DropDownItems.AddRange(new ToolStripItem[] { menuItemLoad_KMA, menuItemSave_KMA, menuItemExit_KMA, toolStripMenuItem1 });
            menuItemFile_KMA.Name = "menuItemFile_KMA";
            menuItemFile_KMA.Size = new Size(59, 24);
            menuItemFile_KMA.Text = "Файл";
            // 
            // menuItemLoad_KMA
            // 
            menuItemLoad_KMA.Name = "menuItemLoad_KMA";
            menuItemLoad_KMA.Size = new Size(166, 26);
            menuItemLoad_KMA.Text = "Загрузить";
            menuItemLoad_KMA.Click += buttonLoadFile_KMA_Click;
            // 
            // menuItemSave_KMA
            // 
            menuItemSave_KMA.Name = "menuItemSave_KMA";
            menuItemSave_KMA.Size = new Size(166, 26);
            menuItemSave_KMA.Text = "Сохранить";
            menuItemSave_KMA.Click += buttonSaveFile_KMA_Click;
            // 
            // menuItemExit_KMA
            // 
            menuItemExit_KMA.Name = "menuItemExit_KMA";
            menuItemExit_KMA.Size = new Size(166, 26);
            menuItemExit_KMA.Text = "Выход";
            menuItemExit_KMA.Click += menuItemExit_KMA_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(163, 6);
            // 
            // menuItemEdit_KMA
            // 
            menuItemEdit_KMA.DropDownItems.AddRange(new ToolStripItem[] { menuItemAdd_KMA, menuItemDelete_KMA, toolStripMenuItem2 });
            menuItemEdit_KMA.Name = "menuItemEdit_KMA";
            menuItemEdit_KMA.Size = new Size(74, 24);
            menuItemEdit_KMA.Text = "Правка";
            // 
            // menuItemAdd_KMA
            // 
            menuItemAdd_KMA.Name = "menuItemAdd_KMA";
            menuItemAdd_KMA.Size = new Size(211, 26);
            menuItemAdd_KMA.Text = "Добавить запись";
            menuItemAdd_KMA.Click += buttonAdd_KMA_Click;
            // 
            // menuItemDelete_KMA
            // 
            menuItemDelete_KMA.Name = "menuItemDelete_KMA";
            menuItemDelete_KMA.Size = new Size(211, 26);
            menuItemDelete_KMA.Text = "Удалить запись";
            menuItemDelete_KMA.Click += buttonDelete_KMA_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(208, 6);
            // 
            // menuItemView_KMA
            // 
            menuItemView_KMA.DropDownItems.AddRange(new ToolStripItem[] { menuItemChart_KMA, toolStripMenuItem3 });
            menuItemView_KMA.Name = "menuItemView_KMA";
            menuItemView_KMA.Size = new Size(49, 24);
            menuItemView_KMA.Text = "Вид";
            // 
            // menuItemChart_KMA
            // 
            menuItemChart_KMA.Name = "menuItemChart_KMA";
            menuItemChart_KMA.Size = new Size(209, 26);
            menuItemChart_KMA.Text = "Показать график";
            menuItemChart_KMA.Click += buttonChart_KMA_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(206, 6);
            // 
            // menuItemHelp_KMA
            // 
            menuItemHelp_KMA.DropDownItems.AddRange(new ToolStripItem[] { menuItemAbout_KMA, menuItemManual_KMA, toolStripMenuItem4 });
            menuItemHelp_KMA.Name = "menuItemHelp_KMA";
            menuItemHelp_KMA.Size = new Size(81, 24);
            menuItemHelp_KMA.Text = "Справка";
            // 
            // menuItemAbout_KMA
            // 
            menuItemAbout_KMA.Name = "menuItemAbout_KMA";
            menuItemAbout_KMA.Size = new Size(187, 26);
            menuItemAbout_KMA.Text = "О программе";
            menuItemAbout_KMA.Click += buttonHelp_KMA_Click;
            // 
            // menuItemManual_KMA
            // 
            menuItemManual_KMA.Name = "menuItemManual_KMA";
            menuItemManual_KMA.Size = new Size(187, 26);
            menuItemManual_KMA.Text = "Руководство";
            menuItemManual_KMA.Click += buttonManual_KMA_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(184, 6);
            // 
            // toolStripMain_KMA
            // 
            toolStripMain_KMA.ImageScalingSize = new Size(32, 32);
            toolStripMain_KMA.Items.AddRange(new ToolStripItem[] { toolStripButtonLoad_KMA, toolStripButtonSave_KMA, toolStripSeparator1_KMA, toolStripButtonAdd_KMA, toolStripButtonDelete_KMA, toolStripSeparator2_KMA, toolStripButtonSearch_KMA, toolStripButtonSort_KMA, toolStripButtonChart_KMA, toolStripButtonHelp_KMA });
            toolStripMain_KMA.Location = new Point(0, 28);
            toolStripMain_KMA.Name = "toolStripMain_KMA";
            toolStripMain_KMA.Size = new Size(1236, 39);
            toolStripMain_KMA.TabIndex = 1;
            toolStripMain_KMA.Text = "toolStrip1";
            // 
            // toolStripButtonLoad_KMA
            // 
            toolStripButtonLoad_KMA.Image = (Image)resources.GetObject("toolStripButtonLoad_KMA.Image");
            toolStripButtonLoad_KMA.ImageTransparentColor = Color.Magenta;
            toolStripButtonLoad_KMA.Name = "toolStripButtonLoad_KMA";
            toolStripButtonLoad_KMA.Size = new Size(113, 36);
            toolStripButtonLoad_KMA.Text = "Загрузить";
            toolStripButtonLoad_KMA.ToolTipText = "Загрузить CSV файл с данными";
            toolStripButtonLoad_KMA.Click += buttonLoadFile_KMA_Click;
            // 
            // toolStripButtonSave_KMA
            // 
            toolStripButtonSave_KMA.Image = (Image)resources.GetObject("toolStripButtonSave_KMA.Image");
            toolStripButtonSave_KMA.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave_KMA.Name = "toolStripButtonSave_KMA";
            toolStripButtonSave_KMA.Size = new Size(119, 36);
            toolStripButtonSave_KMA.Text = "Сохранить";
            toolStripButtonSave_KMA.ToolTipText = "Сохранить изменения";
            toolStripButtonSave_KMA.Click += buttonSaveFile_KMA_Click;
            // 
            // toolStripSeparator1_KMA
            // 
            toolStripSeparator1_KMA.Name = "toolStripSeparator1_KMA";
            toolStripSeparator1_KMA.Size = new Size(6, 39);
            // 
            // toolStripButtonAdd_KMA
            // 
            toolStripButtonAdd_KMA.Image = (Image)resources.GetObject("toolStripButtonAdd_KMA.Image");
            toolStripButtonAdd_KMA.ImageTransparentColor = Color.Magenta;
            toolStripButtonAdd_KMA.Name = "toolStripButtonAdd_KMA";
            toolStripButtonAdd_KMA.Size = new Size(112, 36);
            toolStripButtonAdd_KMA.Text = "Добавить";
            toolStripButtonAdd_KMA.ToolTipText = "Добавить новую запись";
            toolStripButtonAdd_KMA.Click += buttonAdd_KMA_Click;
            // 
            // toolStripButtonDelete_KMA
            // 
            toolStripButtonDelete_KMA.Image = (Image)resources.GetObject("toolStripButtonDelete_KMA.Image");
            toolStripButtonDelete_KMA.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelete_KMA.Name = "toolStripButtonDelete_KMA";
            toolStripButtonDelete_KMA.Size = new Size(101, 36);
            toolStripButtonDelete_KMA.Text = "Удалить";
            toolStripButtonDelete_KMA.ToolTipText = "Удалить выбранную запись";
            toolStripButtonDelete_KMA.Click += buttonDelete_KMA_Click;
            // 
            // toolStripSeparator2_KMA
            // 
            toolStripSeparator2_KMA.Name = "toolStripSeparator2_KMA";
            toolStripSeparator2_KMA.Size = new Size(6, 39);
            // 
            // toolStripButtonSearch_KMA
            // 
            toolStripButtonSearch_KMA.Image = (Image)resources.GetObject("toolStripButtonSearch_KMA.Image");
            toolStripButtonSearch_KMA.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearch_KMA.Name = "toolStripButtonSearch_KMA";
            toolStripButtonSearch_KMA.Size = new Size(88, 36);
            toolStripButtonSearch_KMA.Text = "Поиск";
            toolStripButtonSearch_KMA.ToolTipText = "Найти записи по ФИО";
            toolStripButtonSearch_KMA.Click += toolStripButtonSearch_KMA_Click;
            // 
            // toolStripButtonSort_KMA
            // 
            toolStripButtonSort_KMA.Image = (Image)resources.GetObject("toolStripButtonSort_KMA.Image");
            toolStripButtonSort_KMA.ImageTransparentColor = Color.Magenta;
            toolStripButtonSort_KMA.Name = "toolStripButtonSort_KMA";
            toolStripButtonSort_KMA.Size = new Size(128, 36);
            toolStripButtonSort_KMA.Text = "Сортировка";
            toolStripButtonSort_KMA.ToolTipText = "Сортировать по капиталу(по возрастанию)";
            toolStripButtonSort_KMA.Click += buttonSort_KMA_Click;
            // 
            // toolStripButtonChart_KMA
            // 
            toolStripButtonChart_KMA.Image = (Image)resources.GetObject("toolStripButtonChart_KMA.Image");
            toolStripButtonChart_KMA.ImageTransparentColor = Color.Magenta;
            toolStripButtonChart_KMA.Name = "toolStripButtonChart_KMA";
            toolStripButtonChart_KMA.Size = new Size(95, 36);
            toolStripButtonChart_KMA.Text = "График";
            toolStripButtonChart_KMA.ToolTipText = "Показать график капитала";
            toolStripButtonChart_KMA.Click += buttonChart_KMA_Click;
            // 
            // toolStripButtonHelp_KMA
            // 
            toolStripButtonHelp_KMA.Image = (Image)resources.GetObject("toolStripButtonHelp_KMA.Image");
            toolStripButtonHelp_KMA.ImageTransparentColor = Color.Magenta;
            toolStripButtonHelp_KMA.Name = "toolStripButtonHelp_KMA";
            toolStripButtonHelp_KMA.Size = new Size(131, 36);
            toolStripButtonHelp_KMA.Text = "Руководство";
            toolStripButtonHelp_KMA.ToolTipText = "Открыть руководство пользователя";
            toolStripButtonHelp_KMA.Click += buttonManual_KMA_Click;
            // 
            // groupBoxStatistics_KMA
            // 
            groupBoxStatistics_KMA.Controls.Add(labelMaxCapital_KMA);
            groupBoxStatistics_KMA.Controls.Add(labelMinCapital_KMA);
            groupBoxStatistics_KMA.Controls.Add(labelAverageCapital_KMA);
            groupBoxStatistics_KMA.Controls.Add(textBoxMaxCapital_KMA);
            groupBoxStatistics_KMA.Controls.Add(textBoxMinCapital_KMA);
            groupBoxStatistics_KMA.Controls.Add(textBoxAverageCapital_KMA);
            groupBoxStatistics_KMA.Controls.Add(textBoxTotalCapital_KMA);
            groupBoxStatistics_KMA.Controls.Add(labelTotalCapital_KMA);
            groupBoxStatistics_KMA.Controls.Add(textBoxTotalCount_KMA);
            groupBoxStatistics_KMA.Controls.Add(labelTotalCount_KMA);
            groupBoxStatistics_KMA.Dock = DockStyle.Left;
            groupBoxStatistics_KMA.Location = new Point(0, 67);
            groupBoxStatistics_KMA.Name = "groupBoxStatistics_KMA";
            groupBoxStatistics_KMA.Size = new Size(193, 472);
            groupBoxStatistics_KMA.TabIndex = 2;
            groupBoxStatistics_KMA.TabStop = false;
            groupBoxStatistics_KMA.Text = "Статистика";
            // 
            // labelMaxCapital_KMA
            // 
            labelMaxCapital_KMA.AutoSize = true;
            labelMaxCapital_KMA.Location = new Point(13, 384);
            labelMaxCapital_KMA.Name = "labelMaxCapital_KMA";
            labelMaxCapital_KMA.Size = new Size(120, 20);
            labelMaxCapital_KMA.TabIndex = 9;
            labelMaxCapital_KMA.Text = "Максимальный:";
            // 
            // labelMinCapital_KMA
            // 
            labelMinCapital_KMA.AutoSize = true;
            labelMinCapital_KMA.Location = new Point(13, 274);
            labelMinCapital_KMA.Name = "labelMinCapital_KMA";
            labelMinCapital_KMA.Size = new Size(116, 20);
            labelMinCapital_KMA.TabIndex = 8;
            labelMinCapital_KMA.Text = "Минимальный:";
            // 
            // labelAverageCapital_KMA
            // 
            labelAverageCapital_KMA.AutoSize = true;
            labelAverageCapital_KMA.Location = new Point(13, 182);
            labelAverageCapital_KMA.Name = "labelAverageCapital_KMA";
            labelAverageCapital_KMA.Size = new Size(132, 20);
            labelAverageCapital_KMA.TabIndex = 7;
            labelAverageCapital_KMA.Text = "Средний капитал:";
            // 
            // textBoxMaxCapital_KMA
            // 
            textBoxMaxCapital_KMA.Location = new Point(23, 419);
            textBoxMaxCapital_KMA.Name = "textBoxMaxCapital_KMA";
            textBoxMaxCapital_KMA.ReadOnly = true;
            textBoxMaxCapital_KMA.Size = new Size(125, 27);
            textBoxMaxCapital_KMA.TabIndex = 6;
            textBoxMaxCapital_KMA.TabStop = false;
            // 
            // textBoxMinCapital_KMA
            // 
            textBoxMinCapital_KMA.Location = new Point(23, 319);
            textBoxMinCapital_KMA.Name = "textBoxMinCapital_KMA";
            textBoxMinCapital_KMA.ReadOnly = true;
            textBoxMinCapital_KMA.Size = new Size(125, 27);
            textBoxMinCapital_KMA.TabIndex = 5;
            textBoxMinCapital_KMA.TabStop = false;
            // 
            // textBoxAverageCapital_KMA
            // 
            textBoxAverageCapital_KMA.Location = new Point(23, 222);
            textBoxAverageCapital_KMA.Name = "textBoxAverageCapital_KMA";
            textBoxAverageCapital_KMA.ReadOnly = true;
            textBoxAverageCapital_KMA.Size = new Size(125, 27);
            textBoxAverageCapital_KMA.TabIndex = 4;
            textBoxAverageCapital_KMA.TabStop = false;
            // 
            // textBoxTotalCapital_KMA
            // 
            textBoxTotalCapital_KMA.Location = new Point(23, 135);
            textBoxTotalCapital_KMA.Name = "textBoxTotalCapital_KMA";
            textBoxTotalCapital_KMA.ReadOnly = true;
            textBoxTotalCapital_KMA.Size = new Size(125, 27);
            textBoxTotalCapital_KMA.TabIndex = 3;
            textBoxTotalCapital_KMA.TabStop = false;
            // 
            // labelTotalCapital_KMA
            // 
            labelTotalCapital_KMA.AutoSize = true;
            labelTotalCapital_KMA.Location = new Point(13, 100);
            labelTotalCapital_KMA.Name = "labelTotalCapital_KMA";
            labelTotalCapital_KMA.Size = new Size(155, 20);
            labelTotalCapital_KMA.TabIndex = 2;
            labelTotalCapital_KMA.Text = "Суммарный капитал:";
            // 
            // textBoxTotalCount_KMA
            // 
            textBoxTotalCount_KMA.Location = new Point(23, 55);
            textBoxTotalCount_KMA.Name = "textBoxTotalCount_KMA";
            textBoxTotalCount_KMA.ReadOnly = true;
            textBoxTotalCount_KMA.Size = new Size(125, 27);
            textBoxTotalCount_KMA.TabIndex = 1;
            textBoxTotalCount_KMA.TabStop = false;
            // 
            // labelTotalCount_KMA
            // 
            labelTotalCount_KMA.AutoSize = true;
            labelTotalCount_KMA.Location = new Point(13, 23);
            labelTotalCount_KMA.Name = "labelTotalCount_KMA";
            labelTotalCount_KMA.Size = new Size(112, 20);
            labelTotalCount_KMA.TabIndex = 0;
            labelTotalCount_KMA.Text = "Всего записей:";
            // 
            // groupBoxSearch_KMA
            // 
            groupBoxSearch_KMA.Controls.Add(textBoxMaxFilter_KMA);
            groupBoxSearch_KMA.Controls.Add(textBoxMinFilter_KMA);
            groupBoxSearch_KMA.Controls.Add(labelFilterResult_KMA);
            groupBoxSearch_KMA.Controls.Add(buttonClearFilter_KMA);
            groupBoxSearch_KMA.Controls.Add(buttonFilter_KMA);
            groupBoxSearch_KMA.Controls.Add(labelMaxCapitalFilter_KMA);
            groupBoxSearch_KMA.Controls.Add(labelMinCapitalFilter_KMA);
            groupBoxSearch_KMA.Controls.Add(labelFilter_KMA);
            groupBoxSearch_KMA.Controls.Add(labelSeparator_KMA);
            groupBoxSearch_KMA.Controls.Add(buttonClearSearch_KMA);
            groupBoxSearch_KMA.Controls.Add(buttonSearch_KMA);
            groupBoxSearch_KMA.Controls.Add(comboBoxSearchField_KMA);
            groupBoxSearch_KMA.Controls.Add(textBoxSearch_KMA);
            groupBoxSearch_KMA.Dock = DockStyle.Left;
            groupBoxSearch_KMA.Location = new Point(193, 67);
            groupBoxSearch_KMA.Name = "groupBoxSearch_KMA";
            groupBoxSearch_KMA.Size = new Size(262, 472);
            groupBoxSearch_KMA.TabIndex = 3;
            groupBoxSearch_KMA.TabStop = false;
            groupBoxSearch_KMA.Text = "Поиск и фильтрация";
            // 
            // textBoxMaxFilter_KMA
            // 
            textBoxMaxFilter_KMA.Location = new Point(138, 267);
            textBoxMaxFilter_KMA.Name = "textBoxMaxFilter_KMA";
            textBoxMaxFilter_KMA.Size = new Size(103, 27);
            textBoxMaxFilter_KMA.TabIndex = 12;
            textBoxMaxFilter_KMA.Text = "1000000";
            toolTipButtons_KMA.SetToolTip(textBoxMaxFilter_KMA, "Введите максимальную сумму капитала для фильтрации");
            textBoxMaxFilter_KMA.TextChanged += textBoxMaxFilter_KMA_TextChanged;
            // 
            // textBoxMinFilter_KMA
            // 
            textBoxMinFilter_KMA.Location = new Point(5, 267);
            textBoxMinFilter_KMA.Name = "textBoxMinFilter_KMA";
            textBoxMinFilter_KMA.Size = new Size(103, 27);
            textBoxMinFilter_KMA.TabIndex = 11;
            textBoxMinFilter_KMA.Text = "0";
            toolTipButtons_KMA.SetToolTip(textBoxMinFilter_KMA, "\"Введите минимальную сумму капитала для фильтрации");
            textBoxMinFilter_KMA.TextChanged += textBoxMinFilter_KMA_TextChanged;
            // 
            // labelFilterResult_KMA
            // 
            labelFilterResult_KMA.AutoSize = true;
            labelFilterResult_KMA.ForeColor = SystemColors.ActiveBorder;
            labelFilterResult_KMA.Location = new Point(5, 384);
            labelFilterResult_KMA.Name = "labelFilterResult_KMA";
            labelFilterResult_KMA.Size = new Size(157, 20);
            labelFilterResult_KMA.TabIndex = 10;
            labelFilterResult_KMA.Text = "Фильтр не применен";
            // 
            // buttonClearFilter_KMA
            // 
            buttonClearFilter_KMA.Location = new Point(138, 332);
            buttonClearFilter_KMA.Name = "buttonClearFilter_KMA";
            buttonClearFilter_KMA.Size = new Size(103, 29);
            buttonClearFilter_KMA.TabIndex = 9;
            buttonClearFilter_KMA.Text = "Сбросить";
            toolTipButtons_KMA.SetToolTip(buttonClearFilter_KMA, "Сбросить фильтрацию и показать все записи");
            buttonClearFilter_KMA.UseVisualStyleBackColor = true;
            buttonClearFilter_KMA.Click += buttonClearFilter_KMA_Click;
            // 
            // buttonFilter_KMA
            // 
            buttonFilter_KMA.Location = new Point(6, 332);
            buttonFilter_KMA.Name = "buttonFilter_KMA";
            buttonFilter_KMA.Size = new Size(105, 29);
            buttonFilter_KMA.TabIndex = 8;
            buttonFilter_KMA.Text = "Применить";
            toolTipButtons_KMA.SetToolTip(buttonFilter_KMA, "Применить фильтр по диапазону капитала");
            buttonFilter_KMA.UseVisualStyleBackColor = true;
            buttonFilter_KMA.Click += buttonFilter_KMA_Click;
            // 
            // labelMaxCapitalFilter_KMA
            // 
            labelMaxCapitalFilter_KMA.AutoSize = true;
            labelMaxCapitalFilter_KMA.Location = new Point(147, 225);
            labelMaxCapitalFilter_KMA.Name = "labelMaxCapitalFilter_KMA";
            labelMaxCapitalFilter_KMA.Size = new Size(31, 20);
            labelMaxCapitalFilter_KMA.TabIndex = 7;
            labelMaxCapitalFilter_KMA.Text = "До:";
            toolTipButtons_KMA.SetToolTip(labelMaxCapitalFilter_KMA, "Введите максимальный капитал");
            // 
            // labelMinCapitalFilter_KMA
            // 
            labelMinCapitalFilter_KMA.AutoSize = true;
            labelMinCapitalFilter_KMA.Location = new Point(6, 229);
            labelMinCapitalFilter_KMA.Name = "labelMinCapitalFilter_KMA";
            labelMinCapitalFilter_KMA.Size = new Size(29, 20);
            labelMinCapitalFilter_KMA.TabIndex = 6;
            labelMinCapitalFilter_KMA.Text = "От:";
            toolTipButtons_KMA.SetToolTip(labelMinCapitalFilter_KMA, "Введите минимальный капитал");
            // 
            // labelFilter_KMA
            // 
            labelFilter_KMA.AutoSize = true;
            labelFilter_KMA.Location = new Point(0, 200);
            labelFilter_KMA.Name = "labelFilter_KMA";
            labelFilter_KMA.Size = new Size(185, 20);
            labelFilter_KMA.TabIndex = 5;
            labelFilter_KMA.Text = "Фильтрация по капиталу:";
            // 
            // labelSeparator_KMA
            // 
            labelSeparator_KMA.AutoSize = true;
            labelSeparator_KMA.Location = new Point(0, 162);
            labelSeparator_KMA.Name = "labelSeparator_KMA";
            labelSeparator_KMA.Size = new Size(257, 20);
            labelSeparator_KMA.TabIndex = 4;
            labelSeparator_KMA.Text = "───────────────────────────────";
            // 
            // buttonClearSearch_KMA
            // 
            buttonClearSearch_KMA.Location = new Point(163, 116);
            buttonClearSearch_KMA.Name = "buttonClearSearch_KMA";
            buttonClearSearch_KMA.Size = new Size(94, 29);
            buttonClearSearch_KMA.TabIndex = 3;
            buttonClearSearch_KMA.Text = "Очистить";
            toolTipButtons_KMA.SetToolTip(buttonClearSearch_KMA, "Очистить фильтр");
            buttonClearSearch_KMA.UseVisualStyleBackColor = true;
            buttonClearSearch_KMA.Click += buttonClearSearch_KMA_Click;
            // 
            // buttonSearch_KMA
            // 
            buttonSearch_KMA.Location = new Point(163, 44);
            buttonSearch_KMA.Name = "buttonSearch_KMA";
            buttonSearch_KMA.Size = new Size(94, 29);
            buttonSearch_KMA.TabIndex = 2;
            buttonSearch_KMA.Text = "Найти";
            toolTipButtons_KMA.SetToolTip(buttonSearch_KMA, "Найти записи по выбранному критерию");
            buttonSearch_KMA.UseVisualStyleBackColor = true;
            buttonSearch_KMA.Click += buttonSearch_KMA_Click;
            // 
            // comboBoxSearchField_KMA
            // 
            comboBoxSearchField_KMA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchField_KMA.FormattingEnabled = true;
            comboBoxSearchField_KMA.Items.AddRange(new object[] { "По ФИО", "По адресу", "По телефону", "По ID", "По капиталу" });
            comboBoxSearchField_KMA.Location = new Point(6, 45);
            comboBoxSearchField_KMA.Name = "comboBoxSearchField_KMA";
            comboBoxSearchField_KMA.Size = new Size(151, 28);
            comboBoxSearchField_KMA.TabIndex = 1;
            toolTipButtons_KMA.SetToolTip(comboBoxSearchField_KMA, "Выберите поле для поиска");
            // 
            // textBoxSearch_KMA
            // 
            textBoxSearch_KMA.Location = new Point(5, 116);
            textBoxSearch_KMA.Name = "textBoxSearch_KMA";
            textBoxSearch_KMA.Size = new Size(151, 27);
            textBoxSearch_KMA.TabIndex = 0;
            toolTipButtons_KMA.SetToolTip(textBoxSearch_KMA, "Введите текст для поиска владельцев");
            // 
            // toolTipButtons_KMA
            // 
            toolTipButtons_KMA.IsBalloon = true;
            toolTipButtons_KMA.ShowAlways = true;
            toolTipButtons_KMA.ToolTipIcon = ToolTipIcon.Info;
            toolTipButtons_KMA.ToolTipTitle = "Подсказка";
            // 
            // statusStripMain_KMA
            // 
            statusStripMain_KMA.ImageScalingSize = new Size(20, 20);
            statusStripMain_KMA.Items.AddRange(new ToolStripItem[] { statusLabelInfo_KMA, statusLabelTime_KMA });
            statusStripMain_KMA.Location = new Point(455, 513);
            statusStripMain_KMA.Name = "statusStripMain_KMA";
            statusStripMain_KMA.Size = new Size(781, 26);
            statusStripMain_KMA.TabIndex = 5;
            statusStripMain_KMA.Text = "statusStrip1";
            // 
            // statusLabelInfo_KMA
            // 
            statusLabelInfo_KMA.Name = "statusLabelInfo_KMA";
            statusLabelInfo_KMA.Size = new Size(703, 20);
            statusLabelInfo_KMA.Spring = true;
            statusLabelInfo_KMA.Text = "Готово";
            statusLabelInfo_KMA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusLabelTime_KMA
            // 
            statusLabelTime_KMA.Name = "statusLabelTime_KMA";
            statusLabelTime_KMA.Size = new Size(63, 20);
            statusLabelTime_KMA.Text = "00:00:00";
            statusLabelTime_KMA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridViewMain_KMA
            // 
            dataGridViewMain_KMA.AllowUserToAddRows = false;
            dataGridViewMain_KMA.AllowUserToDeleteRows = false;
            dataGridViewMain_KMA.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewMain_KMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain_KMA.Dock = DockStyle.Fill;
            dataGridViewMain_KMA.Location = new Point(455, 67);
            dataGridViewMain_KMA.Name = "dataGridViewMain_KMA";
            dataGridViewMain_KMA.RowHeadersVisible = false;
            dataGridViewMain_KMA.RowHeadersWidth = 51;
            dataGridViewMain_KMA.Size = new Size(781, 446);
            dataGridViewMain_KMA.TabIndex = 6;
            // 
            // FormMain_KMA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 539);
            Controls.Add(dataGridViewMain_KMA);
            Controls.Add(statusStripMain_KMA);
            Controls.Add(groupBoxSearch_KMA);
            Controls.Add(groupBoxStatistics_KMA);
            Controls.Add(toolStripMain_KMA);
            Controls.Add(menuStripMain_KMA);
            MainMenuStrip = menuStripMain_KMA;
            Name = "FormMain_KMA";
            Text = "Проект | Спринт 7 | Вариант 2 | Коваленко М.А.";
            menuStripMain_KMA.ResumeLayout(false);
            menuStripMain_KMA.PerformLayout();
            toolStripMain_KMA.ResumeLayout(false);
            toolStripMain_KMA.PerformLayout();
            groupBoxStatistics_KMA.ResumeLayout(false);
            groupBoxStatistics_KMA.PerformLayout();
            groupBoxSearch_KMA.ResumeLayout(false);
            groupBoxSearch_KMA.PerformLayout();
            statusStripMain_KMA.ResumeLayout(false);
            statusStripMain_KMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_KMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain_KMA;
        private ToolStripMenuItem menuItemFile_KMA;
        private ToolStripMenuItem menuItemLoad_KMA;
        private ToolStripMenuItem menuItemSave_KMA;
        private ToolStripMenuItem menuItemExit_KMA;
        private ToolStripMenuItem menuItemEdit_KMA;
        private ToolStripMenuItem menuItemAdd_KMA;
        private ToolStripMenuItem menuItemDelete_KMA;
        private ToolStripMenuItem menuItemView_KMA;
        private ToolStripMenuItem menuItemChart_KMA;
        private ToolStripMenuItem menuItemHelp_KMA;
        private ToolStripMenuItem menuItemAbout_KMA;
        private ToolStripMenuItem menuItemManual_KMA;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStrip toolStripMain_KMA;
        private ToolStripButton toolStripButtonLoad_KMA;
        private ToolStripButton toolStripButtonSave_KMA;
        private ToolStripButton toolStripButtonAdd_KMA;
        private ToolStripButton toolStripButtonDelete_KMA;
        private ToolStripSeparator toolStripSeparator1_KMA;
        private ToolStripSeparator toolStripSeparator2_KMA;
        private ToolStripButton toolStripButtonSearch_KMA;
        private ToolStripButton toolStripButtonSort_KMA;
        private ToolStripButton toolStripButtonChart_KMA;
        private GroupBox groupBoxStatistics_KMA;
        private TextBox textBoxTotalCapital_KMA;
        private Label labelTotalCapital_KMA;
        private TextBox textBoxTotalCount_KMA;
        private Label labelTotalCount_KMA;
        private Label labelMaxCapital_KMA;
        private Label labelMinCapital_KMA;
        private Label labelAverageCapital_KMA;
        private TextBox textBoxMaxCapital_KMA;
        private TextBox textBoxMinCapital_KMA;
        private TextBox textBoxAverageCapital_KMA;
        private GroupBox groupBoxSearch_KMA;
        private Button buttonClearSearch_KMA;
        private Button buttonSearch_KMA;
        private TextBox textBoxSearch_KMA;
        private ComboBox comboBoxSearchField_KMA;
        private ToolTip toolTipButtons_KMA;
        private StatusStrip statusStripMain_KMA;
        private DataGridView dataGridViewMain_KMA;
        private ToolStripStatusLabel statusLabelInfo_KMA;
        private ToolStripStatusLabel statusLabelTime_KMA;
        private ToolStripButton toolStripButtonHelp_KMA;
        private Label labelSeparator_KMA;
        private Label labelFilter_KMA;
        private Button buttonClearFilter_KMA;
        private Button buttonFilter_KMA;
        private Label labelMaxCapitalFilter_KMA;
        private Label labelMinCapitalFilter_KMA;
        private Label labelFilterResult_KMA;
        private TextBox textBoxMaxFilter_KMA;
        private TextBox textBoxMinFilter_KMA;
    }
}
