using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinNorthwindUI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedList = from x in words
                             orderby x
                             select x;
            foreach (var item in sortedList)
            {
                listBox1.Items.Add(item);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedList = from x in words
                             orderby x.Length ascending
                             select x;
            foreach (var item in sortedList)
            {
                listBox1.Items.Add(item);
            }
        }
        NorthwindEntities db = new NorthwindEntities();
        private void button3_Click(object sender, EventArgs e)
        {
            //Urunleri fiyatlarına gore sıralıyın adı fiyatı gorunuecek

            var urunListesi = from x in db.Products
                              orderby x.UnitPrice
                              select new { UrunAdi = x.ProductName, Fiyat = x.UnitPrice };
            foreach (var item in urunListesi)
            {
                listBox1.Items.Add(item.Fiyat + " " + item.UrunAdi);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = from x in words
            //                  orderby x
            //                  select x;

            var sortedWords = words.OrderBy(z => z, new BoyukGucukBakma());

            foreach (var item in sortedWords)
            {
                listBox1.Items.Add(item);
            }
        }

        public class BoyukGucukBakma : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
