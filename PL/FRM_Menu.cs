using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(200, 450);
            pnlParamettre.Visible = false;
        }
        public void DesactiverForm()
        {
            btnClient.Enabled = false;
            btnCategorie.Enabled = false;
            btnProduit.Enabled = false;
            btnCommande.Enabled = false;
            btnDeconnecter.Enabled = false;
            Btnbonsortie.Enabled = false;
            pnlBut.Enabled = false;
            btnConnecter.Enabled = true;
            pnlParamettre.Visible = false;
            BtnFournisseur.Enabled = false;
            btnPersonnel.Enabled = false;


        }

        public void ActiverForm()
        {
            btnClient.Enabled = true;
            btnCategorie.Enabled = true;
            btnProduit.Enabled = true;
            btnCommande.Enabled = true;
            btnDeconnecter.Enabled = true;
            Btnbonsortie.Enabled = true;
            pnlBut.Enabled = true;
            BtnFournisseur.Enabled = true;
            btnConnecter.Enabled = false;
            btnPersonnel.Enabled = true;
        }
        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            DesactiverForm();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnProduit.Top;
            if (!pnlaficher.Controls.Contains(User_Liste_Produit.Instance))
            {
                pnlaficher.Controls.Add(User_Liste_Produit.Instance);
                User_Liste_Produit.Instance.Dock = DockStyle.Fill;
                User_Liste_Produit.Instance.BringToFront();

            }
            else
            {
                User_Liste_Produit.Instance.BringToFront();
            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if(panel1.Size == new Size(194, 562))
            {
                panel1.Size = new Size(87, 450);
            }
            else
            {
                panel1.Size = new Size(194, 562);
            }
        }

        private void BtnCategorie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnCategorie.Top;
            if (!pnlaficher.Controls.Contains(USER_LIST_Categorie.instance))
            {
                pnlaficher.Controls.Add(USER_LIST_Categorie.instance);
                USER_LIST_Categorie.instance.Dock = DockStyle.Fill;
                USER_LIST_Categorie.instance.BringToFront();

            }
            else
            {
                USER_LIST_Categorie.instance.BringToFront();
            }
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnClient.Top;
            if(!pnlaficher.Controls.Contains(USER_List_CLIENT.Instance))
            {
                pnlaficher.Controls.Add(USER_List_CLIENT.Instance);
                USER_List_CLIENT.Instance.Dock = DockStyle.Fill;
                USER_List_CLIENT.Instance.BringToFront();

            }else
            {
                USER_List_CLIENT.Instance.BringToFront();
            }
        }

        private void BtcCommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnCommande.Top;
            
            if (!pnlaficher.Controls.Contains(USER_LISTE_Commande.instance))
            {
                pnlaficher.Controls.Add(USER_LISTE_Commande.instance);
                USER_LISTE_Commande.instance.Dock = DockStyle.Fill;
                USER_LISTE_Commande.instance.BringToFront();

            }
            else
            {
                USER_LISTE_Commande.instance.BringToFront();
            }

        }

        

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnParamettre_Click(object sender, EventArgs e)
        {
            pnlParamettre.Size = new Size(335, 182);
            pnlParamettre.Visible = !pnlParamettre.Visible;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FRM_Connexion frmC = new FRM_Connexion(this);
            frmC.ShowDialog();
        }

        private void Panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnDeconnecter_Click(object sender, EventArgs e)
        {
            DesactiverForm();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pnlBut.Top = BtnFournisseur.Top;
            if (!pnlaficher.Controls.Contains(User_List_Fournisseur.Instance))
            {
                pnlaficher.Controls.Add(User_List_Fournisseur.Instance);
                User_List_Fournisseur.Instance.Dock = DockStyle.Fill;
                User_List_Fournisseur.Instance.BringToFront();

            }
            else
            {
                User_List_Fournisseur.Instance.BringToFront();
            }
        }

        private void Btnbonsortie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = Btnbonsortie.Top;
            
            if (!pnlaficher.Controls.Contains(User_List_BonSortie.instance))
            {
                pnlaficher.Controls.Add(User_List_BonSortie.instance);
                User_List_BonSortie.instance.Dock = DockStyle.Fill;
                User_List_BonSortie.instance.BringToFront();

            }
            else
            {
                User_List_BonSortie.instance.BringToFront();
            }
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnPersonnel.Top;
            if (!pnlaficher.Controls.Contains(User_Liste_Personnel.Instance))
            {
                pnlaficher.Controls.Add(User_Liste_Personnel.Instance);
                User_Liste_Personnel.Instance.Dock = DockStyle.Fill;
                User_Liste_Personnel.Instance.BringToFront();

            }
            else
            {
                User_Liste_Personnel.Instance.BringToFront();
            }
        }
    }
}
