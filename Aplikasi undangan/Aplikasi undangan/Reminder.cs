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
    public partial class Reminder : Form
    {
        Undangan ud;
        Pejabat pj;
        tampilUndangan tu;
        tampilPejabat tp;
        c_reminder cr;
        updateUndangan uu;
        updatePejabat up;
        Form1 f;
        reportUndangan ru;
        ReminderBidang rb;
        reportList rl;
        public Reminder()
        {
            InitializeComponent();
        }

        
        
        private void Reminder_Load(object sender, EventArgs e)
        {
            
            radioButton4.Checked = true;
            cr = new c_reminder();
            cr.tampilUndanganparsatu(dataGridView1);
        }

        private void inputDataUndanganToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Undangan")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                ud = new Undangan();
                ud.Show();
                //fp.WindowState = FormWindowState.Maximized;
            }  

           
        }

        private void inputDataPejabatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Pejabat")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                pj = new Pejabat();
                
                pj.Show();
                //fp.WindowState = FormWindowState.Maximized;
            }  

            
        }

        private void tampilanUndanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "tampilUndangan")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                tu = new tampilUndangan();
                
                tu.Show();
                //fp.WindowState = FormWindowState.Maximized;
            }  

            
        }

        private void tampilanPejabatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "tampilPejabat")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                tp = new tampilPejabat();
                
                tp.Show();
                //fp.WindowState = FormWindowState.Maximized;
            }  

           
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string plh = "";
            cr = new c_reminder();

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
                case "hari ini": cr.tampilUndanganparsatu(dataGridView1);
                    break;
                case "2 hari kedepan": cr.tampilUndanganpardua(dataGridView1);
                    break;
                case "3 hari kedepan": cr.tampilUndanganpartiga(dataGridView1);
                    break;
                case "1 minggu kedepan": cr.tampilUndanganparminggu(dataGridView1);
                    break;
                default: break;
            }
        }

        private void editDataUndanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "updateUndangan")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                uu = new updateUndangan();
                
                uu.Show();
                //fp.WindowState = FormWindowState.Maximized;
            }  

            
        }

        private void editDataPejabatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "updatePejabat")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                up = new updatePejabat();
                
                up.Show();
                //fp.WindowState = FormWindowState.Maximized;
            }  

            
        }

        private void reportPejabatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Form1")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                f = new Form1();
                f.Show();
                //fp.WindowState = FormWindowState.Maximized;
            }
            
        }

        private void reportUndanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Form1")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                ru = new reportUndangan();
                ru.Show();
                //fp.WindowState = FormWindowState.Maximized;
            }
            
        }

        private void reminderPerBidangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Form1")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                rb = new ReminderBidang();
                rb.Show();
                //fp.WindowState = FormWindowState.Maximized;
            }
           
        }

        private void reportUndanganLengkapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "reportList")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                rl = new reportList();
                rl.Show();
                //fp.WindowState = FormWindowState.Maximized;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
