using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int Id { get; set; }

        [Display(Name = "Cliente")]
        public string CustName { get; set; } = null!;

        [Display(Name = "Dirección")]
        public string Adress { get; set; } = null!;

        public bool? Status { get; set; }
        public int CustomerTypeId { get; set; }

        [Display(Name = "Tipo cliente")]
        public virtual CustomerType CustomerType { get; set; } = null!;
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
