using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceDB_EF.Models.ORM
{
    public class Customers
    {
        [Key]
        public int CustomersId { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string SurName { get; set; }

        [MaxLength(20)]
        public string? Phone { get; set; }

        [MaxLength(24)]
        public string? Email { get; set; }

        [MaxLength(60)]
        public string? Address { get; set; }

    }
}
