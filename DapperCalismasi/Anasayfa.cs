using Dapper;
using System.Data.SqlClient;
namespace DapperCalismasi
{
    public partial class Anasayfa : System.Windows.Forms.Form
    {
        public UserSettingcs userSettingcs;
        public int counter;
        public const string connectionString = "Server=DESKTOP-P37DUPU;Database=dapperDatabase;User Id=sa; Password=12345;";
        SqlConnection connection;
        public Anasayfa()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            userSettingcs = new UserSettingcs();
        }

        private async void Anasayfa_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(userSettingcs.VeriOku("program_settings", "ArkaplanRengi")));

            var ogrenciler = await connection.QueryAsync<Ogrenci>("SELECT * FROM ogrenci");
            
            dataGridViewOgr.DataSource = ogrenciler;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridViewOgr.Columns.Add(btn);
            btn.HeaderText = "Sil";
            btn.Text = "Sil";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnGuncelle = new DataGridViewButtonColumn();
            dataGridViewOgr.Columns.Add(btnGuncelle);
            btnGuncelle.HeaderText = "Guncelle";
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.UseColumnTextForButtonValue = true;


            var bolumler = await connection.QueryAsync<Bolum>("SELECT * FROM bolum");

            dataGridViewBolumler.DataSource = bolumler;

            var fakulteler = await connection.QueryAsync<fakulte>("SELECT * FROM fakulte");

            dataGridViewFakulteler.DataSource = fakulteler;


            this.dataGridViewBolumler.Columns["fakulte"].Visible = false;
            this.dataGridViewBolumler.Columns["fakulteId"].Visible = false;
            this.dataGridViewOgr.Columns["Bolum"].Visible = false;
            this.dataGridViewOgr.Columns["bolumId"].Visible = false;

        }

        private void buttonAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }

        private void buttonOgrEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();

        }

        private void dataGridViewOgr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                if (dataGridViewOgr.Rows[e.RowIndex].Cells[0].Value is string)
                {
                    FormOgrenciDetay formOgrenciDetay = new FormOgrenciDetay((int)dataGridViewOgr.Rows[e.RowIndex].Cells[2].Value);
                    formOgrenciDetay.Show();
                }
                else
                {
                    FormOgrenciDetay formOgrenciDetay = new FormOgrenciDetay((int)dataGridViewOgr.Rows[e.RowIndex].Cells[0].Value);
                    formOgrenciDetay.Show();
                    
                }
                
            }
            else if (e.ColumnIndex == 14)
            {
                
                FormOgrenciDetay formOgrenciDetay = new FormOgrenciDetay((int)dataGridViewOgr.Rows[e.RowIndex].Cells[0].Value);
                formOgrenciDetay.Show();
            }
            else if (e.ColumnIndex == 1)
            {
               
                FormOgrenciDetay formOgrenciDetay = new FormOgrenciDetay((int)dataGridViewOgr.Rows[e.RowIndex].Cells[2].Value);
                formOgrenciDetay.Show();
            }
            else if (e.ColumnIndex == 13)
            {

                connection.Query("DELETE FROM ogrenci WHERE ogrenciId='" + dataGridViewOgr.Rows[e.RowIndex].Cells[0].Value + "'");
                MessageBox.Show("Ogrenci silindi");
                
            }
            else if (e.ColumnIndex == 0)
            {

                connection.Query("DELETE FROM ogrenci WHERE ogrenciId='" + dataGridViewOgr.Rows[e.RowIndex].Cells[2].Value + "'");
                MessageBox.Show("Ogrenci silindi");
                
            }
        }

        private void Anasayfa_Activated(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(userSettingcs.VeriOku("program_settings", "ArkaplanRengi")));
            counter++;
            if (counter > 1)
            {
                var ogrenciler = connection.Query<Ogrenci>("SELECT * FROM ogrenci");
                dataGridViewOgr.DataSource = ogrenciler;
            }
        }
    }
}