using Class_Library;
using System.Windows.Forms;

namespace Windows_Forms_App
{
    public partial class SelectAtmForm : Form
    {
        private readonly AppState _appState;

        public SelectAtmForm()
        {
            InitializeComponent();

            _appState = AppState.Instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atmDataGridView.DataSource = _appState.Atms;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void AtmDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow clickedRow = atmDataGridView.Rows[e.RowIndex];

            var atmId = clickedRow.Cells["Id"].Value.ToString();

            if (atmId == null)
            {
                MessageBox.Show("ATM not found");

                return;
            }

            var selectedAtm = _appState.Atms?.Find(atm => atm.Id == atmId);

            if (selectedAtm?.Balance == 0)
            {
                MessageBox.Show("ATM is empty");

                return;
            }

            _appState.SelectAtm(atmId);

            MessageBox.Show($"ATM #{atmId} selected");

            if (_appState.IsCardSelected())
            {
                var selectOptionForm = new SelectOptionForm();

                selectOptionForm.ShowDialog();

                return;
            }

            var credentialsForm = new EnterCredentialsForm();

            credentialsForm.ShowDialog();
        }

        private void RefreshDataGridView()
        {
            atmDataGridView.DataSource = null;
            atmDataGridView.DataSource = _appState.Atms;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
