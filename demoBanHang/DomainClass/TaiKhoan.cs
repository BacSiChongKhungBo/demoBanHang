using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace demoBanHang.DomainClass;

[Table("TaiKhoan")]
public partial class TaiKhoan
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("username")]
    [StringLength(50)]
    public string? Username { get; set; }

    [StringLength(50)]
    public string? Upassword { get; set; }

    [InverseProperty("IdNvNavigation")]
    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
