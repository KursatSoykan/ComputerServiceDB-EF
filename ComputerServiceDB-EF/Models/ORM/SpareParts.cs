using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceDB_EF.Models.ORM
{
    public class SpareParts
    {
        [Key]
        public int PartId { get; set; }
        public string Name { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? StockQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

    }
}
