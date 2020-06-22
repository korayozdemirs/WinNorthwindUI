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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //5 Den Küçük Numaralar
            int[] numaralar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numaraListesi = from x in numaralar
                                where x < 5
                                select x;

            foreach (var item in numaraListesi)
            {
                listBox1.Items.Add(item);
            }
        }

        NorthwindEntities db = new NorthwindEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            //Stock miktarı 20 den az olanlar
            var plist = from x in db.Products
                        where x.UnitsInStock < 20
                        select new { x.ProductName, x.UnitsInStock };

            foreach (var product in plist)
            {
                listBox1.Items.Add(product.ProductName + product.UnitsInStock);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Urunlerin Fiyatın 20 30 arası olanlar
            var plist = from x in db.Products
                        where x.UnitPrice > 20 && x.UnitPrice < 30
                        select new { x.ProductName, x.UnitPrice };

            foreach (var product in plist)
            {
                listBox1.Items.Add(product.ProductName + product.UnitPrice);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Beverages Kategorisindeki Urunler (ID = 1)
            var plist = from x in db.Products
                        where x.CategoryID == 1
                        select x;

            foreach (var item in plist)
            {
                listBox1.Items.Add(item.ProductName);
            }
        }
    }
}
