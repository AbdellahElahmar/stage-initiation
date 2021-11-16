using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Produit
    {
        private dbstockContext db = new dbstockContext();
        private Produit PR;
        public bool Ajouter_Produit(string RefP,string Designation, int QuanP, string PrixP, int IDCategorie)
        {
            PR = new Produit();
            PR.Reference = RefP;
            PR.Designation = Designation;
            PR.ID_Categorie = IDCategorie;
            PR.Quantite_Produit = QuanP;
            PR.Prix_Produit = PrixP;
            if(db.Produits.SingleOrDefault(a=> a.Reference==RefP)==null)
            {
                db.Produits.Add(PR);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }


        }
        public void modifierProduit(int IdP, string RefP,string designation, int QuanP, string PrixP, int IDCategorie)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_Produit == IdP);
            if (PR != null)
            {
                PR.Reference = RefP;
                PR.Designation = designation;
                PR.ID_Categorie = IDCategorie;
                PR.Quantite_Produit = QuanP;
                PR.Prix_Produit = PrixP;

                db.SaveChanges();
            }
        }

        public void SupprimerProduit(int id)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_Produit == id);
            if(PR!=null)
            {
                db.Produits.Remove(PR);
                db.SaveChanges();
            }
        }
        public void diminuerQuantite(int id,int quantite)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_Produit == id);
            if(PR != null)
            {
                PR.Quantite_Produit = PR.Quantite_Produit - quantite;
                db.SaveChanges();

            }
        }
        public void RajouterQuantite(int id, int quantite)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.ID_Produit == id);
            if (PR != null)
            {
                PR.Quantite_Produit = PR.Quantite_Produit + quantite;
                db.SaveChanges();

            }
        }
    }
}
