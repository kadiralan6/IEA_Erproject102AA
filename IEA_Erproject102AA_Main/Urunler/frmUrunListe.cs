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

namespace IEA_Erproject102AA_Main.Urunler
{
    public partial class frmUrunListe : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;
        public frmUrunListe()
        {
            InitializeComponent();
        }

        private void frmUrunListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

       
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblUrunler1
                       where s.isActive == true
                       select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.UrunGenelNo;
                Liste.Rows[i].Cells[3].Value = k.UrunKodu;
                Liste.Rows[i].Cells[4].Value = k.UrunAdi;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblUrunKodu.Text = n.UrunGenelKodu();
            //txtKayitBul.Text = n.UrunGenelKodu();
        }
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Application.OpenForms["UrunGirisSistemi"] != null)
            {
                UrunGirisSistemi frm = Application.OpenForms["UrunGirisSistemi"] as UrunGirisSistemi;
                frm.Ac(secimId);
                Close();
            }
            else
            {
                UrunGirisSistemi frm = new UrunGirisSistemi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
            }
        }
    }
}
