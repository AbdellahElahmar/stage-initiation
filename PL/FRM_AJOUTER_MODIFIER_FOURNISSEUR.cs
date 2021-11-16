using GestionDeStock.BL;
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
    public partial class FRM_AJOUTER_MODIFIER_FOURNISSEUR : Form
    {
        private UserControl UsFournisseur;
        public FRM_AJOUTER_MODIFIER_FOURNISSEUR(UserControl UserF)
        {
            InitializeComponent();
            this.UsFournisseur = UserF;
        }
        string TestObligatoire()
        {
            if ((txtNomfournisseur.Text == "" || txtNomfournisseur.Text == "Nom Fournisseur"))
            {
                return "Entre le nom du fournisseur";
            }
            if ((txtAdresse.Text == "" || txtAdresse.Text == "Adresse"))
            {
                return "Veuillez saisir l'adresse";
            }
            
            
            if (txtNumTelephone.Text == "" || txtNumTelephone.Text == "Numero de telephone")
            {
                return "Le nmero de telephone est requis";

            }
            
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_AJOUTER_MODIFIER_FOURNISSEUR_Load(object sender, EventArgs e)
        {

        }

        private void txtAdresse_Enter(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "Adresse")
            {
                txtAdresse.Text = "";
                txtAdresse.ForeColor = Color.White;

            }
        }

        private void txtNomfournisseur_Enter(object sender, EventArgs e)
        {
            if (txtNomfournisseur.Text == "Nom fournisseur")
            {
                txtNomfournisseur.Text = "";
                txtNomfournisseur.ForeColor = Color.White;
            }
        }

        private void txtNumTelephone_Enter(object sender, EventArgs e)
        {
            if (txtNumTelephone.Text == "Numero de telephone")
            {
                txtNumTelephone.Text = "";
                txtNumTelephone.ForeColor = Color.White;
            }
        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "")
            {
                txtAdresse.Text = "Adresse";
                txtAdresse.ForeColor = Color.Silver;
            }
        }

        private void txtNomfournisseur_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumTelephone_Leave(object sender, EventArgs e)
        {
           if (txtNumTelephone.Text == "")
           {
                txtNumTelephone.Text = "Numero de telephone";
                txtNumTelephone.ForeColor = Color.Silver;
           } 
        }

        private void txtNumTelephone_KeyPress(object sender, KeyPressEventArgs e)
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
        public int IdSelect;
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TestObligatoire() != null)
            {
                MessageBox.Show(TestObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (labeltitre.Text == "Ajouter Fournisseur :")
            {
                BL.CLS_Fournisseur ClFournisseur = new BL.CLS_Fournisseur();
                if (ClFournisseur.AjouterFournisseur(txtNomfournisseur.Text, txtNumTelephone.Text, txtAdresse.Text))
                {
                    MessageBox.Show("Fournisseur Ajoutée avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    (UsFournisseur as User_List_Fournisseur).ActualiserGrid();
                }
                else
                {
                    MessageBox.Show("Nom de fournisseur Deja existat", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BL.CLS_Fournisseur ClFournisseur = new BL.CLS_Fournisseur();
                DialogResult R = MessageBox.Show("Voulez vous vraiment modifier le fournisseur ?", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    ClFournisseur.ModifierFournisseur(IdSelect, txtNomfournisseur.Text, txtNumTelephone.Text, txtAdresse.Text);
                    (UsFournisseur as User_List_Fournisseur).ActualiserGrid();
                    MessageBox.Show("Fournisseur modifié avec succés", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Modification annulée", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            txtNomfournisseur.Text = "Nom Fournisseur";
            txtNomfournisseur.ForeColor = Color.Silver;
            txtAdresse.Text = "Adresse";
            txtAdresse.ForeColor = Color.Silver;
            txtNumTelephone.Text = "Numero de telephone";
            txtNumTelephone.ForeColor = Color.Silver;
        }

        private void txtNomfournisseur_Leave(object sender, EventArgs e)
        {
            if (txtNomfournisseur.Text == "")
            {
                txtNomfournisseur.Text = "Nom fournisseur";
                txtNomfournisseur.ForeColor = Color.Silver;
            }
        }
    }
}
