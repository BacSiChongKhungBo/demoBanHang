using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace demoBanHang.DomainClass;

[Table("HOADON")]
public partial class Hoadon
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("idNV")]
    public int? IdNv { get; set; }

    public DateOnly? NgayTao { get; set; }

    [Column("thanhTien", TypeName = "money")]
    public decimal? ThanhTien { get; set; }

    [Column("trangthai")]
    public bool? Trangthai { get; set; }

    [InverseProperty("IdHdNavigation")]
    public virtual ICollection<Cthd> Cthds { get; set; } = new List<Cthd>();

    [ForeignKey("IdNv")]
    [InverseProperty("Hoadons")]
    public virtual TaiKhoan? IdNvNavigation { get; set; }
}
