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
            this.components = new System.ComponentModel.Container();
            this.tourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonList = new System.Windows.Forms.Button();
            this.labelNullError = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.radioButtonWiFiFalse = new System.Windows.Forms.RadioButton();
            this.radioButtonWiFiTrue = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTotalPriceTo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTotalPriceFrom = new System.Windows.Forms.TextBox();
            this.checkBoxWiFi = new System.Windows.Forms.CheckBox();
            this.checkBoxTotalPrice = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSurchageTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSurchageFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAmountOfMansTo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAmountOfMansFrom = new System.Windows.Forms.TextBox();
            this.checkBoxSurchage = new System.Windows.Forms.CheckBox();
            this.checkBoxAmountOfMan = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPriceForManTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPriceForManFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNightsTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNightsFrom = new System.Windows.Forms.TextBox();
            this.checkBoxPriceForMan = new System.Windows.Forms.CheckBox();
            this.checkBoxAmountOfDays = new System.Windows.Forms.CheckBox();
            this.comboBoxDirectionFilter = new System.Windows.Forms.ComboBox();
            this.checkBoxDirection = new System.Windows.Forms.CheckBox();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.radioButtonSortDown = new System.Windows.Forms.RadioButton();
            this.radioButtonSortUp = new System.Windows.Forms.RadioButton();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalSumToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.surchargeCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.surchargeSumToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toursDataGridView = new System.Windows.Forms.DataGridView();
            this.DirectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfDaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceForManColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfManColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WiFiColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SurchargeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toursDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tourBindingSource
            // 
            this.tourBindingSource.DataSource = typeof(HotTours.Models.Tour);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxSort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1060, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 799);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.labelNullError);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.radioButtonWiFiFalse);
            this.groupBox1.Controls.Add(this.radioButtonWiFiTrue);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxTotalPriceTo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxTotalPriceFrom);
            this.groupBox1.Controls.Add(this.checkBoxWiFi);
            this.groupBox1.Controls.Add(this.checkBoxTotalPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSurchageTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSurchageFrom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxAmountOfMansTo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxAmountOfMansFrom);
            this.groupBox1.Controls.Add(this.checkBoxSurchage);
            this.groupBox1.Controls.Add(this.checkBoxAmountOfMan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPriceForManTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxPriceForManFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNightsTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNightsFrom);
            this.groupBox1.Controls.Add(this.checkBoxPriceForMan);
            this.groupBox1.Controls.Add(this.checkBoxAmountOfDays);
            this.groupBox1.Controls.Add(this.comboBoxDirectionFilter);
            this.groupBox1.Controls.Add(this.checkBoxDirection);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(522, 719);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 526);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 133);
            this.panel3.TabIndex = 113;
            // 
            // buttonList
            // 
            this.buttonList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonList.Location = new System.Drawing.Point(0, 0);
            this.buttonList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(516, 61);
            this.buttonList.TabIndex = 110;
            this.buttonList.Text = "Списком";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // labelNullError
            // 
            this.labelNullError.AutoSize = true;
            this.labelNullError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNullError.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelNullError.Location = new System.Drawing.Point(61, 388);
            this.labelNullError.Name = "labelNullError";
            this.labelNullError.Size = new System.Drawing.Size(460, 32);
            this.labelNullError.TabIndex = 112;
            this.labelNullError.Text = "По вашему запросу ничего не найдено!";
            this.labelNullError.Visible = false;
            // 
            // buttonExport
            // 
            this.buttonExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExport.Location = new System.Drawing.Point(3, 659);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(516, 56);
            this.buttonExport.TabIndex = 111;
            this.buttonExport.Text = "Экспорт";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.ExportClick);
            // 
            // radioButtonWiFiFalse
            // 
            this.radioButtonWiFiFalse.AutoSize = true;
            this.radioButtonWiFiFalse.Enabled = false;
            this.radioButtonWiFiFalse.Location = new System.Drawing.Point(392, 276);
            this.radioButtonWiFiFalse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonWiFiFalse.Name = "radioButtonWiFiFalse";
            this.radioButtonWiFiFalse.Size = new System.Drawing.Size(59, 24);
            this.radioButtonWiFiFalse.TabIndex = 109;
            this.radioButtonWiFiFalse.Text = " Нет";
            this.radioButtonWiFiFalse.UseVisualStyleBackColor = true;
            this.radioButtonWiFiFalse.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // radioButtonWiFiTrue
            // 
            this.radioButtonWiFiTrue.AutoSize = true;
            this.radioButtonWiFiTrue.Checked = true;
            this.radioButtonWiFiTrue.Enabled = false;
            this.radioButtonWiFiTrue.Location = new System.Drawing.Point(234, 276);
            this.radioButtonWiFiTrue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonWiFiTrue.Name = "radioButtonWiFiTrue";
            this.radioButtonWiFiTrue.Size = new System.Drawing.Size(59, 24);
            this.radioButtonWiFiTrue.TabIndex = 108;
            this.radioButtonWiFiTrue.TabStop = true;
            this.radioButtonWiFiTrue.Text = "Есть";
            this.radioButtonWiFiTrue.UseVisualStyleBackColor = true;
            this.radioButtonWiFiTrue.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 107;
            this.label11.Text = "до";
            // 
            // textBoxTotalPriceTo
            // 
            this.textBoxTotalPriceTo.Enabled = false;
            this.textBoxTotalPriceTo.Location = new System.Drawing.Point(392, 235);
            this.textBoxTotalPriceTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTotalPriceTo.Name = "textBoxTotalPriceTo";
            this.textBoxTotalPriceTo.Size = new System.Drawing.Size(100, 27);
            this.textBoxTotalPriceTo.TabIndex = 106;
            this.textBoxTotalPriceTo.TextChanged += new System.EventHandler(this.MakeSortAndFilter);
            this.textBoxTotalPriceTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromTo_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 105;
            this.label12.Text = "от";
            // 
            // textBoxTotalPriceFrom
            // 
            this.textBoxTotalPriceFrom.Enabled = false;
            this.textBoxTotalPriceFrom.Location = new System.Drawing.Point(234, 235);
            this.textBoxTotalPriceFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTotalPriceFrom.Name = "textBoxTotalPriceFrom";
            this.textBoxTotalPriceFrom.Size = new System.Drawing.Size(106, 27);
            this.textBoxTotalPriceFrom.TabIndex = 104;
            this.textBoxTotalPriceFrom.TextChanged += new System.EventHandler(this.MakeSortAndFilter);
            this.textBoxTotalPriceFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromTo_KeyPress);
            // 
            // checkBoxWiFi
            // 
            this.checkBoxWiFi.AutoSize = true;
            this.checkBoxWiFi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxWiFi.Location = new System.Drawing.Point(25, 276);
            this.checkBoxWiFi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxWiFi.Name = "checkBoxWiFi";
            this.checkBoxWiFi.Size = new System.Drawing.Size(125, 24);
            this.checkBoxWiFi.TabIndex = 103;
            this.checkBoxWiFi.Text = "Наличие WiFi";
            this.checkBoxWiFi.UseVisualStyleBackColor = true;
            this.checkBoxWiFi.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // checkBoxTotalPrice
            // 
            this.checkBoxTotalPrice.AutoSize = true;
            this.checkBoxTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTotalPrice.Location = new System.Drawing.Point(25, 237);
            this.checkBoxTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxTotalPrice.Name = "checkBoxTotalPrice";
            this.checkBoxTotalPrice.Size = new System.Drawing.Size(155, 24);
            this.checkBoxTotalPrice.TabIndex = 102;
            this.checkBoxTotalPrice.Text = "Общая стоимость";
            this.checkBoxTotalPrice.UseVisualStyleBackColor = true;
            this.checkBoxTotalPrice.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "до";
            // 
            // textBoxSurchageTo
            // 
            this.textBoxSurchageTo.Enabled = false;
            this.textBoxSurchageTo.Location = new System.Drawing.Point(392, 196);
            this.textBoxSurchageTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSurchageTo.Name = "textBoxSurchageTo";
            this.textBoxSurchageTo.Size = new System.Drawing.Size(100, 27);
            this.textBoxSurchageTo.TabIndex = 100;
            this.textBoxSurchageTo.TextChanged += new System.EventHandler(this.MakeSortAndFilter);
            this.textBoxSurchageTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromTo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "от";
            // 
            // textBoxSurchageFrom
            // 
            this.textBoxSurchageFrom.Enabled = false;
            this.textBoxSurchageFrom.Location = new System.Drawing.Point(234, 196);
            this.textBoxSurchageFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSurchageFrom.Name = "textBoxSurchageFrom";
            this.textBoxSurchageFrom.Size = new System.Drawing.Size(106, 27);
            this.textBoxSurchageFrom.TabIndex = 98;
            this.textBoxSurchageFrom.TextChanged += new System.EventHandler(this.MakeSortAndFilter);
            this.textBoxSurchageFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromTo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "до";
            // 
            // textBoxAmountOfMansTo
            // 
            this.textBoxAmountOfMansTo.Enabled = false;
            this.textBoxAmountOfMansTo.Location = new System.Drawing.Point(392, 157);
            this.textBoxAmountOfMansTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAmountOfMansTo.Name = "textBoxAmountOfMansTo";
            this.textBoxAmountOfMansTo.Size = new System.Drawing.Size(100, 27);
            this.textBoxAmountOfMansTo.TabIndex = 96;
            this.textBoxAmountOfMansTo.TextChanged += new System.EventHandler(this.MakeSortAndFilter);
            this.textBoxAmountOfMansTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromTo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 95;
            this.label8.Text = "от";
            // 
            // textBoxAmountOfMansFrom
            // 
            this.textBoxAmountOfMansFrom.Enabled = false;
            this.textBoxAmountOfMansFrom.Location = new System.Drawing.Point(234, 157);
            this.textBoxAmountOfMansFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAmountOfMansFrom.Name = "textBoxAmountOfMansFrom";
            this.textBoxAmountOfMansFrom.Size = new System.Drawing.Size(106, 27);
            this.textBoxAmountOfMansFrom.TabIndex = 94;
            this.textBoxAmountOfMansFrom.TextChanged += new System.EventHandler(this.MakeSortAndFilter);
            this.textBoxAmountOfMansFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromTo_KeyPress);
            // 
            // checkBoxSurchage
            // 
            this.checkBoxSurchage.AutoSize = true;
            this.checkBoxSurchage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSurchage.Location = new System.Drawing.Point(25, 199);
            this.checkBoxSurchage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSurchage.Name = "checkBoxSurchage";
            this.checkBoxSurchage.Size = new System.Drawing.Size(131, 24);
            this.checkBoxSurchage.TabIndex = 93;
            this.checkBoxSurchage.Text = "Доплаты (руб)";
            this.checkBoxSurchage.UseVisualStyleBackColor = true;
            this.checkBoxSurchage.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // checkBoxAmountOfMan
            // 
            this.checkBoxAmountOfMan.AutoSize = true;
            this.checkBoxAmountOfMan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAmountOfMan.Location = new System.Drawing.Point(25, 160);
            this.checkBoxAmountOfMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxAmountOfMan.Name = "checkBoxAmountOfMan";
            this.checkBoxAmountOfMan.Size = new System.Drawing.Size(160, 24);
            this.checkBoxAmountOfMan.TabIndex = 92;
            this.checkBoxAmountOfMan.Text = "По кол-ву человек";
            this.checkBoxAmountOfMan.UseVisualStyleBackColor = true;
            this.checkBoxAmountOfMan.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "до";
            // 
            // textBoxPriceForManTo
            // 
            this.textBoxPriceForManTo.Enabled = false;
            this.textBoxPriceForManTo.Location = new System.Drawing.Point(392, 119);
            this.textBoxPriceForManTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPriceForManTo.Name = "textBoxPriceForManTo";
            this.textBoxPriceForManTo.Size = new System.Drawing.Size(100, 27);
            this.textBoxPriceForManTo.TabIndex = 90;
            this.textBoxPriceForManTo.TextChanged += new System.EventHandler(this.MakeSortAndFilter);
            this.textBoxPriceForManTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromTo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "от";
            // 
            // textBoxPriceForManFrom
            // 
            this.textBoxPriceForManFrom.Enabled = false;
            this.textBoxPriceForManFrom.Location = new System.Drawing.Point(234, 119);
            this.textBoxPriceForManFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPriceForManFrom.Name = "textBoxPriceForManFrom";
            this.textBoxPriceForManFrom.Size = new System.Drawing.Size(106, 27);
            this.textBoxPriceForManFrom.TabIndex = 88;
            this.textBoxPriceForManFrom.TextChanged += new System.EventHandler(this.MakeSortAndFilter);
            this.textBoxPriceForManFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromTo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "до";
            // 
            // textBoxNightsTo
            // 
            this.textBoxNightsTo.Enabled = false;
            this.textBoxNightsTo.Location = new System.Drawing.Point(392, 80);
            this.textBoxNightsTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNightsTo.Name = "textBoxNightsTo";
            this.textBoxNightsTo.Size = new System.Drawing.Size(100, 27);
            this.textBoxNightsTo.TabIndex = 86;
            this.textBoxNightsTo.TextChanged += new System.EventHandler(this.MakeSortAndFilter);
            this.textBoxNightsTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromTo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "от";
            // 
            // textBoxNightsFrom
            // 
            this.textBoxNightsFrom.Enabled = false;
            this.textBoxNightsFrom.Location = new System.Drawing.Point(234, 80);
            this.textBoxNightsFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNightsFrom.Name = "textBoxNightsFrom";
            this.textBoxNightsFrom.Size = new System.Drawing.Size(106, 27);
            this.textBoxNightsFrom.TabIndex = 84;
            this.textBoxNightsFrom.TextChanged += new System.EventHandler(this.MakeSortAndFilter);
            this.textBoxNightsFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromTo_KeyPress);
            // 
            // checkBoxPriceForMan
            // 
            this.checkBoxPriceForMan.AutoSize = true;
            this.checkBoxPriceForMan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPriceForMan.Location = new System.Drawing.Point(25, 121);
            this.checkBoxPriceForMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPriceForMan.Name = "checkBoxPriceForMan";
            this.checkBoxPriceForMan.Size = new System.Drawing.Size(178, 24);
            this.checkBoxPriceForMan.TabIndex = 83;
            this.checkBoxPriceForMan.Text = "По стоимости за чел.";
            this.checkBoxPriceForMan.UseVisualStyleBackColor = true;
            this.checkBoxPriceForMan.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // checkBoxAmountOfDays
            // 
            this.checkBoxAmountOfDays.AutoSize = true;
            this.checkBoxAmountOfDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAmountOfDays.Location = new System.Drawing.Point(25, 83);
            this.checkBoxAmountOfDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxAmountOfDays.Name = "checkBoxAmountOfDays";
            this.checkBoxAmountOfDays.Size = new System.Drawing.Size(147, 24);
            this.checkBoxAmountOfDays.TabIndex = 82;
            this.checkBoxAmountOfDays.Text = "По кол-ву ночей";
            this.checkBoxAmountOfDays.UseVisualStyleBackColor = true;
            this.checkBoxAmountOfDays.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // comboBoxDirectionFilter
            // 
            this.comboBoxDirectionFilter.Enabled = false;
            this.comboBoxDirectionFilter.FormattingEnabled = true;
            this.comboBoxDirectionFilter.Location = new System.Drawing.Point(206, 41);
            this.comboBoxDirectionFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDirectionFilter.Name = "comboBoxDirectionFilter";
            this.comboBoxDirectionFilter.Size = new System.Drawing.Size(286, 28);
            this.comboBoxDirectionFilter.TabIndex = 1;
            this.comboBoxDirectionFilter.SelectedIndexChanged += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // checkBoxDirection
            // 
            this.checkBoxDirection.AutoSize = true;
            this.checkBoxDirection.Location = new System.Drawing.Point(25, 44);
            this.checkBoxDirection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxDirection.Name = "checkBoxDirection";
            this.checkBoxDirection.Size = new System.Drawing.Size(152, 24);
            this.checkBoxDirection.TabIndex = 0;
            this.checkBoxDirection.Text = "По направлению";
            this.checkBoxDirection.UseVisualStyleBackColor = true;
            this.checkBoxDirection.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.radioButtonSortDown);
            this.groupBoxSort.Controls.Add(this.radioButtonSortUp);
            this.groupBoxSort.Controls.Add(this.comboBoxSort);
            this.groupBoxSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSort.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSort.Size = new System.Drawing.Size(522, 80);
            this.groupBoxSort.TabIndex = 5;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Сортировать по ";
            // 
            // radioButtonSortDown
            // 
            this.radioButtonSortDown.AutoSize = true;
            this.radioButtonSortDown.Location = new System.Drawing.Point(397, 31);
            this.radioButtonSortDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSortDown.Name = "radioButtonSortDown";
            this.radioButtonSortDown.Size = new System.Drawing.Size(127, 24);
            this.radioButtonSortDown.TabIndex = 2;
            this.radioButtonSortDown.Text = "По убыванию";
            this.radioButtonSortDown.UseVisualStyleBackColor = true;
            this.radioButtonSortDown.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // radioButtonSortUp
            // 
            this.radioButtonSortUp.AutoSize = true;
            this.radioButtonSortUp.Checked = true;
            this.radioButtonSortUp.Location = new System.Drawing.Point(257, 31);
            this.radioButtonSortUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSortUp.Name = "radioButtonSortUp";
            this.radioButtonSortUp.Size = new System.Drawing.Size(146, 24);
            this.radioButtonSortUp.TabIndex = 1;
            this.radioButtonSortUp.TabStop = true;
            this.radioButtonSortUp.Text = "По возрастанию";
            this.radioButtonSortUp.UseVisualStyleBackColor = true;
            this.radioButtonSortUp.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(7, 29);
            this.comboBoxSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(243, 28);
            this.comboBoxSort.TabIndex = 0;
            this.comboBoxSort.Click += new System.EventHandler(this.MakeSortAndFilter);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editToolStripMenuItem.Text = "Изменить";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changeAccountToolStripMenuItem
            // 
            this.changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            this.changeAccountToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.changeAccountToolStripMenuItem.Text = "Сменить аккаунт";
            this.changeAccountToolStripMenuItem.Click += new System.EventHandler(this.changeAccountToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.changeAccountToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1582, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.accountsToolStripMenuItem.Text = "Аккаунты";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
            // 
            // totalToolStripStatusLabel
            // 
            this.totalToolStripStatusLabel.Name = "totalToolStripStatusLabel";
            this.totalToolStripStatusLabel.Size = new System.Drawing.Size(98, 20);
            this.totalToolStripStatusLabel.Text = "Всего туров: ";
            // 
            // totalSumToolStripStatusLabel
            // 
            this.totalSumToolStripStatusLabel.Name = "totalSumToolStripStatusLabel";
            this.totalSumToolStripStatusLabel.Size = new System.Drawing.Size(112, 20);
            this.totalSumToolStripStatusLabel.Text = "Общая сумма: ";
            // 
            // surchargeCountToolStripStatusLabel
            // 
            this.surchargeCountToolStripStatusLabel.Name = "surchargeCountToolStripStatusLabel";
            this.surchargeCountToolStripStatusLabel.Size = new System.Drawing.Size(144, 20);
            this.surchargeCountToolStripStatusLabel.Text = "Туров с доплатами:";
            // 
            // surchargeSumToolStripStatusLabel
            // 
            this.surchargeSumToolStripStatusLabel.Name = "surchargeSumToolStripStatusLabel";
            this.surchargeSumToolStripStatusLabel.Size = new System.Drawing.Size(114, 20);
            this.surchargeSumToolStripStatusLabel.Text = "Сумма доплат: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripStatusLabel,
            this.totalSumToolStripStatusLabel,
            this.surchargeCountToolStripStatusLabel,
            this.surchargeSumToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 829);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1582, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toursDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 799);
            this.panel2.TabIndex = 6;
            // 
            // toursDataGridView
            // 
            this.toursDataGridView.AllowUserToAddRows = false;
            this.toursDataGridView.AllowUserToDeleteRows = false;
            this.toursDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toursDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirectionColumn,
            this.DateColumn,
            this.AmountOfDaysColumn,
            this.PriceForManColumn,
            this.AmountOfManColumn,
            this.WiFiColumn,
            this.SurchargeColumn,
            this.TotalColumn});
            this.toursDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toursDataGridView.Location = new System.Drawing.Point(0, 0);
            this.toursDataGridView.Name = "toursDataGridView";
            this.toursDataGridView.RowHeadersVisible = false;
            this.toursDataGridView.RowHeadersWidth = 51;
            this.toursDataGridView.RowTemplate.Height = 29;
            this.toursDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toursDataGridView.Size = new System.Drawing.Size(1060, 799);
            this.toursDataGridView.TabIndex = 3;
            this.toursDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.toursDataGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // DirectionColumn
            // 
            this.DirectionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DirectionColumn.DataPropertyName = "Direction";
            this.DirectionColumn.HeaderText = "Направление";
            this.DirectionColumn.MinimumWidth = 6;
            this.DirectionColumn.Name = "DirectionColumn";
            this.DirectionColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateColumn.DataPropertyName = "Date";
            this.DateColumn.HeaderText = "Дата вылета";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // AmountOfDaysColumn
            // 
            this.AmountOfDaysColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountOfDaysColumn.DataPropertyName = "AmountOfDays";
            this.AmountOfDaysColumn.HeaderText = "Количество ночей";
            this.AmountOfDaysColumn.MinimumWidth = 6;
            this.AmountOfDaysColumn.Name = "AmountOfDaysColumn";
            this.AmountOfDaysColumn.ReadOnly = true;
            // 
            // PriceForManColumn
            // 
            this.PriceForManColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceForManColumn.DataPropertyName = "PriceForMan";
            this.PriceForManColumn.HeaderText = "Стоимость за отдыхающего (руб)";
            this.PriceForManColumn.MinimumWidth = 6;
            this.PriceForManColumn.Name = "PriceForManColumn";
            this.PriceForManColumn.ReadOnly = true;
            // 
            // AmountOfManColumn
            // 
            this.AmountOfManColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountOfManColumn.DataPropertyName = "AmountOfMan";
            this.AmountOfManColumn.HeaderText = "Количество отдыхающих";
            this.AmountOfManColumn.MinimumWidth = 6;
            this.AmountOfManColumn.Name = "AmountOfManColumn";
            this.AmountOfManColumn.ReadOnly = true;
            // 
            // WiFiColumn
            // 
            this.WiFiColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WiFiColumn.DataPropertyName = "WiFi";
            this.WiFiColumn.HeaderText = "Наличие Wi-Fi";
            this.WiFiColumn.MinimumWidth = 6;
            this.WiFiColumn.Name = "WiFiColumn";
            this.WiFiColumn.ReadOnly = true;
            // 
            // SurchargeColumn
            // 
            this.SurchargeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurchargeColumn.DataPropertyName = "Surcharge";
            this.SurchargeColumn.HeaderText = "Доплаты (руб)";
            this.SurchargeColumn.MinimumWidth = 6;
            this.SurchargeColumn.Name = "SurchargeColumn";
            this.SurchargeColumn.ReadOnly = true;
            // 
            // TotalColumn
            // 
            this.TotalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalColumn.DataPropertyName = "TotalPrice";
            this.TotalColumn.HeaderText = "Общая стоимость";
            this.TotalColumn.MinimumWidth = 6;
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 855);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1597, 891);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Горячие туры | Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toursDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource tourBindingSource;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label labelNullError;
        private Button buttonExport;
        private Button buttonList;
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
        private ComboBox comboBoxDirectionFilter;
        private CheckBox checkBoxDirection;
        private GroupBox groupBoxSort;
        private RadioButton radioButtonSortDown;
        private RadioButton radioButtonSortUp;
        private ComboBox comboBoxSort;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem changeAccountToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripStatusLabel totalToolStripStatusLabel;
        private ToolStripStatusLabel totalSumToolStripStatusLabel;
        private ToolStripStatusLabel surchargeCountToolStripStatusLabel;
        private ToolStripStatusLabel surchargeSumToolStripStatusLabel;
        private StatusStrip statusStrip1;
        private Panel panel2;
        private DataGridView toursDataGridView;
        private DataGridViewTextBoxColumn DirectionColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn AmountOfDaysColumn;
        private DataGridViewTextBoxColumn PriceForManColumn;
        private DataGridViewTextBoxColumn AmountOfManColumn;
        private DataGridViewCheckBoxColumn WiFiColumn;
        private DataGridViewTextBoxColumn SurchargeColumn;
        private DataGridViewTextBoxColumn TotalColumn;
        private Panel panel3;
        private ToolStripMenuItem accountsToolStripMenuItem;
    }
}
