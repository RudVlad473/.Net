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
using Windows_Forms_App.OptionForms;

namespace Windows_Forms_App
{
    public partial class SelectOptionForm : Form
    {
        private readonly AppState _appState;

        public SelectOptionForm()
        {
            InitializeComponent();

            _appState = AppState.Instance;

            if (_appState.SelectedAccount == null)
            {
                MessageBox.Show("Please select an account");

                Close();

                return;
            }
        }

        private void SelectOperationForm_Load(object sender, EventArgs e)
        {
            var operations = Enum.GetNames(typeof(OperationType))
                .Select(TextFormatter.SplitCamelCase)
                .ToArray();

            OptionComboBox.Items.AddRange(operations);
        }

        private void OperationComboBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private OperationType? GetSelectedOption()
        {
            var selectedOperation = TextFormatter.UnsplitCamelCase(
                OptionComboBox.SelectedItem.ToString() ?? null
            );

            if (selectedOperation == null)
            {
                return null;
            }

            OperationType operation = (OperationType)
                Enum.Parse(typeof(OperationType), selectedOperation);

            return operation;
        }

        private void OperationComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var operation = GetSelectedOption();

            if (operation == null)
            {
                MessageBox.Show("Please select an option");

                return;
            }

            switch (operation)
            {
                case OperationType.Balance:
                    MessageBox.Show($"Your balance is {_appState.SelectedAccount.Balance}");

                    break;
                case OperationType.Withdraw:
                    var withdrawForm = new WithdrawForm();

                    withdrawForm.ShowDialog();

                    break;
                case OperationType.Deposit:
                    var depositForm = new DepositForm();

                    depositForm.ShowDialog();

                    break;
                case OperationType.Transaction:
                    var transferForm = new TransactionForm();

                    transferForm.ShowDialog();

                    break;
                case OperationType.NearestAtms:
                    var nearestAtmsForm = new NearestAtmsForm();

                    nearestAtmsForm.ShowDialog();

                    break;
                case OperationType.OperationsHistory:
                    var operationsHistoryForm = new OperationHistoryForm();

                    operationsHistoryForm.ShowDialog();

                    break;
                default:
                    MessageBox.Show("Invalid operation");

                    break;
            }
        }
    }
}
