using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace demoBanHang.DomainClass;

[Table("CTSP")]
public partial class Ctsp
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("idSP")]
    public int? IdSp { get; set; }

    [Column("idHang")]
    public int? IdHang { get; set; }

    [Column("idTheTich")]
    public int? IdTheTich { get; set; }

    public bool? TrangThai { get; set; }

    [InverseProperty("IdCtspNavigation")]
    public virtual ICollection<Cthd> Cthds { get; set; } = new List<Cthd>();

    [ForeignKey("IdHang")]
    [InverseProperty("Ctsps")]
    public virtual Hang? IdHangNavigation { get; set; }

    [ForeignKey("IdSp")]
    [InverseProperty("Ctsps")]
    public virtual SanPham? IdSpNavigation { get; set; }

    [ForeignKey("IdTheTich")]
    [InverseProperty("Ctsps")]
    public virtual TheTich? IdTheTichNavigation { get; set; }
}
