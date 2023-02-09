using System;
using System.Collections;
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
    public partial class SafeKeyMain2 : Form
    {
        public SafeKeyMain2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 accountmanager = new Form2();
            accountmanager.ShowDialog();

            SafeKeyMain2 form = (SafeKeyMain2)sender;
            form.ShowInTaskbar = false;
            form.Opacity = 0;
        }

        private void SafeKeyMain2_Load_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(string.Format("{0} | {1} | {2} | {3}", MyGlobals.txtAccountVar, MyGlobals.txtEmailVar, MyGlobals.txtPassowrdVar, MyGlobals.txtUsernameVar));
        }
    }
}
