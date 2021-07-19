using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADOX_GestionVentesPro.Données;
using ADOX_GestionVentesPro.Properties;

namespace ADOX_GestionVentesPro
{
    public static class Utilitaires
    {
        /// <summary>
        /// Positions de navigation dans une source de données.
        /// </summary>
        public enum POSITIONS
        {
            Premier, Précédent, Suivant, Dernier
        }

        /// <summary>
        /// Vérifie si l'instance d'un formulaire existe encore dans la mémoire. 
        /// </summary>
        /// <param name="Formulaire">Objet du formulaire à vérifier.</param>
        /// <returns></returns>
        public static bool FormulaireExiste(Form Formulaire)
        {
            if (Formulaire == null || Formulaire.IsDisposed)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Enlève la limite sur la valeur maximale des contrôles NumericUpDown et la met au maximum
        /// du type de donnée affiché par le contrôle (par défaut decimal).
        /// </summary>
        /// <param name="NumericUpDownControls">Collection des contrôles NumericUpDown à maximiser.</param>
        public static void MaximiserNumericUpDownValue(params Control[] NumericUpDownControls)
        {
            foreach (Control control in NumericUpDownControls)
            {
                if (control.GetType() == typeof(NumericUpDown))
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Maximum = decimal.MaxValue;
                }
            }
        }

        /// <summary>
        /// Initialise la valeur des contrôles NumericUpDown.
        /// </summary>
        /// <param name="NumericUpDownControls">Collection des contrôles NumericUpDown à initialiser.</param>
        public static void InitialiserNumericUpDownValue(params Control[] NumericUpDownControls)
        {
            foreach (Control control in NumericUpDownControls)
            {
                if (control.GetType() == typeof(NumericUpDown))
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = numericUpDown.Minimum;
                }
            }
        }

        /// <summary>
        /// Initialise le texte des contrôles TextBox.
        /// </summary>
        /// <param name="NumericUpDownControls">Collection des contrôles TextBox à initialiser.</param>
        public static void InitialiserTextBoxText(params Control[] TextBoxControls)
        {
            foreach (Control control in TextBoxControls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }

        /// <summary>
        /// Initialise les éléments et les images des contrôles ListView.
        /// </summary>
        /// <param name="ListViewControls"></param>
        public static void InitialiserListView(params Control[] ListViewControls)
        {
            foreach (Control control in ListViewControls)
            {
                if (control.GetType() == typeof(ListView))
                {
                    ListView listView = (ListView)control;
                    listView.LargeImageList.Images.Clear();
                    listView.Items.Clear();
                }
            }
        }

        /// <summary>
        /// Convertit un objet Image en tableau d'octects.
        /// </summary>
        /// <param name="ObjetImage">l'objet Image à convertir.</param>
        /// <returns>Tableau d'octects représentant l'image.</returns>
        public static byte[] ImageEnOctects(Image ObjetImage)
        {
            MemoryStream Flux = new MemoryStream();
            ObjetImage.Save(Flux, System.Drawing.Imaging.ImageFormat.Jpeg);
            return Flux.ToArray(); ;
        }

        /// <summary>
        /// Convertit un tableau d'octects en objet Image.
        /// </summary>
        /// <param name="image">Tableau d'octects à convertir.</param>
        /// <returns>Objet Image.</returns>
        public static Image ChampsEnImage(object ChampsImage)
        {
            byte[] TableauOctects = (byte[])ChampsImage;
            MemoryStream Flux = new MemoryStream(TableauOctects);
            return Image.FromStream(Flux);
        }

        /// <summary>
        /// Permet de choisir des images depuis le disque
        /// et les importe dans une liste d'images.
        /// </summary>
        /// <returns>Liste d'images.</returns>
        public static ImageList ImporterImagesEnListView (ListView ListViewControl)
        {
            ListViewControl = new ListView();
            ListViewControl.LargeImageList = new ImageList();
            ImageList ListeImages = new ImageList();
            OpenFileDialog Explorateur = new OpenFileDialog();
            Explorateur.Filter = "Fichiers image (*.jpg)|*.jpg; *.jpeg; *.png; *.gif *.bmp;";
            Explorateur.Multiselect = true;
            if (Explorateur.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < Explorateur.FileNames.Length; i++)
                {
                    string nom = i + "_" + Explorateur.SafeFileNames[i];
                    Image image = Image.FromFile(Explorateur.FileNames[i]);
                    
                    ListeImages.Images.Add(image);
                    
                    ListViewControl.LargeImageList.Images.Add(nom, image);
                    ListViewControl.Items.Add(nom, nom);
                }
            }
            return ListeImages;
        }

        /// <summary>
        /// Obtient ou sauvegarde la date de mise à jour dans les paramètres.
        /// </summary>
        /// <param name="Sauvegarder">Si vrai sauvegarde la date dans les paramètres.</param>
        /// <returns></returns>
        public static DateTime DateMiseÀJour(bool Sauvegarder)
        {
            if (Sauvegarder)
            {
                Settings.Default.Date_MiseAJour_Produits = DateTime.Now;
                Settings.Default.Save();
            }
            return Settings.Default.Date_MiseAJour_Produits;
        }

        /// <summary>
        /// Définit les propriétés d'auto-incrémentation pour une colonne
        /// depuis un objet de gestion de données.
        /// </summary>
        /// <param name="Gestionnaire">Objet de gestion de données contenant la table
        /// de la colonne ciblée.</param>
        /// <param name="NomChamps">Nom de la colonne.</param>
        /// <param name="ValeurDépart">Valeur de départ de la colonne.</param>
        /// <param name="Pas">Incrément utilisé par la colonne.</param>
        public static void DéfinirAutoIncrémentation(GestionDonnées Gestionnaire, string NomChamps, int ValeurDépart, int Pas)
        {
            Gestionnaire.Table.Columns[NomChamps].AutoIncrement = true;
            Gestionnaire.Table.Columns[NomChamps].AutoIncrementSeed = ValeurDépart;
            Gestionnaire.Table.Columns[NomChamps].AutoIncrementStep = Pas;
        }
    }
}
