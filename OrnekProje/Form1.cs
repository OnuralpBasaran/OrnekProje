using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrnekProje
{
    public partial class FrmStokEkstre : Form
    {
        public FrmStokEkstre()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {

                int baslangicTarih = 0;
                int bitisTarihi = 0;
                string malKodu = "";

                if ((txtBaslangicTarih.Text != "" && txtBitisTarih.Text != "") || txtMalKodu.Text != "")
                {
                    if (txtBaslangicTarih.Text != "")
                        baslangicTarih = Convert.ToInt32(Convert.ToDateTime(txtBaslangicTarih.Text).ToOADate());

                    if (txtBitisTarih.Text != "")
                        bitisTarihi = Convert.ToInt32(Convert.ToDateTime(txtBitisTarih.Text).ToOADate());

                    malKodu = txtMalKodu.Text;
                }
                else
                {
                    MessageBox.Show("Lütfen Başlangıç Ve Bitiş Tarihlerini Giriniz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu.");
            }
        }
    }
}
