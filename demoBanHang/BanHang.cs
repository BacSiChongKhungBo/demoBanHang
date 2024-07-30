using demoBanHang.DomainClass;
using demoBanHang.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoBanHang
{
    public partial class BanHang : Form
    {
        SanPhamService _sService = new SanPhamService();
        UserService _uservice = new UserService();
        HoaDonService _hService = new HoaDonService();
        HDCTService _hDCTService = new HDCTService();
        int _IdSPWhenClick;
        string info_user;
        public BanHang(string user)
        {
            InitializeComponent();
            txt_user.Text = user;
            txt_user.Enabled = false;
            txtMaHD.Enabled = false;
            txtThanhTien.Enabled = false;
            info_user = user;
            LoadDataSP();
        }

        public void LoadDataSP()
        {
            int stt = 1;
            //Xác định số lượng côt = số lượng thuộc tính đối tượng + stt
            dtgView_SP.ColumnCount = 7;
            //Đặt tên cột
            dtgView_SP.Columns[0].Name = "STT";
            dtgView_SP.Columns[1].Name = "ID";
            dtgView_SP.Columns[2].Name = "Tên SP";
            dtgView_SP.Columns[3].Name = "Giá";
            dtgView_SP.Columns[4].Name = "Hãng";
            dtgView_SP.Columns[5].Name = "Thể Tích";
            dtgView_SP.Columns[6].Name = "Trạng Thái";
            //Reset dòng để ko bị lỗi khi load lại
            dtgView_SP.Rows.Clear();
            //Bổ sung: Giấu cột ID đi

            var lstHang = _sService.GetHang();
            var lstTheTich = _sService.GetTheTich();
            var lstCTSP = _sService.GetCtsp();
            var lstSP = _sService.GetSanPhams();
            //join           bảng A       Bảng B
            var dataJoinSP = lstCTSP.Join(lstSP,
                           ctsp => ctsp.Id, //Key bảng A
                           sp => sp.Id, // Key bảng B

                           (ctsp, sp) => new // key A = Key B
                           { //Có thể lấy dữ liệu từ cả 2 bảng
                               ID = ctsp.Id,
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
                                       TenSP = ctsp.TenSP,
                                       Gia = ctsp.Gia,
                                       TenHang = ctsp.TenHang,
                                       TheTich = tt.Thetich1,
                                       TrangThai = ctsp.TrangThai
                                   }).ToList();
            foreach (var item in dataJoinTheTich)
            {
                dtgView_SP.Rows.Add(stt++, item.ID, item.TenSP, item.Gia, item.TenHang, item.TheTich, item.TrangThai == true ? "Đang Hoạt Động" : "Ngừng Bán");
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
        public void LoadDataCTHD()
        {
            //Tạo Bảng HDCT
            int stt = 1;
            //Xác định số lượng côt = số lượng thuộc tính đối tượng + stt
            dtgView_CTHD.ColumnCount = 9;
            //Đặt tên cột
            dtgView_CTHD.Columns[0].Name = "STT";
            dtgView_CTHD.Columns[1].Name = "ID Hóa Đơn";
            dtgView_CTHD.Columns[2].Name = "ID CTHD";
            dtgView_CTHD.Columns[3].Name = "Tên SP";
            dtgView_CTHD.Columns[4].Name = "Giá";
            dtgView_CTHD.Columns[5].Name = "Hãng";
            dtgView_CTHD.Columns[6].Name = "Thể Tích";
            dtgView_CTHD.Columns[7].Name = "Số lượng";
            dtgView_CTHD.Columns[8].Name = "Thành Tiền";
            dtgView_CTHD.Rows.Clear();
            //ID Hóa đơn, IDCTSP, ID SP, ID Hang, ID TheTich, soluong, Giá
            var lstHang = _sService.GetHang();
            var lstTheTich = _sService.GetTheTich();
            var lstCTSP = _sService.GetCtsp();
            var lstSP = _sService.GetSanPhams();
            var lstHD = _hService.GetAllHoaDon();
            var lstHDCT = _hDCTService.GetAll();
            decimal? thanhtien = 0;
            var query1 = from hdct in lstHDCT
                         join hd in lstHD on hdct.IdHd equals hd.Id
                         join ctsp in lstCTSP on hdct.IdCtsp equals ctsp.Id
                         select new { IdHDCT = hdct.Id, IdHD = hd.Id, IdSP = ctsp.IdSp, IdHang = ctsp.IdHang, IdTT = ctsp.IdTheTich, sl = hdct.Soluong };
            var query2 = from q1 in query1
                         join spham in lstSP on q1.IdSP equals spham.Id
                         join hang in lstHang on q1.IdHang equals hang.Id
                         join tt in lstTheTich on q1.IdTT equals tt.Id
                         select new { IdHDCT = q1.IdHDCT, IdHD = q1.IdHD, IdSP = q1.IdSP, TenSP = spham.TenSp, gia = spham.Gia, IdHang = q1.IdHang, TenHang = hang.TenHang, IdTT = q1.IdTT, tenTT = tt.Thetich1, sl = q1.sl };
            dtgView_CTHD.Rows.Clear();
            foreach (var item in query2)
            {
                dtgView_CTHD.Rows.Add(stt++, item.IdHD, item.IdHDCT, item.TenSP, item.gia, item.TenHang, item.tenTT, item.sl, item.sl * item.gia);
                thanhtien += (item.sl * item.gia);
            }
            txtThanhTien.Text = thanhtien.ToString();
        }
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            GetThongTin();
            LoadDataCTHD();
        }

        private void btn_AddSPToHD_Click(object sender, EventArgs e)
        {
            var ctsp = _sService.GetCtsp().FirstOrDefault(x => x.Id == _IdSPWhenClick);
            var hd = _hService.GetAllHoaDon().FirstOrDefault(x => x.Id.ToString() == txtMaHD.Text);
            Cthd cthd = new Cthd();
            cthd.IdCtsp = ctsp.Id;
            cthd.IdHd = hd.Id;
            _hDCTService.Add(cthd);
            LoadDataCTHD();

        }

        private void dtgView_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy được xem mình ấn vào dòng nào
            int selectedRow = e.RowIndex;
            if (selectedRow < 0 || selectedRow >= _sService.GetSanPhams().Count)
            {
                return;
            }
            //ko trích xuất ID từ những dòng ko liên quan
            //Trích xuất cột chứa ID
            _IdSPWhenClick = int.Parse(dtgView_SP.Rows[selectedRow].Cells[1].Value.ToString());
        }
    }
}
