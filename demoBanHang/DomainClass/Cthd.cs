using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace demoBanHang.DomainClass;

[Table("CTHD")]
public partial class Cthd
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("idHD")]
    public int? IdHd { get; set; }

    [Column("idCTSP")]
    public int? IdCtsp { get; set; }

    [Column("soluong")]
    public int? Soluong { get; set; }

    [ForeignKey("IdCtsp")]
    [InverseProperty("Cthds")]
    public virtual Ctsp? IdCtspNavigation { get; set; }

    [ForeignKey("IdHd")]
    [InverseProperty("Cthds")]
    public virtual Hoadon? IdHdNavigation { get; set; }
}
