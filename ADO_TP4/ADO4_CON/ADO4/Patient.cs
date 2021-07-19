using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO4
{
    public static class Patient
    {
        public static SqlCommand commande = new SqlCommand("", Program.connexion);
        public static SqlDataReader lecteur;

        public static bool CodeExiste(int code)
        {
            Program.connexion.Open();
            commande.CommandText = "select * from Patient where code_patient=" + code;
            lecteur = commande.ExecuteReader();
            if (lecteur.HasRows)
            {
                Program.connexion.Close();
                return true;
            }
            Program.connexion.Close();
            return false;
        }

        public static void Enregistrer(TextBox tb_code, TextBox tb_nom, TextBox tb_adr,
            DateTimePicker dtp_dateNaiss, RadioButton rb_M, RadioButton rb_F)
        {
            int code;
            if (!int.TryParse(tb_code.Text, out code) || tb_nom.Text == "" || tb_adr.Text=="" ||
                dtp_dateNaiss.Value > DateTime.Now || (!rb_M.Checked && !rb_F.Checked))
            {
                MessageBox.Show("Des informations sont manquantes ou incorrectes!", "Erreurs d'informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!CodeExiste(code))
                {
                    string sexe = "";
                    if (rb_M.Checked) sexe = "M"; else if (rb_F.Checked) sexe = "F";
                    Program.connexion.Open();
                    commande.CommandText = string.Format("insert into Patient values ({0},'{1}','{2}','{3}','{4}')",
                         code, tb_nom.Text, tb_adr.Text, dtp_dateNaiss.Value,sexe);
                    int n = commande.ExecuteNonQuery();
                    if (n == 0)
                    {
                        MessageBox.Show("Une erreur s'est produit !\nEchec d'ajout du patient.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Patient ajouté avec succés.", "Patient Ajouté",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Le code saisie existe déjà!", "Code disponible",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                Program.connexion.Close();
            }
        }

        public static void Nouveau(TextBox tb_code, TextBox tb_nom, TextBox tb_adr,
            DateTimePicker dtp_dateNaiss, RadioButton rb_M, RadioButton rb_F)
        {
            tb_code.Clear(); tb_nom.Clear(); tb_adr.Clear();
            dtp_dateNaiss.Value = DateTime.Now; rb_M.Checked = rb_F.Checked = false;
            tb_code.Focus();
        }

        public static void Supprimer(TextBox tb_code, TextBox tb_nom, TextBox tb_adr,
            DateTimePicker dtp_dateNaiss, RadioButton rb_M, RadioButton rb_F)
        {
            int code;
            if (!int.TryParse(tb_code.Text, out code))
            {
                MessageBox.Show("Le code saisi est incorrect!", "Erreurs d'informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!CodeExiste(code))
                {
                    MessageBox.Show("Le code saisie est introuvable!", "Code indisponible",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult confirmer = new DialogResult();
                    confirmer = MessageBox.Show("Supprimer le patient de code " + code + " ?", "Confirmer la suppression",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmer == DialogResult.Yes)
                    {
                        Program.connexion.Open();
                        commande.CommandText = "delete from Patient where code_patient=" + code;
                        int n = commande.ExecuteNonQuery();
                        if (n == 0)
                        {
                            MessageBox.Show("Une erreur s'est produit !\nEchec de suppression du patient.", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Patient supprimé avec succés.", "Patient Ajouté",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        Program.connexion.Close();
                    }

                }
            }
        }

        public static void Modifier(TextBox tb_code, TextBox tb_nom, TextBox tb_adr,
            DateTimePicker dtp_dateNaiss, RadioButton rb_M, RadioButton rb_F)
        {
            int code;
            if (!int.TryParse(tb_code.Text, out code) || tb_nom.Text == "" || tb_adr.Text=="" ||
                dtp_dateNaiss.Value > DateTime.Now || (!rb_M.Checked && !rb_F.Checked))
            {
                MessageBox.Show("Des informations sont manquantes ou incorrectes!", "Erreurs d'informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!CodeExiste(code))
                {
                    MessageBox.Show("Le code saisie est introuvable!", "Code indisponible",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string sexe = "";
                    if (rb_M.Checked) sexe = "M"; else if (rb_F.Checked) sexe = "F";
                    Program.connexion.Open();
                    commande.CommandText = string.Format("update Patient set " +
                        "nom_Patient='{0}',adresse_Patient='{1}',date_naissance='{2}',sexe_patient='{3}' " +
                        "where code_patient={4}",
                        tb_nom.Text, tb_adr.Text, dtp_dateNaiss.Value,sexe,code);
                    int n = commande.ExecuteNonQuery();
                    if (n == 0)
                    {
                        MessageBox.Show("Une erreur s'est produit !\nEchec de modification du patient.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Patient modifié avec succés.", "Patient Ajouté",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    Program.connexion.Close();
                }

            }
        }

        public static void Verifier(TextBox tb_code, TextBox tb_nom, TextBox tb_adr,
            DateTimePicker dtp_dateNaiss, RadioButton rb_M, RadioButton rb_F)
        {
            int code;
            if (!int.TryParse(tb_code.Text, out code))
            {
                MessageBox.Show("Le code saisi est incorrect!", "Erreurs d'informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!CodeExiste(code))
                {
                    MessageBox.Show("Le code saisie est introuvable!", "Code indisponible",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Le code saisie existe déjà!", "Code disponible",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void Afficher(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add("code_patient", "Code");
            dgv.Columns.Add("nom_patient", "Nom");
            dgv.Columns.Add("adresse_patient", "Adresse");
            dgv.Columns.Add("dateNaissance_patient", "Date de naissance");
            dgv.Columns.Add("sexe_patient", "Sexe");
            Program.connexion.Open();
            commande.CommandText = "select * from Patient";
            lecteur = commande.ExecuteReader();
            while (lecteur.Read())
            {
                dgv.Rows.Add(lecteur[0], lecteur[1], lecteur[2], lecteur[3], lecteur[4]);
            }
            lecteur.Close();
            Program.connexion.Close();
        }

        public static void Afficher(ComboBox cmb)
        {
            cmb.Items.Clear();
            Program.connexion.Open();
            commande.CommandText = "select code_patient from Patient";
            lecteur = commande.ExecuteReader();
            while (lecteur.Read())
            {
                cmb.Items.Add(lecteur[0]);
            }
            lecteur.Close();
            cmb.Text = "Choisir le code du patient";
            Program.connexion.Close();
        }
    }
}
