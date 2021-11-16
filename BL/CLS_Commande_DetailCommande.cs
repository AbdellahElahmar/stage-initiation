using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Commande_DetailCommande
    {
        private dbstockContext db = new dbstockContext();
        private Commande clsCommande;
        private Details_Commande clsDetailsCom;

        public int idCommande;
        public void Ajouter_Commande(DateTime Date_Commande, string totalht,string tva ,string TTC,string SommeTVA, int id_Fournisseur)
        {
            clsCommande = new Commande();
            clsCommande.Date_Commande = Date_Commande;
            clsCommande.Id_Fourisseur = id_Fournisseur;
            clsCommande.Total_HT = totalht;
            clsCommande.Tva = tva;
            clsCommande.Total_TTC = TTC;
            clsCommande.SommeTVA = SommeTVA;
            db.Commandes.Add(clsCommande);
            
            db.SaveChanges();
            idCommande = clsCommande.ID_Commande;
        }
        public void AjouterDetailsCom( string Reference,string Designation, int quantite, string prix, String totalhc)
        {
            clsDetailsCom = new Details_Commande();
            clsDetailsCom.ID_Commande = idCommande;
            clsDetailsCom.Quantite = quantite;
            clsDetailsCom.Designation = Designation;
            clsDetailsCom.prix = prix;
            clsDetailsCom.Ref_Produit = Reference;
            clsDetailsCom.total = totalhc;
            db.Details_Commande.Add(clsDetailsCom);
            db.SaveChanges();
        }
    }
}
