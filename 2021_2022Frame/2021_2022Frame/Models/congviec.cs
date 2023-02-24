namespace _2021_2022Frame.Models
{
    public class congviec
    {
        private string macv, tencv;
        private double dongia;

        public congviec() { }

        public congviec(string macv, string tencv, double dongia)
        {
            this.macv = macv;
            this.tencv = tencv;
            this.dongia = dongia;
        }

        public string Macv { get => macv; set => macv = value; }
        public string Tencv { get => tencv; set => tencv = value; }
        public double Dongia { get => dongia; set => dongia = value; }
    }
}
