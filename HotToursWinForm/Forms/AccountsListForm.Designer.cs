namespace HotTours.Forms
{
    partial class AccountsListForm
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
            radioButtonFalse = new RadioButton();
            radioButtonTrue = new RadioButton();
            label6 = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // radioButtonFalse
            // 
            radioButtonFalse.AutoSize = true;
            radioButtonFalse.Location = new Point(293, 170);
            radioButtonFalse.Name = "radioButtonFalse";
            radioButtonFalse.Size = new Size(45, 19);
            radioButtonFalse.TabIndex = 56;
            radioButtonFalse.Text = "Нет";
            radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrue
            // 
            radioButtonTrue.AutoSize = true;
            radioButtonTrue.Checked = true;
            radioButtonTrue.Location = new Point(197, 170);
            radioButtonTrue.Name = "radioButtonTrue";
            radioButtonTrue.Size = new Size(48, 19);
            radioButtonTrue.TabIndex = 55;
            radioButtonTrue.TabStop = true;
            radioButtonTrue.Text = "Есть";
            radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 172);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 48;
            label6.Text = "Права администратора";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(176, 128);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(183, 23);
            textBoxPassword.TabIndex = 44;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(176, 88);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(183, 23);
            textBoxLogin.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 91);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 41;
            label2.Text = "Логин";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 131);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 40;
            label1.Text = "Пароль";
            // 
            // AccountsListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 279);
            Controls.Add(radioButtonFalse);
            Controls.Add(radioButtonTrue);
            Controls.Add(label6);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccountsListForm";
            Text = "Горячие туры | Список пользователей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonFalse;
        private RadioButton radioButtonTrue;
        private Label label6;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label label2;
        private Label label1;
    }
}