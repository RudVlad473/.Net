using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms_App.BaseForms;

namespace Windows_Forms_App.OptionForms
{
    public partial class TransactionForm : SingleNumericInputForm
    {
        public TransactionForm()
        {
            InitializeComponent();

            submitButton.Click += OnTransaction;
        }

        public void OnTransaction(object sender, EventArgs e)
        {
            var cardNumber = CardNumberTextBox.Text;
            var amount = numericUpDown.Value;

            try
            {
                _appState.Transaction(cardNumber, amount);

                MessageBox.Show(
                    $"You have successfully transferred {amount} to {cardNumber}. Your balance {_appState.SelectedAccount.Balance}"
                );
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                return;
            }
            finally
            {
                numericUpDown.Value = 0;
            }
        }
    }
}
