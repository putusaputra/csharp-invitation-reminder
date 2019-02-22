namespace Aplikasi_undangan
{
    partial class tampilPejabat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tampilPejabat));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonNama = new System.Windows.Forms.Button();
            this.buttonNIP = new System.Windows.Forms.Button();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 420);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(892, 60);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(889, 108);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHapus});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(889, 196);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnHapus
            // 
            this.ColumnHapus.HeaderText = "";
            this.ColumnHapus.Name = "ColumnHapus";
            this.ColumnHapus.Text = "Hapus";
            this.ColumnHapus.UseColumnTextForButtonValue = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(659, 150);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(182, 40);
            this.buttonReset.TabIndex = 72;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonNama
            // 
            this.buttonNama.Location = new System.Drawing.Point(471, 150);
            this.buttonNama.Name = "buttonNama";
            this.buttonNama.Size = new System.Drawing.Size(182, 40);
            this.buttonNama.TabIndex = 71;
            this.buttonNama.Text = "Cari Berdasarkan Nama";
            this.buttonNama.UseVisualStyleBackColor = true;
            this.buttonNama.Click += new System.EventHandler(this.buttonNama_Click);
            // 
            // buttonNIP
            // 
            this.buttonNIP.Location = new System.Drawing.Point(283, 150);
            this.buttonNIP.Name = "buttonNIP";
            this.buttonNIP.Size = new System.Drawing.Size(182, 40);
            this.buttonNIP.TabIndex = 70;
            this.buttonNIP.Text = "Cari Berdasarkan NIP";
            this.buttonNIP.UseVisualStyleBackColor = true;
            this.buttonNIP.Click += new System.EventHandler(this.buttonNIP_Click);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCari.Location = new System.Drawing.Point(31, 150);
            this.textBoxCari.Multiline = true;
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(245, 40);
            this.textBoxCari.TabIndex = 69;
            // 
            // tampilPejabat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonNama);
            this.Controls.Add(this.buttonNIP);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "tampilPejabat";
            this.Text = "tampilPejabat";
            this.Load += new System.EventHandler(this.tampilPejabat_Load);
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
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonNama;
        private System.Windows.Forms.Button buttonNIP;
        private System.Windows.Forms.TextBox textBoxCari;
    }
}