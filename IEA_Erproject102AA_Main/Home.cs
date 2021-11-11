using IEA_Erproject102AA_Main.BilgiGirisİslemleri.Doktorlar;
using IEA_Erproject102AA_Main.BilgiGirisİslemleri.Hastaneler;
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
            tv2.Visible = false;
            tv3.Visible = false;
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
                frmHastanelerListesi frm = new frmHastanelerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
           
            else if (isim == "Doktor Bilgi Giris Ekrani" && Application.OpenForms["frmDoktorGirisEkrani"] is null)
            {
            frmDoktorGirisEkrani frm = new frmDoktorGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Doktorlar Listesi" && Application.OpenForms["frmDoktorlarListesi"] is null)
            {
                frmDoktorlarListesi frm = new frmDoktorlarListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }
    }
}
