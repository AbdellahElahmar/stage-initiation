using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class D_Commande
    {
        public static List<D_Commande> DetailsCommande = new List<D_Commande>();

        public String Designation { get; set; }
        public string Reference { get; set; }
        
        public int Quantite { get; set; }
        public string Prix { get; set; }
        public string Total { get; set; }
    }
}
