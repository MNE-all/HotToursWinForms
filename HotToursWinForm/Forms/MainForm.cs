using HotTours.Forms;
using HotTours.Models;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;

namespace HotTours
{
    //TODO Странный баг с отображением общей суммы (TotalPrice)
    public partial class MainForm : Form
    {
        private readonly BindingSource bindingSource;

        List<Tour> tours = BusinessLogic.Read();
        public MainForm(bool isAdmin)
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            bindingSource.DataSource = BusinessLogic.Read();

            if (!isAdmin)
            {
                правкаToolStripMenuItem.Visible = false;
                statusStrip1.Visible = false;
            }

            foreach (DataGridViewColumn column in toursDataGridView.Columns)
            {
                comboBoxSort.Items.Add(column.HeaderText);
            }
            comboBoxSort.SelectedItem = comboBoxSort.Items[0];

            toursDataGridView.AutoGenerateColumns = false;
            MakeSortAndFilter();
            Tour.Directions.ToList().ForEach(x =>
            {
                comboBoxDirectionFilter.Items.Add(x);
            });

            comboBoxDirectionFilter.SelectedItem = comboBoxDirectionFilter.Items[0];
            toursDataGridView.DataSource = bindingSource;
            CalculateStats();
        }
        private void MakeSortAndFilter(object sender, EventArgs e)
        {
            MakeSortAndFilter();
        }
        private void MakeSortAndFilter()
        {
            tours = BusinessLogic.Read();

            // Sort
            SortTours(ref tours);
            if (radioButtonSortDown.Checked)
            {
                tours.Reverse();
            }

            // Filter
            // Направление
            if (checkBoxDirection.Checked)
            {
                tours = tours.Where(x => x.Direction.ToString() == comboBoxDirectionFilter.SelectedItem.ToString()).ToList();
                comboBoxDirectionFilter.Enabled = true;
            }
            else
            {
                comboBoxDirectionFilter.Enabled = false;
            }
            // Кол-во дней
            if (checkBoxAmountOfDays.Checked)
            {
                TextBoxFromToFilter(textBoxNightsFrom, textBoxNightsTo);

                textBoxNightsFrom.Enabled = true;
                textBoxNightsTo.Enabled = true;
            }
            else
            {
                textBoxNightsFrom.Enabled = false;
                textBoxNightsTo.Enabled = false;
            }
            // Доплаты
            if (checkBoxSurchage.Checked)
            {
                TextBoxFromToFilter(textBoxSurchageFrom, textBoxSurchageTo);

                textBoxSurchageFrom.Enabled = true;
                textBoxSurchageTo.Enabled = true;
            }
            else
            {
                textBoxSurchageFrom.Enabled = false;
                textBoxSurchageTo.Enabled = false;
            }
            // Кол-во отдыхающих
            if (checkBoxAmountOfMan.Checked)
            {
                TextBoxFromToFilter(textBoxAmountOfMansFrom, textBoxAmountOfMansTo);

                textBoxAmountOfMansFrom.Enabled = true;
                textBoxAmountOfMansTo.Enabled = true;
            }
            else
            {
                textBoxAmountOfMansFrom.Enabled = false;
                textBoxAmountOfMansTo.Enabled = false;
            }
            // Цена за отдыхающего
            if (checkBoxPriceForMan.Checked)
            {
                TextBoxFromToFilter(textBoxPriceForManFrom, textBoxPriceForManTo);

                textBoxPriceForManFrom.Enabled = true;
                textBoxPriceForManTo.Enabled = true;
            }
            else
            {
                textBoxPriceForManFrom.Enabled = false;
                textBoxPriceForManTo.Enabled = false;
            }
            // Общая стоимость
            if (checkBoxTotalPrice.Checked)
            {
                TextBoxFromToFilter(textBoxTotalPriceFrom, textBoxTotalPriceTo);

                textBoxTotalPriceFrom.Enabled = true;
                textBoxTotalPriceTo.Enabled = true;
            }
            else
            {
                textBoxTotalPriceFrom.Enabled = false;
                textBoxTotalPriceTo.Enabled = false;
            }
            // Наличие WiFi
            if (checkBoxWiFi.Checked)
            {
                if (radioButtonWiFiTrue.Checked)
                {
                    tours = tours.Where(x => x.WiFi == true).ToList();
                }
                else
                {
                    tours = tours.Where(x => x.WiFi == false).ToList();
                }
                radioButtonWiFiTrue.Enabled = true;
                radioButtonWiFiFalse.Enabled = true;
            }
            else
            {
                radioButtonWiFiTrue.Enabled = false;
                radioButtonWiFiFalse.Enabled = false;
            }

            bindingSource.DataSource = tours;
            CalculateStats();
        }

