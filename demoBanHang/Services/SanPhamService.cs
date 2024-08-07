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
        public string ThemCTSP(Ctsp ctsp)
        {
            bool check = _repos.GetAllCtsp().Any(x => x.IdSp == ctsp.IdSp && x.IdHang == ctsp.IdHang && x.IdTheTich == ctsp.IdTheTich);
            if (check) //nếu tồn tại bất kì ctsp nào trùng cả 3 id trên => ko cho vào db
            {
                return "Thêm Thất Bại";
            }
            if (_repos.AddCTSPToDB(ctsp))
            {
                return "Thêm Thành Công";
            }
            return "Thêm Thất Bại";
        }
        public string UpdateCTSP(Ctsp ctsp)
        {
            bool check = _repos.GetAllCtsp().Any(x => x.IdSp == ctsp.IdSp && x.IdHang == ctsp.IdHang && x.IdTheTich == ctsp.IdTheTich);
            if (!check) //nếu tồn tại bất kì ctsp nào trùng cả 3 id trên => ko cho vào db
            {
                return "Cập Nhật Thất Bại";
            }
            if (_repos.UpdateCTSPToDB(ctsp))
            {
                return "Cập nhật Thành Công";
            }
            return "Cập nhật Thất Bại";
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
