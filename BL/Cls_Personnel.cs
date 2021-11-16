using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class Cls_Personnel
    {
        private dbstockContext db = new dbstockContext();
        private Personnel P;

        public bool AjouterPersonnel(string CIN , string Nom, string Adresse ,string Numtelephone,string Poste )
        {

            P = new Personnel();
            P.CIN = CIN;
            P.Nom_Personnel = Nom;
            P.Adresse_Personnel = Adresse;
            P.Telephone_Personnel = Numtelephone;
            P.Poste = Poste;
            
            if (db.Personnels.SingleOrDefault(s => s.CIN == CIN) == null)
            {
                db.Personnels.Add(P);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public void ModifierPersonnel(int id,string CIN , string Nom , string Adresse ,string Telephone,string Poste)
        {
            P = new Personnel();
            P = db.Personnels.SingleOrDefault(s => s.id_Personnel == id);
            if (P != null)
            {
                P.Nom_Personnel = Nom;
                P.CIN = CIN;
                P.Adresse_Personnel = Adresse;
                P.Telephone_Personnel = Telephone;
                P.Poste = Poste;
                db.SaveChanges();
            }
        }
        public void SupprimerPersonnel(int id)
        {
            P = new Personnel();
            P = db.Personnels.SingleOrDefault(s => s.id_Personnel == id);
            if (P != null)
            {
                db.Personnels.Remove(P);
                db.SaveChanges();
            }
        }
    }
}
