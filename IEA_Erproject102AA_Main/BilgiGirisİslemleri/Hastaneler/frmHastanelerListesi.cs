using IEA_Erproject102AA_Main.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_Erproject102AA_Main.BilgiGirisİslemleri.Hastaneler
{
   // private ErpProject102Entities erp = new ErpProject102Entities();
    public partial class frmHastanelerListesi : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        frmHastaneGirisEkrani frm = new frmHastaneGirisEkrani();
        private int secimId;
        public frmHastanelerListesi()
        {

            InitializeComponent();
        }
        private void frmHastanelerListesi_Load(object sender, EventArgs e)
        {
           // ComboDoldur();
            Listele();
        }



        private void Listele()
        {
            HastListeBilgi.Rows.Clear();
            // HastListeBilgi.Rows.Clear(); // temizleyip yeniden oluştursun
            int i = 0, sira = 1;

            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGrupId==1
                       select new
                       {
                           id = s.Id,
                           hkodu = s.CariKodu,
                           hadi = s.CariAdi,
                           htel = s.CariTel,
                           hmail = s.CariMail,
                           hyet = s.YetkiliAdi1
                       }).ToList(); //new ihtayç  kadar çekmek için bunları form ekranında bize gözükecek yer kadar yaptık

            foreach (var k in lst)
            {
                HastListeBilgi.Rows.Add();
                HastListeBilgi.Rows[i].Cells[0].Value = k.id;
                HastListeBilgi.Rows[i].Cells[1].Value = sira;
                HastListeBilgi.Rows[i].Cells[2].Value = k.hkodu;
                HastListeBilgi.Rows[i].Cells[3].Value = k.hadi;
                HastListeBilgi.Rows[i].Cells[4].Value = k.htel;
                HastListeBilgi.Rows[i].Cells[5].Value = k.hmail;
                HastListeBilgi.Rows[i].Cells[6].Value = k.hyet;
               
                i++; sira++;
            }
           HastListeBilgi.AllowUserToAddRows = false;
           HastListeBilgi.ReadOnly = true;
            HastListeBilgi.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // bu nedir Veriye tıklandığında satır seçimi sağlama.
           
        }
       

        private void HastListeBilgi_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)HastListeBilgi.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 || Application.OpenForms["frmHastaneGirisEkrani"] == null)
            {
                frmHastaneGirisEkrani frm = new frmHastaneGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
                Close();
            }
            else if(Application.OpenForms["frmHastaneGirisEkrani"] != null)
            {
                frmHastaneGirisEkrani frm = Application.OpenForms["frmHastaneGirisEkrani"] as frmHastaneGirisEkrani;
                frm.Ac(secimId); //girişekranindanki ni public yaptık
                Close();
            }

            
        }

        private void HastListeBilgi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
