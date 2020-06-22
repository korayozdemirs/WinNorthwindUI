using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numaraArttirGoster = from x in numbers
                                     select x + 1;

            foreach (var item in numaraArttirGoster)
            {
                listBox1.Items.Add(item);
            }
        }

        NorthwindEntities db = new NorthwindEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            List<Product> productList = (from x in db.Products
                                         select x).ToList();

            var productName = from p in productList
                              select p.ProductName;

            foreach (var item in productName)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var NumaraDeger = from x in numbers
                              select strings[x];

            foreach (var item in NumaraDeger)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var BuyukKucukHarf = from x in words
                                 select new { Upper = x.ToUpper(), Lower = x.ToLower() };
            foreach (var item in BuyukKucukHarf)
            {

                string format = string.Format("Buyuk Hali = {0} , Kucuk Hali = {1}", item.Upper, item.Lower);
                listBox1.Items.Add(format);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Kategorilerin adnın Id lerini acıklamalarını getırınız.
            var KategoriListe = from x in db.Categories
                                select new
                                {
                                    KategoriAdi = x.CategoryName,
                                    ID = x.CategoryID,
                                    Aciklama = x.Description
                                };

            foreach (var item in KategoriListe)
            {
                listBox1.Items.Add(item.KategoriAdi + " " + item.Aciklama + " " + item.ID);
            }

        }
    }
}
