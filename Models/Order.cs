using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace McNameeLab3.Models;

public partial class Order
{
    [Key]
    [Column("OrderID")]
    public int OrderId { get; set; }

    [Column("CustomerID")]
    public int? CustomerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalAmount { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Orders")]
    public virtual Customer? Customer { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
