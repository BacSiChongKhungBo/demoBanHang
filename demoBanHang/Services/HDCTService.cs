using demoBanHang.Context;
using demoBanHang.DomainClass;
using demoBanHang.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoBanHang.Services
{
    internal class HDCTService
    {
        HDCTRepository _repos;
        public HDCTService()
        {
            _repos = new HDCTRepository();
        }

        public List<Cthd> GetAll()
        {
            return _repos.GetAllHDCT();
        }
        public void Add(Cthd cthd)
        {
            //2 TH: đã có trong cthd
            if (GetAll().Any(x => x.IdCtsp == cthd.IdCtsp)) 
            {
                var updateCTHD = _repos.GetAllHDCT().First(x=> x.IdCtsp == cthd.IdCtsp);
                updateCTHD.Soluong++;
                _repos.UpdateCTHD(updateCTHD);
            }
            else
            {
                cthd.Soluong = 1;
                _repos.AddCTHD(cthd);
            }
            
        }
        public void Remove(Cthd cthd)
        {
            //2 TH: đã có trong cthd
            if (cthd != null)
            {
                _repos.RemoveCTHD(cthd);
            }
        }

    }
}
