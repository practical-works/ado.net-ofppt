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
        private static SqlConnection cnx = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=HotelDb;Integrated Security=True");
        private static SqlCommand cmd = new SqlCommand("", cnx);
        private static SqlDataReader dr;
        
        public Form_main()
        {
            InitializeComponent();
            Actualiser("All");
        }

        public void Actualiser(string table)
        {
            if (cnx.State != ConnectionState.Open) cnx.Open();
            if (table == "Client")
            {
                cmd.CommandText = "select * from Client";
                dr = cmd.ExecuteReader();
                dataGridView_clients.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView_clients.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                }
            }
            else if (table == "Reservation")
            {
                cmd.CommandText = "select * from Reservation";
                dr = cmd.ExecuteReader();
                dataGridView_reservations.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView_reservations.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                }
            }
            else if (table == "ReservationAnnulee")
            {
                cmd.CommandText = "select * from ReservationAnnulee";
                dr = cmd.ExecuteReader();
                dataGridView_reservations_annulees.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView_reservations_annulees.Rows.Add(dr[0], dr[1]);
                }
            }
            else if (table == "Sejour")
            {
                cmd.CommandText = "select * from Sejour";
                dr = cmd.ExecuteReader();
                dataGridView_sejours.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView_sejours.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
                }
            }
            else if (table == "All")
            {
                Actualiser("Client");
                Actualiser("Reservation");
                Actualiser("ReservationAnnulee");
                Actualiser("Sejour");
            }
            dr.Close();
            cnx.Close();
        }

        public void Rechercher(string table)
        {
            cnx.Open();
            if (table == "Client")
            {
                cmd.CommandText = "select * from Client where id_client";
                dr = cmd.ExecuteReader();
                dataGridView_clients.ClearSelection();
                int c = 0;
                while (dr.Read())
                {
                    c++;
                    if (Convert.ToDecimal(dr[0]) == num_id_client.Value)
                    {
                        dataGridView_clients.Rows[c].Selected = true;
                    }
                }
            }
            else if (table == "Reservation")
            {
                
            }
            else if (table == "ReservationAnnulee")
            {
                
            }
            else if (table == "Sejour")
            {
                
            }
            dr.Close();
            cnx.Close();
        }

    }
}
