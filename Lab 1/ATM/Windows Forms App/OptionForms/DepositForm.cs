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
using Windows_Forms_App.BaseForms;

namespace Windows_Forms_App.OptionForms
{
    public partial class DepositForm : SingleNumericInputForm
    {
        public DepositForm()
        {
            InitializeComponent();

            submitButton.Click += OnDeposit;
        }

        public void OnDeposit(object sender, EventArgs e)
        {
            var depositAmount = numericUpDown.Value;

            if (depositAmount == 0)
            {
                MessageBox.Show("Please enter an amount");

                return;
            }

            try
            {
                _appState.Deposit(depositAmount);

                MessageBox.Show(
                    $"Operation completed successfully. Your balance is: {_appState.SelectedAccount.Balance}"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return;
            }
            finally
            {
                numericUpDown.Value = 0;
            }
        }
    }
}
