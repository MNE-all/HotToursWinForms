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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.totalToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalSumToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.surchargeCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.surchargeSumToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toursDataGridView = new System.Windows.Forms.DataGridView();
            this.DirectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfDaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceForManColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfManColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WiFiColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SurchargeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toursDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
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
            this.addToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.editToolStripMenuItem.Text = "Изменить";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripStatusLabel,
            this.totalSumToolStripStatusLabel,
            this.surchargeCountToolStripStatusLabel,
            this.surchargeSumToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1051, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
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
            // toursDataGridView
            // 
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
            this.toursDataGridView.Location = new System.Drawing.Point(0, 28);
            this.toursDataGridView.Name = "toursDataGridView";
            this.toursDataGridView.RowHeadersVisible = false;
            this.toursDataGridView.RowHeadersWidth = 51;
            this.toursDataGridView.RowTemplate.Height = 29;
            this.toursDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toursDataGridView.Size = new System.Drawing.Size(1051, 352);
            this.toursDataGridView.TabIndex = 2;
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
            this.DateColumn.HeaderText = "Дата вылета: ";
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
            this.TotalColumn.HeaderText = "Общая стоимость";
            this.TotalColumn.MinimumWidth = 6;
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 406);
            this.Controls.Add(this.toursDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Горячие туры | Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toursDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridViewTextBoxColumn DirectionColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn AmountOfDaysColumn;
        private DataGridViewTextBoxColumn PriceForManColumn;
        private DataGridViewTextBoxColumn AmountOfManColumn;
        private DataGridViewCheckBoxColumn WiFiColumn;
        private DataGridViewTextBoxColumn SurchargeColumn;
        private DataGridViewTextBoxColumn TotalColumn;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripStatusLabel totalSumToolStripStatusLabel;
        private ToolStripStatusLabel surchargeCountToolStripStatusLabel;
        private ToolStripStatusLabel surchargeSumToolStripStatusLabel;
    }
}
