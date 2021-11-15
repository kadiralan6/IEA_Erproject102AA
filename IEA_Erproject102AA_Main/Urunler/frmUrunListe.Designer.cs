
namespace IEA_Erproject102AA_Main.Urunler
{
    partial class frmUrunListe
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sıra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sıra,
            this.GenelNo,
            this.UrunKod,
            this.UrunAdi1});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Top;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1234, 237);
            this.Liste.TabIndex = 8;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
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
            // GenelNo
            // 
            this.GenelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GenelNo.HeaderText = "Genel No";
            this.GenelNo.MinimumWidth = 6;
            this.GenelNo.Name = "GenelNo";
            this.GenelNo.Width = 97;
            // 
            // UrunKod
            // 
            this.UrunKod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKod.HeaderText = "Urun Kodu";
            this.UrunKod.MinimumWidth = 6;
            this.UrunKod.Name = "UrunKod";
            // 
            // UrunAdi1
            // 
            this.UrunAdi1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAdi1.HeaderText = "Urun Adi";
            this.UrunAdi1.MinimumWidth = 6;
            this.UrunAdi1.Name = "UrunAdi1";
            // 
            // frmUrunListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 518);
            this.Controls.Add(this.Liste);
            this.Name = "frmUrunListe";
            this.Text = "frmUrunListe";
            this.Load += new System.EventHandler(this.frmUrunListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sıra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi1;
    }
}