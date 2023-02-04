namespace _2019_2020cuoiky.Models
{
    public class CN_TC
    {
        string maCongnhan, maTrieuChung;

        public CN_TC()
        {
        }

        public CN_TC(string maCongnhan, string maTrieuChung)
        {
            this.maCongnhan = maCongnhan;
            this.maTrieuChung = maTrieuChung;
        }

        public string MaCongnhan { get => maCongnhan; set => maCongnhan = value; }
        public string MaTrieuChung { get => maTrieuChung; set => maTrieuChung = value; }
    }
}
