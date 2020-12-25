using Service_Exercise2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Exercise2
{
    public partial class Server : Form
    {
        ServiceHost hostObjek;
        public Server()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;

            
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            label2.Text = "Server On";
            label3.Text = "Klik OFF untuk Mematikan Server";
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;

            ServiceHost hostObjek = null;

            try
            {
                hostObjek = new ServiceHost(typeof(TI_UMY));
                hostObjek.Open();
                Console.WriteLine("Server ready...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;

            //ServiceHost hostObjek = null;
            try
            {
                hostObjek = new ServiceHost(typeof(TI_UMY));
                hostObjek.Close();
                label2.Text = "Server OFF";
                label3.Text = "Klik ON untuk menghidupkan server";
            }
            catch (Exception ex)
            {
                label2.Text = "Server Error";
            }
        }
    }
}
