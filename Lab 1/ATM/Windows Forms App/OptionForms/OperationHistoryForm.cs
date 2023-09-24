using Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_App.OptionForms
{
    public partial class OperationHistoryForm : Form
    {
        private readonly AppState _appState;

        public OperationHistoryForm()
        {
            InitializeComponent();

            _appState = AppState.Instance;
        }

        public void InitializeOperationHistory()
        {
            var operationHistory = _appState?.Operations;

            if (operationHistory == null)
            {
                MessageBox.Show("Please select an account");

                Close();

                return;
            }

            operationsHistoryDataGridView.DataSource = operationHistory;
        }

        private void OperationHistoryForm_Load(object sender, EventArgs e)
        {
            InitializeOperationHistory();
        }

        private void SubmitButton_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeOperationHistory();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var filteredOperations = _appState?.Operations
                .Where(operation => operation.Timestamp.Date == DateTime.Today.Date)
                .ToList();

            operationsHistoryDataGridView.DataSource = filteredOperations;
        }

        private void weekButton_Click(object sender, EventArgs e)
        {
            var filteredOperations = _appState?.Operations
                .Where(operation => operation.Timestamp.Date >= DateTime.Today.AddDays(-7).Date)
                .ToList();

            operationsHistoryDataGridView.DataSource = filteredOperations;
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            var filteredOperations = _appState?.Operations
                .Where(operation => operation.Timestamp.Date >= DateTime.Today.AddMonths(-1).Date)
                .ToList();

            operationsHistoryDataGridView.DataSource = filteredOperations;
        }
    }
}
