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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kaç Tane Sayı Var (Farklı)
            int[] sayilar = { 2, 2, 3, 5, 5 };

            var result = sayilar.Distinct().Count();
            MessageBox.Show(result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2 ye göre Modu 1 olan sayıların sayısı
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var sonuc = numbers.Count(z => z % 2 == 1);

            MessageBox.Show(sonuc.ToString());

        }
    }
}
