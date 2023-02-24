namespace _2020_2021Frame.Models
{
    public class NV_TB
    {
        private string maNhanVien, maThietBi, maCanHo;
        private int lanThu;
        private string ngayBaoTri;
        public NV_TB() { }

        public NV_TB(string maNhanVien, string maThietBi, string maCanHo, int lanThu, string ngayBaoTri)
        {
            this.maNhanVien = maNhanVien;
            this.maThietBi = maThietBi;
            this.maCanHo = maCanHo;
            this.lanThu = lanThu;
            this.ngayBaoTri = ngayBaoTri;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaThietBi { get => maThietBi; set => maThietBi = value; }
        public string MaCanHo { get => maCanHo; set => maCanHo = value; }
        public int LanThu { get => lanThu; set => lanThu = value; }
        public string NgayBaoTri { get => ngayBaoTri; set => ngayBaoTri = value; }
    }
}
