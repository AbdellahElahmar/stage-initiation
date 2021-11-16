using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajouet_Modifier_Produit : Form
    {
        private dbstockContext db;
        private UserControl UserProduit;

        public FRM_Ajouet_Modifier_Produit(UserControl User)
        {
            InitializeComponent();
            db = new dbstockContext();
            this.UserProduit = User;
            comboCategorie.DataSource = db.Categories.ToList();
            comboCategorie.DisplayMember = "Nom_Categorie";
            comboCategorie.ValueMember = "ID_Categorie";
            

        }
        string testObligatoire()
        {
            if(txtBoxRef.Text=="Reference" || txtBoxRef.Text=="")
            {
                return "la reference est obligatoire";
            }
            if (txtBoxQuantite.Text == "Quantité" || txtBoxQuantite.Text == "")
            {
                return "Saisissez la quantité";
            }
            if (txtBoxPrix.Text == "Prix Unitaire" || txtBoxRef.Text == "")
            {
                return "Saisissez le prix";
            }
            
            if(comboCategorie.Text=="")
            {
                return " Entre la categorie";
            }
            
            return null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxRef_Enter(object sender, EventArgs e)
        {
            if(txtBoxRef.Text=="Reference")
            {
                txtBoxRef.Text = "";
                txtBoxRef.ForeColor = Color.White;
            }
        }

        private void txtBoxRef_Leave(object sender, EventArgs e)
        {
            if(txtBoxRef.Text=="")
            {
                txtBoxRef.Text = "Reference";
                txtBoxRef.ForeColor = Color.Silver;
            }
        }

        private void txtBoxQuantite_Leave(object sender, EventArgs e)
        {
            if(txtBoxQuantite.Text=="")
            {
                txtBoxQuantite.Text = "Quantité";
                txtBoxQuantite.ForeColor = Color.Silver;
            }
        }

        private void txtBoxQuantite_Enter(object sender, EventArgs e)
        {
            if (txtBoxQuantite.Text == "Quantité")
            {
                txtBoxQuantite.Text = "";
                txtBoxQuantite.ForeColor = Color.White;
            }
        }

        private void txtBoxPrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPrix_Leave(object sender, EventArgs e)
        {
            if(txtBoxPrix.Text=="")
            {
                txtBoxPrix.Text = "Prix Unitaire";
                txtBoxPrix.ForeColor = Color.Silver;
            }
        }

        private void txtBoxPrix_Enter(object sender, EventArgs e)
        {
            if(txtBoxPrix.Text=="Prix Unitaire")
            {
                txtBoxPrix.Text = "";
                txtBoxPrix.ForeColor = Color.White;
            }
        }

        

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            txtBoxRef.Text = "Reference";
            txtBoxRef.ForeColor = Color.Silver;
            textBoxDesignation.Text = "Designation";
            textBoxDesignation.ForeColor = Color.Silver;
            txtBoxPrix.Text = "Prix Unitaire";
            txtBoxPrix.ForeColor = Color.Silver;
            txtBoxQuantite.Text = "Quantité";
            txtBoxQuantite.ForeColor = Color.Silver;
            comboCategorie.Text = "";
        }

        private void txtBoxQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        

        private void FRM_Ajouet_Modifier_Produit_Load(object sender, EventArgs e)
        {

        }
        public int IDPRODUIT;

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(testObligatoire()!=null)
            {
                MessageBox.Show(testObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lbltitre.Text=="Ajouter Produit")
                {
                    BL.CLS_Produit ClpProduit = new BL.CLS_Produit();
                    MemoryStream MR = new MemoryStream();
                    
                    if(ClpProduit.Ajouter_Produit(txtBoxRef.Text,textBoxDesignation.Text, int.Parse(txtBoxQuantite.Text),txtBoxPrix.Text,Convert.ToInt32(comboCategorie.SelectedValue))==true)
                    {
                        MessageBox.Show("Produit Ajouté ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UserProduit as User_Liste_Produit).ActualiserdvgProduit();
                    }
                    else
                    {
                        MessageBox.Show("Produit exiiste deja ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MemoryStream MR = new MemoryStream();
                    BL.CLS_Produit clsProduit = new BL.CLS_Produit();
                    DialogResult RS = MessageBox.Show("voulez vous vraiment Modifier ce produit ?", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (RS == DialogResult.Yes)
                    {          
                        clsProduit.modifierProduit(IDPRODUIT, txtBoxRef.Text,textBoxDesignation.Text, int.Parse(txtBoxQuantite.Text), txtBoxPrix.Text, Convert.ToInt32(comboCategorie.SelectedValue));
                        MessageBox.Show("Produit modifié avec succes ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (UserProduit as User_Liste_Produit).ActualiserdvgProduit();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Modification Annulée", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        private void comboFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDesignation_Enter(object sender, EventArgs e)
        {
            if (textBoxDesignation.Text == "Designation")
            {
                textBoxDesignation.Text = "";
                textBoxDesignation.ForeColor = Color.White;
            }
        }

        private void textBoxDesignation_Leave(object sender, EventArgs e)
        {
            if (textBoxDesignation.Text == "")
            {
                textBoxDesignation.Text = "Designation";
                textBoxDesignation.ForeColor = Color.Silver;
            }
        }
    }
}
