using IEA_Erproject102AA_Main.BilgiGirisİslemleri.Doktorlar;
using IEA_Erproject102AA_Main.BilgiGirisİslemleri.Firmalar;
using IEA_Erproject102AA_Main.BilgiGirisİslemleri.Hastaneler;
using IEA_Erproject102AA_Main.BilgiGirisİslemleri.Personeller;
using IEA_Erproject102AA_Main.DepoIslemleri.StokIslemleri;
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

namespace IEA_Erproject102AA_Main
{
    public partial class Home : Form
    {
        Formlar f = new Formlar(); 
        public static int Aktarma = -1; //static sebebi  devamlı kullanılacağı için statik yaptık
        public Home()
        {
            InitializeComponent();
        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            MenuOlustur();
        }

        private void MenuOlustur()
        {
            #region Bilgi Giris İslemleri

            tvBilgiGirisİslemleri.Nodes.Add("Hastaneler"); //root elemanı
            tvBilgiGirisİslemleri.Nodes[0].Nodes.Add("Hastane Bilgi Giris Ekrani"); //child
            tvBilgiGirisİslemleri.Nodes[0].Nodes.Add("Hastaneler Listesi"); //child

            tvBilgiGirisİslemleri.Nodes.Add("Doktorlar"); //root elemanı
            tvBilgiGirisİslemleri.Nodes[1].Nodes.Add("Doktor Bilgi Giris Ekrani"); //child
            tvBilgiGirisİslemleri.Nodes[1].Nodes.Add("Doktorlar Listesi"); //child

            tvBilgiGirisİslemleri.Nodes.Add("Firmalar"); //root elemanı
            tvBilgiGirisİslemleri.Nodes[2].Nodes.Add("Firma Bilgi Giris Ekrani"); //child
            tvBilgiGirisİslemleri.Nodes[2].Nodes.Add("Firmalar Listesi"); //child

            tvBilgiGirisİslemleri.Nodes.Add("Personeller"); //root elemanı
            tvBilgiGirisİslemleri.Nodes[3].Nodes.Add("Personel Bilgi Giris Ekrani"); //child
            tvBilgiGirisİslemleri.Nodes[3].Nodes.Add("Personeller Listesi"); //child

            #endregion
            #region Ürünler Bilgi Giris
            tvUrunIslemleri.Nodes.Add("Ürünler"); //root elemanı
            tvUrunIslemleri.Nodes[0].Nodes.Add("Ürün Bilgi Giris Ekrani"); //child
            tvUrunIslemleri.Nodes[0].Nodes.Add("Ürünler Listesi"); //child
            #endregion
            #region DepoIslemleri
            tvDepoIslemleri.Nodes.Add("Depo Islemleri");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Durum");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Giris");
            tvDepoIslemleri.Nodes[0].Nodes[1].Nodes.Add("Depo Stok Giris");
            tvDepoIslemleri.Nodes[0].Nodes[1].Nodes.Add("Stok Giris Listesi");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Sevkiyat");

            #endregion
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            lblMenuText.Text = btnBilgiGiris.Text;
            TvGorunum();
            tvBilgiGirisİslemleri.Visible = true;
               
        }

        private void TvGorunum()
        {
            tvBilgiGirisİslemleri.Visible = false;
            tvUrunIslemleri.Visible = false;
            tvDepoIslemleri.Visible = false;
            tv4.Visible = false;
            tv5.Visible = false;
            tv6.Visible = false;
            tv7.Visible = false;
            tv8.Visible = false;
            tv9.Visible = false;
            tv10.Visible = false;
            tv11.Visible = false;
            tv12.Visible = false;

        }

