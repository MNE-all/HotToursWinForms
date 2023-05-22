using HotTours.Forms;
using HotTours.Models;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace HotTours
{
    public partial class MainForm : Form
    {
        private readonly BindingSource bindingSource;

        List<Tour> tours = BusinessLogic.Read();
        bool isAdmin = true;
        public MainForm(bool _isAdmin)
        {
            InitializeComponent();
            bindingSource = new BindingSource();

            if (!_isAdmin)
            {
                ������ToolStripMenuItem.Visible = false;
                statusStrip1.Visible = false;
                isAdmin = false;
                accountsToolStripMenuItem.Visible = false;
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
            // �����������
            if (checkBoxDirection.Checked)
            {
                tours = tours.Where(x => x.Direction.ToString() == comboBoxDirectionFilter.SelectedItem.ToString()).ToList();
                comboBoxDirectionFilter.Enabled = true;
            }
            else
            {
                comboBoxDirectionFilter.Enabled = false;
            }
            // ���-�� ����
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
            // �������
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
            // ���-�� ����������
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
            // ���� �� �����������
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
            // ����� ���������
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
            // ������� WiFi
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

            if (tours.Count == 0)
            {
                labelNullError.Visible = true;
                buttonExport.Enabled = false;
            }
            else
            {
                labelNullError.Visible = false;
                buttonExport.Enabled = true;
            }

            bindingSource.DataSource = tours;
            CalculateStats();
        }
        private void AboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("������� ��������: ������� ������� �������� ��-20-3", "������������� ���������",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportClick(object sender, EventArgs e)
        {
            var ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //�����.^
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //�������.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Columns.ColumnWidth = 24;
            ExcelApp.Cells[1, 1] = "�����������";
            ExcelApp.Cells[1, 2] = "���� ������";
            ExcelApp.Cells[1, 3] = "���������� �����";
            ExcelApp.Cells[1, 4] = "��������� �� ����������� (���.)";
            ExcelApp.Cells[1, 5] = "���������� ����������";
            ExcelApp.Cells[1, 6] = "������� Wi-Fi";
            ExcelApp.Cells[1, 7] = "������� (���.)";
            ExcelApp.Cells[1, 8] = "����� ���������";
            for (int i = 0; i < toursDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < toursDataGridView.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = toursDataGridView.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void SortTours(ref List<Tour> tours)
        {
            switch (comboBoxSort.SelectedItem)
            {
                case "�����������":
                    tours = tours.OrderBy(x => x.Direction).ToList();
                    break;
                case "���� ������":
                    tours = tours.OrderBy(x => x.Date).ToList();
                    break;
                case "����� ���������":
                    tours = tours.OrderBy(x => x.TotalPrice).ToList();
                    break;
                case "������� (���)":
                    tours = tours.OrderBy(x => x.Surcharge).ToList();
                    break;
                case "������� Wi-Fi":
                    tours = tours.OrderBy(x => x.WiFi).ToList();
                    break;
                case "���������� ����������":
                    tours = tours.OrderBy(x => x.AmountOfMan).ToList();
                    break;
                case "��������� �� ����������� (���)":
                    tours = tours.OrderBy(x => x.PriceForMan).ToList();
                    break;
                case "���������� �����":
                    tours = tours.OrderBy(x => x.AmountOfDays).ToList();
                    break;
            }
        }

        // ���������� ��������� �����
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
            tourForm.Text = "���������� ����";
            if (tourForm.ShowDialog(this) == DialogResult.OK)
            {
                BusinessLogic.AddTour(tourForm.Tour);
                MakeSortAndFilter();
                MessageBox.Show("��������� ����� ������!");
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tour data = (Tour)toursDataGridView.Rows[toursDataGridView.SelectedRows[0].Index].DataBoundItem;
            InfoTourForm tourForm = new InfoTourForm(data);
            tourForm.Text = "��������� ����";
            if (tourForm.ShowDialog(this) == DialogResult.OK)
            {
                // ��������� � ��
                BusinessLogic.EditTour(tourForm.Tour,
                    data.Guid);
                MakeSortAndFilter();
                MessageBox.Show("������ ��������!");
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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
            totalToolStripStatusLabel.Text = "����� �����: " + tours.Count.ToString();
            totalSumToolStripStatusLabel.Text = "����� �����: " + tours.Sum(x => x.TotalPrice).ToString();
            surchargeCountToolStripStatusLabel.Text = "����� � ���������: " + tours.Where(x => x.Surcharge > 0).ToList().Count.ToString();
            surchargeSumToolStripStatusLabel.Text = "����� ������: " + tours.Sum(x => x.Surcharge).ToString();

            bindingSource.ResetBindings(false);
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            editToolStripMenuItem.Enabled = deleteToolStripMenuItem.Enabled =
                BusinessLogic.Read().Count() > 0;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�� �������?", "�������������� �� ��������!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in toursDataGridView.SelectedRows)
                {
                    BusinessLogic.DeleteTour((Tour)toursDataGridView
                    .Rows[row.Index].DataBoundItem);
                }
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

        private void buttonList_Click(object sender, EventArgs e)
        {
            ToursListForm toursListForm = new ToursListForm(isAdmin);
            toursListForm.ShowDialog();
            MakeSortAndFilter();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsListForm accountsListForm = new AccountsListForm();
            accountsListForm.ShowDialog();
        }

        private void toursDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var x = toursDataGridView.SelectedRows[0];
            if (x != null)
            {
                Tour data = toursDataGridView.Rows[x.Index].DataBoundItem as Tour;
                if (data != null && data.Date < DateTime.Now)
                {
                    editToolStripMenuItem.Enabled = false;
                }
            }


        }

        private void �������������100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessLogic.GenerateTours();
            MakeSortAndFilter();
        }
    }
}
