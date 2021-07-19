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
    public static class RDV
    {
        public static SqlCommand commande = new SqlCommand("", Program.connexion);
        public static SqlDataReader lecteur;

        public static bool CodeExiste(int code)
        {
            Program.connexion.Open();
            commande.CommandText = "select * from rendez-vous where num_rdv=" + code;
            lecteur = commande.ExecuteReader();
            if (lecteur.HasRows)
            {
                Program.connexion.Close();
                return true;
            }
            Program.connexion.Close();
            return false;
        }

        public static void Enregistrer(TextBox tb_num, DateTimePicker dtp_dateRDV, MaskedTextBox mtb_heure,
            ComboBox cmb_medecin, ComboBox cmb_patient)
        {
            int numero;
            if (!int.TryParse(tb_num.Text, out numero) || dtp_dateRDV.Value < DateTime.Today || 
                !mtb_heure.MaskFull || cmb_medecin.SelectedIndex==-1 || cmb_patient.SelectedIndex==-1)
            {
                MessageBox.Show("Des informations sont manquantes ou incorrectes!", "Erreurs d'informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!CodeExiste(numero))
                {
                    Program.connexion.Open();
                    commande.CommandText = string.Format("insert into rendez-vous values ({0},'{1}','{2}',{3}, {4})",
                         numero, dtp_dateRDV.Value, mtb_heure, cmb_medecin.SelectedItem, cmb_patient.SelectedItem);
                    int n = commande.ExecuteNonQuery();
                    if (n == 0)
                    {
                        MessageBox.Show("Une erreur s'est produit !\nEchec d'ajout du rendez-vous.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Rendez-vous ajouté avec succés.", "Rendez-vous Ajouté",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Le numéro saisie existe déjà!", "Code disponible",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                Program.connexion.Close();
            }
        }

        public static void Nouveau(TextBox tb_num, DateTimePicker dtp_dateRDV, MaskedTextBox mtb_heure,
            ComboBox cmb_medecin, ComboBox cmb_patient)
        {
            tb_num.Clear();
            dtp_dateRDV.Value = DateTime.Today; mtb_heure.Clear();
            cmb_medecin.SelectedIndex = cmb_patient.SelectedIndex = -1;
        }

        public static void Supprimer(TextBox tb_num, DateTimePicker dtp_dateRDV, MaskedTextBox mtb_heure,
            ComboBox cmb_medecin, ComboBox cmb_patient)
        {
            int numero;
            if (!int.TryParse(tb_num.Text, out numero))
            {
                MessageBox.Show("Le code saisi est incorrect!", "Erreurs d'informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!CodeExiste(numero))
                {
                    MessageBox.Show("Le code saisie est introuvable!", "Code indisponible",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult confirmer = new DialogResult();
                    confirmer = MessageBox.Show("Supprimer le rendez-vous de code " + numero + " ?", "Confirmer la suppression",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmer == DialogResult.Yes)
                    {
                        Program.connexion.Open();
                        commande.CommandText = "delete from RDV where num_rdv=" + numero;
                        int n = commande.ExecuteNonQuery();
                        if (n == 0)
                        {
                            MessageBox.Show("Une erreur s'est produit !\nEchec de suppression du rendez-vous.", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("rendez-vous supprimé avec succés.", "rendez-vous Ajouté",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        Program.connexion.Close();
                    }

                }
            }
        }

        public static void Modifier(TextBox tb_num, DateTimePicker dtp_dateRDV, MaskedTextBox mtb_heure,
            ComboBox cmb_medecin, ComboBox cmb_patient)
        {
            int numero;
            if (!int.TryParse(tb_num.Text, out numero) || dtp_dateRDV.Value < DateTime.Today ||
                !mtb_heure.MaskFull || cmb_medecin.SelectedIndex == -1 || cmb_patient.SelectedIndex == -1)
            {
                MessageBox.Show("Des informations sont manquantes ou incorrectes!", "Erreurs d'informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!CodeExiste(numero))
                {
                    MessageBox.Show("Le code saisie est introuvable!", "Code indisponible",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Program.connexion.Open();
                    commande.CommandText = string.Format("update RDV set " +
                        "date_rdv='{0}',heure_rdv='{1}',code_medecin={2},code_patient={3}" +
                        "where num_rdv={4}",
                        dtp_dateRDV.Value, mtb_heure, cmb_medecin.SelectedItem, cmb_patient.SelectedItem, numero);
                    int n = commande.ExecuteNonQuery();
                    if (n == 0)
                    {
                        MessageBox.Show("Une erreur s'est produit !\nEchec de modification du rendez-vous.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Rendez-vous modifié avec succés.", "Rendez-vous Ajouté",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    Program.connexion.Close();
                }

            }
        }

        public static void Verifier(TextBox tb_num, DateTimePicker dtp_dateRDV, MaskedTextBox mtb_heure,
            ComboBox cmb_medecin, ComboBox cmb_patient)
        {
            int numero;
            if (!int.TryParse(tb_num.Text, out numero))
            {
                MessageBox.Show("Le code saisi est incorrect!", "Erreurs d'informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!CodeExiste(numero))
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
            dgv.Columns.Add("num_rdv", "Numéro");
            dgv.Columns.Add("date_rdv", "Date");
            dgv.Columns.Add("heure_rdv", "Heure");
            dgv.Columns.Add("code_medecin", "Médecin");
            dgv.Columns.Add("code_patient", "Patient");
            Program.connexion.Open();
            commande.CommandText = "select * from RDV";
            lecteur = commande.ExecuteReader();
            while (lecteur.Read())
            {
                dgv.Rows.Add(lecteur[0], lecteur[1], lecteur[2], lecteur[3], lecteur[4]);
            }
            lecteur.Close();
            Program.connexion.Close();
        }
    }
}
