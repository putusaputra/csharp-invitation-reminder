namespace Aplikasi_undangan
{
    partial class tampilUndangan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tampilUndangan));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxNoBerkas = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxPengundang = new System.Windows.Forms.TextBox();
            this.textBoxNoSurat = new System.Windows.Forms.TextBox();
            this.textBoxMateri = new System.Windows.Forms.TextBox();
            this.textBoxDisposisi = new System.Windows.Forms.TextBox();
            this.textBoxDisposisiKalimat = new System.Windows.Forms.TextBox();
            this.buttonCari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 654);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1369, 76);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1369, 113);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHapus});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1369, 417);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnHapus
            // 
            this.ColumnHapus.HeaderText = "";
            this.ColumnHapus.Name = "ColumnHapus";
            this.ColumnHapus.Text = "Hapus";
            this.ColumnHapus.UseColumnTextForButtonValue = true;
            // 
            // textBoxNoBerkas
            // 
            this.textBoxNoBerkas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoBerkas.Location = new System.Drawing.Point(12, 164);
            this.textBoxNoBerkas.Multiline = true;
            this.textBoxNoBerkas.Name = "textBoxNoBerkas";
            this.textBoxNoBerkas.Size = new System.Drawing.Size(142, 40);
            this.textBoxNoBerkas.TabIndex = 65;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1097, 162);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(182, 40);
            this.buttonReset.TabIndex = 68;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxPengundang
            // 
            this.textBoxPengundang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPengundang.Location = new System.Drawing.Point(160, 164);
            this.textBoxPengundang.Multiline = true;
            this.textBoxPengundang.Name = "textBoxPengundang";
            this.textBoxPengundang.Size = new System.Drawing.Size(142, 40);
            this.textBoxPengundang.TabIndex = 69;
            // 
            // textBoxNoSurat
            // 
            this.textBoxNoSurat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoSurat.Location = new System.Drawing.Point(308, 164);
            this.textBoxNoSurat.Multiline = true;
            this.textBoxNoSurat.Name = "textBoxNoSurat";
            this.textBoxNoSurat.Size = new System.Drawing.Size(142, 40);
            this.textBoxNoSurat.TabIndex = 70;
            // 
            // textBoxMateri
            // 
            this.textBoxMateri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMateri.Location = new System.Drawing.Point(456, 164);
            this.textBoxMateri.Multiline = true;
            this.textBoxMateri.Name = "textBoxMateri";
            this.textBoxMateri.Size = new System.Drawing.Size(142, 40);
            this.textBoxMateri.TabIndex = 71;
            // 
            // textBoxDisposisi
            // 
            this.textBoxDisposisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisposisi.Location = new System.Drawing.Point(604, 164);
            this.textBoxDisposisi.Multiline = true;
            this.textBoxDisposisi.Name = "textBoxDisposisi";
            this.textBoxDisposisi.Size = new System.Drawing.Size(142, 40);
            this.textBoxDisposisi.TabIndex = 72;
            // 
            // textBoxDisposisiKalimat
            // 
            this.textBoxDisposisiKalimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisposisiKalimat.Location = new System.Drawing.Point(752, 164);
            this.textBoxDisposisiKalimat.Multiline = true;
            this.textBoxDisposisiKalimat.Name = "textBoxDisposisiKalimat";
            this.textBoxDisposisiKalimat.Size = new System.Drawing.Size(142, 40);
            this.textBoxDisposisiKalimat.TabIndex = 73;
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(909, 162);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(182, 40);
            this.buttonCari.TabIndex = 74;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "No Berkas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Pengundang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "No Surat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Materi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Disposisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(782, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Disposisi Kalimat";
            // 
            // tampilUndangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 731);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.textBoxDisposisiKalimat);
            this.Controls.Add(this.textBoxDisposisi);
            this.Controls.Add(this.textBoxMateri);
            this.Controls.Add(this.textBoxNoSurat);
            this.Controls.Add(this.textBoxPengundang);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxNoBerkas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "tampilUndangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tampilUndangan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tampilUndangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnHapus;
        private System.Windows.Forms.TextBox textBoxNoBerkas;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxPengundang;
        private System.Windows.Forms.TextBox textBoxNoSurat;
        private System.Windows.Forms.TextBox textBoxMateri;
        private System.Windows.Forms.TextBox textBoxDisposisi;
        private System.Windows.Forms.TextBox textBoxDisposisiKalimat;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}