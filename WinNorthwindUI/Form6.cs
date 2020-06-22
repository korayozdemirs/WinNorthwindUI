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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            var yazigrup = from x in words
                           group x by x[0] into g
                           select new { IlkBulunan = g.Key, Karsiti = g };


            foreach (var item in yazigrup)
            {
                listBox1.Items.Add(item.IlkBulunan);
                foreach (var item1 in item.Karsiti)
                {
                    listBox1.Items.Add(item1);
                }
            }

        }

        NorthwindEntities db = new NorthwindEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            //Urunleri kategorilerine gore gruplayın
            var plist = from x in db.Products
                        group x by x.CategoryID into y
                        select new { CategoryID_ = y.Key, Product_ = y };

            foreach (var item in plist)
            {
                listBox1.Items.Add(item.CategoryID_);
                foreach (var item1 in item.Product_)
                {
                    listBox1.Items.Add(item1.ProductName);

                }
            }
        }
    }
}
