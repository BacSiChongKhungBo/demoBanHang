using demoBanHang.DomainClass;
using demoBanHang.Services;
using System;
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
    public partial class LichSuGD : Form
    {
        SanPhamService _sService = new SanPhamService();
        UserService _uservice = new UserService();
        HoaDonService _hService = new HoaDonService();
        HDCTService _hDCTService = new HDCTService();
        List<Hoadon> _lst = new List<Hoadon>();
        public LichSuGD()
        {
            InitializeComponent();
            SettingComboBox();
            _lst = _hService.GetAllHoaDon();
            LoadAllHD();
        }

        private void LoadAllHD()
        {
            int stt = 1;
            //Xác định số lượng côt = số lượng thuộc tính đối tượng + stt
            dtgViewHD.ColumnCount = 6;
            //Đặt tên cột66
            dtgViewHD.Columns[0].Name = "STT";
            dtgViewHD.Columns[1].Name = "ID Hóa Đơn";
            dtgViewHD.Columns[2].Name = "ID NV";
            dtgViewHD.Columns[3].Name = "Ngay Tao";
            dtgViewHD.Columns[4].Name = "Thanh Tien";
            dtgViewHD.Columns[5].Name = "TrangThai";
            dtgViewHD.Rows.Clear();
            //foreach (var hd in _hService.GetAllHoaDon())
            //{
            //    dtgView_HD.Rows.Add(stt++, hd.Id, hd.IdNv, hd.NgayTao, hd.ThanhTien == null ? 0 + " VND" : hd.ThanhTien + " VND", hd.Trangthai == false ? "Chưa Thanh Toán" : "Đã thanh toán");
            //}
            foreach (var hd in _lst)
            {
                dtgViewHD.Rows.Add(stt++, hd.Id, hd.IdNv, hd.NgayTao, hd.ThanhTien == null ? 0 + " VND" : hd.ThanhTien + " VND", hd.Trangthai == false ? "Chưa Thanh Toán" : "Đã thanh toán");
            }
        }

        private void SettingComboBox()
        {
            cmbBoLoc.Items.Add("Tất Cả");
            cmbBoLoc.Items.Add("Ngày Tăng Dần");
            cmbBoLoc.Items.Add("Ngày Giảm Dần");
            cmbBoLoc.Items.Add("Theo Khách Hàng");
            cmbBoLoc.Items.Add("Giá Tăng Dần");
            cmbBoLoc.Items.Add("Giá Giảm dần");
            cmbBoLoc.SelectedIndex = 0;
            cmbBoLoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _lst = _hService.GetAllHoaDon().Where(
                hd => hd.Id.ToString().Contains(txtSearch.Text) ||
                      hd.NgayTao.ToString().Contains(txtSearch.Text)||
                      hd.ThanhTien.ToString().Contains(txtSearch.Text)).ToList();
            LoadAllHD();
        }
    }
}
