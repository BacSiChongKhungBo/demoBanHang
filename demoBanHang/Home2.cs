﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoBanHang
{
	public partial class Home2 : Form
	{
        public string Username { get; set; }
        public Home2()
		{
			InitializeComponent();
		}

		//ghi đè 
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			lblUsername.Text = "Xin Chào " + Username + " Ở Home 2";
		}
	}
}
