//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionDeStock
{
    using System;
    using System.Collections.Generic;
    
    public partial class Details_Commande
    {
        public int idDetail { get; set; }
        public int ID_Commande { get; set; }
        public string Ref_Produit { get; set; }
        public int Quantite { get; set; }
        public string prix { get; set; }
        public string total { get; set; }
        public string Designation { get; set; }
    
        public virtual Commande Commande { get; set; }
    }
}
