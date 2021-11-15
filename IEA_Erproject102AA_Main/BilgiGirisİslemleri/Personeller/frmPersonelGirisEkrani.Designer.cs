
namespace IEA_Erproject102AA_Main.BilgiGirisİslemleri.Personeller
{
    partial class frmPersonelGirisEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.lblHastaneKodu = new System.Windows.Forms.Label();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtDoktUnvan = new System.Windows.Forms.ComboBox();
            this.a = new System.Windows.Forms.TextBox();
            this.txtPerHastAdresi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerEvAdresi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPerMail = new System.Windows.Forms.TextBox();
            this.txtPerAdi = new System.Windows.Forms.TextBox();
            this.txtPerSehir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.txtPerCepTel = new System.Windows.Forms.MaskedTextBox();
            this.txtPerisTel = new System.Windows.Forms.MaskedTextBox();
            this.txtPerDept = new System.Windows.Forms.ComboBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtPerIsAyrilis = new System.Windows.Forms.DateTimePicker();
            this.txtPerIsBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtDurum = new System.Windows.Forms.CheckBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sıra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerisTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerisGiris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerisBitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAlt
            // 
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlAlt.Location = new System.Drawing.Point(0, 739);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1464, 22);
            this.pnlAlt.TabIndex = 11;
            // 
            // lblHastaneKodu
            // 
            this.lblHastaneKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHastaneKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneKodu.Location = new System.Drawing.Point(680, 12);
            this.lblHastaneKodu.Name = "lblHastaneKodu";
            this.lblHastaneKodu.Size = new System.Drawing.Size(142, 45);
            this.lblHastaneKodu.TabIndex = 0;
            this.lblHastaneKodu.Text = "***";
            this.lblHastaneKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlUst.Size = new System.Drawing.Size(1464, 83);
            this.pnlUst.TabIndex = 10;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikis.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.exit_64;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1353, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(53, 49);
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
            this.btnTemizle.Size = new System.Drawing.Size(54, 49);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(173, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(54, 49);
            this.btnSil.TabIndex = 2;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuncelle.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(102, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(54, 49);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKayit.BackgroundImage = global::IEA_Erproject102AA_Main.Properties.Resources.Save_icon64x64;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.Location = new System.Drawing.Point(16, 12);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(54, 49);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtDoktUnvan
            // 
            this.txtDoktUnvan.FormattingEnabled = true;
            this.txtDoktUnvan.Location = new System.Drawing.Point(155, 153);
            this.txtDoktUnvan.Name = "txtDoktUnvan";
            this.txtDoktUnvan.Size = new System.Drawing.Size(175, 24);
            this.txtDoktUnvan.TabIndex = 1;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(82, 100);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(344, 22);
            this.a.TabIndex = 0;
            // 
            // txtPerHastAdresi
            // 
            this.txtPerHastAdresi.Location = new System.Drawing.Point(619, 153);
            this.txtPerHastAdresi.Multiline = true;
            this.txtPerHastAdresi.Name = "txtPerHastAdresi";
            this.txtPerHastAdresi.Size = new System.Drawing.Size(272, 59);
            this.txtPerHastAdresi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Adi : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerEvAdresi
            // 
            this.txtPerEvAdresi.Location = new System.Drawing.Point(619, 241);
            this.txtPerEvAdresi.Multiline = true;
            this.txtPerEvAdresi.Name = "txtPerEvAdresi";
            this.txtPerEvAdresi.Size = new System.Drawing.Size(272, 59);
            this.txtPerEvAdresi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Unvan :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(513, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "İş Başlangıç Zamanı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(490, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "İş Çıkış Zamanı :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // txtPerMail
            // 
            this.txtPerMail.Location = new System.Drawing.Point(155, 412);
            this.txtPerMail.Name = "txtPerMail";
            this.txtPerMail.Size = new System.Drawing.Size(175, 22);
            this.txtPerMail.TabIndex = 7;
            // 
            // txtPerAdi
            // 
            this.txtPerAdi.Location = new System.Drawing.Point(155, 218);
            this.txtPerAdi.Name = "txtPerAdi";
            this.txtPerAdi.Size = new System.Drawing.Size(271, 22);
            this.txtPerAdi.TabIndex = 2;
            // 
            // txtPerSehir
            // 
            this.txtPerSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPerSehir.FormattingEnabled = true;
            this.txtPerSehir.Location = new System.Drawing.Point(155, 257);
            this.txtPerSehir.Name = "txtPerSehir";
            this.txtPerSehir.Size = new System.Drawing.Size(159, 24);
            this.txtPerSehir.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(513, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Hastane Adresi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(36, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 48);
            this.label13.TabIndex = 4;
            this.label13.Text = "Personel İş Tel.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(36, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "Personel Mail :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(39, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Sehir : ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(41, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Departman :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(513, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Personel Ev Adresi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(36, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cep Telefonu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 505);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1464, 22);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sıra,
            this.PersonelDept,
            this.PersonelAdi,
            this.PerisTel,
            this.PerMail,
            this.PerisGiris,
            this.PerisBitis});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 527);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1464, 234);
            this.Liste.TabIndex = 12;
            this.Liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellContentClick);
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // txtPerCepTel
            // 
            this.txtPerCepTel.Location = new System.Drawing.Point(155, 355);
            this.txtPerCepTel.Mask = "(999) 000-0000";
            this.txtPerCepTel.Name = "txtPerCepTel";
            this.txtPerCepTel.Size = new System.Drawing.Size(137, 22);
            this.txtPerCepTel.TabIndex = 6;
            // 
            // txtPerisTel
            // 
            this.txtPerisTel.Location = new System.Drawing.Point(155, 306);
            this.txtPerisTel.Mask = "(999) 000-0000";
            this.txtPerisTel.Name = "txtPerisTel";
            this.txtPerisTel.Size = new System.Drawing.Size(137, 22);
            this.txtPerisTel.TabIndex = 5;
            // 
            // txtPerDept
            // 
            this.txtPerDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPerDept.FormattingEnabled = true;
            this.txtPerDept.Location = new System.Drawing.Point(155, 188);
            this.txtPerDept.Name = "txtPerDept";
            this.txtPerDept.Size = new System.Drawing.Size(157, 24);
            this.txtPerDept.TabIndex = 4;
            // 
            // pnlOrta
            // 
            this.pnlOrta.Controls.Add(this.txtDurum);
            this.pnlOrta.Controls.Add(this.txtPerIsAyrilis);
            this.pnlOrta.Controls.Add(this.txtPerIsBaslangic);
            this.pnlOrta.Controls.Add(this.pnlAlt);
            this.pnlOrta.Controls.Add(this.txtDoktUnvan);
            this.pnlOrta.Controls.Add(this.a);
            this.pnlOrta.Controls.Add(this.txtPerHastAdresi);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtPerEvAdresi);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtPerMail);
            this.pnlOrta.Controls.Add(this.txtPerAdi);
            this.pnlOrta.Controls.Add(this.txtPerSehir);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtPerCepTel);
            this.pnlOrta.Controls.Add(this.txtPerisTel);
            this.pnlOrta.Controls.Add(this.txtPerDept);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 0);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1464, 761);
            this.pnlOrta.TabIndex = 14;
            // 
            // txtPerIsAyrilis
            // 
            this.txtPerIsAyrilis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPerIsAyrilis.Location = new System.Drawing.Point(619, 377);
            this.txtPerIsAyrilis.Name = "txtPerIsAyrilis";
            this.txtPerIsAyrilis.Size = new System.Drawing.Size(200, 22);
            this.txtPerIsAyrilis.TabIndex = 12;
            this.txtPerIsAyrilis.Visible = false;
            // 
            // txtPerIsBaslangic
            // 
            this.txtPerIsBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPerIsBaslangic.Location = new System.Drawing.Point(619, 336);
            this.txtPerIsBaslangic.Name = "txtPerIsBaslangic";
            this.txtPerIsBaslangic.Size = new System.Drawing.Size(200, 22);
            this.txtPerIsBaslangic.TabIndex = 12;
            // 
            // txtDurum
            // 
            this.txtDurum.AutoSize = true;
            this.txtDurum.Location = new System.Drawing.Point(849, 336);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(166, 21);
            this.txtDurum.TabIndex = 13;
            this.txtDurum.Text = "İş Bitiş Tarihi eklensin";
            this.txtDurum.UseVisualStyleBackColor = true;
            this.txtDurum.Visible = false;
            this.txtDurum.CheckedChanged += new System.EventHandler(this.txtDurum_CheckedChanged);
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
            dataGridViewCellStyle5.Format = ".";
            this.PerisGiris.DefaultCellStyle = dataGridViewCellStyle5;
            this.PerisGiris.HeaderText = "Personel İş Giriş Zamanı";
            this.PerisGiris.MinimumWidth = 6;
            this.PerisGiris.Name = "PerisGiris";
            this.PerisGiris.Width = 125;
            // 
            // PerisBitis
            // 
            dataGridViewCellStyle6.Format = ".";
            this.PerisBitis.DefaultCellStyle = dataGridViewCellStyle6;
            this.PerisBitis.HeaderText = "Personel İş bitiş Tarihi";
            this.PerisBitis.MinimumWidth = 6;
            this.PerisBitis.Name = "PerisBitis";
            this.PerisBitis.Width = 125;
            // 
            // frmPersonelGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 761);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlOrta);
            this.Name = "frmPersonelGirisEkrani";
            this.Text = "frmPersonelGirisEkrani";
            this.Load += new System.EventHandler(this.frmPersonelGirisEkrani_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAlt;
        public System.Windows.Forms.Label lblHastaneKodu;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.ComboBox txtDoktUnvan;
        private System.Windows.Forms.TextBox a;
        public System.Windows.Forms.TextBox txtPerHastAdresi;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPerEvAdresi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtPerMail;
        public System.Windows.Forms.TextBox txtPerAdi;
        public System.Windows.Forms.ComboBox txtPerSehir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView Liste;
        public System.Windows.Forms.MaskedTextBox txtPerCepTel;
        public System.Windows.Forms.MaskedTextBox txtPerisTel;
        public System.Windows.Forms.ComboBox txtPerDept;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.DateTimePicker txtPerIsAyrilis;
        private System.Windows.Forms.DateTimePicker txtPerIsBaslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sıra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerisTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerisGiris;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerisBitis;
        private System.Windows.Forms.CheckBox txtDurum;
    }
}