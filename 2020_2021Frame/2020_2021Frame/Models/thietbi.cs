namespace _2020_2021Frame.Models
{
    public class thietbi
    {
        private string maThietBi, tenThietBi;
        public thietbi() { }

        public thietbi(string maThietBi, string tenThietBi)
        {
            this.maThietBi = maThietBi;
            this.tenThietBi = tenThietBi;
        }

        public string MaThietBi { get => maThietBi; set => maThietBi = value; }
        public string TenThietBi { get => tenThietBi; set => tenThietBi = value; }
    }
}
