using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int Quantity { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfTransaction { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product{ get; set; }
    }
}



/* [Required]
[ForeignKey(nameof(Product))]
public int ProductId { get; set; }
public virtual Product Product { get; set; }

[Required]
public int CustomerId { get; set; }
[ForeignKey(nameof(CustomerId))]
public virtual Customer Customer { get; set; }*/