        private void tvBilgiGirisİslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if( tvBilgiGirisİslemleri.SelectedNode !=null )
            {
               isim = tvBilgiGirisİslemleri.SelectedNode.Text;
            }
            //string isim =tvBilgiGirisİslemleri.SelectedNode !=null ?  //eğer selected node gelmıyorsa //boşsa isine tırnak koy hata veriyor sonra
            //    tvBilgiGirisİslemleri.SelectedNode.Text : ""; //seçilen node nın ismi alınıyor
            if(isim== "Hastane Bilgi Giris Ekrani" && Application.OpenForms["frmHastaneGirisEkrani"]  is null)
            {
                frmHastaneGirisEkrani frm = new frmHastaneGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            } else if(isim == "Hastaneler Listesi" && Application.OpenForms["frmHastanelerListesi"] is null)
            {
                f.HastaneListesi();
            //    frmHastanelerListesi frm = new frmHastanelerListesi();
            //    frm.MdiParent = Form.ActiveForm;
            //    frm.Show();
            }
           
            else if (isim == "Doktor Bilgi Giris Ekrani" && Application.OpenForms["frmDoktorGirisEkrani"] is null)
            {
            frmDoktorGirisEkrani frm = new frmDoktorGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Doktorlar Listesi" && Application.OpenForms["frmDoktorlarListesi"] is null)
            {
                f.DoktorlarListesi();
                //frmDoktorlarListesi frm = new frmDoktorlarListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
            }
            else if (isim == "Personel Bilgi Giris Ekrani" && Application.OpenForms["frmPersonelGirisEkrani"] is null)
            {
                frmPersonelGirisEkrani frm = new frmPersonelGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Personeller Listesi" && Application.OpenForms["frmPersonellerListesi"] is null)
            {
                f.PersonellerListesi();
                //frmPersonellerListesi frm = new frmPersonellerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
            }
            else if (isim == "Firma Bilgi Giris Ekrani" && Application.OpenForms["frmFirmaGiris"] is null)
            {
                frmFirmaGiris frm = new frmFirmaGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Firmalar Listesi" && Application.OpenForms["frmFirmalarListesi"] is null)
            {
                f.FirmalarListesi();
                //    frmFirmalarListesi frm = new frmFirmalarListesi();
                //    frm.MdiParent = Form.ActiveForm;
                //    frm.Show();
            }
        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            lblMenuText.Text = btnBilgiGiris.Text;
            TvGorunum();
            tvUrunIslemleri.Visible = true;

        }

        private void tvUrunIslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if (tvUrunIslemleri.SelectedNode != null)
            {
                isim = tvUrunIslemleri.SelectedNode.Text;
            }
            //string isim =tvBilgiGirisİslemleri.SelectedNode !=null ?  //eğer selected node gelmıyorsa //boşsa isine tırnak koy hata veriyor sonra
            //    tvBilgiGirisİslemleri.SelectedNode.Text : ""; //seçilen node nın ismi alınıyor
            if (isim == "Ürün Bilgi Giris Ekrani" && Application.OpenForms["frmFirmaGiris"] is null)
            {
                UrunGirisSistemi frm = new UrunGirisSistemi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Ürünler Listesi" && Application.OpenForms["frmFirmalarListesi"] is null)
            {
                frmUrunListe frm = new frmUrunListe();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }

        private void tvDepoIslemleri_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvDepoIslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if (tvDepoIslemleri.SelectedNode != null)
            {
                isim = tvDepoIslemleri.SelectedNode.Text;
            }
            //string isim =tvBilgiGirisİslemleri.SelectedNode !=null ?  //eğer selected node gelmıyorsa //boşsa isine tırnak koy hata veriyor sonra
            //    tvBilgiGirisİslemleri.SelectedNode.Text : ""; //seçilen node nın ismi alınıyor
            if (isim == "Stok Giris Listesi" && Application.OpenForms["frmStokListesi"] is null)
            {
                frmStokListesi frm = new frmStokListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Depo Stok Giris" && Application.OpenForms["frmStokGiris"] is null)
            {
                frmStokGiris frm = new frmStokGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

        }

        private void btnDepoIslemleri_Click(object sender, EventArgs e)
        {
            lblMenuText.Text = btnDepoIslemleri.Text;
            TvGorunum();
            tvDepoIslemleri.Visible = true;
        }
    }
}
