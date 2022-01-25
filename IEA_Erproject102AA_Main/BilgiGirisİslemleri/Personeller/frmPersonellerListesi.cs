using IEA_Erproject102AA_Main.BilgiGirisİslemleri.Hastaneler;
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

namespace IEA_Erproject102AA_Main.BilgiGirisİslemleri.Personeller
{
    public partial class frmPersonellerListesi : Form
    {
        public bool Secim = false;
        private ErpProject102Entities erp = new ErpProject102Entities();
        frmPersonelGirisEkrani frm = new frmPersonelGirisEkrani();
        private int secimId;
        public frmPersonellerListesi()
        {
            InitializeComponent();
        }
        private void frmPersonellerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
  
        private void Listele()
        {
                PerListBilgi.Rows.Clear();
                // HastListeBilgi.Rows.Clear(); // temizleyip yeniden oluştursun
                int i = 0, sira = 1;

            var lst = (from s in erp.tblPersonelDetay
                       where s.tblCariler.isActive == true
                       where s.tblCariler.CariGrupId == 4
                       select new
                       {
                           id = s.Id,
                           dkodu = s.tblCariler.CariKodu,
                           dadi = s.tblCariler.CariAdi,
                           dtel = s.tblCariler.CariTel,
                           dmail = s.tblCariler.CariMail,
                           dyetcep = s.tblCariler.YetkiliCep1,
                           dgtarih = s.IsBasiTarih,
                           dbtarih = s.IsBitisTarih


                       }).ToList(); //new ihtayç  kadar çekmek için bunları form ekranında bize gözükecek yer kadar yaptık

                foreach (var k in lst)
                {
                PerListBilgi.Rows.Add();
                PerListBilgi.Rows[i].Cells[0].Value = k.id;
                PerListBilgi.Rows[i].Cells[1].Value = sira;
                PerListBilgi.Rows[i].Cells[2].Value = k.dkodu;
                PerListBilgi.Rows[i].Cells[3].Value = k.dadi;
                PerListBilgi.Rows[i].Cells[4].Value = k.dtel;
                PerListBilgi.Rows[i].Cells[5].Value = k.dyetcep;
                PerListBilgi.Rows[i].Cells[6].Value = k.dmail;
                PerListBilgi.Rows[i].Cells[7].Value = k.dgtarih;
                PerListBilgi.Rows[i].Cells[8].Value = k.dbtarih;

                i++; sira++;
                }
                PerListBilgi.AllowUserToAddRows = false;
                PerListBilgi.ReadOnly = true;
                PerListBilgi.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // bu nedir Veriye tıklandığında satır seçimi sağlama.

        }

        private void DoktListBilgi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                
            
        }

        private void PerListBilgi_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)PerListBilgi.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Secim && Application.OpenForms["frmPersonellerGirisEkrani"] == null)
            {
                //frmPersonelGirisEkrani frm = new frmPersonelGirisEkrani();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmPersonellerGirisEkrani"] != null)
            {
                frmPersonelGirisEkrani frm = Application.OpenForms["frmPersonellerGirisEkrani"] as frmPersonelGirisEkrani;
                frm.Ac(secimId); //girişekranindanki ni public yaptık
                Close();
            }
        }

        private void PerListBilgi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
