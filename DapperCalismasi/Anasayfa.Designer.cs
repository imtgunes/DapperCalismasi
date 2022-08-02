namespace DapperCalismasi
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewOgr = new System.Windows.Forms.DataGridView();
            this.buttonAyarlar = new System.Windows.Forms.Button();
            this.buttonOgrEkle = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewBolumler = new System.Windows.Forms.DataGridView();
            this.dataGridViewFakulteler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgr)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBolumler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFakulteler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOgr
            // 
            this.dataGridViewOgr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgr.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewOgr.Name = "dataGridViewOgr";
            this.dataGridViewOgr.RowTemplate.Height = 25;
            this.dataGridViewOgr.Size = new System.Drawing.Size(1292, 366);
            this.dataGridViewOgr.TabIndex = 0;
            this.dataGridViewOgr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOgr_CellClick);
            // 
            // buttonAyarlar
            // 
            this.buttonAyarlar.Location = new System.Drawing.Point(12, 415);
            this.buttonAyarlar.Name = "buttonAyarlar";
            this.buttonAyarlar.Size = new System.Drawing.Size(75, 23);
            this.buttonAyarlar.TabIndex = 1;
            this.buttonAyarlar.Text = "Ayarlar";
            this.buttonAyarlar.UseVisualStyleBackColor = true;
            this.buttonAyarlar.Click += new System.EventHandler(this.buttonAyarlar_Click);
            // 
            // buttonOgrEkle
            // 
            this.buttonOgrEkle.Location = new System.Drawing.Point(1219, 415);
            this.buttonOgrEkle.Name = "buttonOgrEkle";
            this.buttonOgrEkle.Size = new System.Drawing.Size(96, 23);
            this.buttonOgrEkle.TabIndex = 2;
            this.buttonOgrEkle.Text = "Öğrenci Ekle";
            this.buttonOgrEkle.UseVisualStyleBackColor = true;
            this.buttonOgrEkle.Click += new System.EventHandler(this.buttonOgrEkle_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1303, 397);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewOgr);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1295, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenci Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewBolumler);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1295, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bölümler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewFakulteler);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1295, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fakülteler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBolumler
            // 
            this.dataGridViewBolumler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBolumler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBolumler.Name = "dataGridViewBolumler";
            this.dataGridViewBolumler.RowTemplate.Height = 25;
            this.dataGridViewBolumler.Size = new System.Drawing.Size(1295, 366);
            this.dataGridViewBolumler.TabIndex = 0;
            // 
            // dataGridViewFakulteler
            // 
            this.dataGridViewFakulteler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFakulteler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFakulteler.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewFakulteler.Name = "dataGridViewFakulteler";
            this.dataGridViewFakulteler.RowTemplate.Height = 25;
            this.dataGridViewFakulteler.Size = new System.Drawing.Size(1294, 368);
            this.dataGridViewFakulteler.TabIndex = 0;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonOgrEkle);
            this.Controls.Add(this.buttonAyarlar);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Activated += new System.EventHandler(this.Anasayfa_Activated);
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgr)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBolumler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFakulteler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewOgr;
        private Button buttonAyarlar;
        private Button buttonOgrEkle;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridViewBolumler;
        private TabPage tabPage3;
        private DataGridView dataGridViewFakulteler;
    }
}