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
    public partial class FRM_Details_Commande : Form
    {
        private UserControl UserCommand;
        private dbstockContext db;
        public FRM_Details_Commande(UserControl User)
        {
            InitializeComponent();
            db = new dbstockContext();
            UserCommand = User;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            BL.D_Commande.DetailsCommande.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.FRM_LISTE_FOURNISSEUR FRMF = new PL.FRM_LISTE_FOURNISSEUR();
            FRMF.ShowDialog();
            IDFournisseur = (int)FRMF.dvgFournisseur.CurrentRow.Cells[0].Value;
            textBoxFournisseur.Text = FRMF.dvgFournisseur.CurrentRow.Cells[1].Value.ToString();
            textBoxNumtel.Text = FRMF.dvgFournisseur.CurrentRow.Cells[3].Value.ToString();
            textBoxAdresse.Text = FRMF.dvgFournisseur.CurrentRow.Cells[2].Value.ToString();
            
        }

        public void ActualiserDetailCommande()
        {
            float totalHT = 0, TVA = 0;
            
            float totalTTC;
            if (textBoxTVA.Text != "")
            {
                TVA = int.Parse(textBoxTVA.Text);
            }
            dvgDetailCommande.Rows.Clear();
            foreach (var L in BL.D_Commande.DetailsCommande)
            {
                dvgDetailCommande.Rows.Add(L.Reference, L.Quantite, L.Prix, L.Total); ;
                totalHT = totalHT + float.Parse(L.Total);
            }
            textBoxTTHT.Text = totalHT.ToString();
            
            totalTTC = (totalHT + (totalHT * TVA /100));
            textBoxTTC.Text = totalTTC.ToString();
        }
        public int IDFournisseur;
        public float totalHT = 0, TVA = 0;
        public float SommeTVA;
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Commande_DetailCommande clsCommande = new BL.CLS_Commande_DetailCommande();
            
            if (dvgDetailCommande.Rows.Count == 0)
            {
                MessageBox.Show("Ajouter un produit a la commande ", "Ajouter Bon", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (textBoxFournisseur.Text == "")
                {
                    MessageBox.Show("Siassiez le com du fournisseur ", "Ajouter Bon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TVA = float.Parse(textBoxTVA.Text);
                    totalHT = float.Parse(textBoxTTHT.Text);
                    SommeTVA = TVA * totalHT / 100;
                    
                    clsCommande.Ajouter_Commande(Commandedate.Value, textBoxTTHT.Text, textBoxTVA.Text,textBoxTTC.Text,SommeTVA.ToString(), IDFournisseur);
                    foreach (var l in BL.D_Commande.DetailsCommande)
                    {


                        clsCommande.AjouterDetailsCom(l.Designation,l.Reference, l.Quantite, l.Prix, l.Total);
                        
                        
                    }
                    (UserCommand as USER_LISTE_Commande).RemplireData();
                    BL.D_Commande.DetailsCommande.Clear();
                    Close();
                    MessageBox.Show("Commande ajoutée avec succes ", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

        }

        private void BtnAjouterproduit_Click(object sender, EventArgs e)
        {
            FRM_PRODUIT_COMMANDE FRMPC = new FRM_PRODUIT_COMMANDE(this);
            FRMPC.ShowDialog();
        }

        private void FRM_Details_Commande_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUIT_COMMANDE frmpc = new FRM_PRODUIT_COMMANDE(this);
            frmpc.textBoxRef.Text = dvgDetailCommande.CurrentRow.Cells[0].Value.ToString();
            frmpc.textBoxQuantite.Text = dvgDetailCommande.CurrentRow.Cells[1].Value.ToString();
            frmpc.textBoxPrixU.Text = dvgDetailCommande.CurrentRow.Cells[2].Value.ToString();
            frmpc.textBoxTotal.Text = dvgDetailCommande.CurrentRow.Cells[3].Value.ToString();
            frmpc.ShowDialog();

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvgDetailCommande.CurrentRow != null)
            {
                DialogResult PR = MessageBox.Show("Voulez vous vraiment supprimer ce produit de la commande ? ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {
                    int index = BL.D_Commande.DetailsCommande.FindIndex(s => s.Reference == dvgDetailCommande.CurrentRow.Cells[0].Value.ToString());
                    BL.D_Commande.DetailsCommande.RemoveAt(index);
                    ActualiserDetailCommande();
                    MessageBox.Show("Supression avec succes", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Supression echouée", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
