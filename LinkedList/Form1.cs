using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LinkedList.BagliListe;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        BagliListe FirstList = new BagliListe();

        private void Form1_Load(object sender, EventArgs e)
        {
            //ilk elamndan önce,onu göstericek bir eleman olmadığından ilk elamn için hafızada yer açtık ve head'in onu göstermesini sağladık
            FirstList.head = new Eleman("a");           
        }

        int i = 1;
        public void btnEkle_Click(object sender, EventArgs e)
        {
            i++;
            char karakter = Convert.ToChar(96+i);


            //ilk elemanı gösteren bir referans oluşturuduk
            Eleman c = FirstList.head;

            //gösterininin next'i null ise yani sona gelinmiş ise referansı son elamın referansı yaptık
            while (c.next!=null)
            {
                c = c.next;
            }

            //bu son elemnadan sonrakine yeni bir eleman ekledik
            c.next = new Eleman(karakter.ToString());

            //eklenen elemının sonraki elemana null atadık 
            c.next.next = null;

            //elemanları yazdırma metodu çağırdık
            Print();
        }

        public void Print()
        {
            lstElemanlar.Items.Clear();

            //bir referans oluşturduk ve head' referanssinin değerini verdik
            Eleman e = FirstList.head;

            //son elemana gelene kadar yazdırma işlemi yaptırdık son elemanın null olduğunu biliyoruz
            while (e!=null)
            {
                lstElemanlar.Items.Add(e.data + " ");
                e = e.next;
            }
        }

        private void btnTersCevir_Click(object sender, EventArgs e)
        {
            //boş bir refrans oluşturduk
            Eleman previous = null;

            //bir referans daha oluşturduk ve ilk elemanın referansını ona atadık
            Eleman current = FirstList.head;

            //yer değiştirme işlemleri
            while (current !=null)
            {
                //geçici bir referans daha oluşturduk ve sonraki elemanın referansını verdik
                Eleman temp = current.next;

                //önceki elemanın referansını sonraki elemana verdik
                current.next = previous;

                // önceki elamanın referansına eleman referansını atadık
                previous = current;

                //eleman referansı geçi referans olmuş oldu
                current = temp;
            }

            //ilk referans artık en sondaki eleman refrans ediyor
            FirstList.head = previous;

            Print();
        }
    }
}
