using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_109_Tsaqif
{
    public partial class ClientA : Form
    {
        public ClientA()
        {
            InitializeComponent();
			TampilData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tI_UMYDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.tI_UMYDataSet.Mahasiswa);

        }

		public void TampilData()
		{
			var json = new WebClient().DownloadString("http://localhost:1908/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

			dtMahasiswa.DataSource = data;

		}

		public class Mahasiswa
		{
			private string _nama, _nim, _prodi, _angkatan;
			public string nama
			{
				get { return _nama; }
				set { _nama = value; }
			}

			public string nim
			{
				get { return _nim; }
				set { _nim = value; }
			}

			public string prodi
			{
				get { return _prodi; }
				set { _prodi = value; }
			}

			public string angkatan
			{
				get { return _angkatan; }
				set { _angkatan = value; }
			}
		}

		string baseurl = "http://localhost:1908/";

        private void buttonCari_Click(object sender, EventArgs e)
        {
			var json = new WebClient().DownloadString("http://localhost:1908/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
			string nim = textBoxSearch.Text;
			if (nim == null || nim == "")
			{
				dtMahasiswa.DataSource = data;
			}
			else
			{
				var item = data.Where(x => x.nim == textBoxSearch.Text).ToList();

				dtMahasiswa.DataSource = item;
			}
		}

        private void buttonTambah_Click(object sender, EventArgs e)
        {
			Mahasiswa mhs = new Mahasiswa();
			mhs.nama = textBoxNama.Text;
			mhs.nim = textBoxNIM.Text;
			mhs.prodi = textBoxProdi.Text;
			mhs.angkatan = textBoxAngkatan.Text;

			var data = JsonConvert.SerializeObject(mhs);
			var postdata = new WebClient();
			postdata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
			string response = postdata.UploadString(baseurl + "Mahasiswa", data);
			Console.WriteLine(response);
			TampilData();
		}

        private void dtMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			textBoxNama.Text = Convert.ToString(dtMahasiswa.Rows[e.RowIndex].Cells[0].Value);
			textBoxNIM.Text = Convert.ToString(dtMahasiswa.Rows[e.RowIndex].Cells[1].Value);
			textBoxProdi.Text = Convert.ToString(dtMahasiswa.Rows[e.RowIndex].Cells[2].Value);
			textBoxAngkatan.Text = Convert.ToString(dtMahasiswa.Rows[e.RowIndex].Cells[3].Value);
		}
    }
}
