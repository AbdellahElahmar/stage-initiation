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
    public partial class User_List_BonSortie : UserControl
    {
        private static User_List_BonSortie UserSortie;
        public dbstockContext db;
        public static User_List_BonSortie instance
        {
            get
            {
                if (UserSortie == null)
                {
                    UserSortie = new User_List_BonSortie();
                }
                return UserSortie;
            }
        }
        public User_List_BonSortie()
        {
            InitializeComponent();
            db = new dbstockContext();
        }
        public void RemplireData()
        {
            dvgbonSortie.Rows.Clear();
            string label;
            Client C = new Client();
            Personnel PD = new Personnel();
            Personnel PL = new Personnel();
            foreach (var LC in db.Bons)
            {
                C = db.Clients.SingleOrDefault(s => s.ID_Client == LC.id_Client);
                PL = db.Personnels.SingleOrDefault(s => s.id_Personnel == LC.id_Libreur);
                PD = db.Personnels.SingleOrDefault(s => s.id_Personnel == LC.id_Demandeur);
                label = C.Prenom_Client;
                dvgbonSortie.Rows.Add(LC.id_Bon, LC.Date_Bon, label,LC.Type, PD.Nom_Personnel,PL.Nom_Personnel);
            }
        }
        private void User_List_BonSortie_Load(object sender, EventArgs e)
        {
            RemplireData();
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Detail_Bon_Sortie frmB = new PL.FRM_Detail_Bon_Sortie(this);
            frmB.ShowDialog();
        }

        private void Btnchercher_Click(object sender, EventArgs e)
        {
            var listeBon = db.Bons.ToList();
            if (dvgbonSortie.Rows.Count != 0)
            {
                listeBon = listeBon.Where(s => s.Date_Bon.Date >= dateD.Value.Date && s.Date_Bon.Date <= dateF.Value.Date).ToList();
                dvgbonSortie.Rows.Clear();
            }
            string label;
            Client C = new Client();
            foreach (var LC in listeBon)
            {
                C = db.Clients.SingleOrDefault(s => s.ID_Client == LC.id_Client);
                label = C.Prenom_Client;
                dvgbonSortie.Rows.Add(LC.id_Bon, LC.Date_Bon, label);
            }
        }

        
        private void btnImpCommande_Click(object sender, EventArgs e)
        {
            RAP.FRM_Rapport frmrap = new RAP.FRM_Rapport();
            db = new dbstockContext();
            try
            {
                int id_bon = (int)dvgbonSortie.CurrentRow.Cells[0].Value;
                var Bon = db.Bons.SingleOrDefault(s => s.id_Bon == id_bon);
                var affairebon = db.Clients.SingleOrDefault(s => s.ID_Client == Bon.id_Client);
                var LivreurBon = db.Personnels.SingleOrDefault(s => s.id_Personnel == Bon.id_Libreur);
                var DemandeurBon = db.Personnels.SingleOrDefault(s => s.id_Personnel == Bon.id_Demandeur);
                var listeDetail = db.Details_Bon.Where(s => s.idBon == id_bon).ToList();


                frmrap.RPAfficher.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.RPT_BonSortie.rdlc";
                frmrap.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("DataBonSortie", listeDetail));
                ReportParameter DateBon = new ReportParameter("DateBon", Bon.Date_Bon.ToString());
                ReportParameter idBon = new ReportParameter("IdBon", Bon.id_Bon.ToString());
                ReportParameter NomLivreur = new ReportParameter("NomLivreur", LivreurBon.Nom_Personnel);
                ReportParameter Type = new ReportParameter("Type", Bon.Type);
                ReportParameter NomDemandeur = new ReportParameter("NomDemandeur", DemandeurBon.Nom_Personnel);
                ReportParameter NumAffaire = new ReportParameter("NumAffaire", affairebon.Nom_Client);
                ReportParameter LabelAffaire = new ReportParameter("LabelAffaire", affairebon.Prenom_Client);
                frmrap.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { NumAffaire, LabelAffaire, idBon, DateBon,Type, NomDemandeur, NomLivreur });
                frmrap.RPAfficher.RefreshReport();
                frmrap.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_Details_Bon_Retour frmBR = new PL.FRM_Details_Bon_Retour(this);
            frmBR.ShowDialog();
        }
    }
}
