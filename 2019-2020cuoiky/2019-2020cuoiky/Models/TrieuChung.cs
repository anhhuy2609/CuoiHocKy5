namespace _2019_2020cuoiky.Models
{
    public class TrieuChung
    {
        string maTrieuChung, tenTrieuChung;

        public TrieuChung()
        {
        }

        public TrieuChung(string maTrieuChung, string tenTrieuChung)
        {
            this.maTrieuChung = maTrieuChung;
            this.tenTrieuChung = tenTrieuChung;
        }

        public string MaTrieuChung { get => maTrieuChung; set => maTrieuChung = value; }
        public string TenTrieuChung { get => tenTrieuChung; set => tenTrieuChung = value; }
    }
}
