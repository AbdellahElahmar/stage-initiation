using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajouter_Modifier_Categorie : Form
    {
        private UserControl UserCat;
        public FRM_Ajouter_Modifier_Categorie(UserControl UserCategorie)
        {
            InitializeComponent();
            this.UserCat = UserCategorie;
        }

        private void FRM_Ajouter_Modifier_Categorie_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public int IdCategorie;
        private void txtBoxCategorie_Enter(object sender, EventArgs e)
        {
            if(txtBoxCategorie.Text=="Nom de la categorie")
            {
                txtBoxCategorie.Text = "";
                txtBoxCategorie.ForeColor = Color.White;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Categorie ClCat = new BL.CLS_Categorie();
            if (txtBoxCategorie.Text == "" || txtBoxCategorie.Text == "Nom de la categorie")
            {
                MessageBox.Show("Saisissez le nom de la categorie a ajouter", "Ajouter Categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lbltitre.Text == "Ajouter Categorie")
                {
                    if (ClCat.Ajouter_Categorie(txtBoxCategorie.Text) == false)
                    {
                        MessageBox.Show("La categorie existe deja ", "Ajouter Categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Categorie Ajoutée avec succes", "Ajouter Categorie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UserCat as USER_LIST_Categorie).RemplirDataGrid();
                    }

                }
                if (lbltitre.Text == "Modifier Categorie")
                {
                    DialogResult DR = MessageBox.Show("Voulez vous vraiment modifier cette categorie ? ", "Modifier Categorie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        ClCat.ModifierCategorie(IdCategorie, txtBoxCategorie.Text);
                        MessageBox.Show("Categorie Modifiée avec succes", "Modifier Categorie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UserCat as USER_LIST_Categorie).RemplirDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Modification echouée", "Modifier Categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        
    }
}
