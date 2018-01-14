using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

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
            //Connection String windows authentication olarak oluşturuldu.
            string connString = "Server=.;Database=Test;Trusted_Connection=True;";
            
            //Yeni bir connection oluşturulup connection string olarak yukardaki değişken atandı.
            SqlConnection conn = new SqlConnection(connString);

            //Yeni Bir sql command oluşturulup değerleri ilerleyen satırlarda doldurulmuştur.
            SqlCommand cmd = new SqlCommand();

            try
            {

                int baslangicTarih = 0;
                int bitisTarihi = 0;
                string malKodu = "";

                // Başlangıç ve bitiş tarihi seçilip malkodu veya adı seçilmeme durumu ve tarihlerin seçilmeyip sadece mal kodu veya adı seçilmesi yine aynı alanda kontrol edilir.
                if ((txtBaslangicTarih.Text != "" && txtBitisTarih.Text != "") || txtMalKodu.Text != "")
                {
                    //bu alan eğer txtbaslangicTarihi boş değilse önce datetime daha sonra int değerine dönüştürülür.
                    if (txtBaslangicTarih.Text != "")
                        baslangicTarih = Convert.ToInt32(Convert.ToDateTime(txtBaslangicTarih.Text).ToOADate());

                    //bu alan eğer txtBitisTarih boş değilse önce datetime daha sonra int değerine dönüştürülür.
                    if (txtBitisTarih.Text != "")
                        bitisTarihi = Convert.ToInt32(Convert.ToDateTime(txtBitisTarih.Text).ToOADate());

                    malKodu = txtMalKodu.Text;


                    DataTable dt = new DataTable();

                    //Yukarıda oluşturduğumuz commandı özelliklerini ve stored procedure ismini vermekteyiz.
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_StokEkstre";

                    //Bu if bie connection açıkmı değilmi kontrol ediyor kapalıysa yeni bir connection oluşturmaktadır.
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    //Stored Procedure Icın gerekli olan paremetreleri buarada doldurulmaktadır.
                    cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarih);
                    cmd.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);
                    cmd.Parameters.AddWithValue("@MalKodu", malKodu);
                    cmd.Parameters.AddWithValue("@MalAdi", malKodu);

                    
                  
                    //Data table (dt) yi dataadapter ile doldurup devexpress gridview a datasource olarak verilmektedir.
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    grdCtrEkstre.DataSource = dt;
                    
                }
                else
                {
                    MessageBox.Show("Lütfen Başlangıç Ve Bitiş Tarihlerini Giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu.");
            }
            finally
            {
                //Bu işlemlerde en sonunda hata olsa da olmasda yapılcak şeilde oluşturulmuştur.
                //Burada connection kapatılıp silinmektedir.
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
