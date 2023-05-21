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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotTours.Forms
{
    public partial class ToursListForm : Form
    {
        private readonly List<Tour> tours;
        private readonly BindingSource bindingSourceTours;
        BindingNavigator bindingNavigator;
        public ToursListForm(bool isAdmin)
        {

            InitializeComponent();

            if (!isAdmin)
            {
                textBoxAmounOfMans.Enabled = false;
                textBoxTotalPrice.Enabled = false;
                textBoxSurchage.Enabled = false;
                textBoxNights.Enabled = false;
                textBoxPriceForMan.Enabled = false;
                comboBoxDirection.Enabled = false;
                radioButtonWiFiFalse.Enabled = false;
                radioButtonWiFiTrue.Enabled = false;
                dateTimePicker.Enabled = false;
            }


            comboBoxDirection.DataSource = Tour.Directions;

            using (ApplicationContext db = new ApplicationContext())
            {

                tours = db.Tours.ToList();
                bindingNavigator = new BindingNavigator(true);
                bindingSourceTours = new BindingSource();
                bindingSourceTours.DataSource = tours;
                bindingNavigator.BindingSource = bindingSourceTours;

                var saveButton = bindingNavigator.Items.Add("Save");


                MoveItem_Click(null, new EventArgs());
                saveButton.Click += Save_Click;
                bindingNavigator.PositionItem.TextChanged += MoveItem_Click;
                bindingNavigator.MoveNextItem.Click += MoveItem_Click;
                bindingNavigator.MoveFirstItem.Click += MoveItem_Click;
                bindingNavigator.MoveLastItem.Click += MoveItem_Click;
                bindingNavigator.MovePreviousItem.Click += MoveItem_Click;

                this.Controls.Add(bindingNavigator);
            }
        }

        private void Save_Click(object? sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (int.TryParse(bindingNavigator.PositionItem.Text, out var pos) &&
                pos <= tours.Count && pos >= 0)
                {
                    pos -= 1;
                    var tour = db.Tours.First(x => x.Guid == tours[pos].Guid);
                    if (tour != null)
                    {
                        if (uint.TryParse(textBoxNights.Text, out var nights))
                        {
                            tour.AmountOfDays = nights;
                        }
                        if (uint.TryParse(textBoxAmounOfMans.Text, out var amounOfMans))
                        {
                            tour.AmountOfMan = amounOfMans;
                        }
                        if (decimal.TryParse(textBoxPriceForMan.Text, out var priceForMan))
                        {
                            tour.PriceForMan = priceForMan;
                        }
                        if (decimal.TryParse(textBoxSurchage.Text, out var surcharge))
                        {
                            tour.Surcharge = surcharge;
                        }
                        if (decimal.TryParse(textBoxTotalPrice.Text, out var totalPrice))
                        {
                            tour.TotalPrice = totalPrice;
                        }
                        if (DateTime.TryParse(dateTimePicker.Value.ToString(), out var date))
                        {
                            tour.Date = date;
                        }
                        if (radioButtonWiFiTrue.Checked)
                        {
                            tour.WiFi = true;
                        }
                        else
                        {
                            tour.WiFi = false;
                        }
                        tour.Direction = comboBoxDirection.SelectedText;
                    }
                }

                db.SaveChanges();
            }
        }

        private void MoveItem_Click(object? sender, EventArgs e)
        {
            if (int.TryParse(bindingNavigator.PositionItem.Text, out var pos) &&
                pos <= tours.Count && pos >= 0)
            {
                pos -= 1;
                textBoxNights.Text = tours[pos].AmountOfDays.ToString();
                textBoxAmounOfMans.Text = tours[pos].AmountOfMan.ToString();
                textBoxPriceForMan.Text = tours[pos].PriceForMan.ToString();
                textBoxSurchage.Text = tours[pos].Surcharge.ToString();
                textBoxTotalPrice.Text = tours[pos].TotalPrice.ToString();
                if (tours[pos].WiFi)
                {
                    radioButtonWiFiTrue.Checked = true;
                }
                else
                {
                    radioButtonWiFiFalse.Checked = true;
                }
                dateTimePicker.Value = tours[pos].Date;
                comboBoxDirection.SelectedItem = tours[pos].Direction;

            }
        }
    }
}
