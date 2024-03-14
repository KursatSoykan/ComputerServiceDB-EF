using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceDB_EF.Models.ORM
{
    public class ServiceRecords
    {
        [Key]
        public int ServiceId{ get; set; }
        public int CustomersId { get; set; }
        
        [ForeignKey("CustomersId")]
        public Customers customers { get; set; }
        public string? DeviceType  { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? SeriesNo { get; set; }
        public string? FaultExplanation { get; set; }
        public DateTime? AcceptDate { get; set; }
        public DateTime? EstimatedCompletionDate { get; set; }
        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public ServiceStatus serviceStatus { get; set; }

    }
}
