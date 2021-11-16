using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Categorie
    {
        private dbstockContext db = new dbstockContext();
        private Categorie cat;
        public bool Ajouter_Categorie(string nomCat)
        {
            cat = new Categorie();
            cat.Nom_Categorie = nomCat;
            if (db.Categories.SingleOrDefault(s => s.Nom_Categorie == nomCat) == null)
            {
                db.Categories.Add(cat);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void ModifierCategorie(int idCat, string NomCat)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == idCat);
            if (cat != null)
            {
                cat.Nom_Categorie = NomCat;
                db.SaveChanges();
            }
        }
        public void SupprimerCategorie(int idcat)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == idcat);
            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
            }
        }
    }
}
