using demoBanHang.DomainClass;
using demoBanHang.Services;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Web.UI;
using Microsoft.Extensions.Primitives;
using Azure;

namespace demoBanHang
{
    public partial class BanHang : Form
    {
        SanPhamService _sService = new SanPhamService();
        UserService _uservice = new UserService();
        HoaDonService _hService = new HoaDonService();
        HDCTService _hDCTService = new HDCTService();
        int _IdSPWhenClick;
        int _IdCTSPWhenClick; //3-8-2024
        string info_user;
        int _IdHoaDonWhenClick;
        int _IdHDCTWhenClick;
        int _IDHdDaThanhToan = -1;
        decimal? thanhTien;
        public BanHang(string user)
        {
            InitializeComponent();
            txt_user.Text = user;
            txt_user.Enabled = false;
            txtMaHD.Enabled = false;
            txtThanhTien.Enabled = false;
            info_user = user;
            btnThanhToan.Enabled = false;
            btnXuatHD.Enabled = false;
            LoadDataSP();
            LoadAllHD();

        }

        public void LoadDataSP()
        {
            int stt = 1;
            //Xác định số lượng côt = số lượng thuộc tính đối tượng + stt
            dtgView_SP.ColumnCount = 8; //3-8-2024
            //Đặt tên cột
            dtgView_SP.Columns[0].Name = "STT";
            dtgView_SP.Columns[1].Name = "IDCTSP";  //3-8-2024
            dtgView_SP.Columns[2].Name = "IDSP"; //3-8-2024
            dtgView_SP.Columns[3].Name = "Tên SP";
            dtgView_SP.Columns[4].Name = "Giá";
            dtgView_SP.Columns[5].Name = "Hãng";
            dtgView_SP.Columns[6].Name = "Thể Tích";
            dtgView_SP.Columns[7].Name = "Trạng Thái";
            //Reset dòng để ko bị lỗi khi load lại
            dtgView_SP.Rows.Clear();
            //Bổ sung: Giấu cột ID đi

            var lstHang = _sService.GetHang();
            var lstTheTich = _sService.GetTheTich();
            var lstCTSP = _sService.GetCtsp();
            var lstSP = _sService.GetSanPhams().Where(x => x.TrangThai == true).ToList();
            //join           bảng A       Bảng B
            var dataJoinSP = lstCTSP.Join(lstSP,
                           ctsp => ctsp.IdSp, //Key bảng A
                           sp => sp.Id, // Key bảng B

                           (ctsp, sp) => new // key A = Key B
                           { //Có thể lấy dữ liệu từ cả 2 bảng
                               ID = ctsp.Id,
                               IDSP = sp.Id,
                               TenSP = sp.TenSp,
                               Gia = sp.Gia,
                               idHang = ctsp.IdHang,
                               idTheTich = ctsp.IdTheTich,
                               TrangThai = ctsp.TrangThai
                           }).ToList(); //chuyển về list
            var dataJoinHang = dataJoinSP.Join(lstHang,
                                ctsp => ctsp.idHang,
                                h => h.Id,
                                (ctsp, h) => new
                                {
                                    ID = ctsp.ID,
                                    IDSP = ctsp.IDSP,
                                    TenSP = ctsp.TenSP,
                                    Gia = ctsp.Gia,
                                    TenHang = h.TenHang,
                                    idTheTich = ctsp.idTheTich,
                                    TrangThai = ctsp.TrangThai
                                }).ToList();
            var dataJoinTheTich = dataJoinHang.Join(lstTheTich,
                                   ctsp => ctsp.idTheTich,
                                   tt => tt.Id,
                                   (ctsp, tt) => new
                                   {
                                       ID = ctsp.ID,
                                       IDSP = ctsp.IDSP, //3-8-2024
                                       TenSP = ctsp.TenSP,
                                       Gia = ctsp.Gia,
                                       TenHang = ctsp.TenHang,
                                       TheTich = tt.Thetich1,
                                       TrangThai = ctsp.TrangThai
                                   }).ToList();
            foreach (var item in dataJoinTheTich)
            {
                dtgView_SP.Rows.Add(stt++, item.ID, item.IDSP, item.TenSP, item.Gia, item.TenHang, item.TheTich, item.TrangThai == true ? "Đang Hoạt Động" : "Ngừng Bán");
                //3-8-2024
            }

        }

