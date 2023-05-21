namespace HotTours.Forms
{
    partial class ToursListForm
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
            comboBoxDirection = new ComboBox();
            label8 = new Label();
            textBoxTotalPrice = new TextBox();
            label7 = new Label();
            textBoxSurchage = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBoxAmounOfMans = new TextBox();
            label4 = new Label();
            textBoxPriceForMan = new TextBox();
            label3 = new Label();
            textBoxNights = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            radioButtonWiFiTrue = new RadioButton();
            radioButtonWiFiFalse = new RadioButton();
            SuspendLayout();
            // 
            // comboBoxDirection
            // 
            comboBoxDirection.FormattingEnabled = true;
            comboBoxDirection.Location = new Point(171, 99);
            comboBoxDirection.Name = "comboBoxDirection";
            comboBoxDirection.Size = new Size(183, 23);
            comboBoxDirection.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 305);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 33;
            label8.Text = "Общая стоимость";
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(171, 302);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(183, 23);
            textBoxTotalPrice.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 276);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 31;
            label7.Text = "Доплаты (руб.)";
            // 
            // textBoxSurchage
            // 
            textBoxSurchage.Location = new Point(171, 273);
            textBoxSurchage.Name = "textBoxSurchage";
            textBoxSurchage.Size = new Size(183, 23);
            textBoxSurchage.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 247);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 29;
            label6.Text = "Наличие Wi-Fi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 218);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 27;
            label5.Text = "Кол-во человек";
            // 
            // textBoxAmounOfMans
            // 
            textBoxAmounOfMans.Location = new Point(171, 215);
            textBoxAmounOfMans.Name = "textBoxAmounOfMans";
            textBoxAmounOfMans.Size = new Size(183, 23);
            textBoxAmounOfMans.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 189);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 25;
            label4.Text = "Стоимость за чел.";
            // 
            // textBoxPriceForMan
            // 
            textBoxPriceForMan.Location = new Point(171, 186);
            textBoxPriceForMan.Name = "textBoxPriceForMan";
            textBoxPriceForMan.Size = new Size(183, 23);
            textBoxPriceForMan.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 160);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 23;
            label3.Text = "Кол-во ночей";
            // 
            // textBoxNights
            // 
            textBoxNights.Location = new Point(171, 157);
            textBoxNights.Name = "textBoxNights";
            textBoxNights.Size = new Size(183, 23);
            textBoxNights.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 102);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 21;
            label2.Text = "Направление";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 131);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 19;
            label1.Text = "Дата вылета";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(171, 128);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(183, 23);
            dateTimePicker.TabIndex = 37;
            // 
            // radioButtonWiFiTrue
            // 
            radioButtonWiFiTrue.AutoSize = true;
            radioButtonWiFiTrue.Checked = true;
            radioButtonWiFiTrue.Location = new Point(192, 245);
            radioButtonWiFiTrue.Name = "radioButtonWiFiTrue";
            radioButtonWiFiTrue.Size = new Size(48, 19);
            radioButtonWiFiTrue.TabIndex = 38;
            radioButtonWiFiTrue.TabStop = true;
            radioButtonWiFiTrue.Text = "Есть";
            radioButtonWiFiTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonWiFiFalse
            // 
            radioButtonWiFiFalse.AutoSize = true;
            radioButtonWiFiFalse.Location = new Point(288, 245);
            radioButtonWiFiFalse.Name = "radioButtonWiFiFalse";
            radioButtonWiFiFalse.Size = new Size(45, 19);
            radioButtonWiFiFalse.TabIndex = 39;
            radioButtonWiFiFalse.Text = "Нет";
            radioButtonWiFiFalse.UseVisualStyleBackColor = true;
            // 
            // ToursListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 376);
            Controls.Add(radioButtonWiFiFalse);
            Controls.Add(radioButtonWiFiTrue);
            Controls.Add(dateTimePicker);
            Controls.Add(comboBoxDirection);
            Controls.Add(label8);
            Controls.Add(textBoxTotalPrice);
            Controls.Add(label7);
            Controls.Add(textBoxSurchage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxAmounOfMans);
            Controls.Add(label4);
            Controls.Add(textBoxPriceForMan);
            Controls.Add(label3);
            Controls.Add(textBoxNights);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ToursListForm";
            Text = "Горячие туры | Список туров";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDirection;
        private Label label8;
        private TextBox textBoxTotalPrice;
        private Label label7;
        private TextBox textBoxSurchage;
        private Label label6;
        private Label label5;
        private TextBox textBoxAmounOfMans;
        private Label label4;
        private TextBox textBoxPriceForMan;
        private Label label3;
        private TextBox textBoxNights;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private RadioButton radioButtonWiFiTrue;
        private RadioButton radioButtonWiFiFalse;
    }
}