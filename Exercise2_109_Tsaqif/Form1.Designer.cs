namespace Exercise2_109_Tsaqif
{
    partial class ClientA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.textBoxProdi = new System.Windows.Forms.TextBox();
            this.textBoxAngkatan = new System.Windows.Forms.TextBox();
            this.dtMahasiswa = new System.Windows.Forms.DataGridView();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tI_UMYDataSet = new Exercise2_109_Tsaqif.TI_UMYDataSet();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.mahasiswaTableAdapter = new Exercise2_109_Tsaqif.TI_UMYDataSetTableAdapters.MahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtMahasiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tI_UMYDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prodi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Angkatan";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(148, 36);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(314, 26);
            this.textBoxNama.TabIndex = 5;
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(148, 68);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(314, 26);
            this.textBoxNIM.TabIndex = 6;
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.Location = new System.Drawing.Point(148, 100);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(314, 26);
            this.textBoxProdi.TabIndex = 7;
            // 
            // textBoxAngkatan
            // 
            this.textBoxAngkatan.Location = new System.Drawing.Point(148, 132);
            this.textBoxAngkatan.Name = "textBoxAngkatan";
            this.textBoxAngkatan.Size = new System.Drawing.Size(314, 26);
            this.textBoxAngkatan.TabIndex = 8;
            // 
            // dtMahasiswa
            // 
            this.dtMahasiswa.AutoGenerateColumns = false;
            this.dtMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMahasiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaDataGridViewTextBoxColumn,
            this.nIMDataGridViewTextBoxColumn,
            this.prodiDataGridViewTextBoxColumn,
            this.angkatanDataGridViewTextBoxColumn});
            this.dtMahasiswa.DataSource = this.mahasiswaBindingSource;
            this.dtMahasiswa.Location = new System.Drawing.Point(30, 190);
            this.dtMahasiswa.Name = "dtMahasiswa";
            this.dtMahasiswa.RowHeadersWidth = 62;
            this.dtMahasiswa.RowTemplate.Height = 28;
            this.dtMahasiswa.Size = new System.Drawing.Size(739, 229);
            this.dtMahasiswa.TabIndex = 10;
            this.dtMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMahasiswa_CellClick);
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nIMDataGridViewTextBoxColumn
            // 
            this.nIMDataGridViewTextBoxColumn.DataPropertyName = "NIM";
            this.nIMDataGridViewTextBoxColumn.HeaderText = "NIM";
            this.nIMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nIMDataGridViewTextBoxColumn.Name = "nIMDataGridViewTextBoxColumn";
            this.nIMDataGridViewTextBoxColumn.Width = 150;
            // 
            // prodiDataGridViewTextBoxColumn
            // 
            this.prodiDataGridViewTextBoxColumn.DataPropertyName = "Prodi";
            this.prodiDataGridViewTextBoxColumn.HeaderText = "Prodi";
            this.prodiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prodiDataGridViewTextBoxColumn.Name = "prodiDataGridViewTextBoxColumn";
            this.prodiDataGridViewTextBoxColumn.Width = 150;
            // 
            // angkatanDataGridViewTextBoxColumn
            // 
            this.angkatanDataGridViewTextBoxColumn.DataPropertyName = "Angkatan";
            this.angkatanDataGridViewTextBoxColumn.HeaderText = "Angkatan";
            this.angkatanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.angkatanDataGridViewTextBoxColumn.Name = "angkatanDataGridViewTextBoxColumn";
            this.angkatanDataGridViewTextBoxColumn.Width = 150;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.tI_UMYDataSet;
            // 
            // tI_UMYDataSet
            // 
            this.tI_UMYDataSet.DataSetName = "TI_UMYDataSet";
            this.tI_UMYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(506, 118);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(263, 40);
            this.buttonTambah.TabIndex = 11;
            this.buttonTambah.Text = "Tambah Data";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(506, 72);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(260, 40);
            this.buttonCari.TabIndex = 12;
            this.buttonCari.Text = "Cari Data";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(506, 36);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(260, 26);
            this.textBoxSearch.TabIndex = 13;
            this.textBoxSearch.Text = "Cari berdasarkan NIM";
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // ClientA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dtMahasiswa);
            this.Controls.Add(this.textBoxAngkatan);
            this.Controls.Add(this.textBoxProdi);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientA";
            this.Text = "Client A";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMahasiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tI_UMYDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.TextBox textBoxProdi;
        private System.Windows.Forms.TextBox textBoxAngkatan;
        private System.Windows.Forms.DataGridView dtMahasiswa;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.TextBox textBoxSearch;
        private TI_UMYDataSet tI_UMYDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private TI_UMYDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angkatanDataGridViewTextBoxColumn;
    }
}

