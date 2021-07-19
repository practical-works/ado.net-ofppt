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
    public static class Medecin
    {
        public static SqlCommand commande = new SqlCommand("", Program.connexion);
        public static SqlDataReader lecteur;

        public static bool CodeExiste(int code)
        {
            Program.connexion.Open();
            commande.CommandText = "select * from Medecin where code_medecin=" + code;
            lecteur = commande.ExecuteReader();
            if (lecteur.HasRows)
            {
                Program.connexion.Close();
                return true;
            }
            Program.connexion.Close();
            return false;
        }

        public static void Enregistrer(TextBox tb_code, TextBox tb_nom, MaskedTextBox mtb_tel,
            DateTimePicker dtp_dateEmb, TextBox tb_spec)
        {
            int code;
            if (!int.TryParse(tb_code.Text, out code) || tb_nom.Text == "" || !mtb_tel.MaskFull || 
                dtp_dateEmb.Value > DateTime.Now || tb_spec.Text == "")
            {
                MessageBox.Show("Des informations sont manquantes ou incorrectes!", "Erreurs d'informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!CodeExiste(code))
                {
                    Program.connexion.Open();
                    commande.CommandText = string.Format("insert into Medecin values ({0},'{1}','{2}','{3}','{4}')",
                         code, tb_nom.Text, mtb_tel.Text, dtp_dateEmb.Value,
                         tb_spec.Text);
                    int n = commande.ExecuteNonQuery();
                    if (n == 0)
                    {
                        MessageBox.Show("Une erreur s'est produit !\nEchec d'ajout du médecin.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Medecin ajouté avec succés.", "Medecin Ajouté",
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

        public static void Nouveau(TextBox tb_code, TextBox tb_nom, MaskedTextBox mtb_tel,
            DateTimePicker dtp_dateEmb, TextBox tb_spec)
        {
            tb_code.Clear(); tb_nom.Clear(); mtb_tel.Clear(); tb_spec.Clear();
            dtp_dateEmb.Value = DateTime.Now; 
            tb_code.Focus();
        }

        public static void Supprimer(TextBox tb_code, TextBox tb_nom, MaskedTextBox mtb_tel,
            DateTimePicker dtp_dateEmb, TextBox tb_spec)
        {
            int code;
            if (!int.TryParse(tb_code.Text, out code))
            {
                MessageBox.Show("Le code saisi est incorrecte!", "Erreurs d'informations",
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
                    confirmer = MessageBox.Show("Supprimer le médecin de code " + code + " ?", "Confirmer la suppression",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmer == DialogResult.Yes)
                    {
                        Program.connexion.Open();
                        commande.CommandText = "delete from Medecin where code_medecin=" + code;
                        int n = commande.ExecuteNonQuery();
                        if (n == 0)
                        {
                            MessageBox.Show("Une erreur s'est produit !\nEchec de suppression du médecin.", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Medecin supprimé avec succés.", "Medecin Ajouté",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        Program.connexion.Close();
                    }

                }
            }
        }

        public static void Modifier(TextBox tb_code, TextBox tb_nom, MaskedTextBox mtb_tel,
            DateTimePicker dtp_dateEmb, TextBox tb_spec)
        {
            int code;
            if (!int.TryParse(tb_code.Text, out code) || tb_nom.Text == "" ||
                !mtb_tel.MaskFull || dtp_dateEmb.Value > DateTime.Now ||
                tb_spec.Text == "")
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
                    Program.connexion.Open();
                    commande.CommandText = string.Format("update Medecin set " +
                        "nom_medecin='{0}',tel_medecin='{1}',date_embauche='{2}',specialite_medecin='{3}' " +
                        "where code_medecin={4}",
                        tb_nom.Text, mtb_tel.Text, dtp_dateEmb.Value,
                        tb_spec.Text,code);
                    int n = commande.ExecuteNonQuery();
                    if (n == 0)
                    {
                        MessageBox.Show("Une erreur s'est produit !\nEchec de modification du médecin.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Medecin modifié avec succés.", "Medecin Ajouté",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    Program.connexion.Close();
                }

            }
        }

        public static void Verifier(TextBox tb_code, TextBox tb_nom, MaskedTextBox mtb_tel,
            DateTimePicker dtp_dateEmb, TextBox tb_spec)
        {
            int code;
            if (!int.TryParse(tb_code.Text, out code))
            {
                MessageBox.Show("Le code saisi est incorrecte!", "Erreurs d'informations",
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
            dgv.Columns.Add("code_medecin", "Code");
            dgv.Columns.Add("nom_medecin", "Nom");
            dgv.Columns.Add("tel_medecin", "Téléphone");
            dgv.Columns.Add("dateEmbauche_medecin", "Date d'embauche");
            dgv.Columns.Add("specialite_medecin", "Spécialité");
            Program.connexion.Open();
            commande.CommandText = "select * from Medecin";
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
            commande.CommandText = "select code_medecin from Medecin";
            lecteur = commande.ExecuteReader();
            while (lecteur.Read())
            {
                cmb.Items.Add(lecteur[0]);
            }
            lecteur.Close();
            cmb.Text = "Choisir le code du médecin";
            Program.connexion.Close();
        }
    }
}