        public void GetThongTin()
        {
            Hoadon hd = new Hoadon();
            hd.IdNv = _uservice.GetId(info_user);
            DateTime time = DateTime.Now;
            hd.NgayTao = DateOnly.FromDateTime(time);
            hd.Trangthai = false;
            MessageBox.Show(_hService.Them(hd));
            //Bind Id hóa đơn vừa tạo vào textbox
            int idHD = _hService.GetAllHoaDon().First(x => x.IdNv == hd.IdNv && x.NgayTao == hd.NgayTao).Id;
            txtMaHD.Text = idHD.ToString();
        }
        public void LoadAllHD()
        {
            int stt = 1;
            //Xác định số lượng côt = số lượng thuộc tính đối tượng + stt
            dtgView_HD.ColumnCount = 6;
            //Đặt tên cột66
            dtgView_HD.Columns[0].Name = "STT";
            dtgView_HD.Columns[1].Name = "ID Hóa Đơn";
            dtgView_HD.Columns[2].Name = "ID NV";
            dtgView_HD.Columns[3].Name = "Ngay Tao";
            dtgView_HD.Columns[4].Name = "Thanh Tien";
            dtgView_HD.Columns[5].Name = "TrangThai";
            dtgView_HD.Rows.Clear();
            //foreach (var hd in _hService.GetAllHoaDon())
            //{
            //    dtgView_HD.Rows.Add(stt++, hd.Id, hd.IdNv, hd.NgayTao, hd.ThanhTien == null ? 0 + " VND" : hd.ThanhTien + " VND", hd.Trangthai == false ? "Chưa Thanh Toán" : "Đã thanh toán");
            //}
            foreach (var hd in _hService.GetAllHoaDon().Where(x => x.Trangthai == false).ToList()) //ẩn hóa đơn đã thanh toán đi
            {
                dtgView_HD.Rows.Add(stt++, hd.Id, hd.IdNv, hd.NgayTao, hd.ThanhTien == null ? 0 + " VND" : hd.ThanhTien + " VND", hd.Trangthai == false ? "Chưa Thanh Toán" : "Đã thanh toán");
            }
        }
        public void LoadDataCTHD()
        {
            //Tạo Bảng HDCT
            int stt = 1;
            //Xác định số lượng côt = số lượng thuộc tính đối tượng + stt
            dtgView_HDCT.ColumnCount = 9;
            //Đặt tên cột
            dtgView_HDCT.Columns[0].Name = "STT";
            dtgView_HDCT.Columns[1].Name = "ID Hóa Đơn";
            dtgView_HDCT.Columns[2].Name = "ID CTHD";
            dtgView_HDCT.Columns[3].Name = "Tên SP";
            dtgView_HDCT.Columns[4].Name = "Giá";
            dtgView_HDCT.Columns[5].Name = "Hãng";
            dtgView_HDCT.Columns[6].Name = "Thể Tích";
            dtgView_HDCT.Columns[7].Name = "Số lượng";
            dtgView_HDCT.Columns[8].Name = "Thành Tiền";
            dtgView_HDCT.Rows.Clear();
            //ID Hóa đơn, IDCTSP, ID SP, ID Hang, ID TheTich, soluong, Giá
            var lstHang = _sService.GetHang();
            var lstTheTich = _sService.GetTheTich();
            var lstCTSP = _sService.GetCtsp();
            var lstSP = _sService.GetSanPhams();
            var lstHD = _hService.GetAllHoaDon().Where(x => x.Id == _IdHoaDonWhenClick).ToList();
            var lstHDCT = _hDCTService.GetAll();
            decimal? thanhtien = 0;
            var query1 = from hdct in lstHDCT
                         join hd in lstHD on hdct.IdHd equals hd.Id
                         select new { IdHDCT = hdct.Id, IdHD = hd.Id, IdNV = hd.IdNv, ThanhTienHD = hd.ThanhTien, IdCTSP = hdct.IdCtsp, Soluong = hdct.Soluong };
            var query2 = from sp in lstSP
                         join ctsp in lstCTSP on sp.Id equals ctsp.IdSp
                         join h in lstHang on ctsp.IdHang equals h.Id
                         join tt in lstTheTich on ctsp.IdTheTich equals tt.Id
                         select new
                         {
                             IdSP = sp.Id,
                             TenSP = sp.TenSp,
                             DonGia = sp.Gia,
                             TrangThaiSP = sp.TrangThai,
                             IdCTSP = ctsp.Id,
                             IdHang = h.Id,
                             TenHang = h.TenHang,
                             IdTT = tt.Id,
                             TenTT = tt.Thetich1
                         };
            var data = from q1 in query1
                       join q2 in query2 on q1.IdCTSP equals q2.IdCTSP
                       select new
                       {
                           IdHDCT = q1.IdHDCT,
                           IdHD = q1.IdHD,
                           IdNV = q1.IdNV,
                           ThanhTienHD = q1.ThanhTienHD,
                           IdCTSP = q1.IdCTSP,
                           Soluong = q1.Soluong,
                           IdSP = q2.IdSP,
                           TenSP = q2.TenSP,
                           DonGia = q2.DonGia,
                           TrangThaiSP = q2.TrangThaiSP,
                           IdHang = q2.IdHang,
                           TenHang = q2.TenHang,
                           IdTT = q2.IdTT,
                           TenTT = q2.TenTT,
                           SoLuong = q1.Soluong
                       };

            dtgView_HDCT.Rows.Clear();
            foreach (var item in data)
            {
                dtgView_HDCT.Rows.Add(stt++, item.IdHD, item.IdHDCT, item.TenSP, item.DonGia, item.TenHang, item.TenTT, item.SoLuong, item.SoLuong * item.DonGia);
                thanhtien += (item.SoLuong * item.DonGia);
            }
            txtThanhTien.Text = thanhtien.ToString();
        }
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            GetThongTin();
            LoadAllHD();
        }

