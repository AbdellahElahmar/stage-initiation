using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Connexion
    {
        public bool ConnexionValide(dbstockContext db,string Nom,String Mot_De_Passe)
        {
            Utilisateur U = new Utilisateur();
            U.Nom_Utilisateur = Nom;
            U.Mot_De_Passe = Mot_De_Passe;
            if (db.Utilisateurs.SingleOrDefault(s => s.Nom_Utilisateur == Nom && s.Mot_De_Passe == Mot_De_Passe) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
