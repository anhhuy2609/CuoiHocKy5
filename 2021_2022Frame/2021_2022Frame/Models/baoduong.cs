namespace _2021_2022Frame.Models
{
    public class baoduong
    {
        private string mabd, ngaygionhan, ngaygiotra, sokm, noidung, soxe;
        public baoduong() { }

        public baoduong(string mabd, string ngaygionhan, string ngaygiotra, string sokm, string noidung, string soxe)
        {
            this.mabd = mabd;
            this.ngaygionhan = ngaygionhan;
            this.ngaygiotra = ngaygiotra;
            this.sokm = sokm;
            this.noidung = noidung;
            this.soxe = soxe;
        }

        public string Mabd { get => mabd; set => mabd = value; }
        public string Ngaygionhan { get => ngaygionhan; set => ngaygionhan = value; }
        public string Ngaygiotra { get => ngaygiotra; set => ngaygiotra = value; }
        public string Sokm { get => sokm; set => sokm = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Soxe { get => soxe; set => soxe = value; }
    }
}
