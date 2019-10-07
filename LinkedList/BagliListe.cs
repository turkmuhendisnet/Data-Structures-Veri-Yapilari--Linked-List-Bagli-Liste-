using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public class BagliListe
    {
        //ilk elemanın referanssi
       public Eleman head;

        public class Eleman
        {
            //elemanın verisi
            public string data { get; set; }

            //sonraki elemanın referansi
            public Eleman next { get; set; }

            //elemanın ilk değerlerinin constructor ile atanması
            public Eleman(string d)
            {
                data = d;
                next = null;
            }
        }
    }
}
