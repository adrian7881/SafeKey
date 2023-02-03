using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PasswordAddAccount
{
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();

        }

        private void txtAccountName_GotFocus(object sender, EventArgs e)   
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
       

        private void BtnPasteAccountName_Click(object sender, EventArgs e)
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
        private void btnClearAccountName_Click(object sender, EventArgs e)
        {
            txtAccountName.Text = String.Empty;
        }

        private void btnPasteEmail_Click(object sender, EventArgs e)
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

        private void btnClearEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = String.Empty;
        }

        private void btnPasteUsername_Click(object sender, EventArgs e)
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

        private void btnClearUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = String.Empty;
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

        private void btnPastePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = GenerateToken(9);
            btnShow.BringToFront();
        }

        private void btnClearPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = String.Empty;
        }

        private void btnPasteInfo_Click(object sender, EventArgs e)
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

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            txtInfo.Text = String.Empty;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == (char)0x25cf) 
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = (char)0x25cf;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            /*Accountmanager accountmanager = new Accountmanager();
            this.Hide();
            accountmanager.ShowDialog();*/
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            accountmanager.ShowDialog();*/
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
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

        private void lblTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}