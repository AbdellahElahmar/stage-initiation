using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Produit_Sortie : Form
    {
        public Form FrmDetail;
        public FRM_Produit_Sortie(Form Frm)
        {
            InitializeComponent();
            FrmDetail = Frm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Produit_Sortie_Load(object sender, EventArgs e)
        {

        }

        private void textBoxRechercher_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxQuantite_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantite_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BL.D_Bon Detail = new BL.D_Bon
            {
                ID = int.Parse(lblId.Text),
                Reference = lblRef.Text,
                Designation = labelDesignation.Text,
                Quantite = int.Parse(textBoxQuantite.Text),
                Prix = labelPrixU.Text


            };
            if (groupBoxProduit.Text == "Ajouter au bon ")
            {
                if (BL.D_Bon.DetailsBon.SingleOrDefault(s => s.ID == Detail.ID) != null)
                {
                    MessageBox.Show("Produit deja existant dans la commande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BL.D_Bon.DetailsBon.Add(Detail);
                    Close();
                }
            }
        
            else
            {
                DialogResult PR = MessageBox.Show("Voulez vous vraiment modifier ? ", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {
                    int index = BL.D_Bon.DetailsBon.FindIndex(s => s.ID == int.Parse(lblId.Text));
                    BL.D_Bon.DetailsBon[index] = Detail;
                    MessageBox.Show("Produit modifié avec succes", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
                else
                {
                    MessageBox.Show("Modification Annulée ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            (FrmDetail as FRM_Detail_Bon_Sortie).ActualiserDetailBon();
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

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }


    
}
    

