using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplikasi_undangan
{
    public partial class Login : Form
    {
        c_login cl;
        Reminder r;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxNIP;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            cl = new c_login();
            if (cl.cekLogin(textBoxNIP.Text))
            {
                
                r = new Reminder();
                r.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("NIP yang anda inputkan tidak terdapat dalam database");
            }
        }

        private void textBoxNIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cl = new c_login();
                if (cl.cekLogin(textBoxNIP.Text))
                {
                    
                    r = new Reminder();
                    r.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("NIP yang anda inputkan tidak terdapat dalam database");
                }
            }
        }
    }
}
