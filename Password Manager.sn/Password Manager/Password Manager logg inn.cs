
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Logg_inn : Form
    {
        public Logg_inn()
        {
            InitializeComponent();

            
        }

        private void Logg_inn_Load(object sender, EventArgs e)
        {
            
        }


        private void txtPassord_inn_logg_TextChanged(object sender, EventArgs e)
        {
            txtPassord_inn_logg.PasswordChar = (char)0x2022;
        }

        private void lblEnter_password_Click(object sender, EventArgs e)
        {

        }

        private void btnLogginn_Click(object sender, EventArgs e)
        {
            SafeKeyMain2 accountmanager = new SafeKeyMain2();
            ///this.Hide();
            accountmanager.ShowDialog();
            

        }
    }
}
