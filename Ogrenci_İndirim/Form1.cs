using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_İndirim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double fiyat, kdv, tutar;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            fiyat = Convert.ToDouble(txtFiyat.Text);
            kdv = Convert.ToDouble(txtKdv.Text);
     
            kdv = kdv/100;

            tutar = fiyat + (fiyat * kdv);

            txtTutar.Text = tutar.ToString();
            checkBox1.Enabled = checkBox1.Checked;
            tutar = tutar * 0.95;
            txtTutar.Text = tutar.ToString();

        }

        
    }
}
