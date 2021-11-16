using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class User_List_Fournisseur : UserControl
    {
        private static User_List_Fournisseur UserFournisseur;
        private dbstockContext db;
        public static User_List_Fournisseur Instance
        {
            get
            {
                if (UserFournisseur == null)
                {
                    UserFournisseur = new User_List_Fournisseur();
                }
                return UserFournisseur;
            }
        }


        public User_List_Fournisseur()
        {
            InitializeComponent();
            db = new dbstockContext();
            textBoxRechercher.Enabled = false;
        }
        public void ActualiserGrid()
        {
            db = new dbstockContext();
            dvgFournisseur.Rows.Clear();
            foreach (var S in db.Fournisseurs)
            {
                dvgFournisseur.Rows.Add(false, S.Id_Fournisseur, S.Nom_Fournisseur, S.Telephone_Fournisseur, S.Adresse_Fournisseur);
            }
        }
        public string SelectVerif()
        {
            int Nombrelignesselect = 0;
            for (int i = 0; i < dvgFournisseur.Rows.Count; i++)
            {
                if ((bool)dvgFournisseur.Rows[i].Cells[0].Value == true)
                {
                    Nombrelignesselect++;
                }

            }
            if (Nombrelignesselect == 0)
            {
                return "Selectionner le fournisseur à modifer";
            }
            if (Nombrelignesselect > 1)
            {
                return " Selectionner seulement 1 fournisseur";
            }

            return null;
        }

        private void User_List_Fournisseur_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void textBoxRechercher_Enter(object sender, EventArgs e)
        {
            if (textBoxRechercher.Text == "Rechercher")
            {
                textBoxRechercher.Text = "";
                textBoxRechercher.ForeColor = Color.Black;
            }
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            db = new dbstockContext();
            var listrechercher = db.Fournisseurs.ToList();
            if (textBoxRechercher.Text != "")
            {
                switch (ComboRechaerche.Text)
                {
                    case "Nom":
                        listrechercher = listrechercher.Where(s => s.Nom_Fournisseur.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    

                }
            }
            dvgFournisseur.Rows.Clear();
            foreach (var l in listrechercher)
            {
                dvgFournisseur.Rows.Add(false, l.Id_Fournisseur, l.Nom_Fournisseur, l.Telephone_Fournisseur, l.Adresse_Fournisseur);
            }
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            FRM_AJOUTER_MODIFIER_FOURNISSEUR FrmFournisseur = new FRM_AJOUTER_MODIFIER_FOURNISSEUR(this);
            FrmFournisseur.ShowDialog();
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            FRM_AJOUTER_MODIFIER_FOURNISSEUR Frmfournisseur = new FRM_AJOUTER_MODIFIER_FOURNISSEUR(this);
            if (SelectVerif() == null)
            {
                for (int i = 0; i < dvgFournisseur.Rows.Count; i++)
                {
                    if ((bool)dvgFournisseur.Rows[i].Cells[0].Value == true)
                    {

                        Frmfournisseur.IdSelect = (int)dvgFournisseur.Rows[i].Cells[1].Value;
                        Frmfournisseur.txtNomfournisseur.Text = dvgFournisseur.Rows[i].Cells[2].Value.ToString();
                        Frmfournisseur.txtNumTelephone.Text = dvgFournisseur.Rows[i].Cells[3].Value.ToString();
                        Frmfournisseur.txtAdresse.Text = dvgFournisseur.Rows[i].Cells[4].Value.ToString();


                    }
                }
                Frmfournisseur.labeltitre.Text = "Modifier Fournisseur";
                Frmfournisseur.labeltitre.ForeColor = Color.Silver;
                Frmfournisseur.btnActualiser.Visible = false;
                Frmfournisseur.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            BL.CLS_Fournisseur ClFournisseur = new BL.CLS_Fournisseur();
            int select = 0;
            for (int i = 0; i < dvgFournisseur.Rows.Count; i++)
            {
                if ((bool)dvgFournisseur.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }

            }
            if (select == 0)
            {
                MessageBox.Show("Aucun Fournisseur selectionnée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voules-vous vraiment supprimer ce Fournisseur ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dvgFournisseur.Rows.Count; i++)
                    {
                        if ((bool)dvgFournisseur.Rows[i].Cells[0].Value == true)
                        {
                            ClFournisseur.SupprimerFournisseur(int.Parse(dvgFournisseur.Rows[i].Cells[1].Value.ToString()));

                        }

                    }
                    ActualiserGrid();
                    MessageBox.Show("Suppression avec succés", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppresion annulée", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void ComboRechaerche_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRechercher.Enabled = true;
            textBoxRechercher.Text = "";
        }
    }
}
