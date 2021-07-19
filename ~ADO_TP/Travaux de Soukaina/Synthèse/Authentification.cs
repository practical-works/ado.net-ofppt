using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Synthèse
{
    public partial class Authentification : Form
    {
        //SqlDataReader dataReader;
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }

        //private void Authentification_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
                               
        //        textBox_motDePasse.PasswordChar = '*';
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        

        //private void button_Connexion_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Program.connection.Open();

        //        Program.command.Connection = Program.connection;   
        //        Program.command.CommandText = string.Format("select * from Comptes where login='{0}' and MotDePasse='{1}'", textBox_login.Text,textBox_motDePasse.Text);
        //        dataReader = Program.command.ExecuteReader();
        //        if (dataReader.HasRows)
        //        {
        //            (this.MdiParent as Form_MenuPrincipal).Activer();
        //            MessageBox.Show("Connexion effectuée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            //Authentification a = new Authentification();
        //            //a.Hide();
        //        }
        //        else  MessageBox.Show("Les informations que vous avez donné ne sont pas valides !!!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);


        //        dataReader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
