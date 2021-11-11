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

namespace IEA_Erproject102AA_Main.BilgiGirisİslemleri.Doktorlar
{
    public partial class frmDoktorGirisEkrani : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;
        public frmDoktorGirisEkrani()
        {
            InitializeComponent();
        }
        private void frmDoktorGirisEkrani_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear(); // temizleyip yeniden oluştursun
            int i = 0, sira = 1;

            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGrupId == 2
                       select new
                       {
                           id = s.Id,
                           Dkodu = s.CariKodu,
                           Dadi = s.CariAdi,
                           Dtel = s.CariTel,
                           Dmail = s.CariMail,
                           
                       }).ToList(); //new ihtayç  kadar çekmek için bunları form ekranında bize gözükecek yer kadar yaptık

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.Dkodu;
                Liste.Rows[i].Cells[3].Value = k.Dadi;
                Liste.Rows[i].Cells[4].Value = k.Dtel;
                Liste.Rows[i].Cells[5].Value = k.Dmail;             
                i++; sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // bu nedir Veriye tıklandığında satır seçimi sağlama.
            lblHastaneKodu.Text = n.CariKoduDoktor();
        }

        private void ComboDoldur()
        {
            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 2).ToList();
            txtDoktUnvan.DataSource = Enum.GetValues(typeof(enumDoktorUnvanlar));
            var seh = erp.tblSehirler.ToList(); // on kosul yok hepsini alıyoz

            txtDokSehir.DataSource = seh;
            txtDokSehir.ValueMember = "id";
            txtDokSehir.DisplayMember = "sehir"; //departmanlar veritabanındaki adi ile aynı olmali
            txtDokSehir.SelectedIndex = -1; // ilk çalıştıgında  adana yazmasın orası boş olsun diye


            txtDkDepartman.DataSource = dep1;
            txtDkDepartman.ValueMember = "Id";
            txtDkDepartman.DisplayMember = "DeptAdi"; //departmanlar veritabanındaki adi ile aynı olmali
            txtDkDepartman.SelectedIndex = -1;
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
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();

                    hst.isActive = true;
                    hst.CariAdi = txtDoktAdi.Text;
                    hst.CariMail = txtDoktMail.Text;
                    hst.CariTel = txtDoktTel.Text;

                    hst.YetkiliDep1 = txtDkDepartman.Text;                              
                    hst.YetkiliCep1 = txtDokCep.Text;             
                
                    hst.Adres1 = txtDoktHastAdres.Text;
                    hst.Adres2 = txtDktMyAdres.Text;

                    hst.CariUnvan = txtDoktUnvan.Text;
                    hst.VDairesi = txtDkVDairesi.Text;
                    hst.VNoTcno = txtDkVTcNo.Text;
                 
                    hst.SehirId = (int?)txtDokSehir.SelectedValue ?? -1; //3. yontem  //gelen veri int ise gönder yoksa -1 gonder(null ise)
                    
                    hst.CariGrupId = 2;
                    hst.CariTipId = 2;
                    hst.SaveDate = DateTime.Now;
                    hst.SaveUserId = 1;
                    hst.CariKodu = hKodu; // sor

                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();
                    MessageBox.Show("Kayit Başarili");
                    Temizle();

                    Listele();
                }
                else
                {
                    MessageBox.Show(" kayıt yapılı");
                }
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

                hst.CariAdi = txtDoktAdi.Text;
                hst.CariMail = txtDoktMail.Text;
                hst.CariTel = txtDoktTel.Text;             
                hst.YetkiliDep1 = txtDkDepartman.Text;          
             
                hst.YetkiliCep1 = txtDokCep.Text;          
            
                hst.Adres1 = txtDoktHastAdres.Text;
                hst.Adres2 = txtDktMyAdres.Text;
                hst.CariTipId = 2;

                hst.CariUnvan = txtDoktUnvan.Text;
                hst.VDairesi = txtDkVDairesi.Text;
                hst.VNoTcno = txtDkVTcNo.Text;

                hst.SehirId = (int?)txtDokSehir.SelectedValue ?? -1;
                hst.UpdateDate = DateTime.Now;
                hst.UpdateUserId = 2;
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
            txtDokSehir.SelectedIndex = -1;
            txtDkDepartman.SelectedIndex = -1;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
        public void Ac(int i)
        {
            secimId = i;
            try
            {
                tblCariler hst = erp.tblCariler.Find(i); //sor

                txtDoktAdi.Text = hst.CariAdi;
                txtDoktMail.Text = hst.CariMail;
                txtDoktTel.Text = hst.CariTel;
                txtDokCep.Text = hst.YetkiliTel1;

                txtDoktHastAdres.Text = hst.Adres1;
                txtDktMyAdres.Text = hst.Adres2;

                txtDkVDairesi.Text = hst.VDairesi;
                txtDkVTcNo.Text = hst.VNoTcno;
      
                txtDkDepartman.Text = hst.YetkiliDep1;
                txtDoktUnvan.Text = hst.CariUnvan;

                txtDokSehir.Text = hst.tblSehirler.sehir;
                lblHastaneKodu.Text = hst.CariKodu;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
