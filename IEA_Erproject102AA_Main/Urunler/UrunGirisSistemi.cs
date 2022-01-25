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

namespace IEA_Erproject102AA_Main.Urunler
{
    public partial class UrunGirisSistemi : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int SecimId = -1;
        public UrunGirisSistemi()
        {
            InitializeComponent();
        }

        private void UrunGirisSistemi_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();

        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblUrunler1
                       where s.isActive == true
                       select s).ToList();
            foreach(var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.UrunGenelNo;
                Liste.Rows[i].Cells[3].Value = k.UrunKodu;
               Liste.Rows[i].Cells[4].Value = k.UrunAdi;
                i++; sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblUrunKodu.Text = n.UrunGenelKodu();
            txtGenelNo.Text = n.UrunGenelKodu();
        }

        private void ComboDoldur()
        {
            txtDistributor.DataSource = (from s in erp.tblCariler where s.CariGrupId == 3 where s.CariTipId == 1 select s).ToList();
            txtDistributor.ValueMember = "Id";
            txtDistributor.DisplayMember = "CariAdi";
            txtDistributor.SelectedIndex = -1;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {

            if (SecimId !=-1 || txtUrunKodu.Text=="")
            {
                return;
            }
        
                try
                {
                tblUrunler1 urn = new tblUrunler1();
                urn.UrunAdi = txtUrunAdi.Text;
                urn.UrunGenelNo = n.UrunGenelKodu();
                urn.UrunKodu = txtUrunKodu.Text;
                urn.AlisFiyat = decimal.Parse(txtUrunAFiyat.Text);
                urn.SatisFiyat = decimal.Parse(txtUrunSFiyat.Text);
                urn.DistributorId = (int)txtDistributor.SelectedValue;
                urn.KutuIcerik = txtKutuIcerik.Text;
                urn.UrunAciklama = txtUrunAciklama.Text;
                urn.KullanimSuresiAy = txtKullanimSuresi.Value; //field bi bak
                urn.SaveDate = DateTime.Now;
                urn.SaveUserId = 1;
                urn.isActive = true;

                erp.tblUrunler1.Add(urn);
                erp.SaveChanges();
                MessageBox.Show("kayit başarılı");
                Temizle();
                Listele();
                }
                catch (Exception)
                {


                }
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
            SecimId = -1;
         
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtGenelNo.ClientSize.Height + 0); // 
            btn.Location = new Point(txtGenelNo.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            SendMessage(txtGenelNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
            txtGenelNo.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += btn_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msh, IntPtr wp, IntPtr lp);

        private void btn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[""] == null)
            {
                UrunGirisSistemi frm = new UrunGirisSistemi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            SecimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(SecimId);
        }
        private tblUrunler1 Urunler;
        public void Ac(int secimId)
        {
            SecimId = -1;
            Urunler=erp.tblUrunler1.Find(SecimId);
            try
            {
                tblUrunler1 urn = Urunler;
                txtDistributor.Text = urn.tblCariler.CariAdi;
                txtGenelNo.Text = urn.UrunGenelNo;
                txtUrunKodu.Text = urn.UrunKodu;
                txtUrunAdi.Text = urn.UrunAdi;
                txtUrunAciklama.Text = urn.UrunAciklama;
                txtUrunAFiyat.Text = urn.AlisFiyat.ToString();
                txtUrunSFiyat.Text = urn.SatisFiyat.ToString();
                txtKutuIcerik.Text = urn.KutuIcerik;
               if(urn.KullanimSuresiAy!=null) txtKullanimSuresi.Value = urn.KullanimSuresiAy.Value;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        void Guncelle()
        {
            if (SecimId == -1)
            {
                return;
            }
            try
            {
                tblUrunler1 urn = new tblUrunler1();
                //   urn.UrunAdi = txtUrunAi.Text;
                urn.UrunGenelNo = n.UrunGenelKodu();
                urn.UrunKodu = txtUrunKodu.Text;
                urn.AlisFiyat = decimal.Parse(txtUrunAFiyat.Text);
                urn.SatisFiyat = decimal.Parse(txtUrunSFiyat.Text);
                urn.DistributorId = (int)txtDistributor.SelectedValue;
                urn.KutuIcerik = txtKutuIcerik.Text;
                urn.UrunAciklama = txtUrunAciklama.Text;
                urn.KullanimSuresiAy = txtKullanimSuresi.Value;
                urn.UpdateDate = DateTime.Now;
                urn.UpdateUserId = 1;
                urn.isActive = true;

                
                erp.SaveChanges();
                MessageBox.Show("Guncelleme başarılı");
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
            if(SecimId > 0)
            {
                tblUrunler1 hst = Urunler;
                hst.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme Başarılı");
                Temizle();
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
