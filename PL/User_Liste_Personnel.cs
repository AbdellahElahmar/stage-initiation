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
    public partial class User_Liste_Personnel : UserControl
    {
        private static User_Liste_Personnel UserPersonnel;
        private dbstockContext db;

        public static User_Liste_Personnel Instance
        {
            get
            {
                if (UserPersonnel == null)
                {
                    UserPersonnel = new User_Liste_Personnel();
                }
                return UserPersonnel;
            }
        }

        public User_Liste_Personnel()
        {
            InitializeComponent();
            db = new dbstockContext();
            textBoxRechercher.Enabled = false;
        }
        public void ActualiserGrid()
        {
            db = new dbstockContext();
            dvgPersonnel.Rows.Clear();
            foreach (var S in db.Personnels)
            {
                dvgPersonnel.Rows.Add(false, S.id_Personnel, S.CIN, S.Nom_Personnel, S.Adresse_Personnel, S.Telephone_Personnel,S.Poste);
            }
        }
        public string SelectVerif()
        {
            int Nombrelignesselect = 0;
            for (int i = 0; i < dvgPersonnel.Rows.Count; i++)
            {
                if ((bool)dvgPersonnel.Rows[i].Cells[0].Value == true)
                {
                    Nombrelignesselect++;
                }

            }
            if (Nombrelignesselect == 0)
            {
                return "Selectionner l'employé à modifer";
            }
            if (Nombrelignesselect > 1)
            {
                return " Selectionner seulement 1 employé";
            }

            return null;
        }

        private void User_Liste_Personnel_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            db = new dbstockContext();
            var listrechercher = db.Personnels.ToList();
            if (textBoxRechercher.Text != "")
            {
                switch (ComboRechaerche.Text)
                {
                    case "CIN":
                        listrechercher = listrechercher.Where(s => s.CIN.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Nom Complet":
                        listrechercher = listrechercher.Where(s => s.Nom_Personnel.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Poste":
                        listrechercher = listrechercher.Where(s => s.Poste.IndexOf(textBoxRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;



                }
            }
            dvgPersonnel.Rows.Clear();
            foreach (var l in listrechercher)
            {
                dvgPersonnel.Rows.Add(false, l.id_Personnel, l.CIN, l.Nom_Personnel, l.Adresse_Personnel, l.Telephone_Personnel, l.Poste);
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

        private void btnAjouterPersonnel_Click(object sender, EventArgs e)
        {
            FRM_Ajouter_Modifier_Personnel FrmPerso = new FRM_Ajouter_Modifier_Personnel(this);
            FrmPerso.ShowDialog();
        }

        private void btnModifierPersonnel_Click(object sender, EventArgs e)
        {
            FRM_Ajouter_Modifier_Personnel FrmPerso = new FRM_Ajouter_Modifier_Personnel(this);
            if (SelectVerif() == null)
            {
                for (int i = 0; i < dvgPersonnel.Rows.Count; i++)
                {
                    if ((bool)dvgPersonnel.Rows[i].Cells[0].Value == true)
                    {

                        FrmPerso.IdSelect = (int)dvgPersonnel.Rows[i].Cells[1].Value;
                        FrmPerso.txtCIN.Text = dvgPersonnel.Rows[i].Cells[2].Value.ToString();
                        FrmPerso.txtNom.Text = dvgPersonnel.Rows[i].Cells[3].Value.ToString();
                        FrmPerso.txtAdresse.Text = dvgPersonnel.Rows[i].Cells[4].Value.ToString();
                        FrmPerso.txtNumTelephone.Text = dvgPersonnel.Rows[i].Cells[5].Value.ToString();
                        FrmPerso.txtPoste.Text = dvgPersonnel.Rows[i].Cells[6].Value.ToString();

                    }
                }
                FrmPerso.labeltitre.Text = "Modifier Employé";
                FrmPerso.labeltitre.ForeColor = Color.Silver;
                FrmPerso.btnActualiser.Visible = false;
                FrmPerso.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            BL.Cls_Personnel clsPerso = new BL.Cls_Personnel();
            int select = 0;
            for (int i = 0; i < dvgPersonnel.Rows.Count; i++)
            {
                if ((bool)dvgPersonnel.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }

            }
            if (select == 0)
            {
                MessageBox.Show("Aucun Employé selectionné", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voules-vous vraiment supprimer les informations de cet employé ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dvgPersonnel.Rows.Count; i++)
                    {
                        if ((bool)dvgPersonnel.Rows[i].Cells[0].Value == true)
                        {
                            clsPerso.SupprimerPersonnel(int.Parse(dvgPersonnel.Rows[i].Cells[1].Value.ToString()));

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
    }
}
