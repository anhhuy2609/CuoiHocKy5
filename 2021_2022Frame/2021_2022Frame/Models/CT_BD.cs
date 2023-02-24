namespace _2021_2022Frame.Models
{
    public class CT_BD
    {
        private string mabd, macv;
        public CT_BD() { }

        public CT_BD(string mabd, string macv)
        {
            this.mabd = mabd;
            this.macv = macv;
        }

        public string Mabd { get => mabd; set => mabd = value; }
        public string Macv { get => macv; set => macv = value; }
    }
}
