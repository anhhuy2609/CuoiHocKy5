using MySql.Data.MySqlClient;
namespace _2021_2022Frame.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }
        public StoreContext(string connectionString)
        {
            ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public void themcongviec(congviec cv)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into CONGVIEC values(@macv, @tencv, @dongia)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macv", cv.Macv);
                cmd.Parameters.AddWithValue("tencv", cv.Tencv);
                cmd.Parameters.AddWithValue("dongia", cv.Dongia);
                cmd.ExecuteNonQuery();
            }
        }

        public List<baoduong> getbaoduong(string soxe)
        {
            List<baoduong> list = new List<baoduong>();
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from BAODUONG where soxe = @soxe";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("soxe", soxe);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var baoduong = new baoduong
                        {
                            Mabd = reader[0].ToString(),
                            Ngaygionhan = reader[1].ToString(),
                            Ngaygiotra = reader[2].ToString(),
                            Sokm = reader[3].ToString(),
                            Noidung = reader[4].ToString()
                        };
                        list.Add(baoduong);
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public baoduong chitietbaoduong(string Mabd)
        {
            baoduong bd = new baoduong();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select MABD, NGAYGIONHAN, NGAYGIOTRA from BAODUONG where MABD = @Mabd";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("Mabd", Mabd);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bd.Mabd = reader["MABD"].ToString();
                        bd.Ngaygionhan = reader["NGAYGIONHAN"].ToString();
                        bd.Ngaygiotra = reader["NGAYGIOTRA"].ToString();
                    }
                }
            }
            return bd;
        }

        public List<congviec> getcongviec(string Mabd)
        {
            List<congviec> list = new List<congviec>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select C.MACV, TENCV, DONGIA from CONGVIEC C, CT_BD, BAODUONG B where C.MACV = CT_BD.MACV and CT_BD.MABD = B.MABD and B.MABD = @Mabd";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("Mabd", Mabd);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        congviec cv = new congviec()
                        {
                            Macv = reader[0].ToString(),
                            Tencv = reader[1].ToString(),
                            Dongia = Convert.ToDouble(reader[2])
                        };
                        list.Add(cv);
                    }
                }
            }
            return list;
        }

        public void xoacongviec(string Mabd, string Macv)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from CT_BD where MABD = @Mabd and MACV = @Macv";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("Mabd", Mabd);
                cmd.Parameters.AddWithValue("Macv", Macv);
                cmd.ExecuteNonQuery();
            }
        }

        public baoduong suabaoduong(string Mabd)
        {
            baoduong bd = new baoduong();
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from BAODUONG where MABD = @Mabd";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("Mabd", Mabd);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bd.Mabd = reader[0].ToString();
                        bd.Ngaygionhan = reader[1].ToString();
                        bd.Ngaygiotra = reader[2].ToString();
                        bd.Sokm = reader[3].ToString();
                        bd.Noidung = reader[4].ToString();
                    }
                }
            }
            return bd;
        }
        public void capnhatbd(baoduong baoduong)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update baoduong set NGAYGIONHAN = @ngaygionhan, NGAYGIOTRA = @ngaygiotra, SOKM = @sokm, NOIDUNG = @noidung where MABD = @mabd";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ngaygionhan", baoduong.Ngaygionhan);
                cmd.Parameters.AddWithValue("ngaygiotra", baoduong.Ngaygiotra);
                cmd.Parameters.AddWithValue("sokm", baoduong.Sokm);
                cmd.Parameters.AddWithValue("noidung", baoduong.Noidung);
                cmd.Parameters.AddWithValue("mabd", baoduong.Mabd);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
