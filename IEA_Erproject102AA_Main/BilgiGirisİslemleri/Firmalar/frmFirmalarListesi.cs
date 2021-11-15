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

namespace IEA_Erproject102AA_Main.BilgiGirisİslemleri.Firmalar
{
    public partial class frmFirmalarListesi : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        frmFirmaGiris frm = new frmFirmaGiris();
        private int secimId;
        public frmFirmalarListesi()
        {
            InitializeComponent();
        }
        private void frmFirmalarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 || Application.OpenForms["frmFirmaGiris"] == null)
            {
                frmFirmaGiris frm = new frmFirmaGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
                Close();
            }
            else if (Application.OpenForms["frmFirmaGiris"] != null)
            {
                frmFirmaGiris frm = Application.OpenForms["frmFirmaGiris"] as frmFirmaGiris;
                frm.Ac(secimId); //girişekranindanki ni public yaptık
                Close();
            }
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
            
        }


    }
}
