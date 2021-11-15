using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxyForm_P5_003
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Angka1 = Convert.ToInt32(textBox1.Text);
            int Angka2 = Convert.ToInt32(textBox2.Text);

            double hasilPenjumlahan = object.Tambah(Angka1, Angka1);
            double hasilPengurangan = object.Kurang(Angka1, Angka1);
            double hasilPerkalian = object.Kali(Angka1, Angka1);
            double hasilPembagian = object.Bagi(Angka1, Angka1);

            labelPenjumlahan.Text = hasilPenjumlahan.ToString();
            labelPengurangan.Text = hasilPengurangan.ToString();
            labelPerkalian.Text = hasilPerkalian.ToString();
            labelPembagian.Text = hasilPembagian.ToString();

        }
    }
}
