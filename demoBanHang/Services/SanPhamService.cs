using demoBanHang.DomainClass;
using demoBanHang.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoBanHang.Services
{
    internal class SanPhamService
    {
        SanPhamRepository _repos;
        public SanPhamService()
        {
            _repos = new SanPhamRepository();
        }
        public List<SanPham> GetSanPhams() 
        {
            return _repos.GetAllSP();
        }
        public string Them(SanPham sp)
        {
            if (_repos.AddToDB(sp))
            {
                return "Thêm Thành Công";
            }
            return "Thêm Thất Bại";
        }
        public string CapNhat(SanPham sp)
        {
            if (_repos.UpdateToDB(sp))
            {
                return "Cập Nhật Thành Công";
            }
            return "Cập Nhật Thất Bại";
        }

        public List<Ctsp> GetCtsp() 
        { 
            return _repos.GetAllCtsp();
        }
        public List<Hang> GetHang()
        {
            return _repos.GetAllHang();
        }
        public List<TheTich> GetTheTich()
        {
            return _repos.GetAllTheTich();
        }
    }
}
