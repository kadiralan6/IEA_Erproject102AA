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

namespace IEA_Erproject102AA_Main.DepoIslemleri.StokIslemleri
{
    public partial class btnStokGirisGuncelleme : Form
    {
        public string[] MyArray { get; set; }

        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        Formlar f = new Formlar();
        private int secimId = -1;
        public btnStokGirisGuncelleme()
        {
            InitializeComponent();
        }

        private void btnStokGirisGuncelleme_Load(object sender, EventArgs e)
        {

            FormDoldur();
        }

        private void FormDoldur()
        {
            secimId = Home.Aktarma;
            var sonuc = erp.tblStokGirisAlt.Find(secimId);
            txtGenelNo.Text = sonuc.GenelNo.ToString();
            lblGenelNO.Text = sonuc.GenelNo.ToString();
            txtAlisFiyat.Text = sonuc.AlisFiyat.ToString();
            lblAlisFiyat.Text = sonuc.AlisFiyat.ToString();
            txtBarkod.Text = sonuc.Barkod;
            lblBarkod.Text = sonuc.Barkod;
            txtLot.Text = sonuc.LotSeriNo;
            lblLot.Text = sonuc.LotSeriNo;
            txtSKT.Text = sonuc.SKT.ToString();
            lblSkt.Text = sonuc.SKT.ToString();
            txtUrunKodu.Text = sonuc.UrunKodu;
            lblUrunKod.Text = sonuc.UrunKodu;
            txtUT.Text = sonuc.UT.ToString();
            lblUt.Text = sonuc.UT.ToString();
            txtAdet.Text = sonuc.Adet.ToString();
            lblAdet.Text = sonuc.Adet.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           Guncelle();
        }

        private void Guncelle()
        {
            var srg = erp.tblStokDurum.First(s => s.Barkod == txtBarkod.Text);

            if (srg!=null)
            {
                srg.StokAdet -= int.Parse(lblAdet.Text);
                srg.RafAdet -= int.Parse(lblAdet.Text); 
                srg.StokAdet += int.Parse(txtAdet.Text);
                srg.RafAdet += int.Parse(txtAdet.Text); 
            }
           // var lst = erp.tblStokGirisAlt.Where(s => s.GenelNo.ToString() == txtGenelNo.Text).ToList();
          //  tblStokGirisAlt[] alt = new tblStokGirisAlt[lst.Count];

            var lst = erp.tblStokGirisAlt.First(s => s.Id == secimId);

            lst.UrunKodu = txtUrunKodu.Text;
            lst.AlisFiyat = Convert.ToDecimal(txtAlisFiyat.Text);
            lst.Barkod = txtBarkod.Text;
            lst.GenelNo = Convert.ToInt32(txtGenelNo.Text);
            lst.LotSeriNo = txtLot.Text;
            lst.SKT = txtSKT.Value;
            lst.UT = txtUT.Value;
            lst.Adet = Convert.ToInt32(txtAdet.Text);
            erp.SaveChanges();

            MessageBox.Show("Guncelleme Yapild");
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
