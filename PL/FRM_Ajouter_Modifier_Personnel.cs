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
using System.Xml.Serialization;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajouter_Modifier_Personnel : Form
    {
        private UserControl usPersonnel;
        public FRM_Ajouter_Modifier_Personnel(UserControl userP)
        {
            InitializeComponent();
            this.usPersonnel = userP;
        }
        string TestObligatoire()
        {
            if ((txtCIN.Text == "" || txtCIN.Text == "CIN"))
            {
                return "Entre le numero dela carte d'identité";
            }
            if ((txtNom.Text == "" || txtNom.Text == "Nom Complet"))
            {
                return "Veuillez saisir le nom de l'employé";
            }
            if (txtAdresse.Text == "" || txtAdresse.Text == "Adresse")
            {
                return "l'adresse est requise";

            }

            if (txtNumTelephone.Text == "" || txtNumTelephone.Text == "Numero de telephone")
            {
                return "Le nmero de telephone est requis";

            }
            
            return null;
        }
         private void button2_Click(object sender, EventArgs e)
         {
            this.Close();
         }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "")
            {
                txtAdresse.Text = "Adresse";
                txtAdresse.ForeColor = Color.Silver;
            }
        }

        private void txtAdresse_Enter(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "Adresse")
            {
                txtAdresse.Text = "";
                txtAdresse.ForeColor = Color.White;

            }
        }

        private void txtCIN_Enter(object sender, EventArgs e)
        {
            if (txtCIN.Text == "CIN")
            {
                txtCIN.Text = "";
                txtCIN.ForeColor = Color.White;

            }
        }

        private void txtPoste_Enter(object sender, EventArgs e)
        {
            if (txtPoste.Text == "Poste")
            {
                txtPoste.Text = "";
                txtPoste.ForeColor = Color.White;

            }
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom Complet")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;

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

        private void txtCIN_Leave(object sender, EventArgs e)
        {
            if (txtCIN.Text == "")
            {
                txtCIN.Text = "CIN";
                txtCIN.ForeColor = Color.Silver;
            }
        }

        private void txtPoste_Leave(object sender, EventArgs e)
        {
            if (txtPoste.Text == "")
            {
                txtPoste.Text = "Poste";
                txtPoste.ForeColor = Color.Silver;
            }
        }

        private void txtNumTelephone_Leave(object sender, EventArgs e)
        {
            if (txtNumTelephone.Text == "")
            {
                txtNumTelephone.Text = "Numero de telephone";
                txtNumTelephone.ForeColor = Color.Silver;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom Complet";
                txtNom.ForeColor = Color.Silver;
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
            if (labeltitre.Text == "Ajouter Employé :")
            {
                BL.Cls_Personnel ClPersonnel = new BL.Cls_Personnel();
                if (ClPersonnel.AjouterPersonnel(txtCIN.Text, txtNom.Text, txtAdresse.Text, txtNumTelephone.Text, txtPoste.Text))
                {
                    MessageBox.Show("Employé Ajouté avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    (usPersonnel as User_Liste_Personnel).ActualiserGrid();
                }
                else
                {
                    MessageBox.Show("CIN Deja existat", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BL.Cls_Personnel ClPersonnel = new BL.Cls_Personnel();
                DialogResult R = MessageBox.Show("Voulez vous vraiment modifier les informations de cet employé ?", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    ClPersonnel.ModifierPersonnel(IdSelect, txtCIN.Text, txtNom.Text,txtAdresse.Text,txtNumTelephone.Text,txtPoste.Text) ;
                    MessageBox.Show("Informations modifié avec succés", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usPersonnel as User_Liste_Personnel).ActualiserGrid();

                }
                else
                {
                    MessageBox.Show("Modification annulée", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            txtAdresse.Text = "Adresse";
            txtAdresse.ForeColor = Color.Silver;
            txtCIN.Text = "CIN";
            txtCIN.ForeColor = Color.Silver;
            txtNom.Text = "Nom Complet";
            txtNom.ForeColor = Color.Silver;
            txtPoste.Text = "Poste";
            txtPoste.ForeColor = Color.Silver;
            txtNumTelephone.Text = "Numero de telephone";
            txtNumTelephone.ForeColor = Color.Silver;
        }

        private void FRM_Ajouter_Modifier_Personnel_Load(object sender, EventArgs e)
        {

        }
    }
}
