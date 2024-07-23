using demoBanHang.Services;

namespace demoBanHang
{
	public partial class Form1 : Form
	{
		UserService _Uservice = new UserService();
		Thread thread;
		private string username ="";
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			//Lấy dữ liệu từ textbox
			username = txtUsername.Text;
			string password = txtPassword.Text;
			//Kiểm tra user => xét đăng nhập
			string message = _Uservice.CheckLogin(username, password);
			MessageBox.Show(message);
			if (message.Equals("Đăng nhập thành công"))
			{
				//mở form khi message đúng
				this.Close();
				thread = new Thread(OpenHomeForm);
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
			}
			//ko đúng message thì ở lại form và clear output
			txtUsername.Text = "";
			txtPassword.Text = "";
		}

		//Sử dụng thread khác khi mở form
		//Thread: Các luồng chạy của code
		//bình thường code chúng ta có 1 luồng chạy
		// thread giúp mình có nhiều luồng code
		private void OpenHomeForm()
		{
			Application.Run(new Home(username));
		}
		/// <summary>
		/// Nên sử dụng khi truyền sang form khác dữ liệu < 2
		/// </summary>

		private void OpenHomeForm2()
		{
			Home2 h2 = new Home2();
			h2.Username = username;
			Application.Run(h2);
		}
		/// Sử dụng khi có quá nhiều dữ liệu sang bên form mới
	}
}
