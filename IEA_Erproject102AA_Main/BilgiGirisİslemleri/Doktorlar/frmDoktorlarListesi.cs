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

namespace IEA_Erproject102AA_Main.BilgiGirisİslemleri.Doktorlar
{
    public partial class frmDoktorlarListesi : Form
    {
        public bool Secim = false;
        private ErpProject102Entities erp = new ErpProject102Entities();
        frmHastaneGirisEkrani frm = new frmHastaneGirisEkrani();
        private int secimId;
        public frmDoktorlarListesi()
        {
            InitializeComponent();
        }

        private void frmDoktorlarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            PerListBilgi.Rows.Clear();
            // HastListeBilgi.Rows.Clear(); // temizleyip yeniden oluştursun
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
                PerListBilgi.Rows.Add();
                PerListBilgi.Rows[i].Cells[0].Value = k.id;
                PerListBilgi.Rows[i].Cells[1].Value = sira;
                PerListBilgi.Rows[i].Cells[2].Value = k.Dkodu;
                PerListBilgi.Rows[i].Cells[3].Value = k.Dadi;
                PerListBilgi.Rows[i].Cells[4].Value = k.Dtel;
                PerListBilgi.Rows[i].Cells[5].Value = k.Dmail;           

                i++; sira++;
            }
            PerListBilgi.AllowUserToAddRows = false;
            PerListBilgi.ReadOnly = true;
            PerListBilgi.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // bu nedir Veriye tıklandığında satır seçimi sağlama.

        }

        private void DoktListBilgi_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)PerListBilgi.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Secim && Application.OpenForms["frmDoktorGirisEkrani"] == null)
            {
                //frmDoktorGirisEkrani frm = new frmDoktorGirisEkrani();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmDoktorGirisEkrani"] != null)
            {
                frmDoktorGirisEkrani frm = Application.OpenForms["frmDoktorGirisEkrani"] as frmDoktorGirisEkrani;
                frm.Ac(secimId); //girişekranindanki ni public yaptık
                Close();
            }
        }

        private void DoktListBilgi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
