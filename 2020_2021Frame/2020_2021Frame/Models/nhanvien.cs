namespace _2020_2021Frame.Models
{
    public class nhanvien
    {
        private string maNhanVien, tenNhanVien, soDienThoai;
        private bool gioiTinh;

        public nhanvien() { }

        public nhanvien(string maNhanVien, string tenNhanVien, string soDienThoai, bool gioiTinh)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.soDienThoai = soDienThoai;
            this.gioiTinh = gioiTinh;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