        private void SortTours(ref List<Tour> tours)
        {
            switch (comboBoxSort.SelectedItem)
            {
                case "Направление":
                    tours = tours.OrderBy(x => x.Direction).ToList();
                    break;
                case "Дата вылета":
                    tours = tours.OrderBy(x => x.Date).ToList();
                    break;
                case "Общая стоимость":
                    tours = tours.OrderBy(x => x.TotalPrice).ToList();
                    break;
                case "Доплаты (руб)":
                    tours = tours.OrderBy(x => x.Surcharge).ToList();
                    break;
                case "Наличие Wi-Fi":
                    tours = tours.OrderBy(x => x.WiFi).ToList();
                    break;
                case "Количество отдыхающих":
                    tours = tours.OrderBy(x => x.AmountOfMan).ToList();
                    break;
                case "Стоимость за отдыхающего (руб)":
                    tours = tours.OrderBy(x => x.PriceForMan).ToList();
                    break;
                case "Количество ночей":
                    tours = tours.OrderBy(x => x.AmountOfDays).ToList();
                    break;
            }
        }

        // Фильтрация текстовых полей
        private void TextBoxFromToFilter(TextBox textFrom, TextBox textTo)
        {


            if (textFrom == textBoxSurchageFrom)
            {
                decimal.TryParse(textFrom.Text, out var value);
                decimal.TryParse(textTo.Text, out var value2);

                var SelectionStart = textFrom.SelectionStart;
                textFrom.Text = value.ToString("N");
                textFrom.SelectionStart = SelectionStart;

                SelectionStart = textTo.SelectionStart;
                textTo.Text = value2.ToString("N");
                textTo.SelectionStart = SelectionStart;

                if (value > value2)
                {
                    tours = tours.Where(x => x.Surcharge >= value).ToList();
                }
                else
                {
                    tours = tours.Where(x => x.Surcharge >= value && x.Surcharge <= value2).ToList();
                }
            }
            else if (textFrom == textBoxAmountOfMansFrom)
            {
                int.TryParse(String.Concat(textFrom.Text.Split(",")), out var value);
                int.TryParse(String.Concat(textTo.Text.Split(",")), out var value2);

                var SelectionStart = textFrom.SelectionStart;
                textFrom.Text = value.ToString("#,0", CultureInfo.InvariantCulture);
                textFrom.SelectionStart = SelectionStart;

                SelectionStart = textTo.SelectionStart;
                textTo.Text = value2.ToString("#,0", CultureInfo.InvariantCulture);
                textTo.SelectionStart = SelectionStart;

                if (value > value2)
                {
                    tours = tours.Where(x => x.AmountOfMan >= value).ToList();
                }
                else
                {
                    tours = tours.Where(x => x.AmountOfMan >= value && x.AmountOfMan <= value2).ToList();
                }
            }
            else if (textFrom == textBoxNightsFrom)
            {
                int.TryParse(String.Concat(textFrom.Text.Split(",")), out var value);
                int.TryParse(String.Concat(textTo.Text.Split(",")), out var value2);

                var SelectionStart = textFrom.SelectionStart;
                var x = value.ToString("#,0", CultureInfo.InvariantCulture);
                textFrom.Text = x;
                textFrom.SelectionStart = SelectionStart;

                SelectionStart = textTo.SelectionStart;
                textTo.Text = value2.ToString("#,0", CultureInfo.InvariantCulture);
                textTo.SelectionStart = SelectionStart;
                if (value > value2)
                {
                    tours = tours.Where(x => x.AmountOfDays >= value).ToList();
                }
                else
                {
                    tours = tours.Where(x => x.AmountOfDays >= value && x.AmountOfDays <= value2).ToList();
                }
            }
            else if (textFrom == textBoxPriceForManFrom)
            {
                decimal.TryParse(textFrom.Text, out var value);
                decimal.TryParse(textTo.Text, out var value2);

                var SelectionStart = textFrom.SelectionStart;
                textFrom.Text = value.ToString("N");
                textFrom.SelectionStart = SelectionStart;

                SelectionStart = textTo.SelectionStart;
                textTo.Text = value2.ToString("N");
                textTo.SelectionStart = SelectionStart;

                if (value > value2)
                {
                    tours = tours.Where(x => x.PriceForMan >= value).ToList();
                }
                else
                {
                    tours = tours.Where(x => x.PriceForMan >= value && x.PriceForMan <= value2).ToList();
                }
            }
            else if (textFrom == textBoxTotalPriceFrom)
            {
                decimal.TryParse(textFrom.Text, out var value);
                decimal.TryParse(textTo.Text, out var value2);

                var SelectionStart = textFrom.SelectionStart;
                textFrom.Text = value.ToString("N");
                textFrom.SelectionStart = SelectionStart;

                SelectionStart = textTo.SelectionStart;
                textTo.Text = value2.ToString("N");
                textTo.SelectionStart = SelectionStart;

                if (value > value2)
                {
                    tours = tours.Where(x => x.TotalPrice >= value).ToList();
                }
                else
                {
                    tours = tours.Where(x => x.TotalPrice >= value && x.TotalPrice <= value2).ToList();
                }
            }



        }

