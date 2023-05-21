namespace HotTours
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changeAccountToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            totalToolStripStatusLabel = new ToolStripStatusLabel();
            totalSumToolStripStatusLabel = new ToolStripStatusLabel();
            surchargeCountToolStripStatusLabel = new ToolStripStatusLabel();
            surchargeSumToolStripStatusLabel = new ToolStripStatusLabel();
            toursDataGridView = new DataGridView();
            DirectionColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            AmountOfDaysColumn = new DataGridViewTextBoxColumn();
            PriceForManColumn = new DataGridViewTextBoxColumn();
            AmountOfManColumn = new DataGridViewTextBoxColumn();
            WiFiColumn = new DataGridViewCheckBoxColumn();
            SurchargeColumn = new DataGridViewTextBoxColumn();
            TotalColumn = new DataGridViewTextBoxColumn();
            groupBoxSort = new GroupBox();
            radioButtonSortDown = new RadioButton();
            radioButtonSortUp = new RadioButton();
            comboBoxSort = new ComboBox();
            groupBox1 = new GroupBox();
            radioButtonWiFiFalse = new RadioButton();
            radioButtonWiFiTrue = new RadioButton();
            label11 = new Label();
            textBoxTotalPriceTo = new TextBox();
            label12 = new Label();
            textBoxTotalPriceFrom = new TextBox();
            checkBoxWiFi = new CheckBox();
            checkBoxTotalPrice = new CheckBox();
            label1 = new Label();
            textBoxSurchageTo = new TextBox();
            label2 = new Label();
            textBoxSurchageFrom = new TextBox();
            label7 = new Label();
            textBoxAmountOfMansTo = new TextBox();
            label8 = new Label();
            textBoxAmountOfMansFrom = new TextBox();
            checkBoxSurchage = new CheckBox();
            checkBoxAmountOfMan = new CheckBox();
            label5 = new Label();
            textBoxPriceForManTo = new TextBox();
            label6 = new Label();
            textBoxPriceForManFrom = new TextBox();
            label3 = new Label();
            textBoxNightsTo = new TextBox();
            label4 = new Label();
            textBoxNightsFrom = new TextBox();
            checkBoxPriceForMan = new CheckBox();
            checkBoxAmountOfDays = new CheckBox();
            comboBoxDirectionFilter = new ComboBox();
            checkBoxDirection = new CheckBox();
            tourBindingSource = new BindingSource(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toursDataGridView).BeginInit();
            groupBoxSort.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tourBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, правкаToolStripMenuItem, changeAccountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1393, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(109, 22);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, toolStripSeparator1, deleteToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(59, 20);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(128, 22);
            addToolStripMenuItem.Text = "Добавить";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(128, 22);
            editToolStripMenuItem.Text = "Изменить";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(125, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(128, 22);
            deleteToolStripMenuItem.Text = "Удалить";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // changeAccountToolStripMenuItem
            // 
            changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            changeAccountToolStripMenuItem.Size = new Size(112, 20);
            changeAccountToolStripMenuItem.Text = "Сменить аккаунт";
            changeAccountToolStripMenuItem.Click += changeAccountToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { totalToolStripStatusLabel, totalSumToolStripStatusLabel, surchargeCountToolStripStatusLabel, surchargeSumToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 617);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1393, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // totalToolStripStatusLabel
            // 
            totalToolStripStatusLabel.Name = "totalToolStripStatusLabel";
            totalToolStripStatusLabel.Size = new Size(78, 17);
            totalToolStripStatusLabel.Text = "Всего туров: ";
            // 
            // totalSumToolStripStatusLabel
            // 
            totalSumToolStripStatusLabel.Name = "totalSumToolStripStatusLabel";
            totalSumToolStripStatusLabel.Size = new Size(91, 17);
            totalSumToolStripStatusLabel.Text = "Общая сумма: ";
            // 
            // surchargeCountToolStripStatusLabel
            // 
            surchargeCountToolStripStatusLabel.Name = "surchargeCountToolStripStatusLabel";
            surchargeCountToolStripStatusLabel.Size = new Size(114, 17);
            surchargeCountToolStripStatusLabel.Text = "Туров с доплатами:";
            // 
            // surchargeSumToolStripStatusLabel
            // 
            surchargeSumToolStripStatusLabel.Name = "surchargeSumToolStripStatusLabel";
            surchargeSumToolStripStatusLabel.Size = new Size(92, 17);
            surchargeSumToolStripStatusLabel.Text = "Сумма доплат: ";
            // 
            // toursDataGridView
            // 
            toursDataGridView.AllowUserToAddRows = false;
            toursDataGridView.AllowUserToDeleteRows = false;
            toursDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toursDataGridView.Columns.AddRange(new DataGridViewColumn[] { DirectionColumn, DateColumn, AmountOfDaysColumn, PriceForManColumn, AmountOfManColumn, WiFiColumn, SurchargeColumn, TotalColumn });
            toursDataGridView.Dock = DockStyle.Left;
            toursDataGridView.Location = new Point(0, 24);
            toursDataGridView.Margin = new Padding(3, 2, 3, 2);
            toursDataGridView.Name = "toursDataGridView";
            toursDataGridView.RowHeadersVisible = false;
            toursDataGridView.RowHeadersWidth = 51;
            toursDataGridView.RowTemplate.Height = 29;
            toursDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            toursDataGridView.Size = new Size(920, 593);
            toursDataGridView.TabIndex = 2;
            toursDataGridView.CellFormatting += dataGridView1_CellFormatting;
            toursDataGridView.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // DirectionColumn
            // 
            DirectionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DirectionColumn.DataPropertyName = "Direction";
            DirectionColumn.HeaderText = "Направление";
            DirectionColumn.MinimumWidth = 6;
            DirectionColumn.Name = "DirectionColumn";
            DirectionColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            DateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateColumn.DataPropertyName = "Date";
            DateColumn.HeaderText = "Дата вылета";
            DateColumn.MinimumWidth = 6;
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            // 
            // AmountOfDaysColumn
            // 
            AmountOfDaysColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AmountOfDaysColumn.DataPropertyName = "AmountOfDays";
            AmountOfDaysColumn.HeaderText = "Количество ночей";
            AmountOfDaysColumn.MinimumWidth = 6;
            AmountOfDaysColumn.Name = "AmountOfDaysColumn";
            AmountOfDaysColumn.ReadOnly = true;
            // 
            // PriceForManColumn
            // 
            PriceForManColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PriceForManColumn.DataPropertyName = "PriceForMan";
            PriceForManColumn.HeaderText = "Стоимость за отдыхающего (руб)";
            PriceForManColumn.MinimumWidth = 6;
            PriceForManColumn.Name = "PriceForManColumn";
            PriceForManColumn.ReadOnly = true;
            // 
            // AmountOfManColumn
            // 
            AmountOfManColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AmountOfManColumn.DataPropertyName = "AmountOfMan";
            AmountOfManColumn.HeaderText = "Количество отдыхающих";
            AmountOfManColumn.MinimumWidth = 6;
            AmountOfManColumn.Name = "AmountOfManColumn";
            AmountOfManColumn.ReadOnly = true;
            // 
            // WiFiColumn
            // 
            WiFiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WiFiColumn.DataPropertyName = "WiFi";
            WiFiColumn.HeaderText = "Наличие Wi-Fi";
            WiFiColumn.MinimumWidth = 6;
            WiFiColumn.Name = "WiFiColumn";
            WiFiColumn.ReadOnly = true;
            // 
            // SurchargeColumn
            // 
            SurchargeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SurchargeColumn.DataPropertyName = "Surcharge";
            SurchargeColumn.HeaderText = "Доплаты (руб)";
            SurchargeColumn.MinimumWidth = 6;
            SurchargeColumn.Name = "SurchargeColumn";
            SurchargeColumn.ReadOnly = true;
            // 
            // TotalColumn
            // 
            TotalColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalColumn.DataPropertyName = "TotalPrice";
            TotalColumn.HeaderText = "Общая стоимость";
            TotalColumn.MinimumWidth = 6;
            TotalColumn.Name = "TotalColumn";
            TotalColumn.ReadOnly = true;
            // 
            // groupBoxSort
            // 
            groupBoxSort.Controls.Add(radioButtonSortDown);
            groupBoxSort.Controls.Add(radioButtonSortUp);
            groupBoxSort.Controls.Add(comboBoxSort);
            groupBoxSort.Location = new Point(926, 24);
            groupBoxSort.Name = "groupBoxSort";
            groupBoxSort.Size = new Size(455, 60);
            groupBoxSort.TabIndex = 3;
            groupBoxSort.TabStop = false;
            groupBoxSort.Text = "Сортировать по ";
            // 
            // radioButtonSortDown
            // 
            radioButtonSortDown.AutoSize = true;
            radioButtonSortDown.Location = new Point(347, 23);
            radioButtonSortDown.Name = "radioButtonSortDown";
            radioButtonSortDown.Size = new Size(102, 19);
            radioButtonSortDown.TabIndex = 2;
            radioButtonSortDown.Text = "По убыванию";
            radioButtonSortDown.UseVisualStyleBackColor = true;
            radioButtonSortDown.Click += MakeSortAndFilter;
            // 
            // radioButtonSortUp
            // 
            radioButtonSortUp.AutoSize = true;
            radioButtonSortUp.Checked = true;
            radioButtonSortUp.Location = new Point(225, 23);
            radioButtonSortUp.Name = "radioButtonSortUp";
            radioButtonSortUp.Size = new Size(116, 19);
            radioButtonSortUp.TabIndex = 1;
            radioButtonSortUp.TabStop = true;
            radioButtonSortUp.Text = "По возрастанию";
            radioButtonSortUp.UseVisualStyleBackColor = true;
            radioButtonSortUp.Click += MakeSortAndFilter;
            // 
            // comboBoxSort
            // 
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(6, 22);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(213, 23);
            comboBoxSort.TabIndex = 0;
            comboBoxSort.SelectedIndexChanged += MakeSortAndFilter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonWiFiFalse);
            groupBox1.Controls.Add(radioButtonWiFiTrue);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBoxTotalPriceTo);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBoxTotalPriceFrom);
            groupBox1.Controls.Add(checkBoxWiFi);
            groupBox1.Controls.Add(checkBoxTotalPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxSurchageTo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxSurchageFrom);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxAmountOfMansTo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxAmountOfMansFrom);
            groupBox1.Controls.Add(checkBoxSurchage);
            groupBox1.Controls.Add(checkBoxAmountOfMan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxPriceForManTo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxPriceForManFrom);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxNightsTo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxNightsFrom);
            groupBox1.Controls.Add(checkBoxPriceForMan);
            groupBox1.Controls.Add(checkBoxAmountOfDays);
            groupBox1.Controls.Add(comboBoxDirectionFilter);
            groupBox1.Controls.Add(checkBoxDirection);
            groupBox1.Location = new Point(926, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 524);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтры";
            // 
            // radioButtonWiFiFalse
            // 
            radioButtonWiFiFalse.AutoSize = true;
            radioButtonWiFiFalse.Enabled = false;
            radioButtonWiFiFalse.Location = new Point(343, 207);
            radioButtonWiFiFalse.Name = "radioButtonWiFiFalse";
            radioButtonWiFiFalse.Size = new Size(48, 19);
            radioButtonWiFiFalse.TabIndex = 109;
            radioButtonWiFiFalse.Text = " Нет";
            radioButtonWiFiFalse.UseVisualStyleBackColor = true;
            radioButtonWiFiFalse.Click += MakeSortAndFilter;
            // 
            // radioButtonWiFiTrue
            // 
            radioButtonWiFiTrue.AutoSize = true;
            radioButtonWiFiTrue.Checked = true;
            radioButtonWiFiTrue.Enabled = false;
            radioButtonWiFiTrue.Location = new Point(205, 207);
            radioButtonWiFiTrue.Name = "radioButtonWiFiTrue";
            radioButtonWiFiTrue.Size = new Size(48, 19);
            radioButtonWiFiTrue.TabIndex = 108;
            radioButtonWiFiTrue.TabStop = true;
            radioButtonWiFiTrue.Text = "Есть";
            radioButtonWiFiTrue.UseVisualStyleBackColor = true;
            radioButtonWiFiTrue.Click += MakeSortAndFilter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(317, 179);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 107;
            label11.Text = "до";
            // 
            // textBoxTotalPriceTo
            // 
            textBoxTotalPriceTo.Enabled = false;
            textBoxTotalPriceTo.Location = new Point(343, 176);
            textBoxTotalPriceTo.Name = "textBoxTotalPriceTo";
            textBoxTotalPriceTo.Size = new Size(88, 23);
            textBoxTotalPriceTo.TabIndex = 106;
            textBoxTotalPriceTo.TextChanged += MakeSortAndFilter;
            textBoxTotalPriceTo.KeyPress += textBoxFromTo_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(180, 179);
            label12.Name = "label12";
            label12.Size = new Size(19, 15);
            label12.TabIndex = 105;
            label12.Text = "от";
            // 
            // textBoxTotalPriceFrom
            // 
            textBoxTotalPriceFrom.Enabled = false;
            textBoxTotalPriceFrom.Location = new Point(205, 176);
            textBoxTotalPriceFrom.Name = "textBoxTotalPriceFrom";
            textBoxTotalPriceFrom.Size = new Size(93, 23);
            textBoxTotalPriceFrom.TabIndex = 104;
            textBoxTotalPriceFrom.TextChanged += MakeSortAndFilter;
            textBoxTotalPriceFrom.KeyPress += textBoxFromTo_KeyPress;
            // 
            // checkBoxWiFi
            // 
            checkBoxWiFi.AutoSize = true;
            checkBoxWiFi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxWiFi.Location = new Point(22, 207);
            checkBoxWiFi.Name = "checkBoxWiFi";
            checkBoxWiFi.Size = new Size(101, 19);
            checkBoxWiFi.TabIndex = 103;
            checkBoxWiFi.Text = "Наличие WiFi";
            checkBoxWiFi.UseVisualStyleBackColor = true;
            checkBoxWiFi.Click += MakeSortAndFilter;
            // 
            // checkBoxTotalPrice
            // 
            checkBoxTotalPrice.AutoSize = true;
            checkBoxTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTotalPrice.Location = new Point(22, 178);
            checkBoxTotalPrice.Name = "checkBoxTotalPrice";
            checkBoxTotalPrice.Size = new Size(126, 19);
            checkBoxTotalPrice.TabIndex = 102;
            checkBoxTotalPrice.Text = "Общая стоимость";
            checkBoxTotalPrice.UseVisualStyleBackColor = true;
            checkBoxTotalPrice.Click += MakeSortAndFilter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 150);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 101;
            label1.Text = "до";
            // 
            // textBoxSurchageTo
            // 
            textBoxSurchageTo.Enabled = false;
            textBoxSurchageTo.Location = new Point(343, 147);
            textBoxSurchageTo.Name = "textBoxSurchageTo";
            textBoxSurchageTo.Size = new Size(88, 23);
            textBoxSurchageTo.TabIndex = 100;
            textBoxSurchageTo.TextChanged += MakeSortAndFilter;
            textBoxSurchageTo.KeyPress += textBoxFromTo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 150);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 99;
            label2.Text = "от";
            // 
            // textBoxSurchageFrom
            // 
            textBoxSurchageFrom.Enabled = false;
            textBoxSurchageFrom.Location = new Point(205, 147);
            textBoxSurchageFrom.Name = "textBoxSurchageFrom";
            textBoxSurchageFrom.Size = new Size(93, 23);
            textBoxSurchageFrom.TabIndex = 98;
            textBoxSurchageFrom.TextChanged += MakeSortAndFilter;
            textBoxSurchageFrom.KeyPress += textBoxFromTo_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(317, 121);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 97;
            label7.Text = "до";
            // 
            // textBoxAmountOfMansTo
            // 
            textBoxAmountOfMansTo.Enabled = false;
            textBoxAmountOfMansTo.Location = new Point(343, 118);
            textBoxAmountOfMansTo.Name = "textBoxAmountOfMansTo";
            textBoxAmountOfMansTo.Size = new Size(88, 23);
            textBoxAmountOfMansTo.TabIndex = 96;
            textBoxAmountOfMansTo.TextChanged += MakeSortAndFilter;
            textBoxAmountOfMansTo.KeyPress += textBoxFromTo_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(180, 121);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 95;
            label8.Text = "от";
            // 
            // textBoxAmountOfMansFrom
            // 
            textBoxAmountOfMansFrom.Enabled = false;
            textBoxAmountOfMansFrom.Location = new Point(205, 118);
            textBoxAmountOfMansFrom.Name = "textBoxAmountOfMansFrom";
            textBoxAmountOfMansFrom.Size = new Size(93, 23);
            textBoxAmountOfMansFrom.TabIndex = 94;
            textBoxAmountOfMansFrom.TextChanged += MakeSortAndFilter;
            textBoxAmountOfMansFrom.KeyPress += textBoxFromTo_KeyPress;
            // 
            // checkBoxSurchage
            // 
            checkBoxSurchage.AutoSize = true;
            checkBoxSurchage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSurchage.Location = new Point(22, 149);
            checkBoxSurchage.Name = "checkBoxSurchage";
            checkBoxSurchage.Size = new Size(106, 19);
            checkBoxSurchage.TabIndex = 93;
            checkBoxSurchage.Text = "Доплаты (руб)";
            checkBoxSurchage.UseVisualStyleBackColor = true;
            checkBoxSurchage.Click += MakeSortAndFilter;
            // 
            // checkBoxAmountOfMan
            // 
            checkBoxAmountOfMan.AutoSize = true;
            checkBoxAmountOfMan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAmountOfMan.Location = new Point(22, 120);
            checkBoxAmountOfMan.Name = "checkBoxAmountOfMan";
            checkBoxAmountOfMan.Size = new Size(130, 19);
            checkBoxAmountOfMan.TabIndex = 92;
            checkBoxAmountOfMan.Text = "По кол-ву человек";
            checkBoxAmountOfMan.UseVisualStyleBackColor = true;
            checkBoxAmountOfMan.Click += MakeSortAndFilter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 92);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 91;
            label5.Text = "до";
            // 
            // textBoxPriceForManTo
            // 
            textBoxPriceForManTo.Enabled = false;
            textBoxPriceForManTo.Location = new Point(343, 89);
            textBoxPriceForManTo.Name = "textBoxPriceForManTo";
            textBoxPriceForManTo.Size = new Size(88, 23);
            textBoxPriceForManTo.TabIndex = 90;
            textBoxPriceForManTo.TextChanged += MakeSortAndFilter;
            textBoxPriceForManTo.KeyPress += textBoxFromTo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 92);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 89;
            label6.Text = "от";
            // 
            // textBoxPriceForManFrom
            // 
            textBoxPriceForManFrom.Enabled = false;
            textBoxPriceForManFrom.Location = new Point(205, 89);
            textBoxPriceForManFrom.Name = "textBoxPriceForManFrom";
            textBoxPriceForManFrom.Size = new Size(93, 23);
            textBoxPriceForManFrom.TabIndex = 88;
            textBoxPriceForManFrom.TextChanged += MakeSortAndFilter;
            textBoxPriceForManFrom.KeyPress += textBoxFromTo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 63);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 87;
            label3.Text = "до";
            // 
            // textBoxNightsTo
            // 
            textBoxNightsTo.Enabled = false;
            textBoxNightsTo.Location = new Point(343, 60);
            textBoxNightsTo.Name = "textBoxNightsTo";
            textBoxNightsTo.Size = new Size(88, 23);
            textBoxNightsTo.TabIndex = 86;
            textBoxNightsTo.TextChanged += MakeSortAndFilter;
            textBoxNightsTo.KeyPress += textBoxFromTo_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 63);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 85;
            label4.Text = "от";
            // 
            // textBoxNightsFrom
            // 
            textBoxNightsFrom.Enabled = false;
            textBoxNightsFrom.Location = new Point(205, 60);
            textBoxNightsFrom.Name = "textBoxNightsFrom";
            textBoxNightsFrom.Size = new Size(93, 23);
            textBoxNightsFrom.TabIndex = 84;
            textBoxNightsFrom.TextChanged += MakeSortAndFilter;
            textBoxNightsFrom.KeyPress += textBoxFromTo_KeyPress;
            // 
            // checkBoxPriceForMan
            // 
            checkBoxPriceForMan.AutoSize = true;
            checkBoxPriceForMan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxPriceForMan.Location = new Point(22, 91);
            checkBoxPriceForMan.Name = "checkBoxPriceForMan";
            checkBoxPriceForMan.Size = new Size(144, 19);
            checkBoxPriceForMan.TabIndex = 83;
            checkBoxPriceForMan.Text = "По стоимости за чел.";
            checkBoxPriceForMan.UseVisualStyleBackColor = true;
            checkBoxPriceForMan.Click += MakeSortAndFilter;
            // 
            // checkBoxAmountOfDays
            // 
            checkBoxAmountOfDays.AutoSize = true;
            checkBoxAmountOfDays.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAmountOfDays.Location = new Point(22, 62);
            checkBoxAmountOfDays.Name = "checkBoxAmountOfDays";
            checkBoxAmountOfDays.Size = new Size(119, 19);
            checkBoxAmountOfDays.TabIndex = 82;
            checkBoxAmountOfDays.Text = "По кол-ву ночей";
            checkBoxAmountOfDays.UseVisualStyleBackColor = true;
            checkBoxAmountOfDays.Click += MakeSortAndFilter;
            // 
            // comboBoxDirectionFilter
            // 
            comboBoxDirectionFilter.Enabled = false;
            comboBoxDirectionFilter.FormattingEnabled = true;
            comboBoxDirectionFilter.Location = new Point(180, 31);
            comboBoxDirectionFilter.Name = "comboBoxDirectionFilter";
            comboBoxDirectionFilter.Size = new Size(251, 23);
            comboBoxDirectionFilter.TabIndex = 1;
            comboBoxDirectionFilter.SelectedIndexChanged += MakeSortAndFilter;
            // 
            // checkBoxDirection
            // 
            checkBoxDirection.AutoSize = true;
            checkBoxDirection.Location = new Point(22, 33);
            checkBoxDirection.Name = "checkBoxDirection";
            checkBoxDirection.Size = new Size(121, 19);
            checkBoxDirection.TabIndex = 0;
            checkBoxDirection.Text = "По направлению";
            checkBoxDirection.UseVisualStyleBackColor = true;
            checkBoxDirection.Click += MakeSortAndFilter;
            // 
            // tourBindingSource
            // 
            tourBindingSource.DataSource = typeof(Models.Tour);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 639);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxSort);
            Controls.Add(toursDataGridView);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Горячие туры | Главная";
            FormClosed += MainForm_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toursDataGridView).EndInit();
            groupBoxSort.ResumeLayout(false);
            groupBoxSort.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tourBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel totalToolStripStatusLabel;
        private DataGridView toursDataGridView;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripStatusLabel totalSumToolStripStatusLabel;
        private ToolStripStatusLabel surchargeCountToolStripStatusLabel;
        private ToolStripStatusLabel surchargeSumToolStripStatusLabel;
        private GroupBox groupBoxSort;
        private RadioButton radioButtonSortDown;
        private RadioButton radioButtonSortUp;
        private ComboBox comboBoxSort;
        private GroupBox groupBox1;
        private CheckBox checkBoxDirection;
        private ToolStripMenuItem changeAccountToolStripMenuItem;
        private DataGridViewTextBoxColumn DirectionColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn AmountOfDaysColumn;
        private DataGridViewTextBoxColumn PriceForManColumn;
        private DataGridViewTextBoxColumn AmountOfManColumn;
        private DataGridViewCheckBoxColumn WiFiColumn;
        private DataGridViewTextBoxColumn SurchargeColumn;
        private DataGridViewTextBoxColumn TotalColumn;
        private BindingSource tourBindingSource;
        private ComboBox comboBoxDirectionFilter;
        private Label label5;
        private TextBox textBoxPriceForManTo;
        private Label label6;
        private TextBox textBoxPriceForManFrom;
        private Label label3;
        private TextBox textBoxNightsTo;
        private Label label4;
        private TextBox textBoxNightsFrom;
        private CheckBox checkBoxPriceForMan;
        private CheckBox checkBoxAmountOfDays;
        private RadioButton radioButtonWiFiFalse;
        private RadioButton radioButtonWiFiTrue;
        private Label label11;
        private TextBox textBoxTotalPriceTo;
        private Label label12;
        private TextBox textBoxTotalPriceFrom;
        private CheckBox checkBoxWiFi;
        private CheckBox checkBoxTotalPrice;
        private Label label1;
        private TextBox textBoxSurchageTo;
        private Label label2;
        private TextBox textBoxSurchageFrom;
        private Label label7;
        private TextBox textBoxAmountOfMansTo;
        private Label label8;
        private TextBox textBoxAmountOfMansFrom;
        private CheckBox checkBoxSurchage;
        private CheckBox checkBoxAmountOfMan;
    }
}
