
namespace IEA_Erproject102AA_Main.BilgiGirisİslemleri.Personeller
{
    partial class frmPersonellerListesi
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblHastaneKodu = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.PerListBilgi = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sıra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerisTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerisGiris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerListBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlUst.Controls.Add(this.lblHastaneKodu);
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1349, 79);
            this.pnlUst.TabIndex = 9;
            // 
            // lblHastaneKodu
            // 
            this.lblHastaneKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHastaneKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneKodu.Location = new System.Drawing.Point(622, 12);
            this.lblHastaneKodu.Name = "lblHastaneKodu";
            this.lblHastaneKodu.Size = new System.Drawing.Size(142, 45);
            this.lblHastaneKodu.TabIndex = 25;
            this.lblHastaneKodu.Text = "***";
            this.lblHastaneKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikis.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.exit_64;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1238, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(53, 45);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTemizle.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.Sil641;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(244, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(54, 45);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(173, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(54, 45);
            this.btnSil.TabIndex = 2;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuncelle.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(102, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(54, 45);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKayit
            // 
            this.btnKayit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKayit.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.Save_icon64x64;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.Location = new System.Drawing.Point(16, 12);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(54, 45);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.UseVisualStyleBackColor = true;
            // 
            // PerListBilgi
            // 
            this.PerListBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerListBilgi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sıra,
            this.PersonelDept,
            this.PersonelAdi,
            this.PerisTel,
            this.PerMail,
            this.PerisGiris});
            this.PerListBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.PerListBilgi.Location = new System.Drawing.Point(0, 79);
            this.PerListBilgi.Name = "PerListBilgi";
            this.PerListBilgi.RowHeadersWidth = 51;
            this.PerListBilgi.RowTemplate.Height = 24;
            this.PerListBilgi.Size = new System.Drawing.Size(1349, 234);
            this.PerListBilgi.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.HeaderText = "İd";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Sıra
            // 
            this.Sıra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sıra.HeaderText = "Sıra";
            this.Sıra.MinimumWidth = 6;
            this.Sıra.Name = "Sıra";
            this.Sıra.Width = 62;
            // 
            // PersonelDept
            // 
            this.PersonelDept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PersonelDept.HeaderText = "Personel Departman";
            this.PersonelDept.MinimumWidth = 6;
            this.PersonelDept.Name = "PersonelDept";
            this.PersonelDept.Width = 153;
            // 
            // PersonelAdi
            // 
            this.PersonelAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonelAdi.HeaderText = "Personel Adi";
            this.PersonelAdi.MinimumWidth = 6;
            this.PersonelAdi.Name = "PersonelAdi";
            // 
            // PerisTel
            // 
            this.PerisTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PerisTel.HeaderText = "Personel İs Telefonu";
            this.PerisTel.MinimumWidth = 6;
            this.PerisTel.Name = "PerisTel";
            this.PerisTel.Width = 153;
            // 
            // PerMail
            // 
            this.PerMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PerMail.HeaderText = "Personel Mail";
            this.PerMail.MinimumWidth = 6;
            this.PerMail.Name = "PerMail";
            this.PerMail.Width = 112;
            // 
            // PerisGiris
            // 
            this.PerisGiris.HeaderText = "Personel İş Giriş Zamanı";
            this.PerisGiris.MinimumWidth = 6;
            this.PerisGiris.Name = "PerisGiris";
            this.PerisGiris.Width = 125;
            // 
            // frmPersonellerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.PerListBilgi);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmPersonellerListesi";
            this.Text = "frmPersonellerListesi";
            this.Load += new System.EventHandler(this.frmPersonellerListesi_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PerListBilgi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        public System.Windows.Forms.Label lblHastaneKodu;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView PerListBilgi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sıra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerisTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerisGiris;
    }
}