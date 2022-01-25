using IEA_Erproject102AA_Main.BilgiGirisİslemleri.Hastaneler;
using IEA_Erproject102AA_Main.Entity;
using IEA_Erproject102AA_Main.Fonksiyonlar;
using IEA_Erproject102AA_Main.Urunler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_Erproject102AA_Main.DepoIslemleri.StokIslemleri
{
    public partial class frmStokGiris :Form
    {
        public string[] MyArray { get; set; }
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        Formlar f = new Formlar();
        private int secimId = -1;
        public frmStokGiris()
        {
            InitializeComponent();
        }
        private void frmStokGiris_Load(object sender, EventArgs e)
        {
            CombolDoldur();
            txtGenelNo.Text = n.StokGenelKodu();          
        }

        #region Form Yuklenme Islemleri
        private void CombolDoldur()
        {
            tblCariGruplari cariler = new tblCariGruplari();

            txtUrunCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var srg = erp.tblUrunler1.Where(x => x.isActive == true).Select(x => x.UrunKodu).Distinct();
            foreach (string urun in srg)
            {
                veri.Add(urun);
                txtUrunCombo.Items.Add(urun);
            }
            txtUrunCombo.AutoCompleteCustomSource = veri;


            int dgv;
            dgv = txtUrunCombo.Items.Count;
            MyArray = new string[dgv];

            for (int p = 0; p < dgv; p++)
            {
                MyArray[p] = txtUrunCombo.Items[p].ToString();

            }

            txtCariGrup.DataSource = erp.tblCariler.ToList();
            txtCariGrup.ValueMember = "Id";
            txtCariGrup.DisplayMember = "GrupAdi";
            txtCariGrup.SelectedIndex = -1;

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {

        } 
        #endregion

        #region Kayit Islemleri
        private void YeniKayit()
        {
            if (txtCariGrup.Text == "" || txtCariAdi.Text == "")
            {
                MessageBox.Show("Cari Grup veya cari Adi Seçmediniz  Seçmediniz. Lütfen seçim yap");
                return;
            }
            //if (txtCariAdi.Text == "")
            //{
            //    MessageBox.Show("C Cari Adi  Seçmediniz. Lütfen seçim yap");
            //    return;
            //}
            if (txtGirisTipi.Text == "")
            {
                MessageBox.Show("Giris Tipini  Seçmediniz. Lütfen seçim yap");
                return;
            }
            Liste.AllowUserToAddRows = false; //bunu bi araştır......
            try
            {
                tblStokGirisUst ust = new tblStokGirisUst
                {
                    GenelNo = int.Parse(txtGenelNo.Text),
                     CariGrupId = (int)txtCariGrup.SelectedValue,
                    CariAdiId = erp.tblCariler.First(x => x.CariAdi == txtCariAdi.Text).Id,
                    GirisTipi = txtGirisTipi.SelectedIndex+1,
                    FaturaNo = txtFaturaNo.Text,
                    FaturaTarih = txtGirisTarih.Value,
                    Aciklama = txtAciklama.Text,
                    isActive = true,
                    SaveDate = DateTime.Now,
                    SaveUserId = 1
                    
                };

                erp.tblStokGirisUst.Add(ust);
                erp.SaveChanges();
                MessageBox.Show("Kayit başarili");

                tblStokDurum[] drm = new tblStokDurum[Liste.RowCount];
                tblStokGirisAlt[] alt = new tblStokGirisAlt[Liste.RowCount];


                
                for(int i = 0; i < Liste.RowCount; i++)
                {
                    string bar = Liste.Rows[i].Cells[2].Value.ToString()+"/"+ 
                        Liste.Rows[i].Cells[2].Value.ToString();
                    //Ar-1001 12345 = Ar-1001/12345

                    drm[i] = new tblStokDurum();
                    var srg = (from s in erp.tblStokDurum
                               where s.Barkod == bar
                               select new
                               {
                                   sadet = s.StokAdet,
                                   sraf = s.RafAdet
                               }).ToList(); //sorgu sonucunda bir sonuc geliyorsa srg içindeki count artıyor urun var demktir
                    if (srg.Count == 0)
                    {
                        drm[i].StokKodu = "1";
                        drm[i].Barkod = bar;
                        drm[i].Urun = Liste.Rows[i].Cells[2].Value.ToString();
                        drm[i].Lot = Liste.Rows[i].Cells[3].Value.ToString();
                        drm[i].StokAdet =Convert.ToInt32( Liste.Rows[i].Cells[4].Value);
                        drm[i].RafAdet =Convert.ToInt32( Liste.Rows[i].Cells[4].Value);
                        drm[i].SubeAdet =0;
                        drm[i].KonsinyeAdet =0;
                        drm[i].UT =Convert.ToDateTime(Liste.Rows[i].Cells[6].Value);
                        drm[i].SKT = Convert.ToDateTime( Liste.Rows[i].Cells[7].Value.ToString());


                        erp.tblStokDurum.Add(drm[i]);
                        //erp.SaveChanges();
                    
                    
                    }
                    else
                    {
                        tblStokDurum  sdurum= erp.tblStokDurum.First(x => x.Barkod == bar);
                        sdurum.StokAdet+= Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                        sdurum.RafAdet+= Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                        erp.SaveChanges();// değişiklikleri anlık olarak yapsn
                    }


                    alt[i] = new tblStokGirisAlt();
                    alt[i].GenelNo =int.Parse(txtGenelNo.Text) ;
                    alt[i].SiraNo = i + 1;
                    alt[i].Barkod =bar; //barkod bilgisini alıyoz
                    alt[i].UrunKodu = Liste.Rows[i].Cells[2].Value.ToString(); 
                  
                   
                    alt[i].LotSeriNo = Liste.Rows[i].Cells[3].Value.ToString();
                    //objeler pars edilmez
                    alt[i].Adet = Convert.ToInt32(Liste.Rows[i].Cells[4].Value.ToString());
                    alt[i].Not = Liste.Rows[i].Cells[5].Value.ToString();

                    alt[i].UT = Convert.ToDateTime(Liste.Rows[i].Cells[6].Value.ToString());
                    alt[i].SKT = Convert.ToDateTime(Liste.Rows[i].Cells[7].Value.ToString());
                    alt[i].AlisFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[8].Value.ToString());

                    //erp.tblStokGirisAlt.Add(alt[i]);
                    //erp.SaveChanges(); //her satır için o anda kayıt yapması totalde

                }
            //    erp.tblStokDurum.AddRange(drm);
                //bu yöntemde bütün satırlar alta toplandıkdan sonra kayıt edilir
                erp.tblStokGirisAlt.AddRange(alt);
                erp.SaveChanges();

            }
            catch (Exception e)
            {

                MessageBox.Show("100   : "+ e.Message);
            }

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        #endregion

        #region Guncelleme ve Silme Islemleri
        private void KayitAc()
        {

        }
        private void Guncelle()
        {

        }
        private void Sil()
        {

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }
        #endregion



        //sanal buton
        #region Sanal Buton islemleri
        protected override void OnLoad(EventArgs e)
        {
            var btnUrunBul = new Button();
            btnUrunBul.Size = new Size(25, txtGenelNo.ClientSize.Height + 2);
            btnUrunBul.Location = new Point(txtGenelNo.ClientSize.Width - btnUrunBul.Width, -1);
            btnUrunBul.Cursor = Cursors.Default;// mause hareketi
            btnUrunBul.Image = Properties.Resources.arrow_1176;
            txtGenelNo.Controls.Add(btnUrunBul);
            btnUrunBul.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnYer = new Button();
            btnYer.Size = new Size(25, txtCariAdi.ClientSize.Height + 2);
            btnYer.Location = new Point(txtCariAdi.ClientSize.Width - btnYer.Width, -1);
            btnYer.Cursor = Cursors.Default;// mause hareketi
            btnYer.Image = Properties.Resources.arrow_1176;
            txtCariAdi.Controls.Add(btnYer);
            btnYer.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnUrunBul.Click += btnUrunBul_Click;
            btnYer.Click += btnYer_Click;
        }

        private void btnUrunBul_Click(object sender,EventArgs e)
        {
            //frmStokListesi frm = new frmStokListesi();
            //frm.ShowDialog();
            int id = f.StokGirisListesi(true);
            if (id > 0)
            {
                FormAc(id);
            }
            Home.Aktarma = -1; //
        }

        private void FormAc(int id)
        {
            int i = 0;
            var kayitBul = erp.tblStokGirisUst.Find(id);
            //var kayitBul1 = erp.vwStokGiris.First(x => x.Id == id);
            tblStokGirisUst ust = kayitBul;
            txtGenelNo.Text = ust.GenelNo.ToString();
            txtCariGrup.Text = ust.tblCariGruplari.GrupAdi;
            txtAciklama.Text = ust.Aciklama;
            txtFaturaNo.Text = ust.FaturaNo;
            txtCariAdi.Text = ust.tblCariler.CariAdi;
            if (ust.FaturaTarih != null)
            {
                txtGirisTarih.Value = (DateTime)ust.FaturaTarih;
            }
            if (ust.GirisTipi != null) txtGirisTipi.SelectedIndex = ust.GirisTipi.Value;

            var alt = erp.tblStokGirisAlt.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
            Liste.Rows.Clear();
           // var alt1 = erp.vwStokGiris.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
            foreach (var k in alt)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.SiraNo;
                Liste.Rows[i].Cells[1].Value = k.Barkod;
                Liste.Rows[i].Cells[2].Value = k.UrunKodu;
                Liste.Rows[i].Cells[3].Value = k.LotSeriNo;
                Liste.Rows[i].Cells[4].Value = k.Adet;
                Liste.Rows[i].Cells[5].Value = k.Not;
                //DateTime a = Convert.ToDateTime(k.UT);
                Liste.Rows[i].Cells[6].Value = k.UT;
                Liste.Rows[i].Cells[7].Value = k.SKT;
                Liste.Rows[i].Cells[8].Value = k.AlisFiyat;
                Liste.Rows[i].Cells[9].Value = k.Id;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
        }

        private void btnYer_Click(object sender, EventArgs e)
        {
           
             if (txtCariGrup.Text == "Firma")
            {
                int id = f.FirmalarListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }
                Home.Aktarma = -1;
            }
          
        }

        private void Ac(int id)
        {
            tblCariler bulId = erp.tblCariler.Find(id);
            if (txtCariGrup.Text == "Personel")
            {
                bulId = erp.tblPersonelDetay.First(x => x.Id == id).tblCariler;
            }
            try
            {
                tblCariler hst = bulId;
                txtCariAdi.Text = hst.CariAdi;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        } 
        #endregion

        #region DataGridView Düzenlemeleri
       

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    foreach (DataGridViewCell cell in Liste.SelectedCells)
                    {
                        int i = 0;
                        if (cell.Value != null)
                        {
                            if (Liste.CurrentCell != null)
                            {
                                string a = Liste.CurrentRow.Cells[2].Value.ToString();
                            }
                            try
                            {
                                string a = Liste.CurrentRow.Cells[2].Value.ToString();

                                var lst = (from s in erp.tblUrunler1
                                           where s.UrunKodu == a
                                           select s).First();
                            }
                            catch (Exception exxx)
                            {

                                MessageBox.Show(exxx.Message);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Urun Kodu Bos olamaz");
                            if (Liste.CurrentRow != null)
                            {
                                Liste.CurrentRow.Cells[2].Value = "";
                            }
                        }


                        i++;
                    }
                }

            
            if (e.ColumnIndex == 6)
            {
                if (Liste.CurrentRow.Cells[6].Value != null)
                {
                        string urn = Liste.CurrentRow.Cells[2].Value.ToString();
                        var lst = (from s in erp.tblUrunler1 where s.UrunKodu == urn select s).FirstOrDefault();
                        int ayy = Convert.ToInt32( lst.KullanimSuresiAy.Value);

                        DateTime ay = Convert.ToDateTime(Liste.CurrentRow.Cells[6].Value);
                        Liste.CurrentRow.Cells[7].Value = ay.AddMonths(ayy).ToShortDateString();
                }
            } 
             }
            catch (Exception exx)
            {

                MessageBox.Show(exx.Message);
            }
        }




        #endregion

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBox txt = e.Control as TextBox;
                if (Liste.CurrentCell.ColumnIndex == 2 && txt != null) //urun kodunu baz almaya çalısıyoz
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource.AddRange(MyArray);

                }
                else if (Liste.CurrentCell.ColumnIndex != 2 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.None;

                }
                TextBox teks = e.Control as TextBox;
                teks.CharacterCasing = CharacterCasing.Upper;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void KayitIdBul()
        {
            secimId =(int) Liste.CurrentRow.Cells[9].Value;
            if (secimId > 0)
            {
                Home.Aktarma = secimId;
                f.StokGirisGuncelle();
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitIdBul();
            Listele();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            ErpProject102Entities db = new ErpProject102Entities();
            var alt = db.tblStokGirisAlt.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
            Liste.Rows.Clear();
            // var alt1 = erp.vwStokGiris.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
            foreach (var k in alt)
            {
                int i = 0;
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.SiraNo;
                Liste.Rows[i].Cells[1].Value = k.Barkod;
                Liste.Rows[i].Cells[2].Value = k.UrunKodu;
                Liste.Rows[i].Cells[3].Value = k.LotSeriNo;
                Liste.Rows[i].Cells[4].Value = k.Adet;
                Liste.Rows[i].Cells[5].Value = k.Not;
                //DateTime a = Convert.ToDateTime(k.UT);
                Liste.Rows[i].Cells[6].Value = k.UT;
                Liste.Rows[i].Cells[7].Value = k.SKT;
                Liste.Rows[i].Cells[8].Value = k.AlisFiyat;
                Liste.Rows[i].Cells[9].Value = k.Id;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
        }
    }
}
