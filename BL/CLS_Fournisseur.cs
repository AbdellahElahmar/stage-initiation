using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Fournisseur
    {
        private dbstockContext db = new dbstockContext();
        private Fournisseur F;

        public bool AjouterFournisseur(string NomFournisseur, String NumTelephone, string Adresse)
        {

            F = new Fournisseur();
            F.Nom_Fournisseur = NomFournisseur;
            F.Adresse_Fournisseur = Adresse;
            F.Telephone_Fournisseur = NumTelephone;
            if (db.Fournisseurs.SingleOrDefault(s => s.Nom_Fournisseur == NomFournisseur) == null)
            {
                db.Fournisseurs.Add(F);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public void ModifierFournisseur(int id, string NomFournisseur,String NumTelephone, string Adresse)
        {
            F = new Fournisseur();
            F = db.Fournisseurs.SingleOrDefault(s => s.Id_Fournisseur == id);
            if (F != null)
            {
                F.Nom_Fournisseur = NomFournisseur;
                F.Adresse_Fournisseur = Adresse;
                F.Telephone_Fournisseur = NumTelephone;
                db.SaveChanges();
            }
        }
        public void SupprimerFournisseur(int id)
        {
            F = new Fournisseur();
            F = db.Fournisseurs.SingleOrDefault(s => s.Id_Fournisseur == id);
            if (F != null)
            {
                db.Fournisseurs.Remove(F);
                db.SaveChanges();
            }
        }
    }
}
