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
            }
            catch (Exception ex)
            {
                _appState.Notification.SendNotification(
                    new Class_Library.Message("Failure", ex.Message)
                );

                return;
            }
            finally
            {
                numericUpDown.Value = 0;
            }
        }
    }
}
