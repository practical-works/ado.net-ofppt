using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ShopKeeper
{
    public partial class Form1 : Form
    {
        private static SqlConnection connexion = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=ShopKeeperDb;Integrated Security=True");
        private static SqlDataAdapter adapteur = new SqlDataAdapter("select * from Client", connexion);
        private static SqlCommandBuilder commande_generateur = new SqlCommandBuilder(adapteur);
        private static DataSet données = new DataSet("ShopKeeperDb");
        private static BindingSource liaison = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        public void ActualiserRapport()
        {
            CrystalReport11.SetParameterValue("id_client", numericUpDown1.Value);
            crystalReportViewer1.ReportSource = CrystalReport11;
            crystalReportViewer1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserRapport();

            adapteur.Fill(données, "Client");
            liaison.DataSource = données.Tables["Client"];
            numericUpDown1.DataBindings.Add("Value", liaison, "id");
            textBox1.DataBindings.Add("Text", liaison, "nom");
            pictureBox1.DataBindings.Add("Image", liaison, "photo", true);

            bindingNavigator1.BindingSource = liaison;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ActualiserRapport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog explorateur = new OpenFileDialog();
            explorateur.Filter = "Fichiers Image|*.jpg;*.jpeg;*.png;*.bmp";
            if (explorateur.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(explorateur.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStream flux_memoire = new MemoryStream();
            pictureBox1.Image.Save(flux_memoire, pictureBox1.Image.RawFormat);
            byte[] image_octets = flux_memoire.ToArray();
            adapteur.Update(données.Tables["Client"]);
        }
    }
}
