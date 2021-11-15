using IEA_Erproject102AA_Main.Entity;
using IEA_Erproject102AA_Main.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_Erproject102AA_Main.BilgiGirisİslemleri.Personeller
{
    public partial class frmPersonelGirisEkrani : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;
        public frmPersonelGirisEkrani()
        {
            InitializeComponent();
        }


        private void frmPersonelGirisEkrani_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        private void ComboDoldur()
        {
            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 4).ToList();
           
            var seh = erp.tblSehirler.ToList(); // on kosul yok hepsini alıyoz

            txtPerSehir.DataSource = seh;
            txtPerSehir.ValueMember = "id";
            txtPerSehir.DisplayMember = "sehir"; //departmanlar veritabanındaki adi ile aynı olmali
            txtPerSehir.SelectedIndex = -1; // ilk çalıştıgında  adana yazmasın orası boş olsun diye

            txtPerDept.DataSource = dep1;
            txtPerDept.ValueMember = "Id";
            txtPerDept.DisplayMember = "DeptAdi"; //departmanlar veritabanındaki adi ile aynı olmali
            txtPerDept.SelectedIndex = -1;
        
        }
        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls) //pnorta bulunuan textler filan control sınıfının üyesi kısaca .Text aldıgımız her şey control sınıf üyesi
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
            txtPerSehir.SelectedIndex = -1;
            txtPerDept.SelectedIndex = -1;
            txtDurum.Visible = false;
            txtPerIsAyrilis.Visible = false;

        }
        private void Listele()
        {
           
            Liste.Rows.Clear(); // temizleyip yeniden oluştursun
            int i = 0, sira = 1;
           

            var lst = (from s in erp.tblPersonelDetay
                       where s.tblCariler.isActive==true  
                       where s.tblCariler.CariGrupId == 4
                       select new
                       {
                           id = s.Id,
                           PDept = s.tblCariler.YetkiliDep1,
                           Padi = s.tblCariler.CariAdi,
                           Ptel = s.tblCariler.CariTel,
                           Pmail = s.tblCariler.CariMail,
                           PisG=s.tblCariler.isGiris,
                           PisC=s.tblCariler.isCikis

                       }).ToList(); //new ihtayç  kadar çekmek için bunları form ekranında bize gözükecek yer kadar yaptık

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.PDept;
                Liste.Rows[i].Cells[3].Value = k.Padi;
                Liste.Rows[i].Cells[4].Value = k.Ptel;
                Liste.Rows[i].Cells[5].Value = k.Pmail;                
                Liste.Rows[i].Cells[6].Value = k.PisG;
                Liste.Rows[i].Cells[7].Value = k.PisC;

                i++; sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // bu nedir Veriye tıklandığında satır seçimi sağlama.
            lblHastaneKodu.Text = n.CariKoduPersonel();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            string hKodu = n.CariKoduHastane();
            try
            {
                if (txtPerAdi.Text == "")
                {
                    return;
                }
                if (secimId==-1)
                {
                    
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtPerAdi.Text;
                    hst.CariMail = txtPerMail.Text;
                    hst.CariTel = txtPerCepTel.Text;

                    hst.Adres1 = txtPerHastAdresi.Text;
                    hst.Adres2 = txtPerEvAdresi.Text;
                    hst.isGiris = txtPerIsBaslangic.Value;
                    hst.isCikis = txtPerIsAyrilis.Value;

                    hst.YetkiliCep1 = txtPerisTel.Text;
                    hst.YetkiliDep1 = txtPerDept.Text;
                    hst.SehirId = (int?)txtPerSehir.SelectedValue ?? -1;

                    hst.CariGrupId = 4;
                    hst.CariTipId = 1;
                    hst.SaveDate = DateTime.Now;
                    hst.SaveUserId = 1;
                    hst.CariKodu = hKodu; // sor

                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();

                    tblPersonelDetay pdet = new tblPersonelDetay();
                    pdet.isBasiTarih = txtPerIsBaslangic.Value;
                    pdet.CariId = erp.tblCariler.First(x => x.CariAdi ==
                      txtPerAdi.Text).Id;
                    erp.tblPersonelDetay.Add(pdet);
                    erp.SaveChanges();



                    MessageBox.Show("Kayit Başarili");

                    Listele();
                    Temizle();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("kayit başarısiz");
            }
            

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Temizle();
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        public void Ac(int i)
        {
            txtDurum.Visible = true;
            secimId = i;
            try
            {
                tblPersonelDetay hst = erp.tblPersonelDetay.Find(i); //sor

                txtPerAdi.Text = hst.tblCariler.CariAdi;
                txtPerMail.Text = hst.tblCariler.CariMail;
                txtPerCepTel.Text = hst.tblCariler.CariTel;           

                txtPerDept.Text = hst.tblCariler.YetkiliDep1; //personel departmanı  
                txtPerHastAdresi.Text = hst.tblCariler.Adres1;
                txtPerEvAdresi.Text = hst.tblCariler.Adres2;

                txtPerisTel.Text = hst.tblCariler.YetkiliCep1;

                 txtPerIsBaslangic.Value = (DateTime)hst.tblCariler.isGiris;
                 txtPerIsAyrilis.Value = (DateTime)hst.tblCariler.isCikis;

                txtPerSehir.Text = hst.tblCariler.tblSehirler == null ? "": hst.tblCariler.tblSehirler.sehir;

                lblHastaneKodu.Text = hst.tblCariler.CariKodu;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            try
            {
                tblCariler hst = erp.tblCariler.Find(secimId);

                hst.CariAdi = txtPerAdi.Text;
                hst.CariMail = txtPerMail.Text;
                hst.CariTel = txtPerCepTel.Text;
         
                hst.YetkiliDep1 = txtPerDept.Text;            
                hst.YetkiliCep1 = txtPerMail.Text;
            

                hst.Adres1 = txtPerHastAdresi.Text;
                hst.Adres2 = txtPerEvAdresi.Text;
                hst.CariTipId = 1;
           
                if(txtPerSehir.SelectedValue != null)
                {
                    hst.SehirId = (int)txtPerSehir.SelectedValue;
                }
               
                hst.UpdateDate = DateTime.Now;
                hst.UpdateUserId = 1;
                hst.CariKodu = lblHastaneKodu.Text;
                

                erp.SaveChanges();
                MessageBox.Show("Kayit Başarili");

                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme Başarılı");
                Temizle();
                Listele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurum.Checked)
            {
                txtPerIsAyrilis.Visible = false;
            }
            else
            {
                txtPerIsAyrilis.Visible = true;

            }
        }
    }
}
