using IEA_Erproject102AA_Main.Entity;
using IEA_Erproject102AA_Main.Fonksiyonlar;
using IEA_Erproject102AA_Main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_Erproject102AA_Main.BilgiGirisİslemleri.Firmalar
{
    public partial class frmFirmaGiris : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;
        public frmFirmaGiris()
        {
            InitializeComponent();
        }

        private void frmFirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        private void ComboDoldur()
        {
            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var dep2 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var dep3 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            txtFirmaTipi.DataSource = Enum.GetValues(typeof(enumFirmaTipi));

            var seh = erp.tblSehirler.ToList(); // on kosul yok hepsini alıyoz

            txtSehir.DataSource = seh;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "sehir"; //departmanlar veritabanındaki adi ile aynı olmali
            txtSehir.SelectedIndex = -1; // ilk çalıştıgında  adana yazmasın orası boş olsun diye


            txtYetDep1.DataSource = dep1;
            txtYetDep1.ValueMember = "Id";
            txtYetDep1.DisplayMember = "DeptAdi"; //departmanlar veritabanındaki adi ile aynı olmali
            txtYetDep1.SelectedIndex = -1;

            txtYetDep2.DataSource = dep2;
            txtYetDep2.ValueMember = "Id";
            txtYetDep2.DisplayMember = "DeptAdi"; //departmanlar veritabanındaki adi ile aynı olmali
            txtYetDep2.SelectedIndex = -1;

            txtYetDep3.DataSource = dep3;
            txtYetDep3.ValueMember = "Id";
            txtYetDep3.DisplayMember = "DeptAdi"; //departmanlar veritabanındaki adi ile aynı olmali
            txtYetDep3.SelectedIndex = -1;
        }
        private void Listele()
        {
            Liste.Rows.Clear(); // temizleyip yeniden oluştursun
            int i = 0, sira = 1;

            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGrupId == 3
                       select new
                       {
                           id = s.Id,
                           Firmakodu = s.CariKodu,
                           Firmaadi = s.CariAdi,
                           Firmatel = s.CariTel,
                           Firmamail = s.CariMail,
                           FirmaYetAdi = s.YetkiliAdi1,
                           FirmaYetCep = s.YetkiliCep1,
                       }).ToList(); //new ihtayç  kadar çekmek için bunları form ekranında bize gözükecek yer kadar yaptık

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.Firmakodu;
                Liste.Rows[i].Cells[3].Value = k.Firmaadi;
                Liste.Rows[i].Cells[4].Value = k.Firmatel;
                Liste.Rows[i].Cells[5].Value = k.Firmamail;
                Liste.Rows[i].Cells[6].Value = k.FirmaYetAdi;
                Liste.Rows[i].Cells[7].Value = k.FirmaYetCep;
                i++; sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // bu nedir Veriye tıklandığında satır seçimi sağlama.
            lblHastaneKodu.Text = n.CariKoduFirmalar();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
        private void YeniKayit()
        {
            string hKodu = n.CariKoduFirmalar();

            try
            {
                if (txtFirmaAdi.Text == "")
                {
                    return;
                }
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();

                    hst.isActive = true;
                    hst.CariAdi = txtFirmaAdi.Text;
                    hst.CariMail = txtHastMail.Text;
                    hst.CariTel = txtFirmaTel.Text;

                    hst.YetkiliAdi1 = txtYetAdi1.Text;
                    hst.YetkiliAdi2 = txtYetAdi2.Text;
                    hst.YetkiliAdi3 = txtYetAdi3.Text;

                    hst.YetkiliDep1 = txtYetDep1.Text;
                    hst.YetkiliDep2 = txtYetDep2.Text;
                    hst.YetkiliDep3 = txtYetDep3.Text;

                    hst.YetkiliTel1 = txtYetTel1.Text;
                    hst.YetkiliTel2 = txtYetTel2.Text;
                    hst.YetkiliTel3 = txtYetTel3.Text;

                    hst.YetkiliCep1 = txtYetCep1.Text;
                    hst.YetkiliCep2 = txtYetCep2.Text;
                    hst.YetkiliCep3 = txtYetCep3.Text;

                    hst.YetkiliMail1 = txtYetMail1.Text;
                    hst.YetkiliMail2 = txtYetMail2.Text;
                    hst.YetkiliMail3 = txtYetMail3.Text;

                    hst.Adres1 = txtAdres1.Text;
                    hst.Adres2 = txtAdres2.Text;

                    hst.CariGrupId = 3;
                    hst.CariTipId = (int)txtFirmaTipi.SelectedValue;
                    
                   
                    hst.VDairesi = txtVergiD.Text;
                    hst.VnoTcno = txtVergiTc.Text;

                    // hst.SehirId = erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id; //1.yontem
                    //hst.SehirId = txtSehir.SelectedValue !=null ? (int)txtSehir.SelectedValue=-1; //turner if incele 2.yontem
                    hst.SehirId = (int?)txtSehir.SelectedValue ?? -1; //3. yontem  //gelen veri int ise gönder yoksa -1 gonder(null ise)

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
                if (secimId < 0)
                {
                    return;
                }

                tblCariler hst = erp.tblCariler.Find(secimId);

                hst.CariAdi = txtFirmaAdi.Text;
                hst.CariMail = txtHastMail.Text;
                hst.CariTel = txtFirmaTel.Text;

                hst.YetkiliAdi1 = txtYetAdi1.Text;
                hst.YetkiliAdi2 = txtYetAdi2.Text;
                hst.YetkiliAdi3 = txtYetAdi3.Text;

                hst.YetkiliDep1 = txtYetDep1.Text;
                hst.YetkiliDep2 = txtYetDep2.Text;
                hst.YetkiliDep3 = txtYetDep3.Text;

                hst.YetkiliTel1 = txtYetTel1.Text;
                hst.YetkiliTel2 = txtYetTel2.Text;
                hst.YetkiliTel3 = txtYetTel3.Text;

                hst.YetkiliCep1 = txtYetCep1.Text;
                hst.YetkiliCep2 = txtYetCep2.Text;
                hst.YetkiliCep3 = txtYetCep3.Text;

                hst.YetkiliMail1 = txtYetMail1.Text;
                hst.YetkiliMail2 = txtYetMail2.Text;
                hst.YetkiliMail3 = txtYetMail3.Text;

                hst.Adres1 = txtAdres1.Text;
                hst.Adres2 = txtAdres2.Text;
                 if(txtFirmaTipi.Text != "")
                {
                    hst.CariTipId = (int)txtFirmaTipi.SelectedValue;
                }

               
                hst.VDairesi = txtVergiD.Text;
                hst.VnoTcno = txtVergiTc.Text;

                if (txtSehir.SelectedValue != null)
                {
                    hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;
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
            txtSehir.SelectedIndex = -1;
            txtYetDep1.SelectedIndex = -1;
            txtYetDep2.SelectedIndex = -1;
            txtYetDep3.SelectedIndex = -1;

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

                txtFirmaAdi.Text = hst.CariAdi;
                txtHastMail.Text = hst.CariMail;
                txtFirmaTel.Text = hst.CariTel;

                txtYetAdi1.Text = hst.YetkiliAdi1;
                txtYetAdi2.Text = hst.YetkiliAdi2;
                txtYetAdi3.Text = hst.YetkiliAdi3;

                txtYetDep1.Text = hst.YetkiliDep1;
                txtYetDep2.Text = hst.YetkiliDep2;
                txtYetDep3.Text = hst.YetkiliDep3;

                txtYetTel1.Text = hst.YetkiliTel1;
                txtYetTel2.Text = hst.YetkiliTel2;
                txtYetTel3.Text = hst.YetkiliTel3;

                txtYetCep1.Text = hst.YetkiliCep1;
                txtYetCep2.Text = hst.YetkiliCep2;
                txtYetCep3.Text = hst.YetkiliCep3;

                txtYetMail1.Text = hst.YetkiliMail1;
                txtYetMail2.Text = hst.YetkiliMail2;
                txtYetMail3.Text = hst.YetkiliMail3;

                txtAdres1.Text = hst.Adres1;
                txtAdres2.Text = hst.Adres2;

               
                txtVergiD.Text = hst.VDairesi;
                txtVergiTc.Text = hst.VnoTcno;

                txtSehir.Text = hst.tblSehirler.sehir == null ? "" : hst.tblSehirler.sehir;
                lblHastaneKodu.Text = hst.CariKodu;
                txtFirmaTipi.Text=Enum.GetName(typeof(enumFirmaTipi), hst.CariTipId);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtHKoduBul.ClientSize.Height + 0); // 
            btn.Location = new Point(txtHKoduBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            SendMessage(txtHKoduBul.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
            txtHKoduBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += btn_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msh, IntPtr wp, IntPtr lp);

        private void btn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[""] == null)
            {
                frmFirmaGiris frm = new frmFirmaGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }
    }
}
