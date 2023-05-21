using HotTours.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotTours.Forms
{
    public partial class AccountsListForm : Form
    {
        private List<User> users;
        private readonly BindingSource bindingSourceUsers;
        BindingNavigator bindingNavigator;
        public AccountsListForm()
        {
            InitializeComponent();

            using (ApplicationContext db = new ApplicationContext())
            {

                users = db.Users.ToList();
                bindingNavigator = new BindingNavigator(true);
                bindingSourceUsers = new BindingSource();
                bindingSourceUsers.DataSource = users;
                bindingNavigator.BindingSource = bindingSourceUsers;

                var saveButton = bindingNavigator.Items.Add("Save");


                MoveItem_Click(null, new EventArgs());
                // saveButton.Click += Save_Click;
                bindingNavigator.PositionItem.TextChanged += MoveItem_Click;
                bindingNavigator.MoveNextItem.Click += MoveItem_Click;
                bindingNavigator.MoveFirstItem.Click += MoveItem_Click;
                bindingNavigator.MoveLastItem.Click += MoveItem_Click;
                bindingNavigator.MovePreviousItem.Click += MoveItem_Click;

                this.Controls.Add(bindingNavigator);
            }
        }

        private void MoveItem_Click(object? value, EventArgs eventArgs)
        {
            if (int.TryParse(bindingNavigator.PositionItem.Text, out var pos) &&
                pos <= users.Count && pos >= 0)
            {
                pos -= 1;
                textBoxLogin.Text = users[pos].Login.ToString();
                textBoxPassword.Text = users[pos].Password.ToString();
                if (users[pos].IsAdmin)
                {
                    radioButtonTrue.Checked = true;
                }
                else
                {
                    radioButtonFalse.Checked = true;
                }

            }
        }
    }
}
