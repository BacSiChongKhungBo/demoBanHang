using demoBanHang.Context;
using demoBanHang.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoBanHang.Repositories
{
    internal class HDCTRepository
    {
        DBContext _context;
        public HDCTRepository()
        {
            _context = new DBContext();
        }

        public List<Cthd> GetAllHDCT()
        {
            return _context.Cthds.ToList();
        }

        public bool AddCTHD(Cthd cthd)
        {
            if (cthd != null)
            {
                _context.Cthds.Add(cthd);
                _context.SaveChanges();// ko có thì ko lưu dũ liệu vào db
                return true;
            }
            return false;
        }
        public bool UpdateCTHD(Cthd cthd)
        {
            if (cthd != null)
            {
                _context.Cthds.Update(cthd);
                _context.SaveChanges();// ko có thì ko lưu dũ liệu vào db
                return true;
            }
            return false;
        }
    }
}
