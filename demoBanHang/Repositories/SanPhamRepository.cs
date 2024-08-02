using demoBanHang.Context;
using demoBanHang.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoBanHang.Repositories
{
	internal class SanPhamRepository
	{
		DBContext _context;
        public SanPhamRepository()
        {
            _context = new DBContext();
        }

        public List<SanPham> GetAllSP()
        {
            return _context.SanPhams.ToList();
        }

        public bool AddToDB(SanPham sp)
        {
            if (sp != null) 
            { 
                _context.SanPhams.Add(sp);
                _context.SaveChanges();// ko có thì ko lưu dũ liệu vào db
                return true;
            }
            return false;
        }
        public bool UpdateToDB(SanPham sp)
        {
            if (sp != null)
            {
                _context.SanPhams.Update(sp);
                _context.SaveChanges();// ko có thì ko lưu dũ liệu vào db
                return true;
            }
            return false;
        }

        public List<Ctsp> GetAllCtsp() 
        { 
            return _context.Ctsps.ToList();
        }

        public bool AddCTSPToDB(Ctsp ctsp)
        {
            if (ctsp != null)
            {
                _context.Ctsps.Add(ctsp);
                _context.SaveChanges();// ko có thì ko lưu dũ liệu vào db
                return true;
            }
            return false;
        }


        public List<Hang> GetAllHang() 
        { 
            return _context.Hangs.ToList();
        }
        public List<TheTich> GetAllTheTich() 
        { 
            return _context.TheTiches.ToList();
        }
    }
}
