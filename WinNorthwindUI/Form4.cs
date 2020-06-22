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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var ilkUcNumara = numbers.Take(3);

            foreach (var item in ilkUcNumara)
            {
                listBox1.Items.Add(item);
            }
        }

        NorthwindEntities db = new NorthwindEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            //ilk 3 urunu Getiriniz
            var plist = (from x in db.Products
                        select x).Take(3);

            foreach (var item in plist)
            {
                listBox1.Items.Add(item.UnitPrice + " " + item.ProductName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ilk 4 u atla devam 
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numaralar = numbers.Skip(4);

            foreach (var item in numaralar)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
    }
}
