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
    public partial class FRM_LISTE_FOURNISSEUR : Form
    {
        private dbstockContext db;
        public FRM_LISTE_FOURNISSEUR()
        {
            InitializeComponent();
            db = new dbstockContext();
            foreach (var LC in db.Fournisseurs)
            {
                dvgFournisseur.Rows.Add(LC.Id_Fournisseur, LC.Nom_Fournisseur, LC.Adresse_Fournisseur, LC.Telephone_Fournisseur);
            }
        }

        private void FRM_LISTE_FOURNISSEUR_Load(object sender, EventArgs e)
        {

        }

        private void dvgFournisseur_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