        private void textBoxFromTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoTourForm tourForm = new InfoTourForm();
            tourForm.Text = "Добавление тура";
            if (tourForm.ShowDialog(this) == DialogResult.OK)
            {
                BusinessLogic.AddTour(tourForm.Tour);
                MakeSortAndFilter();
                MessageBox.Show("Добавлена новая путёвка!");
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tour data = (Tour)toursDataGridView.Rows[toursDataGridView.SelectedRows[0].Index].DataBoundItem;
            InfoTourForm tourForm = new InfoTourForm(data);
            tourForm.Text = "Изменение тура";
            if (tourForm.ShowDialog(this) == DialogResult.OK)
            {
                // обращение к бл
                BusinessLogic.EditTour(tourForm.Tour,
                    data.Guid);
                MakeSortAndFilter();
                MessageBox.Show("Путёвка изменена!");
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (toursDataGridView.Columns[e.ColumnIndex].Name == "DirectionColumn" &&
            //    e.Value != null)
            //{
            //    Direction val = (Direction)e.Value;
            //    switch (val)
            //    {
            //        case Direction.Tunisia:
            //            e.Value = "Тунис";
            //            break;
            //        case Direction.UAE:
            //            e.Value = "ОАЭ";
            //            break;
            //        case Direction.Crimea:
            //            e.Value = "Крым";
            //            break;
            //        case Direction.Turkey:
            //            e.Value = "Турция";
            //            break;
            //        case Direction.Egypt:
            //            e.Value = "Египет";
            //            break;
            //    }
            //}
            //else
            if (toursDataGridView.Columns[e.ColumnIndex].Name == "DateColumn" &&
                e.RowIndex < tours.Count)
            {
                e.Value = tours[e.RowIndex].Date.Date;
            }
            else if ((toursDataGridView.Columns[e.ColumnIndex].Name == "TotalColumn") &&
                e.RowIndex < tours.Count)
            {
                e.Value = tours[e.RowIndex].PriceForMan *
                    tours[e.RowIndex].AmountOfMan *
                    tours[e.RowIndex].AmountOfDays
                    + tours[e.RowIndex].Surcharge;
            }
        }

        private void CalculateStats()
        {
            totalToolStripStatusLabel.Text = tours.Count.ToString();
            totalSumToolStripStatusLabel.Text = tours.Sum(x => x.TotalPrice).ToString();
            surchargeCountToolStripStatusLabel.Text = tours.Where(x => x.Surcharge > 0).ToList().Count.ToString();
            surchargeSumToolStripStatusLabel.Text = tours.Sum(x => x.Surcharge).ToString();

            bindingSource.ResetBindings(false);
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            editToolStripMenuItem.Enabled = deleteToolStripMenuItem.Enabled =
                BusinessLogic.Read().Count() > 0;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение об удалении!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // обращение к бл
                BusinessLogic.DeleteTour((Tour)toursDataGridView
                    .Rows[toursDataGridView.SelectedRows[0].Index].DataBoundItem);
                MakeSortAndFilter();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
