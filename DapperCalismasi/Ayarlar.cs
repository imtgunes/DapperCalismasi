using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperCalismasi
{
    public partial class Ayarlar : Form
    {
        public UserSettingcs userSettingcs;
        public Ayarlar()
        {
            InitializeComponent();
            userSettingcs = new UserSettingcs();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            this.BackColor =  Color.FromArgb(Convert.ToInt32(userSettingcs.VeriOku("program_settings", "ArkaplanRengi")));

            //MessageBox.Show(userSettingcs.VeriYaz("Kategori", "Anahtar1", "deneme") ? "İni dosyasına yazıldı" : "İni dosyasına yazılamadı");
        }

        private void buttonKydtAyarlar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxFontAyarlar.Text))
            {
                /*Properties.Settings.Default.FontBoyutu = Convert.ToInt32(textBoxFontAyarlar.Text);
                Properties.Settings.Default.Save();*/
                userSettingcs.VeriYaz("program_settings", "FontBoyutu", textBoxFontAyarlar.Text);
            }

            this.Close();
        }

        private void buttonArkaPlan_Click(object sender, EventArgs e)
        {
            
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            userSettingcs.VeriYaz("program_settings", "ArkaplanRengi", colorDialog.Color.ToArgb().ToString());
            this.BackColor = Color.FromArgb(Convert.ToInt32(userSettingcs.VeriOku("program_settings", "ArkaplanRengi")));
            /*Properties.Settings.Default.ArkaPlanRengi = colorDialog.Color;
            Properties.Settings.Default.Save();
            this.BackColor = Properties.Settings.Default.ArkaPlanRengi;*/
        }
    }
}
