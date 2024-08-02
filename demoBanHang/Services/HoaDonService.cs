using demoBanHang.DomainClass;
using demoBanHang.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoBanHang.Services
{
    internal class HoaDonService
    {
        HoaDonRepository _repos;
        public HoaDonService()
        {
            _repos = new HoaDonRepository();
        }
        public List<Hoadon> GetAllHoaDon()
        {
            return _repos.GetAllHD();
        }
        public string Them(Hoadon hd)
        {
            if (_repos.AddHoaDon(hd))
            {
                return "Thêm Thành Công";
            }
            return "Thêm Thất Bại";
        }

        public string UpdateHD(Hoadon hd)
        {
            if (_repos.UpdateHoaDon(hd))
            {
                return "Thêm Thành Công";
            }
            return "Thêm Thất Bại";
        }
        public string RemoveHD(Hoadon hd)
        {
            if (_repos.RemoveHoaDon(hd))
            {
                return "Thêm Thành Công";
            }
            return "Thêm Thất Bại";
        }
    }
}
