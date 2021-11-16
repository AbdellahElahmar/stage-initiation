using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace GestionDeStock.PL
{
    public partial class USER_LISTE_Commande : UserControl
    {
        private USER_LISTE_Commande userCommande;
        private dbstockContext db;
        private static USER_LISTE_Commande UserCommande;
        
        public static USER_LISTE_Commande instance
        {
            get
            {
                if (UserCommande == null)
                {
                    UserCommande = new USER_LISTE_Commande();
                }
                return UserCommande;
            }
        }

        public USER_LISTE_Commande()
        {
            InitializeComponent();
            db = new dbstockContext();
        }
        public void RemplireData()
        {
            dvgCommande.Rows.Clear();
            string Fournisseur;
            Fournisseur F = new Fournisseur();
            foreach (var LC in db.Commandes)
            {
                F = db.Fournisseurs.SingleOrDefault(s => s.Id_Fournisseur == LC.Id_Fourisseur);
                Fournisseur = F.Nom_Fournisseur;
                dvgCommande.Rows.Add(LC.ID_Commande, LC.Date_Commande, Fournisseur, LC.Total_HT, LC.Tva,LC.SommeTVA, LC.Total_TTC) ;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void USER_LISTE_Commande_Load(object sender, EventArgs e)
        {
            RemplireData();
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Details_Commande frmC = new PL.FRM_Details_Commande(this);
            frmC.ShowDialog();
        }

        public int SommeTVA;
        private void btnImpCommande_Click(object sender, EventArgs e)
        {
            RAP.FRM_Rapport frmrap = new RAP.FRM_Rapport();
            db = new dbstockContext();
            try
            {
                int id_Commande = (int)dvgCommande.CurrentRow.Cells[0].Value;
                var Commande = db.Commandes.SingleOrDefault(s => s.ID_Commande == id_Commande);
                var fournisseurCommande = db.Fournisseurs.SingleOrDefault(s => s.Id_Fournisseur == Commande.Id_Fourisseur);
                var listeDetail = db.Details_Commande.Where(s => s.ID_Commande == id_Commande).ToList();

                frmrap.RPAfficher.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.Rpt_Commande.rdlc";
                frmrap.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("DataCommande", listeDetail));
                ReportParameter DateCommande = new ReportParameter("DateCommande", Commande.Date_Commande.ToString());
                ReportParameter Nomfournisseur = new ReportParameter("NomFournisseur", fournisseurCommande.Nom_Fournisseur);
                ReportParameter Adressefournisseur = new ReportParameter("AdresseFournisseur", fournisseurCommande.Adresse_Fournisseur);
                ReportParameter PrixHT = new ReportParameter("PrixHT", Commande.Total_HT);
                ReportParameter PRIXTTC = new ReportParameter("PrixTTC", Commande.Total_TTC);
                ReportParameter Sommetva = new ReportParameter("TVA", Commande.SommeTVA);

                frmrap.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { DateCommande, Nomfournisseur, Adressefournisseur, PrixHT,Sommetva,PRIXTTC });
                frmrap.RPAfficher.RefreshReport();
                frmrap.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
