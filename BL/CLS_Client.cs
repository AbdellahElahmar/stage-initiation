using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    
    partial class CLS_Client
    {
        
        private dbstockContext db = new dbstockContext();
        private Client C;

        public bool AjouterClient(string NumAffaire, string Label, String NumTelephone, string Adresse, string ville, string mail, string DateDebut, string DateFin, string Etat)
        {

            C = new Client();
            C.Email_Client = mail;
            C.Nom_Client = NumAffaire;
            C.Prenom_Client = Label;
            C.Adresse_Client = Adresse;
            C.DateDebut = DateDebut;
            C.DateFin = DateFin;
            C.Etat_Affaire = Etat;
            C.Num_Telephone = NumTelephone;
            C.Ville_Client = ville;
            if (db.Clients.SingleOrDefault(s => s.Nom_Client == NumAffaire) == null)
            {
                db.Clients.Add(C);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void ModifierClient(int id, string NumAffaire, string Label, String NumTelephone, string Adresse, string ville, string mail, string DateDebut, string DateFin, string Etat)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client ==  id);
            if(C!=null)
            {
                C.Email_Client = mail;
                C.Nom_Client = NumAffaire;
                C.Prenom_Client = Label;
                C.Adresse_Client = Adresse;
                C.DateDebut = DateDebut;
                C.DateFin = DateFin;
                C.Etat_Affaire = Etat;
                C.Num_Telephone = NumTelephone;
                db.SaveChanges();
            }
        }
        public void SupprimerClient(int id)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id);
            if(C!=null)
            {
                db.Clients.Remove(C);
                db.SaveChanges();
            }
        }
    }
    
}
