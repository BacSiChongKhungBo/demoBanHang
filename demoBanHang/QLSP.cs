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
            //khóa tên SP lại
            txtTenSP2.Enabled = false;
            rbtn_CTSP_HD.Checked = true;
            SettingCheckListBoxHang();
            SettingCheckListBoxTheTich();
        }

        private void SettingCheckListBoxTheTich()
        {
            foreach (var item in _sService.GetTheTich().Where(x => x.TrangThai == true).ToList())
            {
                chlbx_TheTich.Items.Add(item.Thetich1);
            }
        }

        private void SettingCheckListBoxHang()
        {
            foreach (var item in _sService.GetHang().Where(x => x.TrangThai == true).ToList())
            {
                chlbx_Hang.Items.Add(item.TenHang);
            }
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
            var lstSP = _sService.GetSanPhams().Where(x => x.Id == _IdWhenClick);
            //join           bảng A       Bảng B
            var dataJoinSP = lstCTSP.Join(lstSP,
                           ctsp => ctsp.IdSp, //Key bảng A
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
            LoadDataCTSP();
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
            txtTenSP2.Text = data.TenSp;
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

        private void btn_CTSP_Them_Click(object sender, EventArgs e)
        {

            //tạo số lượng vòng lặp tương ứng với số biến thể ta có của đối tượng
            List<string> selectedHangs = new List<string>();
            List<int> selectedTheTichs = new List<int>();
            foreach (Object item in chlbx_Hang.CheckedItems)
            {
                selectedHangs.Add(item.ToString());
            }
            foreach (int item in chlbx_TheTich.CheckedItems)
            {
                selectedTheTichs.Add(item);
            }
            List<int> selectedHangIds = new List<int>();
            List<int> selectedTheTichIds = new List<int>();
            foreach (var item in selectedHangs)
            {
                int id = _sService.GetHang().FirstOrDefault(x => x.TenHang.Equals(item)).Id;
                selectedHangIds.Add(id);
            }
            foreach (var item in selectedTheTichs)
            {
                int id = _sService.GetTheTich().FirstOrDefault(x => x.Thetich1.Equals(item)).Id;
                selectedTheTichIds.Add(id);
            }
            bool checkSuccess = false; //để check xem có sản phẩm ct nào add thành công vào db ko
            foreach (var itemH in selectedHangIds)
            {
                foreach (int itemTT in selectedTheTichIds)
                {
                    Ctsp ctsp = new Ctsp();
                    ctsp.IdSp = _IdWhenClick;
                    ctsp.IdHang = itemH;
                    ctsp.IdTheTich = itemTT;
                    if (rbtn_CTSP_HD.Checked)
                    {
                        ctsp.TrangThai = true;
                    }
                    else
                    {
                        ctsp.TrangThai = false;
                    }
                    if (_sService.ThemCTSP(ctsp).Equals("Thêm Thành Công"))
                    {
                        checkSuccess = true;
                    }
                }
            }
            if (checkSuccess)
            {
                MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm Thất bại hoặc đã có CTSP tồn tại trong CSDL");
            }
            LoadDataCTSP();
        }

        private void btn_CTSP_CapNhat_Click(object sender, EventArgs e)
        {
            //có thể tách thể tích và hãng là 2 hàm trả về list khác nhau
            List<string> selectedHangs = new List<string>();
            List<int> selectedTheTichs = new List<int>();
            foreach (Object item in chlbx_Hang.CheckedItems)
            {
                selectedHangs.Add(item.ToString());
            }
            foreach (int item in chlbx_TheTich.CheckedItems)
            {
                selectedTheTichs.Add(item);
            }
            List<int> selectedHangIds = new List<int>();
            List<int> selectedTheTichIds = new List<int>();
            foreach (var item in selectedHangs)
            {
                int id = _sService.GetHang().FirstOrDefault(x => x.TenHang.Equals(item)).Id;
                selectedHangIds.Add(id);
            }
            foreach (var item in selectedTheTichs)
            {
                int id = _sService.GetTheTich().FirstOrDefault(x => x.Thetich1.Equals(item)).Id;
                selectedTheTichIds.Add(id);
            }
            bool checkSuccess = false; //để check xem có sản phẩm ct nào add thành công vào db ko
            foreach (var itemH in selectedHangIds)
            {
                foreach (int itemTT in selectedTheTichIds) 
                {
                    var selectedItem = _sService.GetCtsp().FirstOrDefault(x => x.IdSp == _IdWhenClick && x.IdHang == itemH && itemTT == x.IdTheTich);
                    //Với cập nhật, selected Item có thể trả về null
                    // => ko xử lý nếu null
                    if (selectedItem != null)
                    {
                        if (rbtn_CTSP_HD.Checked)
                        {
                            selectedItem.TrangThai = true;
                        }
                        else
                        {
                            selectedItem.TrangThai = false;
                        }
                        if (_sService.UpdateCTSP(selectedItem).Equals("Cập nhật Thành Công"))
                        {
                            checkSuccess = true;
                        }
                    }
                }
            }
            if (checkSuccess)
            {
                MessageBox.Show("Cập Nhật Thành Công");
            }
            else
            {
                MessageBox.Show("Cập Nhật Thất Bại");
            }
            LoadDataCTSP();
        }
    }
}
