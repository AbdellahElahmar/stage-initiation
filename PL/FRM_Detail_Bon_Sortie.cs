using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Detail_Bon_Sortie : Form
    {
        private UserControl UserCommand;
        private dbstockContext db;
        public FRM_Detail_Bon_Sortie(UserControl User)
        {
            InitializeComponent();
            db = new dbstockContext();
            UserCommand = User;
            ComboBoxDemandeur.DataSource = db.Personnels.ToList();
            ComboBoxLivreur.DataSource = db.Personnels.ToList();
            ComboBoxLivreur.DisplayMember = "Nom_Personnel";
            ComboBoxLivreur.ValueMember = "id_Personnel";
            ComboBoxDemandeur.DisplayMember = "Nom_Personnel";
            ComboBoxDemandeur.ValueMember = "id_Personnel";
            
        }
        public void ActualiserDetailBon()
        {
            
            dvgDetailBon.Rows.Clear();
            foreach(var L in BL.D_Bon.DetailsBon)
            {
                dvgDetailBon.Rows.Add(L.ID,L.Designation ,L.Reference, L.Quantite, L.Prix, L.Total);
            }
        }
        public void rempliredvgroduit()
        {
            foreach (var l in db.Produits)
            {
                dvgProduit.Rows.Add(l.ID_Produit,l.Designation , l.Reference, l.Quantite_Produit, l.Prix_Produit);
            }
            for (int i = 0; i < dvgProduit.Rows.Count; i++)
            {
                if ((int)dvgProduit.Rows[i].Cells[3].Value == 0)
                {
                    dvgProduit.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgProduit.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
            }
            dvgProduit.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            BL.D_Bon.DetailsBon.Clear();
        }

        private void FRM_Detail_Commande_Load(object sender, EventArgs e)
        {
            rempliredvgroduit();
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            db = new dbstockContext();
            var listrechercher = db.Produits.ToList();
            listrechercher = listrechercher.Where(s => s.Reference.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dvgProduit.Rows.Clear();
            
            foreach (var l in listrechercher)
            {
                dvgProduit.Rows.Add( l.ID_Produit,l.Designation, l.Reference, l.Quantite_Produit,l.Prix_Produit);
            }
        }

        private void textBoxRechercher_Enter(object sender, EventArgs e)
        {
            if (textBoxRechercher.Text == "Rechercher")
            {
                textBoxRechercher.Text = "";
                textBoxRechercher.ForeColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.FRM_List_Affaire frmC = new FRM_List_Affaire();
            frmC.ShowDialog();
            IDAFFAIRE = (int)frmC.dvgAffaire.CurrentRow.Cells[0].Value;
            textBoxNumAff.Text = frmC.dvgAffaire.CurrentRow.Cells[1].Value.ToString();
            textBoxLabel.Text = frmC.dvgAffaire.CurrentRow.Cells[2].Value.ToString();
            textBoxAdresse.Text = frmC.dvgAffaire.CurrentRow.Cells[3].Value.ToString();
            textBoxVille.Text = frmC.dvgAffaire.CurrentRow.Cells[4].Value.ToString();
            textBoxNumtel.Text = frmC.dvgAffaire.CurrentRow.Cells[5].Value.ToString();


            

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dvgProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Produit_Sortie FrmPS = new FRM_Produit_Sortie(this);
            if ((int)dvgProduit.CurrentRow.Cells[3].Value == 0)
            {
                MessageBox.Show("Le produit n'est plus disponible en stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmPS.lblId.Text = dvgProduit.CurrentRow.Cells[0].Value.ToString();
                FrmPS.labelDesignation.Text = dvgProduit.CurrentRow.Cells[1].Value.ToString();
                FrmPS.lblRef.Text = dvgProduit.CurrentRow.Cells[2].Value.ToString();
                FrmPS.lblQtt.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                FrmPS.labelPrixU.Text = dvgProduit.CurrentRow.Cells[4].Value.ToString();
                FrmPS.ShowDialog();
            }
        }

        public int IDAFFAIRE;
        private void button1_Click(object sender, EventArgs e)
        {
            BL.CLS_BonLivraison clsBL = new BL.CLS_BonLivraison();
            BL.CLS_Bon_DetailsBon clsBon = new BL.CLS_Bon_DetailsBon();
            BL.CLS_Produit clsProduit = new BL.CLS_Produit();
            if (dvgDetailBon.Rows.Count == 0)
            {
                MessageBox.Show("Ajouter un produit au bon ", "Ajouter Bon", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (textBoxNumAff.Text == "")
                {
                    MessageBox.Show("Siassiez une affaire ", "Ajouter Bon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    clsBon.Ajouter_Bon(Bondate.Value, IDAFFAIRE, Convert.ToInt32(ComboBoxLivreur.SelectedValue),Convert.ToInt32(ComboBoxDemandeur.SelectedValue),labelBS.Text) ;
                    foreach(var l in BL.D_Bon.DetailsBon)
                    {
                        
                        clsBon.AjouterDetailBon(l.ID,l.Designation,l.Reference,l.Quantite,l.Prix);
                        clsProduit.diminuerQuantite(l.ID, l.Quantite);
                        if (db.BonLivraisons.SingleOrDefault(a => a.Reference == l.Reference && a.id_Affaire == IDAFFAIRE) == null)
                        {
                            clsBL.ajouterProduitBl(IDAFFAIRE, l.Reference, l.Designation, l.Quantite, l.Prix);
                        }
                        else
                        {
                            clsBL.RajouterQuantiteBL(IDAFFAIRE, l.Reference, l.Designation, l.Quantite);
                        }

                    }
                    (UserCommand as User_List_BonSortie).RemplireData();
                    BL.D_Bon.DetailsBon.Clear();
                    Close();
                    MessageBox.Show("Bon ajouté avec succes ", "Bon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            
            
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Produit_Sortie frm = new FRM_Produit_Sortie(this);
            Produit PR = new Produit();
            frm.lblId.Text = dvgProduit.CurrentRow.Cells[0].Value.ToString();
            frm.lblRef.Text = dvgDetailBon.CurrentRow.Cells[2].Value.ToString();
            frm.labelDesignation.Text = dvgDetailBon.CurrentRow.Cells[1].Value.ToString();
            int IDP = int.Parse(dvgDetailBon.CurrentRow.Cells[0].Value.ToString());
            PR = db.Produits.SingleOrDefault(s => s.ID_Produit == IDP);
            frm.lblQtt.Text = PR.Quantite_Produit.ToString();
            frm.labelPrixU.Text = dvgDetailBon.CurrentRow.Cells[4].Value.ToString();
            frm.textBoxQuantite.Text = dvgDetailBon.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dvgDetailBon.CurrentRow != null)
            {
                DialogResult PR = MessageBox.Show("Voulez vous vraiment supprimer ce produit de la commande ? ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(PR == DialogResult.Yes)
                {
                    int index = BL.D_Bon.DetailsBon.FindIndex(s => s.ID == int.Parse(dvgDetailBon.CurrentRow.Cells[0].Value.ToString()));
                    BL.D_Bon.DetailsBon.RemoveAt(index);
                    ActualiserDetailBon();
                    MessageBox.Show("Supression avec succes", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Supression echouée", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dvgDetailBon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