        private void btn_AddSPToHD_Click(object sender, EventArgs e)
        {
            var ctsp = _sService.GetCtsp().FirstOrDefault(x => x.Id == _IdCTSPWhenClick); //3-8-2024 edit
            var hd = _hService.GetAllHoaDon().FirstOrDefault(x => x.Id == _IdHoaDonWhenClick);
            Cthd cthd = new Cthd();
            cthd.IdCtsp = ctsp.Id;
            cthd.IdHd = hd.Id;
            _hDCTService.Add(cthd);
            UpdateThanhTien();
            LoadDataCTHD();
            LoadAllHD();
        }

        private void UpdateThanhTien()
        {
            var lstCTSP = _sService.GetCtsp();
            var lstSP = _sService.GetSanPhams();
            var lstHD = _hService.GetAllHoaDon().Where(x => x.Id == _IdHoaDonWhenClick);
            var lstHDCT = _hDCTService.GetAll().Where(x => x.IdHd == _IdHoaDonWhenClick);
            var query1 = from hdct in lstHDCT
                         join hd in lstHD on hdct.IdHd equals hd.Id
                         select new { IdHDCT = hdct.Id, IdHD = hd.Id, IdNV = hd.IdNv, ThanhTienHD = hd.ThanhTien, IdCTSP = hdct.IdCtsp, Soluong = hdct.Soluong };
            var query2 = from sp in lstSP
                         join ctsp in lstCTSP on sp.Id equals ctsp.IdSp
                         select new { IdSP = sp.Id, IdCTSP = ctsp.Id, DonGia = sp.Gia };
            var data = from q1 in query1
                       join q2 in query2 on q1.IdCTSP equals q2.IdCTSP
                       select new { IdHDCT = q1.IdHDCT, IdHD = q1.IdHDCT, IdNV = q1.IdHDCT, ThanhTienHD = q1.IdHDCT, IdCTSP = q1.IdHDCT, Soluong = q1.Soluong, DonGia = q2.DonGia };
            decimal? TienHD = 0;
            foreach (var item in data)
            {
                TienHD += item.Soluong * item.DonGia;
            }
            var UpdatedHD = _hService.GetAllHoaDon().First(x => x.Id == _IdHoaDonWhenClick);
            UpdatedHD.ThanhTien = TienHD;
            _hService.UpdateHD(UpdatedHD);
        }

