
using Hot_Tours_BL;
using Hot_Tours_BL.Models;

namespace Hot_tours
{
    public partial class MainForm : Form
    {
        private readonly BindingSource bindingSource;
        public MainForm()
        {
            //List<Tour> tours = BusinessLogic.Read();
            InitializeComponent();

            toursDataGridView.AutoGenerateColumns = false;
            bindingSource = new BindingSource();
            bindingSource.DataSource = BusinessLogic.Read();
            toursDataGridView.DataSource = bindingSource;
            toursDataGridView.AllowUserToAddRows = false;
            CalculateStats();
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
                bindingSource.DataSource = BusinessLogic.Read();
                CalculateStats();
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
                bindingSource.DataSource = BusinessLogic.Read();
                CalculateStats();
                MessageBox.Show("Путёвка изменена!");
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (toursDataGridView.Columns[e.ColumnIndex].Name == "DirectionColumn" &&
                e.Value != null)
            {
                Direction val = (Direction)e.Value;
                switch (val)
                {
                    case Direction.Tunisia:
                        e.Value = "Тунис";
                        break;
                    case Direction.UAE:
                        e.Value = "ОАЭ";
                        break;
                    case Direction.Crimea:
                        e.Value = "Крым";
                        break;
                    case Direction.Turkey:
                        e.Value = "Турция";
                        break;
                    case Direction.Egypt:
                        e.Value = "Египет";
                        break;
                }
            }
            else if (toursDataGridView.Columns[e.ColumnIndex].Name == "DateColumn" &&
                e.RowIndex < BusinessLogic.Read().Count)
            {
                e.Value = BusinessLogic.Read()[e.RowIndex].Date.Date;
            }
            else if ((toursDataGridView.Columns[e.ColumnIndex].Name == "TotalColumn") &&
                e.RowIndex < BusinessLogic.Read().Count)
            {
                e.Value = BusinessLogic.Read()[e.RowIndex].PriceForMan *
                    BusinessLogic.Read()[e.RowIndex].AmountOfMan *
                    BusinessLogic.Read()[e.RowIndex].AmountOfDays;
            }
        }


        private void CalculateStats()
        {
            totalToolStripStatusLabel.Text = BusinessLogic.ToursAmount();
            totalSumToolStripStatusLabel.Text = BusinessLogic.TotalSum();
            surchargeCountToolStripStatusLabel.Text = BusinessLogic.SurchargeAmount();
            surchargeSumToolStripStatusLabel.Text = BusinessLogic.SurchargeSum();
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
                bindingSource.DataSource = BusinessLogic.Read();
                CalculateStats();
            }
        }
    }
}
