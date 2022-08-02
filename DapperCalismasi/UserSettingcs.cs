using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DapperCalismasi
{
    public class UserSettingcs
    {
        static string dizinYolu = "C:\\Proje";
        static string dosyaAdi = "C:\\Proje\\ayarlar.ini";


        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool WritePrivateProfileString(string kategori, string anahtar, string deger, string dosyaAdi);


        [DllImport("kernel32.dll")]
        static extern uint GetPrivateProfileString(string kategori, string anahtar, string lpDefault, StringBuilder sb, int sbKapasite, string dosyaAdi);

        public bool VeriYaz(string kategori, string anahtar, string deger)
        {
            if (!Directory.Exists(dizinYolu)) 
                Directory.CreateDirectory(dizinYolu);

            return WritePrivateProfileString(kategori, anahtar, deger, dosyaAdi);
        }

        public string VeriOku(string kategori, string anahtar)
        {
            
            StringBuilder sb = new StringBuilder(500);

            GetPrivateProfileString(kategori, anahtar, "", sb, sb.Capacity, dosyaAdi);

            string veri = sb.ToString();
            sb.Clear();
            return veri;
        }
    }
}
