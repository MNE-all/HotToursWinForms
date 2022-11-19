namespace HotTours
{
    partial class InfoTourForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.surchargeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.surchargeLabel = new System.Windows.Forms.Label();
            this.wifiCheckBox = new System.Windows.Forms.CheckBox();
            this.wifiLabel = new System.Windows.Forms.Label();
            this.AmountOfManLabel = new System.Windows.Forms.Label();
            this.amountOfManNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceForManNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceForManLabel = new System.Windows.Forms.Label();
            this.amountOfDaysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountOfDaysLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.directionComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.surchargeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfManNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceForManNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfDaysNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 64);
            this.panel1.TabIndex = 0;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(281, 332);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(132, 23);
            this.totalTextBox.TabIndex = 48;
            this.totalTextBox.Text = "0";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(55, 334);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(110, 15);
            this.totalLabel.TabIndex = 47;
            this.totalLabel.Text = "Общая стоимость:";
            // 
            // surchargeNumericUpDown
            // 
            this.surchargeNumericUpDown.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.surchargeNumericUpDown.Location = new System.Drawing.Point(281, 221);
            this.surchargeNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surchargeNumericUpDown.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.surchargeNumericUpDown.Name = "surchargeNumericUpDown";
            this.surchargeNumericUpDown.Size = new System.Drawing.Size(153, 23);
            this.surchargeNumericUpDown.TabIndex = 46;
            this.surchargeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surchargeNumericUpDown.ValueChanged += new System.EventHandler(this.surchargeNumericUpDown_ValueChanged);
            this.surchargeNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.surchargeNumericUpDown_KeyUp);
            // 
            // surchargeLabel
            // 
            this.surchargeLabel.AutoSize = true;
            this.surchargeLabel.Location = new System.Drawing.Point(52, 223);
            this.surchargeLabel.Name = "surchargeLabel";
            this.surchargeLabel.Size = new System.Drawing.Size(93, 15);
            this.surchargeLabel.TabIndex = 45;
            this.surchargeLabel.Text = "Доплаты (руб): ";
            // 
            // wifiCheckBox
            // 
            this.wifiCheckBox.AutoSize = true;
            this.wifiCheckBox.Location = new System.Drawing.Point(150, 277);
            this.wifiCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wifiCheckBox.Name = "wifiCheckBox";
            this.wifiCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wifiCheckBox.Size = new System.Drawing.Size(112, 19);
            this.wifiCheckBox.TabIndex = 44;
            this.wifiCheckBox.Text = ": Наличие Wi-Fi";
            this.wifiCheckBox.UseVisualStyleBackColor = true;
            this.wifiCheckBox.CheckedChanged += new System.EventHandler(this.wifiCheckBox_CheckedChanged);
            // 
            // wifiLabel
            // 
            this.wifiLabel.AutoSize = true;
            this.wifiLabel.Location = new System.Drawing.Point(67, 280);
            this.wifiLabel.Name = "wifiLabel";
            this.wifiLabel.Size = new System.Drawing.Size(0, 15);
            this.wifiLabel.TabIndex = 43;
            // 
            // AmountOfManLabel
            // 
            this.AmountOfManLabel.AutoSize = true;
            this.AmountOfManLabel.Location = new System.Drawing.Point(52, 198);
            this.AmountOfManLabel.Name = "AmountOfManLabel";
            this.AmountOfManLabel.Size = new System.Drawing.Size(154, 15);
            this.AmountOfManLabel.TabIndex = 42;
            this.AmountOfManLabel.Text = "Количество отдыхающих: ";
            // 
            // amountOfManNumericUpDown
            // 
            this.amountOfManNumericUpDown.Location = new System.Drawing.Point(282, 196);
            this.amountOfManNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountOfManNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.amountOfManNumericUpDown.Name = "amountOfManNumericUpDown";
            this.amountOfManNumericUpDown.Size = new System.Drawing.Size(153, 23);
            this.amountOfManNumericUpDown.TabIndex = 41;
            this.amountOfManNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountOfManNumericUpDown.ValueChanged += new System.EventHandler(this.amountOfManNumericUpDown_ValueChanged);
            this.amountOfManNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.amountOfManNumericUpDown_KeyUp);
            // 
            // priceForManNumericUpDown
            // 
            this.priceForManNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.priceForManNumericUpDown.Location = new System.Drawing.Point(282, 172);
            this.priceForManNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceForManNumericUpDown.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.priceForManNumericUpDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceForManNumericUpDown.Name = "priceForManNumericUpDown";
            this.priceForManNumericUpDown.Size = new System.Drawing.Size(153, 23);
            this.priceForManNumericUpDown.TabIndex = 40;
            this.priceForManNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceForManNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceForManNumericUpDown.ValueChanged += new System.EventHandler(this.priceForManNumericUpDown_ValueChanged);
            this.priceForManNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.priceForManNumericUpDown_KeyUp);
            // 
            // priceForManLabel
            // 
            this.priceForManLabel.AutoSize = true;
            this.priceForManLabel.Location = new System.Drawing.Point(52, 173);
            this.priceForManLabel.Name = "priceForManLabel";
            this.priceForManLabel.Size = new System.Drawing.Size(202, 15);
            this.priceForManLabel.TabIndex = 39;
            this.priceForManLabel.Text = "Стоимость за отдыхающего (руб.): ";
            // 
            // amountOfDaysNumericUpDown
            // 
            this.amountOfDaysNumericUpDown.Location = new System.Drawing.Point(282, 147);
            this.amountOfDaysNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountOfDaysNumericUpDown.Name = "amountOfDaysNumericUpDown";
            this.amountOfDaysNumericUpDown.Size = new System.Drawing.Size(152, 23);
            this.amountOfDaysNumericUpDown.TabIndex = 38;
            this.amountOfDaysNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountOfDaysNumericUpDown.ValueChanged += new System.EventHandler(this.amountOfDaysNumericUpDown_ValueChanged);
            this.amountOfDaysNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.amountOfDaysNumericUpDown_KeyUp);
            // 
            // amountOfDaysLabel
            // 
            this.amountOfDaysLabel.AutoSize = true;
            this.amountOfDaysLabel.Location = new System.Drawing.Point(52, 148);
            this.amountOfDaysLabel.Name = "amountOfDaysLabel";
            this.amountOfDaysLabel.Size = new System.Drawing.Size(112, 15);
            this.amountOfDaysLabel.TabIndex = 37;
            this.amountOfDaysLabel.Text = "Количество ночей:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(281, 122);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 23);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(52, 126);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(77, 15);
            this.dateLabel.TabIndex = 35;
            this.dateLabel.Text = "Дата вылета:";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(52, 99);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(84, 15);
            this.directionLabel.TabIndex = 34;
            this.directionLabel.Text = "Направление:";
            // 
            // directionComboBox
            // 
            this.directionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.directionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directionComboBox.FormattingEnabled = true;
            this.directionComboBox.Location = new System.Drawing.Point(281, 97);
            this.directionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.directionComboBox.Name = "directionComboBox";
            this.directionComboBox.Size = new System.Drawing.Size(154, 24);
            this.directionComboBox.TabIndex = 33;
            this.directionComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.directionComboBox_DrawItem);
            this.directionComboBox.SelectedIndexChanged += new System.EventHandler(this.directionComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.acceptButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 76);
            this.panel2.TabIndex = 49;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(330, 31);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 22);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(52, 31);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(82, 22);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // InfoTourForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(463, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.surchargeNumericUpDown);
            this.Controls.Add(this.surchargeLabel);
            this.Controls.Add(this.wifiCheckBox);
            this.Controls.Add(this.wifiLabel);
            this.Controls.Add(this.AmountOfManLabel);
            this.Controls.Add(this.amountOfManNumericUpDown);
            this.Controls.Add(this.priceForManNumericUpDown);
            this.Controls.Add(this.priceForManLabel);
            this.Controls.Add(this.amountOfDaysNumericUpDown);
            this.Controls.Add(this.amountOfDaysLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.directionComboBox);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InfoTourForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InfoTourForm";
            ((System.ComponentModel.ISupportInitialize)(this.surchargeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfManNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceForManNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfDaysNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox totalTextBox;
        private Label totalLabel;
        private NumericUpDown surchargeNumericUpDown;
        private Label surchargeLabel;
        private CheckBox wifiCheckBox;
        private Label wifiLabel;
        private Label AmountOfManLabel;
        private NumericUpDown amountOfManNumericUpDown;
        private NumericUpDown priceForManNumericUpDown;
        private Label priceForManLabel;
        private NumericUpDown amountOfDaysNumericUpDown;
        private Label amountOfDaysLabel;
        private DateTimePicker dateTimePicker1;
        private Label dateLabel;
        private Label directionLabel;
        private ComboBox directionComboBox;
        private Panel panel2;
        private Button cancelButton;
        private Button acceptButton;
    }
}
