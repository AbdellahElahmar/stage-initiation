using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Permissions;
using Microsoft.Reporting.WinForms;

namespace GestionDeStock.PL
{
    public partial class USER_List_CLIENT : UserControl
    {
        private static USER_List_CLIENT UserClient;
        private dbstockContext db;
        public static USER_List_CLIENT Instance
        {
            get
            {
                if(UserClient==null)
                {
                    UserClient = new USER_List_CLIENT();
                }
                return UserClient;
            }
        }


        public USER_List_CLIENT()
        {
            InitializeComponent();
            db = new dbstockContext();
            textBoxRechercher.Enabled = false;
        }
        public void ActualiserGrid()
        {
            db = new dbstockContext();
            dvgClient.Rows.Clear();
            foreach( var S in db.Clients)
            {
                dvgClient.Rows.Add(false, S.ID_Client, S.Nom_Client, S.Prenom_Client, S.Adresse_Client, S.Ville_Client, S.Num_Telephone, S.Email_Client, S.DateDebut,S.DateFin,S.Etat_Affaire) ;
            }
        }
        public string SelectVerif()
        {
            int Nombrelignesselect= 0;
            for (int i= 0; i < dvgClient.Rows.Count;i++)
                {
                if ((bool)dvgClient.Rows[i].Cells[0].Value==true)
                {
                    Nombrelignesselect ++;
                }
                
            }
            if (Nombrelignesselect == 0)
            {
                return "Selectionner l'affaire à modifer";
            }
            if (Nombrelignesselect > 1)
            {
                return " Selectionner seulement 1 affaire";
            }

            return null;
        }

        private void USER_List_CLIENT_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBoxRechercher.Text == "Rechercher")
            {
                textBoxRechercher.Text = "";
                textBoxRechercher.ForeColor = Color.Black;
            }
        }
    

        private void TextBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            db = new dbstockContext();
            var listrechercher = db.Clients.ToList();
            if (textBoxRechercher.Text != "")
            {
                switch (ComboRechaerche.Text)
                {
                    case "Numero d'affaire":
                        listrechercher = listrechercher.Where(s => s.Nom_Client.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Label":
                        listrechercher = listrechercher.Where(s => s.Prenom_Client.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adresse":
                        listrechercher = listrechercher.Where(s => s.Adresse_Client.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listrechercher = listrechercher.Where(s => s.Ville_Client.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Telephone":
                        listrechercher = listrechercher.Where(s => s.Num_Telephone.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "E-mail":
                        listrechercher = listrechercher.Where(s => s.Email_Client.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Date Ouverture":
                        listrechercher = listrechercher.Where(s => s.DateDebut.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Date fermeture":
                        listrechercher = listrechercher.Where(s => s.DateFin.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Etat Affaire":
                        listrechercher = listrechercher.Where(s => s.Etat_Affaire.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;

                }
            }
            dvgClient.Rows.Clear();
            foreach(var l in listrechercher)
            {
                dvgClient.Rows.Add(false,l.ID_Client, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.Ville_Client,l.Num_Telephone,l.Email_Client, l.DateDebut, l.DateFin, l.Etat_Affaire);
            }
        }

        private void BtnAjouterClient_Click(object sender, EventArgs e)
        {
            FRM_Ajouter_Modifier_Client FrmClient = new FRM_Ajouter_Modifier_Client(this);
            FrmClient.ShowDialog();

        }
        
        private void BtnModifierClient_Click(object sender, EventArgs e)
        {
            FRM_Ajouter_Modifier_Client FrmClient = new FRM_Ajouter_Modifier_Client(this);
            if(SelectVerif()==null)
            {
                for (int i = 0;i< dvgClient.Rows.Count;i++)
                {
                    if ((bool)dvgClient.Rows[i].Cells[0].Value==true)
                    {
                        
                        FrmClient.IdSelect = (int)dvgClient.Rows[i].Cells[1].Value;
                        FrmClient.txtNumAffaire.Text = dvgClient.Rows[i].Cells[2].Value.ToString();
                        FrmClient.txtLabel.Text = dvgClient.Rows[i].Cells[3].Value.ToString();
                        FrmClient.txtAdresse.Text = dvgClient.Rows[i].Cells[4].Value.ToString();
                        FrmClient.txtVille.Text = dvgClient.Rows[i].Cells[5].Value.ToString();
                        FrmClient.txtNumTelephone.Text= dvgClient.Rows[i].Cells[6].Value.ToString();
                        FrmClient.txtMail.Text= dvgClient.Rows[i].Cells[7].Value.ToString();
                        FrmClient.txtDateDebut.Text= dvgClient.Rows[i].Cells[8].Value.ToString();
                        FrmClient.TxtDateFin.Text= dvgClient.Rows[i].Cells[9].Value.ToString();
                        FrmClient.txtEtat.Text= dvgClient.Rows[i].Cells[10].Value.ToString();


                    }
                }
                FrmClient.labeltitre.Text = "Modifier Affaire";
                FrmClient.labeltitre.ForeColor = Color.Silver;
                FrmClient.btnActualiser.Visible = false;
                FrmClient.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            BL.CLS_Client clClient = new BL.CLS_Client();
            int select = 0;
            for(int i=0;i<dvgClient.Rows.Count;i++)
            {
                if ((bool)dvgClient.Rows[i].Cells[0].Value==true)
                {
                    select++;
                }

            }
            if (select == 0)
            {
                MessageBox.Show("Aucune affaire selectionnée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R=MessageBox.Show("Voules-vous vraiment supprimer cet affaire ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R==DialogResult.Yes)
                {
                    for (int i = 0; i < dvgClient.Rows.Count; i++)
                    {
                        if ((bool)dvgClient.Rows[i].Cells[0].Value == true)
                        {
                            clClient.SupprimerClient(int.Parse(dvgClient.Rows[i].Cells[1].Value.ToString()));
                           
                        }

                    }
                    ActualiserGrid();
                    MessageBox.Show("Suppression avec succés", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppresion annulée", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void ComboRechaerche_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRechercher.Enabled = true;
            textBoxRechercher.Text = "";
        }

        private void dvgClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImpCommande_Click(object sender, EventArgs e)
        {
            RAP.FRM_Rapport frmrap = new RAP.FRM_Rapport();
            db = new dbstockContext();
            try
            {
                int id_Affaire = (int)dvgClient.CurrentRow.Cells[1].Value;
                var Client = db.Clients.SingleOrDefault(a => a.ID_Client == id_Affaire);
                var BonLivraison = db.BonLivraisons.Where(a => a.id_Affaire == id_Affaire).ToList();
                frmrap.RPAfficher.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.RPT_BonLivraison.rdlc";
                frmrap.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("DataBonLivraison", BonLivraison));
                ReportParameter NomAffaire = new ReportParameter("NomAffaire", Client.Prenom_Client);
                ReportParameter AdresseAffaire = new ReportParameter("AdresseAffaire", Client.Adresse_Client);
                frmrap.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { NomAffaire, AdresseAffaire });
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
