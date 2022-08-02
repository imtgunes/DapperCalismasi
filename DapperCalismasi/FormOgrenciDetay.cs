using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
namespace DapperCalismasi
{
    public partial class FormOgrenciDetay : Form
    {
        public UserSettingcs userSettingcs;
        public int ogrID;
        public const string connectionString = "Server=DESKTOP-P37DUPU;Database=dapperDatabase;User Id=sa; Password=12345;";
        SqlConnection connection;
        public FormOgrenciDetay(int ogrID)
        {
            InitializeComponent();
            this.ogrID = ogrID;
            connection = new SqlConnection(connectionString);
            userSettingcs = new UserSettingcs();
        }

        private void FormOgrenciDetay_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(userSettingcs.VeriOku("program_settings", "ArkaplanRengi")));

            string fontBoyutu = userSettingcs.VeriOku("program_settings", "FontBoyutu");

            if (!String.IsNullOrEmpty(fontBoyutu))
            {
                this.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), Convert.ToInt32(fontBoyutu));
            }
            else
            {
               
            }

            var ogrenciler = connection.Query<Ogrenci>("SELECT * FROM ogrenci WHERE ogrenciId='" + ogrID + "'");

            
            foreach (Ogrenci item in ogrenciler)
            {
                textBoxOgrAd.Text = item.ogrenciAdi.ToString();
                textBoxOgrSoyad.Text = item.ogrenciSoyadi.ToString();
                textBoxOgrKimlik.Text = item.kimlikNo.ToString();
                textBoxOgrNo.Text = item.ogrenciNo.ToString();
                textBoxOgrTlfn.Text = item.telefonNo.ToString();
                textBoxOgrAdres.Text = item.adres.ToString();
                textBoxOgrSinif.Text = item.sinif.ToString();
                if (item.donem == 1)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                dateTimePickerDt.Value = item.dogumTarihi;
                dateTimePickerGt.Value = item.girisTarihi;
            }
            var fakulte = connection.Query<fakulte>("SELECT * FROM fakulte");
            comboBoxFakulte.DataSource = fakulte;
            comboBoxFakulte.DisplayMember = "fakulteAdi";
            comboBoxFakulte.ValueMember = "fakulteId";

            var bolum = connection.Query<Bolum>("SELECT * FROM bolum WHERE fakulteId='" + (int)comboBoxFakulte.SelectedValue + "'");
            comboBoxBolum.DataSource = bolum;
            comboBoxBolum.DisplayMember = "bolumAdi";
            comboBoxBolum.ValueMember = "bolumId";
        }

        private void buttonOgrKaydet_Click(object sender, EventArgs e)
        {
            string ogrAd = textBoxOgrAd.Text;
            string ogrSoyad = textBoxOgrSoyad.Text;
            string adres = textBoxOgrAdres.Text;
            int ogrNo = Convert.ToInt32(textBoxOgrNo.Text);
            int kimlikNo = Convert.ToInt32(textBoxOgrKimlik.Text);
            int? telefonNumarası;
            int sinif = Convert.ToInt32(textBoxOgrSinif.Text);
            int bolumId = (int)comboBoxBolum.SelectedValue;
            DateTime girisTarihi = dateTimePickerGt.Value;
            DateTime dogumTarihi = dateTimePickerDt.Value;
            int donem;
            if (radioButton2.Checked == true)
            {
                donem = 1;
            }
            else
            {
                donem = 0;
            }

            if (!String.IsNullOrEmpty(textBoxOgrTlfn.Text))
            {
                telefonNumarası = Convert.ToInt32(textBoxOgrTlfn.Text);
            }
            else
            {
                telefonNumarası = null;
            }

            connection.Query("UPDATE ogrenci  SET ogrenciAdi = '" + ogrAd + "', ogrenciSoyadi = '" + ogrSoyad + "', kimlikNo = '" + kimlikNo + "', ogrenciNo = '" + ogrNo + "', telefonNo = '" + telefonNumarası + "', adres = '" + adres + "', donem = '" + donem + "', sinif = '" + sinif + "' , dogumTarihi = '" + dogumTarihi + "', girisTarihi = '" + girisTarihi + "', bolumId = '" + bolumId + "' WHERE ogrenciId='" + ogrID + "'");
            
            this.Close();
        }

        private void buttonVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOgrSil_Click(object sender, EventArgs e)
        {
            connection.Query("DELETE FROM ogrenci WHERE ogrenciId='" + ogrID + "'");
            MessageBox.Show("Öğrenci silindi");
            this.Close();
        }

        private void comboBoxFakulte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var bolum = connection.Query<Bolum>("SELECT * FROM bolum WHERE fakulteId='" + (int)comboBoxFakulte.SelectedValue + "'");
            comboBoxBolum.DataSource = bolum;
            comboBoxBolum.DisplayMember = "bolumAdi";
            comboBoxBolum.ValueMember = "bolumId";
        }
    }
}
