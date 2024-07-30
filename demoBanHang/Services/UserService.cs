using demoBanHang.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoBanHang.Services
{
	internal class UserService
	{
		UserRepository _repos;
		public UserService() 
		{ 
			_repos = new UserRepository();
		}

		public string CheckLogin(string username, string password)
		{
			if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				return "Không được để trống";
			}
			if(_repos.IsUserFound(username, password))
			{
				return "Đăng nhập thành công";
			}
			return "Sai Tài Khoản hoặc mật Khẩu";
		}

		public int GetId(string username) 
		{ 
			return _repos.GetUserID(username);
		}
	}
}
