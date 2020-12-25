using Newtonsoft.Json;
using Service_Exercise2;
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

namespace Client_B
{
    public partial class ClientB : Form
    {
        public ClientB()
        {
            InitializeComponent();
            TampilData();
        }

        private void ClientB_Load(object sender, EventArgs e)
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
			var json = new WebClient().DownloadString("http://localhost:1908/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            if (MessageBox.Show("Are you sure you want to delete", "DeleteMahasiswa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ClassData classData = new ClassData();
                    classData.deleteMahasiswa(textBoxNIM.Text);
                    dtMahasiswa.DataSource = classData.getAllData();
                    MessageBox.Show("Data successfuly deleted");
                    ClientB home = new ClientB();
                    this.Hide();
                    home.Show();
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			var json = new WebClient().DownloadString("http://localhost:1908/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            if (textBoxNIM.Text != "" &&
                textBoxNama.Text != "" &&
                textBoxProdi.Text != "" &&
                textBoxAngkatan.Text != "")
            {
                if (textBoxNIM.Text.Length <= 12 &&
                textBoxAngkatan.Text.Length <= 4 &&
                textBoxProdi.Text.Length <= 30 &&
                textBoxNama.Text.Length <= 20)
                {
                    try
                    {
                        Mahasiswa mhs = new Mahasiswa();
                        mhs.nim = textBoxNIM.Text;
                        mhs.nama = textBoxNama.Text;
                        mhs.prodi = textBoxProdi.Text;
                        mhs.angkatan = textBoxAngkatan.Text;

                        ClassData classData = new ClassData();
                        classData.updateDatabase(mhs);
                        MessageBox.Show("Data successfuly updated");

                        dtMahasiswa.DataSource = classData.getAllData();
                        TampilData();
                    }
                    catch
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Please check your data");
                }
            }
            else
            {
                MessageBox.Show("Please check your data");
            }
        }

        private void buttonJumlah_Click(object sender, EventArgs e)
        {
			var json = new WebClient().DownloadString("http://localhost:1908/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
			int length = data.Count();
			labelJumlahData.Text = Convert.ToString(length);
            TampilData();
        }

        private void buttonSinkron_Click(object sender, EventArgs e)
        {
            TampilData();
        }
    }
}
