using demoBanHang.Context;
using demoBanHang.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoBanHang.Repositories
{
    internal class HoaDonRepository
    {
        DBContext _context;
        public HoaDonRepository()
        {
            _context = new DBContext();
        }

        public List<Hoadon> GetAllHD()
        {
            return _context.Hoadons.ToList();
        }

        public bool AddHoaDon(Hoadon hd)
        {
            if (hd != null)
            {
                _context.Hoadons.Add(hd);
                _context.SaveChanges();// ko có thì ko lưu dũ liệu vào db
                return true;
            }
            return false;
        }
    }
}
