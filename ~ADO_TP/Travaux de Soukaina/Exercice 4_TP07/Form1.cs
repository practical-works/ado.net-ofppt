using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_4_TP07
{
    public partial class Form1 : Form
    {
        SqlConnection connexion = new SqlConnection(@"Data Source=.;Initial Catalog=SGBD1_Chapitre1;Integrated Security=True");
        DataSet Data = new DataSet();
        SqlDataAdapter Adapter;
        DataView dataview;
        string m = "";
        string ch = "";
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Exercice4_Load(object sender, EventArgs e)
        {
            
           // #region ChargerComBoBox

           // Adapter = new SqlDataAdapter("select * from Examens", connexion);
           // Adapter.Fill(Data, "Ex");

           // foreach (DataRow item in Data.Tables["Ex"].Rows)
           // {
                checkedListBox_Examens.Items.Add(item["Id"]);
            //}
            //#endregion


           // checkedListBox_Examens.CheckOnClick = true;
           // Adapter = new SqlDataAdapter("select Examen , Stagiaire,Note from Notes", connexion);
            //Adapter.Fill(Data, "Notes");

           // dataview = new DataView(Data.Tables["Notes"]);
            //radioButton_Croissant.Checked = true;

          //  dataview.RowFilter = "1=0";

           // dataGridView1.DataSource = dataview;
           // dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

        }

        private void checkedListBox_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Afficher();
            dataview.RowFilter = ch;
            dataGridView1.DataSource = dataview;
        }

        private void Afficher()
        {
            m="";
            ch = "";
            for (int i = 0; i < checkedListBox_Examens.Items.Count; i++)
            {
                if (checkedListBox_Examens.GetItemChecked(i) == true) m += checkedListBox_Examens.Items[i].ToString() + '.';
            }
           string [] t = new string[15];
           t = m.Split('.');
           for (int i = 0; i < t.Length-1; i++)
           {
               if (i <= t.Length - 3) ch += string.Format("Examen ='{0}' or ", t[i]);
               if (i == t.Length - 2) ch += string.Format("Examen ='{0}'  ", t[i]);
           }
          // MessageBox.Show(ch);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            bool etat = checkBox_CocherDécocherTous.Checked?true:false;
            
                for (int i = 0; i < checkedListBox_Examens.Items.Count; i++)
                {
                    checkedListBox_Examens.SetItemChecked(i, etat);
                }

                if (etat)
                {
                    Afficher();
                    dataview.RowFilter = ch;
                    dataGridView1.DataSource = dataview;
                }
                else
                {
                    dataview.RowFilter = "1=0";

                    dataGridView1.DataSource = dataview;
                }
           
        }

        private void radioButton_Decroissant_CheckedChanged(object sender, EventArgs e)
        {
            dataview.Sort = "Examen desc";
        }

        private void radioButton_Croissant_CheckedChanged(object sender, EventArgs e)
        {
            dataview.Sort = "Examen";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
