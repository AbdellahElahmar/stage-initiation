using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace GestionDeStock.PL
{
    public partial class User_Liste_Produit : UserControl
    {
        private static User_Liste_Produit UserClient;
        private dbstockContext db;
        public static User_Liste_Produit Instance
        {
            get
            {
                if (UserClient == null)
                {
                    UserClient = new User_Liste_Produit();
                }
                return UserClient;
            }
        }
        public User_Liste_Produit()
        {
            InitializeComponent();
            db = new dbstockContext();

        }
        public void ActualiserdvgProduit()
        {
            db = new dbstockContext();
            dvgProduit.Rows.Clear();
            Categorie Cat = new Categorie();
            foreach(var lis in db.Produits)
            {

                Cat = db.Categories.SingleOrDefault(s=> s.ID_Categorie== lis.ID_Categorie);
                if (Cat != null )
                {
                    dvgProduit.Rows.Add(false, lis.ID_Produit, lis.Designation, lis.Reference,Cat.Nom_Categorie, lis.Quantite_Produit, lis.Prix_Produit);
                }
            }
            for (int i = 0;i< dvgProduit.Rows.Count; i++)
            {
                if ((int)dvgProduit.Rows[i].Cells[5].Value == 0)
                {
                    dvgProduit.Rows[i].Cells[5].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgProduit.Rows[i].Cells[5].Style.BackColor = Color.LightGreen;
                }
            }
        }
        public string SelectVerif()
        {
            int NombreNombreLignesSelect = 0;
            for(int i=0;i<dvgProduit.Rows.Count;i++)
            {
                if((bool)dvgProduit.Rows[i].Cells[0].Value==true)
                {
                    NombreNombreLignesSelect++;
                }
            }
            if(NombreNombreLignesSelect==0)
            {
                return "Selectionner Un produit";
            }
            if (NombreNombreLignesSelect > 1)
            {
                return "Selectionner 1 seul produit";
            }
            return null;

        }

        private void User_Liste_Produit_Load(object sender, EventArgs e)
        {
            ActualiserdvgProduit();
        }

        private void textBoxRechercher_Enter(object sender, EventArgs e)
        {
            if (textBoxRechercher.Text == "Rechercher")
            {
                textBoxRechercher.Text = "";
                textBoxRechercher.ForeColor = Color.Black;
            }
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouet_Modifier_Produit Frmproduit = new PL.FRM_Ajouet_Modifier_Produit(this);
            Frmproduit.ShowDialog();
        }

        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            Produit Pr = new Produit();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PL.FRM_Ajouet_Modifier_Produit FrmProduit = new PL.FRM_Ajouet_Modifier_Produit(this);
                FrmProduit.lbltitre.Text = "Modifier Produit";
                FrmProduit.btnActualiser.Visible = false;
                for (int i= 0; i < dvgProduit.Rows.Count; i++)
                {
                    if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MYIDSELECT = (int)dvgProduit.Rows[i].Cells[1].Value;
                        Pr = db.Produits.SingleOrDefault(s=>s.ID_Produit == MYIDSELECT);
                        if (Pr != null)
                        {

                            FrmProduit.txtBoxRef.Text = dvgProduit.Rows[i].Cells[3].Value.ToString();
                            FrmProduit.textBoxDesignation.Text = dvgProduit.Rows[i].Cells[2].Value.ToString();
                            FrmProduit.comboCategorie.Text = dvgProduit.Rows[i].Cells[4].Value.ToString();
                            FrmProduit.txtBoxQuantite.Text = dvgProduit.Rows[i].Cells[5].Value.ToString();
                            FrmProduit.txtBoxPrix.Text = dvgProduit.Rows[i].Cells[6].Value.ToString();
                            FrmProduit.IDPRODUIT = (int)dvgProduit.Rows[i].Cells[1].Value;
                        }
                     

                        

                    } 
                }
            FrmProduit.ShowDialog();

            }

            
            
            
            
        }

        private void dvgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSupprimerProduit_Click(object sender, EventArgs e)
        {
            if(SelectVerif()== "Selectionner Un produit")
            {
                MessageBox.Show(SelectVerif(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult DR = MessageBox.Show("Voulez vraiment supprimer ce produit ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DR==DialogResult.Yes)
                {
                    for (int i = 0; i < dvgProduit.Rows.Count; i++)
                    {
                        if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                        {
                            BL.CLS_Produit clProduit = new BL.CLS_Produit();
                            int idSelect = (int)dvgProduit.Rows[i].Cells[1].Value;
                            clProduit.SupprimerProduit(idSelect);

                        }
                        ActualiserdvgProduit();
                        MessageBox.Show("Le produit a bien été supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
                else
                {
                    MessageBox.Show("Supression Annulée", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            db = new dbstockContext();
            var listrechercher = db.Produits.ToList();
            if (textBoxRechercher.Text != "")
            {
                switch (ComboRechaerche.Text)
                {
                    case "Designation":
                        listrechercher = listrechercher.Where(s => s.Designation.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Reference":
                        listrechercher = listrechercher.Where(s => s.Reference.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    
                    

                }
            }
            dvgProduit.Rows.Clear();
            Categorie Cat = new Categorie();
            foreach (var l in listrechercher)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == l.ID_Categorie);
                dvgProduit.Rows.Add(false, l.ID_Produit,l.Designation, l.Reference, Cat.Nom_Categorie, l.Quantite_Produit, l.Prix_Produit);
            }
            
            
        }

        private void BtnActualiser_Click(object sender, EventArgs e)
        {
            ActualiserdvgProduit();
        }

        private void ComboRechaerche_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRechercher.Enabled = true;
            textBoxRechercher.Text = "";
        }
    }
}
