using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostingAssembly.Models
{
    /// <summary>
    /// Stores query result in Left Join of tblLengthCost and tblMaterial
    /// </summary>
    public class JoinedLengthModel
    {
        public int LenghtCostID { get; set; }
        public int TypeID { get; set; }
        public string MaterialID { get; set; }
        public Nullable<decimal> NoPieces { get; set; }
        public Nullable<decimal> LengthPerPiece { get; set; }
        public Nullable<decimal> TotalLength { get; set; }
        public Nullable<decimal> TotalCostPieces { get; set; }
        public Nullable<decimal> PricePerMeter { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
