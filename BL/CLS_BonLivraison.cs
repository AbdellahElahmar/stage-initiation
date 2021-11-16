using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_BonLivraison
    {
        private dbstockContext db = new dbstockContext();
        private BonLivraison BL;
        public bool ajouterProduitBl(int id_affaire , string reference , string designation , int quantite,string PrixU)
        {
            BL = new BonLivraison();
            BL.id_Affaire = id_affaire;
            BL.Reference = reference;
            BL.Designation = designation;
            BL.Quantite = quantite;
            BL.PrixU = PrixU;
            BL.PrixT = (BL.Quantite * int.Parse(BL.PrixU)).ToString();
            if (db.BonLivraisons.SingleOrDefault(a => a.Reference == reference && a.id_Affaire == id_affaire) == null)
            {
                db.BonLivraisons.Add(BL);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void diminuerQuantiteBL(int id,string reference , string designation, int quantite)
        {
            BL = new BonLivraison();
            BL = db.BonLivraisons.SingleOrDefault(s => s.id_Affaire == id && s.Reference == reference && s.Designation == designation);
            if (BL != null)
            {
                BL.Quantite = BL.Quantite - quantite;
                BL.PrixT = (BL.Quantite * int.Parse(BL.PrixU)).ToString();
                db.SaveChanges();

            }
        }
        public void RajouterQuantiteBL(int id, string reference, string designation, int quantite)
        {
            BL = new BonLivraison();
            BL = db.BonLivraisons.SingleOrDefault(s => s.id_Affaire == id && s.Reference == reference && s.Designation == designation);
            if (BL != null)
            {
                BL.Quantite = BL.Quantite + quantite;
                BL.PrixT = (BL.Quantite * int.Parse(BL.PrixU)).ToString();
                db.SaveChanges();

            }
        }
    }
}
