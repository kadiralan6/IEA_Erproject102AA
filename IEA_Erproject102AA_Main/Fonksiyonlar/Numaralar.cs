using IEA_Erproject102AA_Main.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_Erproject102AA_Main.Fonksiyonlar
{
  
    class Numaralar
    {
        readonly ErpProject102Entities erp = new ErpProject102Entities();

        public string CariKoduHastane()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id; //buraya bak
                numara++; 
                string num ="H"+ numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {

                return "H00000001";
            }

        }
        public string CariKoduDoktor()
        {
            try
            {
                var numara = (from s in erp.tblCariler   orderby s.Id descending select s).First().Id; //buraya bak
                numara++;
                string num = "D" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {

                return "D00000001";
            }

        }

        public string CariKoduPersonel()
        {
            try
            {
                var numara = (from s in erp.tblCariler  orderby s.Id descending select s).First().Id; //buraya bak
                numara++;
                string num = "P" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {

                return "P00000001";
            }

        }
        public string CariKoduFirmalar()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id; //buraya bak
                numara++;
                string num = "F" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {

                return "F00000001";
            }

        }
        public string UrunGenelKodu()
        {
            try
            {
                var numara = (from s in erp.tblUrunler1 orderby s.Id descending select s).First().Id; //buraya bak
                numara++;
                string num = "U" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {

                return "U00000001";
            }

        }
        public string StokGenelKodu()
        {
            try
            {
                var numara = (from s in erp.tblStokGirisUst orderby s.Id descending select s).First().Id; //buraya bak
                numara++;
                string num =  numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {

                return "00000001";
            }

        }
    }
}
