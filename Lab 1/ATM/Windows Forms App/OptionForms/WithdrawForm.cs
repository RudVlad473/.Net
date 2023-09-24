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
    public partial class WithdrawForm : SingleNumericInputForm
    {
        private readonly AppState _appState;

        public WithdrawForm()
        {
            InitializeComponent();

            _appState = AppState.Instance;

            submitButton.Click += OnWithdraw;
        }

        public void OnWithdraw(object sender, EventArgs e)
        {
            var withdrawAmount = numericUpDown.Value;

            if (withdrawAmount == 0)
            {
                MessageBox.Show("Please enter an amount");

                return;
            }

            try
            {
                _appState.Withdraw(withdrawAmount);

                MessageBox.Show(
                    $"You have successfully withdrawn {withdrawAmount} from your account. Your balance {_appState.SelectedAccount.Balance}"
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
