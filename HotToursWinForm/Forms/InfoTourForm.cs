using HotTours.Models;

namespace HotTours
{
    public partial class InfoTourForm : Form
    {
        private Tour tour;
        public Tour Tour => tour;
        public InfoTourForm()
        {
            InitializeComponent();
            FillDirection();

            dateTimePicker1.MinDate = DateTime.Now;

            tour = new Tour
            {
                Date = DateTime.Now,
                PriceForMan = 500,
                Direction = Tour.Directions.First()
            };
            directionComboBox.SelectedItem = tour.Direction;

        }

        public InfoTourForm(Tour t)
        {
            InitializeComponent();
            FillDirection();

            tour = new Tour()
            {
                Date = t.Date,
                Direction = t.Direction,
                AmountOfDays = t.AmountOfDays,
                AmountOfMan = t.AmountOfMan,
                Guid = t.Guid,
                PriceForMan = t.PriceForMan,
                Surcharge = t.Surcharge,
                WiFi = t.WiFi
            };
            dateTimePicker1.MinDate = DateTime.Now;
            directionComboBox.SelectedItem = tour.Direction;
            priceForManNumericUpDown.Value = tour.PriceForMan;
            amountOfManNumericUpDown.Value = tour.AmountOfMan;
            dateTimePicker1.Value = tour.Date;
            wifiCheckBox.Checked = tour.WiFi;
            amountOfDaysNumericUpDown.Value = tour.AmountOfDays;
            surchargeNumericUpDown.Value = tour.Surcharge;
            tour.AmountOfMan = t.AmountOfMan;
        }
        private void FillDirection()
        {
            foreach (var item in Tour.Directions)
            {
                directionComboBox.Items.Add(item);
            }
        }

        private void directionComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Direction direction)
                    {
                        var text = direction == Direction.Crimea
                            ? "Крым" :
                            direction == Direction.UAE ?
                            "ОАЭ" :
                            direction == Direction.Tunisia ?
                            "Тунис" :
                            direction == Direction.Turkey ?
                            "Турция" :
                            direction == Direction.Egypt ?
                            "Египет" : "Неизвестно";
                        e.Graphics.DrawString(text, parent.Font, brush, e.Bounds);

                    }
                    else
                    {
                        e.Graphics.DrawString(parent.Items[e.Index].ToString(),
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                }
            }
        }

        private void directionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (directionComboBox.SelectedIndex >= 0)
            {
                tour.Direction = directionComboBox.SelectedItem.ToString()!;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tour.Date = dateTimePicker1.Value;
        }
        private void wifiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tour.WiFi = wifiCheckBox.Checked;
        }

        private void TotalCalculate()
        {
            decimal totalPrice = amountOfDaysNumericUpDown.Value *
                amountOfManNumericUpDown.Value *
                priceForManNumericUpDown.Value +
                surchargeNumericUpDown.Value;
            tour.TotalPrice = totalPrice;
            totalTextBox.Text = totalPrice.ToString();
        }

        private new void Validate()
        {
            if (amountOfDaysNumericUpDown.Value != 0 &&
                amountOfManNumericUpDown.Value != 0 &&
                priceForManNumericUpDown.Value != 0)
            {
                acceptButton.Enabled = true;
            }
            else
            {
                acceptButton.Enabled = false;
            }
        }

        private void amountOfDaysNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            tour.AmountOfDays = (uint)amountOfDaysNumericUpDown.Value;
            Validate();
            TotalCalculate();
        }

        private void priceForManNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            tour.PriceForMan = priceForManNumericUpDown.Value;
            Validate();
            TotalCalculate();
        }

        private void amountOfManNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            tour.AmountOfMan = (uint)amountOfManNumericUpDown.Value;
            Validate();
            TotalCalculate();
        }

        private void surchargeNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            tour.Surcharge = surchargeNumericUpDown.Value;
            TotalCalculate();
        }

        private void amountOfDaysNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tour.AmountOfDays = (uint)amountOfDaysNumericUpDown.Value;
            Validate();
            TotalCalculate();
        }

        private void priceForManNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tour.PriceForMan = priceForManNumericUpDown.Value;
            Validate();
            TotalCalculate();
        }

        private void amountOfManNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tour.AmountOfMan = (uint)amountOfManNumericUpDown.Value;
            Validate();
            TotalCalculate();
        }

        private void surchargeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tour.Surcharge = surchargeNumericUpDown.Value;
            TotalCalculate();
        }
    }
}
