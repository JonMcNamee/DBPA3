using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace McNameeLab3.Models;

public partial class Customer
{
    [Key]
    [Column("CustomerID")]
    public int CustomerId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
