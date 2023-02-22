using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordAddAccount
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblAccountName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            var textboxes = new[] { txtEmail, txtAccountName, txtPassword };
            if (textboxes.Any(x => string.IsNullOrWhiteSpace(x.Text)) == true)
            {

                btnCreateAccount.Enabled = false;
            }
            else
            {
                btnCreateAccount.Enabled = true;
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void txtAccountName_TextChanged(object sender, EventArgs e)
        {
            var textboxes = new[] { txtEmail, txtAccountName, txtPassword };
            if (textboxes.Any(x => string.IsNullOrWhiteSpace(x.Text)) == true)
            {

                btnCreateAccount.Enabled = false;
            }
            else
            {
                btnCreateAccount.Enabled = true;
            }
        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            var textboxes = new[] { txtEmail, txtAccountName, txtPassword };
            if (textboxes.Any(x => string.IsNullOrWhiteSpace(x.Text)) == true)
            {

                btnCreateAccount.Enabled = false;
            }
            else
            {
                btnCreateAccount.Enabled = true;
            }
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (char)0x25cf;

            var textboxes = new[] { txtEmail, txtAccountName, txtPassword };
            if (textboxes.Any(x => string.IsNullOrWhiteSpace(x.Text)) == true)
            {

                btnCreateAccount.Enabled = false;
            }
            else
            {
                btnCreateAccount.Enabled = true;
            }
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPasteAccountName_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (txtAccountName.SelectionLength > 0)
                {
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        txtAccountName.SelectionStart = txtAccountName.SelectionStart + txtAccountName.SelectionLength;
                }
                txtAccountName.Paste();
            }
        }

        private void btnPasteEmail_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (txtEmail.SelectionLength > 0)
                {
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        txtEmail.SelectionStart = txtEmail.SelectionStart + txtEmail.SelectionLength;
                }
                txtEmail.Paste();
            }
        }

        private void btnPasteUsername_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (txtUsername.SelectionLength > 0)
                {
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        txtUsername.SelectionStart = txtUsername.SelectionStart + txtUsername.SelectionLength;
                }
                txtUsername.Paste();
            }
        }

        private void btnClearAccountName_Click_1(object sender, EventArgs e)
        {
            txtAccountName.Text = String.Empty;
        }

        private void btnClearEmail_Click_1(object sender, EventArgs e)
        {
            txtEmail.Text = String.Empty;

        }

        private void btnClearUsername_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = String.Empty;

        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == (char)0x25cf)
            {
                btnShow.BackgroundImage = Properties.Resources.Untitled__1_;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnShow.BackgroundImage = Properties.Resources.show_final;
                txtPassword.PasswordChar = (char)0x25cf;
            }
        }

        public string GenerateToken(int length)
        {
            using (RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider())
            {
                byte[] tokenBuffer = new byte[length];
                cryptRNG.GetBytes(tokenBuffer);
                return Convert.ToBase64String(tokenBuffer);
            }
        }

        private void btnPastePassword_Click_1(object sender, EventArgs e)
        {
            txtPassword.Text = GenerateToken(9);
            btnShow.BringToFront();
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            /*Accountmanager accountmanager = new Accountmanager();
            this.Hide();
            accountmanager.ShowDialog();*/
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            /*this.Hide();
            accountmanager.ShowDialog();*/
        }

        private void btnClearInfo_Click_1(object sender, EventArgs e)
        {
            txtInfo.Text = String.Empty;
        }

        private void btnPasteInfo_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (txtInfo.SelectionLength > 0)
                {
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        txtInfo.SelectionStart = txtInfo.SelectionStart + txtInfo.SelectionLength;
                }
                txtInfo.Paste();
            }
        }
    }
}