        private void dtgView_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy được xem mình ấn vào dòng nào
            int selectedRow = e.RowIndex;
            if (selectedRow < 0 || selectedRow >= dtgView_SP.RowCount - 1)
            {
                return;
            }
            //ko trích xuất ID từ những dòng ko liên quan
            //Trích xuất cột chứa ID
            _IdSPWhenClick = int.Parse(dtgView_SP.Rows[selectedRow].Cells[2].Value.ToString()); //3-8-2024 sua 
            _IdCTSPWhenClick = int.Parse(dtgView_SP.Rows[selectedRow].Cells[1].Value.ToString()); //3-8-2024 bo sung
        }

        private void dtgView_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy được xem mình ấn vào dòng nào
            int selectedRow = e.RowIndex;
            if (selectedRow < 0 || selectedRow >= _sService.GetSanPhams().Count)
            {
                return;
            }
            //ko trích xuất ID từ những dòng ko liên quan
            //Trích xuất cột chứa ID
            _IdHoaDonWhenClick = int.Parse(dtgView_HD.Rows[selectedRow].Cells[1].Value.ToString());
            txtMaHD.Text = _IdHoaDonWhenClick.ToString();
            txtThanhTien.Text = _hService.GetAllHoaDon().FirstOrDefault(x => x.Id == _IdHoaDonWhenClick).ThanhTien.ToString();
            LoadDataCTHD();
        }

        private void btnCapNhatHD_Click(object sender, EventArgs e)
        {
            //Hoa don co 2 trang thai: Chua TT && da thanh toan => dung cach phia duoi
            var removeCTHD = _hDCTService.GetAll().Where(x => x.IdHd == _IdHoaDonWhenClick).ToList();
            foreach (var x in removeCTHD)
            {
                _hDCTService.Remove(x);
            }
            var removedHD = _hService.GetAllHoaDon().First(x => x.Id == _IdHoaDonWhenClick);
            MessageBox.Show(_hService.RemoveHD(removedHD));
            LoadAllHD();
            LoadDataCTHD();

            //Voi Du an co nhieu trang thai hon, VD: chua thanh toan, da thanh toan, da huy => dung int va update trang thai
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var removedHDCT = _hDCTService.GetAll().FirstOrDefault(x => x.Id == _IdHDCTWhenClick);
            _hDCTService.Remove(removedHDCT);
            UpdateThanhTien();
            LoadAllHD();
            LoadDataCTHD();
        }

        private void dtgView_HDCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy được xem mình ấn vào dòng nào
            int selectedRow = e.RowIndex;
            if (selectedRow < 0 || selectedRow >= _sService.GetSanPhams().Count)
            {
                return;
            }
            //ko trích xuất ID từ những dòng ko liên quan
            //Trích xuất cột chứa ID
            _IdHDCTWhenClick = int.Parse(dtgView_HDCT.Rows[selectedRow].Cells[2].Value.ToString());
        }

        private void txt_TienNhan_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d$");
            //Tien Nhap vao ko dc la chu so
            if (Regex.IsMatch(txt_TienNhan.Text, "^(0|[1-9][0-9]*)$"))
            {
                txt_tienThua.Text = (decimal.Parse(txt_TienNhan.Text) - decimal.Parse(txtThanhTien.Text)).ToString();
                if (decimal.Parse(txt_TienNhan.Text) < decimal.Parse(txtThanhTien.Text)) //khachs chua dua du tien
                {
                    btnThanhToan.Enabled = false;
                }
                else
                {
                    btnThanhToan.Enabled = true;
                }
            }
            else
            {
                btnThanhToan.Enabled = false;
                return;
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //khi thanh toán, sẽ update trạng thái của hóa đơn
            var hdThanhToan = _hService.GetAllHoaDon().FirstOrDefault(x => x.Id == _IdHoaDonWhenClick);
            hdThanhToan.Trangthai = true; //chuyển sang trạng thái đã thanh toán
            _hService.UpdateHD(hdThanhToan);
            thanhTien = hdThanhToan.ThanhTien;
            MessageBox.Show("Thanh Toán Thành Công");
            _IDHdDaThanhToan = _IdHoaDonWhenClick;
            LoadAllHD();
            _IdHoaDonWhenClick = 0;
            LoadDataCTHD();
            txtMaHD.Text = "";
            txtThanhTien.Text = "";
            txt_TienNhan.Text = "";
            txt_tienThua.Text = "";
            btnXuatHD.Enabled = true;
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if(_IDHdDaThanhToan <= 0)
            {
                MessageBox.Show("Bạn chưa thanh toán hóa đơn nào");
                return;
            }
            //ID Hóa đơn, IDCTSP, ID SP, ID Hang, ID TheTich, soluong, Giá
            var lstHang = _sService.GetHang();
            var lstTheTich = _sService.GetTheTich();
            var lstCTSP = _sService.GetCtsp();
            var lstSP = _sService.GetSanPhams();
            var lstHD = _hService.GetAllHoaDon().Where(x => x.Id == _IDHdDaThanhToan).ToList();
            var lstHDCT = _hDCTService.GetAll();
            decimal? thanhtien = 0;
            var query1 = from hdct in lstHDCT
                         join hd in lstHD on hdct.IdHd equals hd.Id
                         select new { IdHDCT = hdct.Id, IdHD = hd.Id, IdNV = hd.IdNv, ThanhTienHD = hd.ThanhTien, IdCTSP = hdct.IdCtsp, Soluong = hdct.Soluong };
            var query2 = from sp in lstSP
                         join ctsp in lstCTSP on sp.Id equals ctsp.IdSp
                         join h in lstHang on ctsp.IdHang equals h.Id
                         join tt in lstTheTich on ctsp.IdTheTich equals tt.Id
                         select new
                         {
                             IdSP = sp.Id,
                             TenSP = sp.TenSp,
                             DonGia = sp.Gia,
                             TrangThaiSP = sp.TrangThai,
                             IdCTSP = ctsp.Id,
                             IdHang = h.Id,
                             TenHang = h.TenHang,
                             IdTT = tt.Id,
                             TenTT = tt.Thetich1
                         };
            var data = from q1 in query1
                       join q2 in query2 on q1.IdCTSP equals q2.IdCTSP
                       select new
                       {
                           IdHDCT = q1.IdHDCT,
                           IdHD = q1.IdHD,
                           IdNV = q1.IdNV,
                           ThanhTienHD = q1.ThanhTienHD,
                           IdCTSP = q1.IdCTSP,
                           Soluong = q1.Soluong,
                           IdSP = q2.IdSP,
                           TenSP = q2.TenSP,
                           DonGia = q2.DonGia,
                           TrangThaiSP = q2.TrangThaiSP,
                           IdHang = q2.IdHang,
                           TenHang = q2.TenHang,
                           IdTT = q2.IdTT,
                           TenTT = q2.TenTT,
                           SoLuong = q1.Soluong
                       };
            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter writer = new HtmlTextWriter(sw))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"card-body mx-4\">");
                    sb.Append("<div class=\"container\">");
                    sb.Append("<p class=\"my-5 mx-5\" style=\"font-size: 30px;\">Thank for your purchase</p>");
                    sb.Append("<div class=\"row\">");
                    sb.Append("<ul class=\"list-unstyled\">");
                    sb.Append("<li class=\"text-black\">");
                    sb.Append(info_user);
                    sb.Append("</li>");
                    sb.Append("<li class=\"text-muted mt-1\"><span class=\"text-black\">Invoice</span>");
                    sb.Append(_IDHdDaThanhToan);
                    sb.Append("</li>");
                    sb.Append("<li class=\"text-black mt-1\">");
                    sb.Append(DateTime.Now); //điền biến của hóa đơn đã lưu vào
                    sb.Append("</li>");
                    sb.Append("</ul>");
                    foreach(var item in data)
                    {
                        sb.Append("<hr>");
                        sb.Append("<div class=\"col-xl-10\">");
                        sb.Append("<p>");
                        sb.Append(item.TenSP);
                        sb.Append(item.TenHang);
                        sb.Append(item.TenTT);
                        sb.Append(" ml");
                        sb.Append("     x");
                        sb.Append(item.Soluong);
                        sb.Append("</p>");
                        sb.Append("</div>");
                        sb.Append("<div class=\"col-xl-2\">");
                        sb.Append("<p class=\"float-end\">{{data.gia}}");
                        sb.Append(item.DonGia * item.Soluong);
                        sb.Append("</p>");
                        sb.Append("</div>");
                        sb.Append("<hr>");
                    }

                    sb.Append("</div>");
                    sb.Append("<hr style=\"border: 2px solid black;\">");
                    sb.Append("</div>");
                    sb.Append("<div class=\"row text-black\">");
                    sb.Append("<div class=\"col-xl-12\">");
                    sb.Append("<p class=\"float-end fw-bold\">Total: ");
                    sb.Append(thanhTien);
                    sb.Append("</p>");
                    sb.Append("</div>");
                    sb.Append("<hr style=\"border: 2px solid black;\">");
                    sb.Append("</div>");
                    sb.Append("<div class=\"text-center\" style=\"margin-top: 90px;\">");
                    sb.Append("<a><u class=\"text-info\">View in browser</u></a>");
                    sb.Append("<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. </p>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");

                    MessageBox.Show(sw.ToString());
                }
            }
        }
    }
}
