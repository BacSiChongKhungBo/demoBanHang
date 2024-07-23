using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace demoBanHang
{
	public partial class Home : Form
	{
		public Home(string username)
		{
			InitializeComponent();
			lblUsername.Text = "Xin Chào " + username;
			pHome.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{			
			QLSP qlsp = new QLSP() { TopLevel = false, TopMost = true };
			qlsp.FormBorderStyle = FormBorderStyle.None;// ko hiển thị viền
														//Nếu tồn tại form khác trong panel => remove form đó đi
			if (pHome.Controls.Count > 0)
			{
				pHome.Controls.RemoveAt(0);
			}
			pHome.Controls.Add(qlsp);
			qlsp.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			QLTK qltk = new QLTK() { TopLevel = false, TopMost = true };
			qltk.FormBorderStyle = FormBorderStyle.None;
			if (pHome.Controls.Count > 0)
			{
				pHome.Controls.RemoveAt(0);
			}
			pHome.Controls.Add(qltk);
			qltk.Show();
		}
	}
}
