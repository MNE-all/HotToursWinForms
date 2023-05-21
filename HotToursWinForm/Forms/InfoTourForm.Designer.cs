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
            panel1 = new Panel();
            totalTextBox = new TextBox();
            totalLabel = new Label();
            surchargeNumericUpDown = new NumericUpDown();
            surchargeLabel = new Label();
            wifiCheckBox = new CheckBox();
            wifiLabel = new Label();
            AmountOfManLabel = new Label();
            amountOfManNumericUpDown = new NumericUpDown();
            priceForManNumericUpDown = new NumericUpDown();
            priceForManLabel = new Label();
            amountOfDaysNumericUpDown = new NumericUpDown();
            amountOfDaysLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateLabel = new Label();
            directionLabel = new Label();
            directionComboBox = new ComboBox();
            panel2 = new Panel();
            cancelButton = new Button();
            acceptButton = new Button();
            ((System.ComponentModel.ISupportInitialize)surchargeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountOfManNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceForManNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountOfDaysNumericUpDown).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 64);
            panel1.TabIndex = 0;
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Location = new Point(281, 332);
            totalTextBox.Margin = new Padding(3, 2, 3, 2);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(132, 23);
            totalTextBox.TabIndex = 48;
            totalTextBox.Text = "0";
            totalTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(55, 334);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(110, 15);
            totalLabel.TabIndex = 47;
            totalLabel.Text = "Общая стоимость:";
            // 
            // surchargeNumericUpDown
            // 
            surchargeNumericUpDown.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            surchargeNumericUpDown.Location = new Point(281, 221);
            surchargeNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            surchargeNumericUpDown.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            surchargeNumericUpDown.Name = "surchargeNumericUpDown";
            surchargeNumericUpDown.Size = new Size(153, 23);
            surchargeNumericUpDown.TabIndex = 46;
            surchargeNumericUpDown.TextAlign = HorizontalAlignment.Center;
            surchargeNumericUpDown.ValueChanged += surchargeNumericUpDown_ValueChanged;
            surchargeNumericUpDown.KeyUp += surchargeNumericUpDown_KeyUp;
            // 
            // surchargeLabel
            // 
            surchargeLabel.AutoSize = true;
            surchargeLabel.Location = new Point(52, 223);
            surchargeLabel.Name = "surchargeLabel";
            surchargeLabel.Size = new Size(93, 15);
            surchargeLabel.TabIndex = 45;
            surchargeLabel.Text = "Доплаты (руб): ";
            // 
            // wifiCheckBox
            // 
            wifiCheckBox.AutoSize = true;
            wifiCheckBox.Location = new Point(150, 277);
            wifiCheckBox.Margin = new Padding(3, 2, 3, 2);
            wifiCheckBox.Name = "wifiCheckBox";
            wifiCheckBox.RightToLeft = RightToLeft.Yes;
            wifiCheckBox.Size = new Size(112, 19);
            wifiCheckBox.TabIndex = 44;
            wifiCheckBox.Text = ": Наличие Wi-Fi";
            wifiCheckBox.UseVisualStyleBackColor = true;
            wifiCheckBox.CheckedChanged += wifiCheckBox_CheckedChanged;
            // 
            // wifiLabel
            // 
            wifiLabel.AutoSize = true;
            wifiLabel.Location = new Point(67, 280);
            wifiLabel.Name = "wifiLabel";
            wifiLabel.Size = new Size(0, 15);
            wifiLabel.TabIndex = 43;
            // 
            // AmountOfManLabel
            // 
            AmountOfManLabel.AutoSize = true;
            AmountOfManLabel.Location = new Point(52, 198);
            AmountOfManLabel.Name = "AmountOfManLabel";
            AmountOfManLabel.Size = new Size(154, 15);
            AmountOfManLabel.TabIndex = 42;
            AmountOfManLabel.Text = "Количество отдыхающих: ";
            // 
            // amountOfManNumericUpDown
            // 
            amountOfManNumericUpDown.Location = new Point(282, 196);
            amountOfManNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            amountOfManNumericUpDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            amountOfManNumericUpDown.Name = "amountOfManNumericUpDown";
            amountOfManNumericUpDown.Size = new Size(153, 23);
            amountOfManNumericUpDown.TabIndex = 41;
            amountOfManNumericUpDown.TextAlign = HorizontalAlignment.Center;
            amountOfManNumericUpDown.ValueChanged += amountOfManNumericUpDown_ValueChanged;
            amountOfManNumericUpDown.KeyUp += amountOfManNumericUpDown_KeyUp;
            // 
            // priceForManNumericUpDown
            // 
            priceForManNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            priceForManNumericUpDown.Location = new Point(282, 172);
            priceForManNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            priceForManNumericUpDown.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            priceForManNumericUpDown.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            priceForManNumericUpDown.Name = "priceForManNumericUpDown";
            priceForManNumericUpDown.Size = new Size(153, 23);
            priceForManNumericUpDown.TabIndex = 40;
            priceForManNumericUpDown.TextAlign = HorizontalAlignment.Center;
            priceForManNumericUpDown.Value = new decimal(new int[] { 500, 0, 0, 0 });
            priceForManNumericUpDown.ValueChanged += priceForManNumericUpDown_ValueChanged;
            priceForManNumericUpDown.KeyUp += priceForManNumericUpDown_KeyUp;
            // 
            // priceForManLabel
            // 
            priceForManLabel.AutoSize = true;
            priceForManLabel.Location = new Point(52, 173);
            priceForManLabel.Name = "priceForManLabel";
            priceForManLabel.Size = new Size(202, 15);
            priceForManLabel.TabIndex = 39;
            priceForManLabel.Text = "Стоимость за отдыхающего (руб.): ";
            // 
            // amountOfDaysNumericUpDown
            // 
            amountOfDaysNumericUpDown.Location = new Point(282, 147);
            amountOfDaysNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            amountOfDaysNumericUpDown.Name = "amountOfDaysNumericUpDown";
            amountOfDaysNumericUpDown.Size = new Size(152, 23);
            amountOfDaysNumericUpDown.TabIndex = 38;
            amountOfDaysNumericUpDown.TextAlign = HorizontalAlignment.Center;
            amountOfDaysNumericUpDown.ValueChanged += amountOfDaysNumericUpDown_ValueChanged;
            amountOfDaysNumericUpDown.KeyUp += amountOfDaysNumericUpDown_KeyUp;
            // 
            // amountOfDaysLabel
            // 
            amountOfDaysLabel.AutoSize = true;
            amountOfDaysLabel.Location = new Point(52, 148);
            amountOfDaysLabel.Name = "amountOfDaysLabel";
            amountOfDaysLabel.Size = new Size(112, 15);
            amountOfDaysLabel.TabIndex = 37;
            amountOfDaysLabel.Text = "Количество ночей:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(281, 122);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 23);
            dateTimePicker1.TabIndex = 36;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(52, 126);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(77, 15);
            dateLabel.TabIndex = 35;
            dateLabel.Text = "Дата вылета:";
            // 
            // directionLabel
            // 
            directionLabel.AutoSize = true;
            directionLabel.Location = new Point(52, 99);
            directionLabel.Name = "directionLabel";
            directionLabel.Size = new Size(84, 15);
            directionLabel.TabIndex = 34;
            directionLabel.Text = "Направление:";
            // 
            // directionComboBox
            // 
            directionComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            directionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            directionComboBox.FormattingEnabled = true;
            directionComboBox.Location = new Point(281, 97);
            directionComboBox.Margin = new Padding(3, 2, 3, 2);
            directionComboBox.Name = "directionComboBox";
            directionComboBox.Size = new Size(154, 24);
            directionComboBox.TabIndex = 33;
            directionComboBox.DrawItem += directionComboBox_DrawItem;
            directionComboBox.SelectedIndexChanged += directionComboBox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(cancelButton);
            panel2.Controls.Add(acceptButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 368);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 76);
            panel2.TabIndex = 49;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(330, 31);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 22);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            acceptButton.DialogResult = DialogResult.OK;
            acceptButton.Enabled = false;
            acceptButton.Location = new Point(52, 31);
            acceptButton.Margin = new Padding(3, 2, 3, 2);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(82, 22);
            acceptButton.TabIndex = 0;
            acceptButton.Text = "Принять";
            acceptButton.UseVisualStyleBackColor = true;
            // 
            // InfoTourForm
            // 
            AcceptButton = acceptButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(463, 444);
            Controls.Add(panel2);
            Controls.Add(totalTextBox);
            Controls.Add(totalLabel);
            Controls.Add(surchargeNumericUpDown);
            Controls.Add(surchargeLabel);
            Controls.Add(wifiCheckBox);
            Controls.Add(wifiLabel);
            Controls.Add(AmountOfManLabel);
            Controls.Add(amountOfManNumericUpDown);
            Controls.Add(priceForManNumericUpDown);
            Controls.Add(priceForManLabel);
            Controls.Add(amountOfDaysNumericUpDown);
            Controls.Add(amountOfDaysLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateLabel);
            Controls.Add(directionLabel);
            Controls.Add(directionComboBox);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InfoTourForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InfoTourForm";
            ((System.ComponentModel.ISupportInitialize)surchargeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountOfManNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceForManNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountOfDaysNumericUpDown).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
