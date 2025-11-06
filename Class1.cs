using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        private string ogrNo;
        private string ogrAd;
        private string ogrSoyad;
        private int sinif;


        public string ogrno
        {
            get
            {
                return ogrNo;
            }
            set
            {
                if (value.Length == 10)
                {
                    ogrno = value;
                    sinif=26-Convert.ToInt32(ogrNo.Substring(0, 2));
                }
                else
                {
                    ogrno = "2211012001";
                    sinif = 26 - Convert.ToInt32(ogrNo.Substring(0, 2));
                }
            }
        }



        public string ograd
        {
            get
            {
                return ogrAd;
            }
            set
            {
                ogrAd = value;
            }
        }

        public string ogrsoyad
        {
            get
            {
                return ogrSoyad;
            }
            set
            {
                ogrSoyad = value;
            }
        }

        public int Sinif
        {
            get
            {
                return sinif;
            }
        }

    }
}
