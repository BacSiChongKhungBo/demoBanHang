using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace demoBanHang.DomainClass;

[Table("TheTich")]
public partial class TheTich
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("thetich")]
    public int? Thetich1 { get; set; }

    public bool? TrangThai { get; set; }

    [InverseProperty("IdTheTichNavigation")]
    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
