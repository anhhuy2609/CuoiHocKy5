namespace _2020_2021Frame.Models
{
    public class canho
    {
        private string maCanHo, tenChuHo;
        public canho() { }

        public canho(string maCanHo, string tenChuHo)
        {
            this.maCanHo = maCanHo;
            this.tenChuHo = tenChuHo;
        }

        public string MaCanHo { get => maCanHo; set => maCanHo = value; }
        public string TenChuHo { get => tenChuHo; set => tenChuHo = value; }
    }
}
