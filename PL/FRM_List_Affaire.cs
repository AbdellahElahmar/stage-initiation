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
    public partial class FRM_List_Affaire : Form
    {
        private dbstockContext db;
        public FRM_List_Affaire()
        {
            InitializeComponent();
            db = new dbstockContext();
            foreach (var LC in db.Clients)
            {
                dvgAffaire.Rows.Add(LC.ID_Client, LC.Nom_Client, LC.Prenom_Client, LC.Adresse_Client, LC.Ville_Client, LC.Num_Telephone);
            }
            
        }

        private void FRM_List_Commande_Load(object sender, EventArgs e)
        {
            
        }

        private void dvgClient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

        private void dvgAffaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
