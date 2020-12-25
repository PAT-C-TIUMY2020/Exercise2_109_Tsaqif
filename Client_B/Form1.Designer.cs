namespace Client_B
{
    partial class ClientB
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dtMahasiswa = new System.Windows.Forms.DataGridView();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tI_UMYDataSet = new Client_B.TI_UMYDataSet();
            this.textBoxAngkatan = new System.Windows.Forms.TextBox();
            this.textBoxProdi = new System.Windows.Forms.TextBox();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonJumlah = new System.Windows.Forms.Button();
            this.labelJumlahData = new System.Windows.Forms.Label();
            this.mahasiswaTableAdapter = new Client_B.TI_UMYDataSetTableAdapters.MahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtMahasiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tI_UMYDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(512, 116);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(126, 40);
            this.buttonUpdate.TabIndex = 24;
            this.buttonUpdate.Text = "Update Data";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(644, 116);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(126, 40);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.Text = "Delete Data";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dtMahasiswa
            // 
            this.dtMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMahasiswa.Location = new System.Drawing.Point(31, 188);
            this.dtMahasiswa.Name = "dtMahasiswa";
            this.dtMahasiswa.RowHeadersWidth = 62;
            this.dtMahasiswa.RowTemplate.Height = 28;
            this.dtMahasiswa.Size = new System.Drawing.Size(739, 229);
            this.dtMahasiswa.TabIndex = 22;
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
            // textBoxAngkatan
            // 
            this.textBoxAngkatan.Location = new System.Drawing.Point(149, 130);
            this.textBoxAngkatan.Name = "textBoxAngkatan";
            this.textBoxAngkatan.Size = new System.Drawing.Size(314, 26);
            this.textBoxAngkatan.TabIndex = 21;
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.Location = new System.Drawing.Point(149, 98);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(314, 26);
            this.textBoxProdi.TabIndex = 20;
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(149, 66);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(314, 26);
            this.textBoxNIM.TabIndex = 19;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(149, 34);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(314, 26);
            this.textBoxNama.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Angkatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Prodi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "NIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nama";
            // 
            // buttonJumlah
            // 
            this.buttonJumlah.Location = new System.Drawing.Point(512, 70);
            this.buttonJumlah.Name = "buttonJumlah";
            this.buttonJumlah.Size = new System.Drawing.Size(258, 40);
            this.buttonJumlah.TabIndex = 25;
            this.buttonJumlah.Text = "Jumlah Data";
            this.buttonJumlah.UseVisualStyleBackColor = true;
            this.buttonJumlah.Click += new System.EventHandler(this.buttonJumlah_Click);
            // 
            // labelJumlahData
            // 
            this.labelJumlahData.AutoSize = true;
            this.labelJumlahData.Location = new System.Drawing.Point(588, 37);
            this.labelJumlahData.Name = "labelJumlahData";
            this.labelJumlahData.Size = new System.Drawing.Size(111, 20);
            this.labelJumlahData.TabIndex = 26;
            this.labelJumlahData.Text = "Jumlah Data : ";
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // ClientB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelJumlahData);
            this.Controls.Add(this.buttonJumlah);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dtMahasiswa);
            this.Controls.Add(this.textBoxAngkatan);
            this.Controls.Add(this.textBoxProdi);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientB";
            this.Text = "Client B";
            this.Load += new System.EventHandler(this.ClientB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMahasiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tI_UMYDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dtMahasiswa;
        private System.Windows.Forms.TextBox textBoxAngkatan;
        private System.Windows.Forms.TextBox textBoxProdi;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonJumlah;
        private System.Windows.Forms.Label labelJumlahData;
        private TI_UMYDataSet tI_UMYDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private TI_UMYDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
    }
}

