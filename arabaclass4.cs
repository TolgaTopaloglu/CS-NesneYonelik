/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneyeyonelikConsoleApp1
{
    internal class arabaclass4
    {
        public string marka;
        public string model;
        private int yas;

        //10 yaşından daha az yaslı arabları yasını 0 olarak al 
        public int Yas{
            get{
                return yas;
            }
            set
            {
                if (value <= 10)
                {
                    yas = 0;
                }
                else
                {
                    yas = value;
                }
            }
        }

        public void gazaBas()
        {
            Console.WriteLine("gaza basıldı");
        }
        

    }
}
   */