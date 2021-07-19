using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO3
{
    public partial class Form_main : Form
    {
        private int INDEX;

        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            button_refresh_clients.PerformClick();
            button_refresh_reservations.PerformClick();
            button_refresh_sejours.PerformClick();
        }

//----------------------------------------------------------------------------------------
#region Client
        public void REMPLIR_CHAMPS(int index)
        {
            DataTable Table = Client.VUE.ToTable();
            num_id_client.Value = Convert.ToDecimal(Table.Rows[index]["id_client"]);
            text_nom_client.Text = Table.Rows[index]["nom_client"].ToString();
            text_adresse_client.Text = Table.Rows[index]["adresse_client"].ToString();
            text_telephone_client.Text = Table.Rows[index]["tel_client"].ToString();
            //if (!dataGridView_clients.Rows[index].Selected)
            //{
            //    dataGridView_clients.ClearSelection();
            //    dataGridView_clients.Rows[index].Selected = true;
            //}  
        }

        public void NAVIGUER(string Position)
        {
            DataTable Table = Client.VUE.ToTable();
            if (Position == "<<")
            {
                INDEX = 0;
                REMPLIR_CHAMPS(INDEX);
            }
            if (Position == ">>")
            {
                INDEX = Table.Rows.Count - 1;
                REMPLIR_CHAMPS(INDEX);
            }
            if (Position == ">")
            {
                if (INDEX < Table.Rows.Count - 1)
                {
                    INDEX++;
                    REMPLIR_CHAMPS(INDEX);
                }
                else
                {
                    INDEX = 0;
                    REMPLIR_CHAMPS(INDEX);
                }
            }
            if (Position == "<")
            {
                if (INDEX > 0)
                {
                    INDEX--;
                    REMPLIR_CHAMPS(INDEX);
                }
                else
                {
                    INDEX = Table.Rows.Count - 1;
                    REMPLIR_CHAMPS(INDEX);
                }
            }
        }

        private void button_rechercher_client_Click(object sender, EventArgs e)
        {
            int ID = (int)num_id_client.Value, index = Client.Rechercher(ID);
            if (index == -1)
            {
                MessageBox.Show("Introuvable!");
                num_id_client.Select();
            }
            else
            {
                text_nom_client.Text = Client.TABLE.Rows[index]["nom_client"].ToString();
                text_adresse_client.Text = Client.TABLE.Rows[index]["adresse_client"].ToString();
                text_telephone_client.Text = Client.TABLE.Rows[index]["tel_client"].ToString();
            }
        }

        private void button_refresh_clients_Click(object sender, EventArgs e)
        {
            dataGridView_clients.DataSource = Client.TABLE;
        }

        private void button_afficher_client_Click(object sender, EventArgs e)
        {
            dataGridView_clients.DataSource = Client.Filtrer(text_afficher_nom_client.Text);
        }

        private void button_ajouter_client_Click(object sender, EventArgs e)
        {
            if (text_nom_client.Text=="" || text_adresse_client.Text=="" || text_telephone_client.Text=="")
            {
                MessageBox.Show("Invalide!");
            }
            else
            {
                bool OK = Client.Ajouter((int)num_id_client.Value, text_nom_client.Text, text_adresse_client.Text, text_telephone_client.Text);
                if (!OK)
                {
                    MessageBox.Show("Exite déjà!");
                }
            }
        }

        private void button_modifier_client_Click(object sender, EventArgs e)
        {
            if (text_nom_client.Text == "" || text_adresse_client.Text == "" || text_telephone_client.Text == "")
            {
                MessageBox.Show("Invalide!");
            }
            else
            {
                bool OK = Client.Modifier((int)num_id_client.Value, text_nom_client.Text, text_adresse_client.Text, text_telephone_client.Text);
                if (!OK)
                {
                    MessageBox.Show("N'existe pas!");
                }
            }
        }

        private void button_supprimer_client_Click(object sender, EventArgs e)
        {
            bool OK = Client.Supprimer((int)num_id_client.Value);
            if (!OK)
            {
                MessageBox.Show("N'existe pas!");
            }
        }

        private void button_nouveau_client_Click(object sender, EventArgs e)
        {
            num_id_client.Value = Convert.ToDecimal(Client.TABLE.Rows[Client.TABLE.Rows.Count - 1]["id_client"]) + 1;
            text_nom_client.Text = text_adresse_client.Text = text_telephone_client.Text = "";
        }

        private void button_premier_client_Click(object sender, EventArgs e)
        {
            NAVIGUER("<<");
        }

        private void button_precedent_client_Click(object sender, EventArgs e)
        {
            NAVIGUER("<");
        }

        private void button_suivant_client_Click(object sender, EventArgs e)
        {
            NAVIGUER(">");
        }

        private void button_dernier_client_Click(object sender, EventArgs e)
        {
            NAVIGUER(">>");
        }

        private void dataGridView_clients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_clients.CurrentRow != null)
            {
                INDEX = dataGridView_clients.CurrentRow.Index;
                REMPLIR_CHAMPS(INDEX);
            }
        }
    }
}

#endregion 

//----------------------------------------------------------------------------------------
#region Reservation

#endregion

//----------------------------------------------------------------------------------------
#region Sejour

#endregion