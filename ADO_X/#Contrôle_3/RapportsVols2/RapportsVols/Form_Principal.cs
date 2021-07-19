using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RapportsVols
{
    public partial class Form_Principal : Form
    {
        private static SqlConnection Connexion = new SqlConnection(@"Data Source=.\AMBRATOLM_SQL; Initial Catalog=Aeoroport_v2_Db; Integrated Security=true;");
        
        private CrystalReport_Passagers RapportPassagers = new CrystalReport_Passagers();
        private CrystalReport_Vol RapportVol = new CrystalReport_Vol();
        private CrystalReport_DiagVols DiagrammeVols = new CrystalReport_DiagVols();
        private CrystalReport_DiagChiffreAffaires DiagrammeChiffreAffaires = new CrystalReport_DiagChiffreAffaires();

        public Form_Principal()
        {
            InitializeComponent();
        }

        private DataTable Table(string Requête)
        {
            SqlDataAdapter Adapteur = new SqlDataAdapter(Requête, Connexion);
            Adapteur.SelectCommand.CommandType = CommandType.Text;
            DataTable Table = new DataTable();
            Adapteur.Fill(Table);
            return Table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_VisionneuseRapports Visionneuse = new Form_VisionneuseRapports();
            string Requête = string.Format("select * from Passager where Ville = '{0}'", textBox_Ville.Text.Trim());
            RapportPassagers.SetDataSource(Table(Requête));
            Visionneuse.crystalReportViewer1.ReportSource = RapportPassagers;
            Visionneuse.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_VisionneuseRapports Visionneuse = new Form_VisionneuseRapports();
            string Requête = string.Format(@"select vol#, villedepart, villearrivee, heuredepart, heurearrivee, 
                                            Pilote.Nom, Avion.Marque, Avion.TypeAvion, Avion.Capacite, sum(AffecteVol.Prix) as RevenuTotal
                                            from Vol 
                                            inner join AffecteVol on Vol.vol# = AffecteVol.vol
                                            inner join Avion on Vol.Avion = Avion.Av# 
                                            inner join Pilote on Vol.pilote = Pilote.pil#
                                            where vol# = {0}
                                            group by vol#, villedepart, villearrivee, heuredepart, heurearrivee, 
                                            Nom, Marque, TypeAvion, Capacite", 
                                            numericUpDown_Vol.Value);
            RapportVol.SetDataSource(Table(Requête));
            Visionneuse.crystalReportViewer1.ReportSource = RapportVol;
            Visionneuse.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_VisionneuseRapports Visionneuse = new Form_VisionneuseRapports();
            Visionneuse.crystalReportViewer1.ReportSource = DiagrammeVols;
            Visionneuse.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_VisionneuseRapports Visionneuse = new Form_VisionneuseRapports();
            Visionneuse.crystalReportViewer1.ReportSource = DiagrammeChiffreAffaires;
            Visionneuse.Show();
        }
    }
}
