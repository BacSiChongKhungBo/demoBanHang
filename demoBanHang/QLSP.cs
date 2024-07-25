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
    public partial class QLSP : Form
    {
        //Khai báo và khởi service
        SanPhamService _sService = new SanPhamService();
        //Thông tin ID:
        int _IdWhenClick;
        //Tạo List SP
        List<SanPham> _lstSP = new List<SanPham>();
        public QLSP()
        {
            InitializeComponent();
            SettingCombobox();
            _lstSP = _sService.GetSanPhams().Where(x => x.TrangThai == true).ToList();
            LoadDataSP();
            LoadDataCTSP();
        }

        private void LoadDataCTSP()
        {
            int stt = 1;
            //Xác định số lượng côt = số lượng thuộc tính đối tượng + stt
            dataGridView1.ColumnCount = 7;
            //Đặt tên cột
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "ID";
            dataGridView1.Columns[2].Name = "Tên SP";
            dataGridView1.Columns[3].Name = "Giá";
            dataGridView1.Columns[4].Name = "Hãng";
            dataGridView1.Columns[5].Name = "Thể Tích";
            dataGridView1.Columns[6].Name = "Trạng Thái";
            //Reset dòng để ko bị lỗi khi load lại
            dataGridView1.Rows.Clear();
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
            foreach ( var item in dataJoinTheTich)
            {
                dataGridView1.Rows.Add(stt++, item.ID, item.TenSP, item.Gia, item.TenHang, item.TheTich, item.TrangThai == true ? "Đang Hoạt Động" : "Ngừng Bán");
            }
            
            
        }

        public void LoadDataSP()
        {
            //Tạo 1 stt
            int stt = 1;
            //Xác định số lượng côt = số lượng thuộc tính đối tượng + stt
            dtgView_SP.ColumnCount = 5;
            //Đặt tên cột
            dtgView_SP.Columns[0].Name = "STT";
            dtgView_SP.Columns[1].Name = "ID";
            dtgView_SP.Columns[2].Name = "Tên SP";
            dtgView_SP.Columns[3].Name = "Giá";
            dtgView_SP.Columns[4].Name = "Trạng Thái";
            //Reset dòng để ko bị lỗi khi load lại
            dtgView_SP.Rows.Clear();
            //Bổ sung: Giấu cột ID đi
            dtgView_SP.Columns[1].Visible = false;
            //Add đối tượng vào datagrid
            foreach (var sp in _lstSP)
            {
                dtgView_SP.Rows.Add(stt++, sp.Id, sp.TenSp, sp.Gia, sp.TrangThai == true ? "Đang Hoạt Động" : "Ngừng Bán");
            }
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
            _IdWhenClick = int.Parse(dtgView_SP.Rows[selectedRow].Cells[1].Value.ToString());
            FillData();
        }

        private void FillData()
        {
            var data = _sService.GetSanPhams().First(x => x.Id == _IdWhenClick);
            txtSP_Ten.Text = data.TenSp;
            txtSP_Gia.Text = data.Gia.ToString();
            if (data.TrangThai == true)
            {
                rbtnSP_HD.Checked = true;
            }
            else
            {
                rbtnSP_NgungBan.Checked = true;
            }

        }

        private void SettingCombobox()
        {
            cmbxLoc.SelectedIndex = 0;
            cmbxLoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cmbxLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxLoc.SelectedIndex == 0)
            {
                _lstSP = _sService.GetSanPhams().Where(x => x.TrangThai == true).ToList();
            }
            else if (cmbxLoc.SelectedIndex == 1)
            {
                _lstSP = _sService.GetSanPhams().Where(x => x.TrangThai == false).ToList();
            }
            else
            {
                _lstSP = _sService.GetSanPhams();
            }
            LoadDataSP();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng mới
            SanPham sp = new SanPham();
            //Gán giá trị từ màn hình vào đối tượng
            sp.TenSp = txtSP_Ten.Text;
            sp.Gia = decimal.Parse(txtSP_Gia.Text);
            if (rbtnSP_HD.Checked == true)
            {
                sp.TrangThai = true;
            }
            else
            {
                sp.TrangThai = false;
            }
            //gọi message thông báo và load lại Data
            MessageBox.Show(_sService.Them(sp));
            //update list sản phẩm do có 1 sản phẩm mới add vào
            _lstSP = _sService.GetSanPhams().Where(x => x.TrangThai == true).ToList();
            LoadDataSP();
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            //với cập nhật, thay vì tạo đối tượng mới => lấy đối tượng tìm được để update
            var sp = _sService.GetSanPhams().Where(x => x.Id == _IdWhenClick).FirstOrDefault();
            sp.TenSp = txtSP_Ten.Text;
            sp.Gia = decimal.Parse(txtSP_Gia.Text);
            if (rbtnSP_HD.Checked == true)
            {
                sp.TrangThai = true;
            }
            else
            {
                sp.TrangThai = false;
            }
            //gọi message thông báo và load lại Data
            MessageBox.Show(_sService.CapNhat(sp));
            //update list sản phẩm do có 1 sản phẩm mới add vào
            _lstSP = _sService.GetSanPhams().Where(x => x.TrangThai == true).ToList();
            LoadDataSP();
        }
    }
}
