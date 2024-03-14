using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceDB_EF.Models.ORM
{
    public class Invoices
    {
        [Key]
        public int InvoiceId { get; set; }
        public int ServiceId { get; set; }
      
        [ForeignKey("ServiceId")]
        public ServiceRecords ServiceRecords { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
