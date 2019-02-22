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
    public partial class ReminderBidang : Form
    {
        c_reminderbidang crb;
        c_pejabat cp;
        public ReminderBidang()
        {
            InitializeComponent();
        }

        private void ReminderBidang_Load(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            cp = new c_pejabat();
            cp.tampilJabatan(comboBoxBidang);
            crb = new c_reminderbidang();
            crb.tampilUndanganparload(dataGridView1);
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string plh = "";

            if (comboBoxBidang.Text != "")
            {
                crb = new c_reminderbidang();

                if (radioButton1.Checked)
                {
                    plh = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    plh = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    plh = radioButton3.Text;
                }
                else
                {
                    plh = radioButton4.Text;
                }

                switch (plh)
                {
                    case "hari ini": crb.tampilUndanganparsatu(dataGridView1, comboBoxBidang.Text);
                        break;
                    case "2 hari kedepan": crb.tampilUndanganpardua(dataGridView1, comboBoxBidang.Text);
                        break;
                    case "3 hari kedepan": crb.tampilUndanganpartiga(dataGridView1, comboBoxBidang.Text);
                        break;
                    case "1 minggu kedepan": crb.tampilUndanganparminggu(dataGridView1, comboBoxBidang.Text);
                        break;
                    default: break;
                }
            }
        }
    }
}
