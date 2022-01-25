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

namespace IEA_Erproject102AA_Main.DepoIslemleri.StokIslemleri
{
    
    public partial class frmStokListesi : Form
    {
        public bool Secim = false;
        private ErpProject102Entities erp = new ErpProject102Entities();
        private frmStokGiris frm = new frmStokGiris();
        private int secimId;
       
        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear(); // temizleyip yeniden oluştursun


            /*/ var lst = (from s in erp.tblStokGirisUst
                        where s.isActive == true

                        select new
                        {
                            id = s.Id,
                            genelno = s.GenelNo,
                            cariadi = s.CariAdiId,
                            faturano = s.FaturaNo,
                            faturatarihi = s.FaturaTarihi,
                            giristipi = s.GirisTipi,

                        }).ToList();*/ //new ihtayç  kadar çekmek için bunları form ekranında bize gözükecek yer kadar yaptık
            /* var lst1 = (from s in erp.vwStokGiris
                         where s.isActive == true
                         select s).Distinct().ToList();*/

            int i = 0, sira = 1;
            var lst = (from s in erp.tblStokGirisUst
                       where s.isActive == true
                       select s).ToList();
             

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.GenelNo;
                Liste.Rows[i].Cells[2].Value = k.tblCariler.CariAdi;
                Liste.Rows[i].Cells[3].Value = k.FaturaNo;
                Liste.Rows[i].Cells[4].Value = k.FaturaTarih;
                Liste.Rows[i].Cells[5].Value = k.GirisTipi;

                i++; sira++;
            }
            Liste.AllowUserToAddRows = false;
            //Liste.ReadOnly = true;
            //Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

       

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Secim)
            {
                Home.Aktarma = secimId;
                Close();
            }

        }

        private void pnlUst_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
