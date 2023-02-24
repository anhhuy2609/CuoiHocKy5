namespace _2021_2022Frame.Models
{
    public class xe
    {
        private string soxe, hangxe, namsx, makh;
        public xe() { }

        public xe(string soxe, string hangxe, string namsx, string makh)
        {
            this.soxe = soxe;
            this.hangxe = hangxe;
            this.namsx = namsx;
            this.makh = makh;
        }

        public string Soxe { get => soxe; set => soxe = value; }
        public string Hangxe { get => hangxe; set => hangxe = value; }
        public string Namsx { get => namsx; set => namsx = value; }
        public string Makh { get => makh; set => makh = value; }
    }
}
