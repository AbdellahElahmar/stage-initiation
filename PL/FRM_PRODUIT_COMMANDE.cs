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
    public partial class FRM_PRODUIT_COMMANDE : Form
    {
        public Form FRMDETAILCOMMANDE;
        public FRM_PRODUIT_COMMANDE(Form frm)
        {
            InitializeComponent();
            FRMDETAILCOMMANDE = frm;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantite_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            BL.D_Commande Detail = new BL.D_Commande
            {
                Reference = textBoxRef.Text,
                Quantite = int.Parse(textBoxQuantite.Text),
                Prix = textBoxPrixU.Text,
                Total = textBoxTotal.Text
                
            };
            if (groupBoxCommande.Text == "Ajouter a la commande :")
            {
                if (BL.D_Commande.DetailsCommande.SingleOrDefault(s => s.Reference == Detail.Reference) != null)
                {
                    MessageBox.Show("Produit deja existant dans la commande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BL.D_Commande.DetailsCommande.Add(Detail);
                    Close();
                }
            }
            else
            {
                DialogResult PR = MessageBox.Show("Voulez vous vraiment modifier ? ", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {
                    int index = BL.D_Commande.DetailsCommande.FindIndex(s => s.Reference == textBoxRef.Text);
                    BL.D_Commande.DetailsCommande[index] = Detail;
                    MessageBox.Show("Produit modifié avec succes", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
                else
                {
                    MessageBox.Show("Modification Annulée ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            (FRMDETAILCOMMANDE as FRM_Details_Commande).ActualiserDetailCommande();


        }

        private void FRM_PRODUIT_COMMANDE_Load(object sender, EventArgs e)
        {

        }

        private void textBoxQuantite_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQuantite.Text != "" && textBoxPrixU.Text !="")
            {
                int Quantite = int.Parse(textBoxQuantite.Text);
                int Prix = int.Parse(textBoxPrixU.Text);
                textBoxTotal.Text = (Quantite * Prix).ToString();
                
            }
            else
            {
                textBoxTotal.Text = textBoxPrixU.Text;
            }
        }
    }


         
    
}
