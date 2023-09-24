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
        public WithdrawForm()
        {
            InitializeComponent();

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
