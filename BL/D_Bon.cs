using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    public class D_Bon
    {
        public static List<D_Bon> DetailsBon = new List<D_Bon>();
        public int ID { get; set; }
        public string Designation { get; set; }
        public string Reference { get; set; }
        public int Quantite { get; set; }
        public string Prix { get; set; }
        public string  Total { get; set; }
    }
}
