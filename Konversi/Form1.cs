using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerbilangLibrary;

namespace Konversi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void btn_konversi_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(InputNominal.Text);
            Terbilang terbilang = new Terbilang();

            HasilKonversi.Items.Clear();
            HasilKonversi.Items.Add(terbilang.TerbilangIndonesia(nominal));
        }
    }
}
