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
    public partial class OgrenciEkle : Form
    {
        public UserSettingcs userSettingcs;
        public const string connectionString = "Server=DESKTOP-P37DUPU;Database=dapperDatabase;User Id=sa; Password=12345;";
        SqlConnection connection;
        public OgrenciEkle()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            userSettingcs = new UserSettingcs();
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            string fontBoyutu = userSettingcs.VeriOku("program_settings", "FontBoyutu");

            if (!String.IsNullOrEmpty(fontBoyutu))
            {
                this.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), Convert.ToInt32(fontBoyutu));
            }
            else
            {

            }

            this.BackColor = Color.FromArgb(Convert.ToInt32(userSettingcs.VeriOku("program_settings", "ArkaplanRengi")));
            var fakulte = connection.Query<fakulte>("SELECT * FROM fakulte");
            comboBoxFakulteE.DataSource = fakulte;
            comboBoxFakulteE.DisplayMember = "fakulteAdi";
            comboBoxFakulteE.ValueMember = "fakulteId";

            var bolum = connection.Query<Bolum>("SELECT * FROM bolum WHERE fakulteId='" + (int)comboBoxFakulteE.SelectedValue + "'");
            comboBoxBolumE.DataSource = bolum;
            comboBoxBolumE.DisplayMember = "bolumAdi";
            comboBoxBolumE.ValueMember = "bolumId";
            
        }

        private void buttonOgrEkle_Click(object sender, EventArgs e)
        {
            string ogrAd = textBoxOgrAdE.Text;
            string ogrSoyad = textBoxOgrSoyadE.Text;
            string adres = textBoxAdresE.Text;
            int ogrNo = Convert.ToInt32(textBoxOgrNoE.Text);
            int kimlikNo = Convert.ToInt32(textBoxKimlikNoE.Text);
            int telefonNo = Convert.ToInt32(textBoxTlfNoE.Text);    
            int sinif = Convert.ToInt32(textBoxSinifE.Text);
            int bolumId = (int)comboBoxBolumE.SelectedValue;
            DateTime girisTarihi = dateTimePickerGtE.Value;
            DateTime dogumTarihi = dateTimePickerDtE.Value;
            int donem;
            if (radioButtonBE.Checked == true)
            {
                donem = 1;
            }
            else
            {
                donem = 0;
            }
            connection.Query("INSERT INTO ogrenci (ogrenciAdi, ogrenciSoyadi, kimlikNo, ogrenciNo, telefonNo, adres, donem, sinif, dogumTarihi, girisTarihi, bolumId ) VALUES ('" + ogrAd + "', '" + ogrSoyad + "', '" + kimlikNo + "', '" + ogrNo + "','" + telefonNo + "', '" + adres+ "','" + donem + "','" + sinif + "','" + dogumTarihi + "','" + girisTarihi + "','" + bolumId + "')");
            MessageBox.Show("Öğrenci Ekleniyor");
            this.Close();
        }

        private void comboBoxFakulteE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var bolum = connection.Query<Bolum>("SELECT * FROM bolum WHERE fakulteId='" + (int)comboBoxFakulteE.SelectedValue + "'");
            comboBoxBolumE.DataSource = bolum;
            comboBoxBolumE.DisplayMember = "bolumAdi";
            comboBoxBolumE.ValueMember = "bolumId";
        }
    }
}
