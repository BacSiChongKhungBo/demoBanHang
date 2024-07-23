using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace demoBanHang.DomainClass;

[Table("Hang")]
public partial class Hang
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? TenHang { get; set; }

    public bool? TrangThai { get; set; }

    [InverseProperty("IdHangNavigation")]
    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
