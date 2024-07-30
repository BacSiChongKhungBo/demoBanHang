using demoBanHang.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoBanHang.Repositories
{
    internal class UserRepository
    {
        DBContext _context;
        public UserRepository()
        {
            _context = new DBContext();
        }

        //Login: Mình ko tìm kiếm và trả về tài khoản
        // Xác định tài khoản có tồn tại hay ko thôi
        public bool IsUserFound(string username, string password) //ko truyền user
        {
            if (_context.TaiKhoans.Any(x => x.Username.Equals(username) && x.Upassword.Equals(password)))
            {
                return true;
            }
            return false;
        }

        public int GetUserID(string username)
        { 
            return _context.TaiKhoans.FirstOrDefault(x => x.Username.Equals(username)).Id;
        }
    }
}
