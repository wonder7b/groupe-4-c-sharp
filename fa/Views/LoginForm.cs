using System;
using System.Windows.Forms;
using fa.Services;

namespace fa.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var cashierName = nameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(cashierName))
            {
                MessageBox.Show("Veuillez saisir un nom pour le caissier.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SessionManager.CashierName = cashierName;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
