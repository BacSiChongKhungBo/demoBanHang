using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace demoBanHang.DomainClass;

[Table("SanPham")]
public partial class SanPham
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("TenSP")]
    [StringLength(50)]
    public string? TenSp { get; set; }

    [Column("gia", TypeName = "money")]
    public decimal? Gia { get; set; }

    public bool? TrangThai { get; set; }

    [InverseProperty("IdSpNavigation")]
    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
