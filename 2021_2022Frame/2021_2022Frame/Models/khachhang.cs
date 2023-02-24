namespace _2021_2022Frame.Models
{
    public class khachhang
    {
        private string makh, hotenkh, diachi, dienthoai;

        public khachhang() { }
        public khachhang(string makh, string hotenkh, string diachi, string dienthoai)
        {
            this.makh = makh;
            this.hotenkh = hotenkh;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
        }

        public string Makh { get => makh; set => makh = value; }
        public string Hotenkh { get => hotenkh; set => hotenkh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
    }
}
