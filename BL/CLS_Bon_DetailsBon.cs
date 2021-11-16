using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Bon_DetailsBon
    {
        private dbstockContext db = new dbstockContext();
        private Bon clsBon;
        private Details_Bon clsDetailsBon;
        
        public int idBon;
        public void Ajouter_Bon(DateTime Date_Bon,int id_Affaire,int idLivreur,int idDemandeur, string type)
        {
            clsBon = new Bon();
            clsBon.id_Demandeur = idDemandeur;
            clsBon.id_Libreur = idLivreur;
            clsBon.Date_Bon = Date_Bon;
            clsBon.Type = type;
            clsBon.id_Client = id_Affaire;
            db.Bons.Add(clsBon);
            db.SaveChanges();
            idBon = clsBon.id_Bon;
        }
        public void AjouterDetailBon( int idProduit,string Designation ,string Reference , int quantite , string prix)
        {
            clsDetailsBon = new Details_Bon();
            clsDetailsBon.idBon = idBon;
            clsDetailsBon.idProduit = idProduit;
            clsDetailsBon.Designation = Designation;
            clsDetailsBon.Quantite = quantite;
            clsDetailsBon.PrixU = prix;
            clsDetailsBon.Reference = Reference;
            db.Details_Bon.Add(clsDetailsBon);
            db.SaveChanges();
        }

        
    }
}
