using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajouter_Modifier_Client : Form
    {
        private UserControl usClient;
        public FRM_Ajouter_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usClient = userC;
        }
        string TestObligatoire()
        {
            if ((txtNumAffaire.Text == "" || txtNumAffaire.Text == "Numero d'affaire"))
            {
                return "Entre le numero daffaire";
            }
            if ((txtLabel.Text == "" || txtLabel.Text == "Label"))
            {
                return "Veuillez saisir le nom de l'affaire";
            }
            if (txtAdresse.Text == "" || txtAdresse.Text == "Adresse")
            {
                return "l'adresse est requise";

            }
            if (txtVille.Text == "" || txtVille.Text == "Ville")
            {
                return " la ville est requise";
            }
            if (txtNumTelephone.Text == "" || txtNumTelephone.Text == "Numero de telephone")
            {
                return "Le nmero de telephone est requis";

            }
            if (txtMail.Text == "" || txtMail.Text == "E-mail")
            {
                return "Veuillez saisir l'adresse mail";
            }
            return null;
        }
        private void FRM_Ajouter_Modifier_Client_Load(object sender, EventArgs e)
        {

        }

        private void TxtNumAffaire_TextChanged(object sender, EventArgs e)
        {



        }

        private void TxtAdresse_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboEtat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtAdresse_Enter(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "Adresse")
            {
                txtAdresse.Text = "";
                txtAdresse.ForeColor = Color.White;

            }
        }

        private void TxtLabel_Enter(object sender, EventArgs e)
        {
            if (txtLabel.Text == "Label")
            {
                txtLabel.Text = "";
                txtLabel.ForeColor = Color.White;
            }
        }

        private void TxtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "E-mail")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.White;
            }
        }

        

        private void TxtVille_Enter(object sender, EventArgs e)
        {
            if (txtVille.Text == "Ville")
            {
                txtVille.Text = "";
                txtVille.ForeColor = Color.White;
            }
        }

        private void TxtNumTelephone_Enter(object sender, EventArgs e)
        {
            if (txtNumTelephone.Text == "Numero de telephone")
            {
                txtNumTelephone.Text = "";
                txtNumTelephone.ForeColor = Color.White;
            }
        }

        private void TxtNumAffaire_Enter(object sender, EventArgs e)
        {
            if (txtNumAffaire.Text == "Numero d'affaire")
            {
                txtNumAffaire.Text = "";
                txtNumAffaire.ForeColor = Color.White;
            }
        }

        private void TxtNumAffaire_Leave(object sender, EventArgs e)
        {
            if (txtNumAffaire.Text == "")
            {
                txtNumAffaire.Text = "Numero d'affaire";
                txtNumAffaire.ForeColor = Color.Silver;
            }
        }

        private void TxtAdresse_Leave(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "")
            {
                txtAdresse.Text = "Adresse";
                txtAdresse.ForeColor = Color.Silver;
            }
        }

        private void TxtVille_Leave(object sender, EventArgs e)
        {
            if (txtVille.Text == "")
            {
                txtVille.Text = "Ville";
                txtVille.ForeColor = Color.Silver;
            }
        }

        private void TxtLabel_Leave(object sender, EventArgs e)
        {
            if (txtLabel.Text == "")
            {
                txtLabel.Text = "Label";
                txtLabel.ForeColor = Color.Silver;
            }
        }

        private void TxtNumTelephone_Leave(object sender, EventArgs e)
        {
            if (txtNumTelephone.Text == "")
            {
                txtNumTelephone.Text = "Numero de telephone";
                txtNumTelephone.ForeColor = Color.Silver;
            }
        }

        private void TxtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "E-mail";
                txtMail.ForeColor = Color.Silver;
            }
        }

        private void ComboEtat_Leave(object sender, EventArgs e)
        {

        }

        private void TxtNumTelephone_KeyPress(object sender, KeyPressEventArgs e)
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
        public void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TestObligatoire() != null)
            {
                MessageBox.Show(TestObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if(labeltitre.Text=="Ajouter Affaire :")
            {
                BL.CLS_Client ClClient = new BL.CLS_Client();
                if(ClClient.AjouterClient(txtNumAffaire.Text, txtLabel.Text, txtNumTelephone.Text, txtAdresse.Text, txtVille.Text, txtMail.Text, txtDateDebut.Text, TxtDateFin.Text, txtEtat.Text))
                {
                    MessageBox.Show("Affaire Ajoutée avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    (usClient as USER_List_CLIENT).ActualiserGrid();
                }
                else
                {
                    MessageBox.Show("Num d'affaire Deja existat", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BL.CLS_Client ClClient = new BL.CLS_Client();
                DialogResult R = MessageBox.Show("Voulez vous vraiment modifier l'affaire?","Modifier",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    ClClient.ModifierClient(IdSelect, txtNumAffaire.Text, txtLabel.Text, txtNumTelephone.Text, txtAdresse.Text, txtVille.Text, txtMail.Text, txtDateDebut.Text, TxtDateFin.Text, txtEtat.Text);
                    (usClient as USER_List_CLIENT).ActualiserGrid();
                    MessageBox.Show("Affaire modifié avec succés", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Modification annulée", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtDateFin_Enter(object sender, EventArgs e)
        {
            if (TxtDateFin.Text == "Date Cloture")
            {
                TxtDateFin.Text = "";
                TxtDateFin.ForeColor = Color.White;
            }
        }

        private void TxtDateFin_Leave(object sender, EventArgs e)
        {
            if (TxtDateFin.Text == "")
            {
                TxtDateFin.Text = "Date Cloture";
                TxtDateFin.ForeColor = Color.Silver;
            }
        }

        private void TxtDateDebut_Enter(object sender, EventArgs e)
        {
            if (txtDateDebut.Text == "Date ouverture dossier")
            {
                txtDateDebut.Text = "";
                txtDateDebut.ForeColor = Color.White;
            }
        }

        private void TxtDateDebut_Leave(object sender, EventArgs e)
        {
            if (txtDateDebut.Text == "")
            {
                txtDateDebut.Text = "Date ouverture dossier";
                txtDateDebut.ForeColor = Color.Silver;
            }
        }

        public void BtnActualiser_Click(object sender, EventArgs e)
        {
            txtMail.Text = "E-mail";
            txtMail.ForeColor = Color.Silver;
            TxtDateFin.Text = "Date Cloture";
            TxtDateFin.ForeColor = Color.Silver;
            txtNumTelephone.Text = "Numero de telephone";
            txtNumTelephone.ForeColor = Color.Silver;
            txtDateDebut.Text = "Date ouverture dossier";
            txtDateDebut.ForeColor = Color.Silver;
            TxtDateFin.Text = "Date Cloture";
            TxtDateFin.ForeColor = Color.Silver;
            txtLabel.Text = "Label";
            txtLabel.ForeColor = Color.Silver;
            txtNumAffaire.Text = "Numero d'affaire";
            txtNumAffaire.ForeColor = Color.Silver;
            txtAdresse.Text = "Adresse";
            txtAdresse.ForeColor = Color.Silver;
            txtVille.Text = "Ville";
            txtVille.ForeColor = Color.Silver;
        }

        private void TxtEtat_Enter(object sender, EventArgs e)
        {
            if(txtEtat.Text=="Etat Affaire")
            {
                txtEtat.Text = "";
                txtEtat.ForeColor = Color.White;
            }
        }

        private void TxtEtat_Leave(object sender, EventArgs e)
        {
            if(txtEtat.Text == "")
            {
                txtEtat.Text = "Etat Affaire";
                txtEtat.ForeColor = Color.Silver;
            }
        }

        
    }
}

        
