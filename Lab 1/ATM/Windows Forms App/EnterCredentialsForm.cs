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
using Windows_Forms_App.Classes;

namespace Windows_Forms_App
{
    public partial class EnterCredentialsForm : Form
    {
        private readonly AppState _appState;

        private readonly int _maxAttempts = 3;

        private int _attempts = 0;

        public EnterCredentialsForm()
        {
            InitializeComponent();

            _appState = AppState.Instance;
        }

        private void CardNumberTextBox_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void PinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!InputValidator.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool areCredentialsEmpty =
                string.IsNullOrEmpty(CardNumberTextBox.Text)
                || string.IsNullOrEmpty(PinTextBox.Text);

            if (areCredentialsEmpty)
            {
                MessageBox.Show("Please enter your card number and PIN");

                return;
            }

            if (!Credentials.ValidateCardNumber(CardNumberTextBox.Text))
            {
                MessageBox.Show("Invalid card number");

                return;
            }

            if (!Credentials.ValidatePin(PinTextBox.Text))
            {
                MessageBox.Show("Invalid PIN");

                return;
            }

            try
            {
                _appState.Authenticate(new Credentials(CardNumberTextBox.Text, PinTextBox.Text));
            }
            catch (Exception ex)
            {
                if (_attempts >= _maxAttempts)
                {
                    _appState.Notification.SendNotification(
                        new Class_Library.Message("Failure", "Too many attempts")
                    );

                    Application.Exit();
                }

                MessageBox.Show(ex.Message);

                _attempts++;

                return;
            }

            var selectOptionForm = new SelectOptionForm();
            selectOptionForm.ShowDialog();

            Close();
        }
    }
}
