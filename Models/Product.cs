using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace McNameeLab3.Models;

public partial class Product
{
    [Key]
    [Column("ProductID")]
    public int ProductId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProductName { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Price { get; set; }

    public int? QuantityInStock { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
