using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace McNameeLab3.Models;

public partial class OrderItem
{
    [Key]
    [Column("LineID")]
    public int LineId { get; set; }

    [Column("OrderID")]
    public int? OrderId { get; set; }

    [Column("ProductID")]
    public int? ProductId { get; set; }

    [Column("ServiceID")]
    public int? ServiceId { get; set; }

    public int? Quantity { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Price { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderItems")]
    public virtual Order? Order { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("OrderItems")]
    public virtual Product? Product { get; set; }

    [ForeignKey("ServiceId")]
    [InverseProperty("OrderItems")]
    public virtual Service? Service { get; set; }
}
