using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data.Common;

namespace GestionDeStock.PL
{
    public partial class USER_LIST_Categorie : UserControl
    {
        private static USER_LIST_Categorie userCategorie;
        private dbstockContext db;
        public static USER_LIST_Categorie instance
        {
            get
            {
                if(userCategorie==null)
                {
                    userCategorie = new USER_LIST_Categorie();
                }
                return userCategorie;
            }
        }
        public USER_LIST_Categorie()
        {
            InitializeComponent();
            db = new dbstockContext();

        }









        private void USER_LIST_Categorie_Load(object sender, EventArgs e)
        {
            RemplirDataGrid();
        }

        public void RemplirDataGrid()
        {
            db = new dbstockContext();
            dvgCategorie.Rows.Clear();
            foreach(var cat in db.Categories)
            {
                dvgCategorie.Rows.Add(false, cat.ID_Categorie, cat.Nom_Categorie);
            }
        }
        private void textBoxRechercher_Enter(object sender, EventArgs e)
        {
            if(textBoxRechercher.Text=="echercher")
            {
                textBoxRechercher.Text = "";
                textBoxRechercher.ForeColor = Color.Black;
            }
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Categorie frmCat = new PL.FRM_Ajouter_Modifier_Categorie(this);
            frmCat.ShowDialog();
        }

        private void dvgCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Categorie frmCat = new PL.FRM_Ajouter_Modifier_Categorie(this);
            if (dvgCategorie.Columns[e.ColumnIndex].Name == "Modifier")
            {
                frmCat.IdCategorie = (int)dvgCategorie.Rows[e.RowIndex].Cells[1].Value;
                frmCat.lbltitre.Text = "Modifier Categorie";
                frmCat.txtBoxCategorie.Text = dvgCategorie.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmCat.ShowDialog();
            }
            if (dvgCategorie.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                BL.CLS_Categorie clsCat = new BL.CLS_Categorie();
                DialogResult PR = MessageBox.Show("Voulez vous vaiment supprimer cette Categorie", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {
                    int idcat = (int)dvgCategorie.Rows[e.RowIndex].Cells[1].Value;
                    int P = db.Produits.Count(s => s.ID_Categorie == idcat);
                    if (P == 0)
                    {
                        clsCat.SupprimerCategorie(idcat);
                        RemplirDataGrid();
                        MessageBox.Show("Categorie Supprimée avec succés", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        
                    }
                    else
                    {
                        DialogResult PDP = MessageBox.Show("Il y'a" + P + "Produit de cette categorie.Voulez vous vraiment supprimer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (PDP == DialogResult.Yes)
                        {
                            clsCat.SupprimerCategorie(idcat);
                            RemplirDataGrid();
                            MessageBox.Show("Categorie Supprimée avec succes.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                        else
                        {
                            MessageBox.Show("Suppression Annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            var maliste = db.Categories.ToList();
            maliste = maliste.Where(s => s.Nom_Categorie.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dvgCategorie.Rows.Clear();
            foreach(var l in maliste)
            {
                dvgCategorie.Rows.Add(false, l.ID_Categorie, l.Nom_Categorie);
                
            }
        }
    }
}
