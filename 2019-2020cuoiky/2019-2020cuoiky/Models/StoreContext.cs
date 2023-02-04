using MySql.Data.MySqlClient;
namespace _2019_2020cuoiky.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }//biết thành viên 

        public StoreContext(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }
        
        public void ThemDCL(DiemCachLy dcl)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "INSERT INTO DiemCachLy VALUES(@MaDiemCachLy, @TenDiemCachLy, @DiaChi)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaDiemCachLy", dcl.MaDiemCachLy);
                cmd.Parameters.AddWithValue("TenDiemCachLy", dcl.TenDiemCachLy);
                cmd.Parameters.AddWithValue("DiaChi", dcl.DiaChi);
                cmd.ExecuteNonQuery();
            }
        }

        public List<object> LietKeTC(int soTC)
        {
            List<object> list = new List<object>();
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select C.MaCongNhan, TenCongNhan, NamSinh, NuocVe, count(*) from CONGNHAN C, CN_TC T where C.MaCongNhan = T.MaCongNhan group by MaCongNhan, TenCongNhan, NamSinh, NuocVe having count(*) >= @stc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("stc", soTC);
                using(var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var obj = new
                        {
                            MaCongNhan = reader[0].ToString(),
                            TenCongNhan = reader[1].ToString(),
                            NamSinh = Convert.ToInt32(reader[2]),
                            NuocVe = reader[3].ToString(),
                            SoTC = Convert.ToInt32(reader[4])
                        };
                        list.Add(obj);
                    }
                }
            }
            return list;
        }

        public List<DiemCachLy> getAllDCL()
        {
            List<DiemCachLy> list = new List<DiemCachLy>();
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from DiemCachLy";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DiemCachLy dcl = new DiemCachLy()
                        {
                            MaDiemCachLy = reader[0].ToString(),
                            TenDiemCachLy = reader[1].ToString()
                        };
                        list.Add(dcl);
                    }
                }
            }
            return list;
        }

        public List<CongNhan> getCongNhan(string MaDiemCachLy)
        {
            List<CongNhan> list = new List<CongNhan>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from CongNhan where MaDiemCachLy = @MaDCL";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaDCL", MaDiemCachLy);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CongNhan cn = new CongNhan()
                        {
                            MaCongNhan = reader[0].ToString(),
                            TenCongNhan = reader[1].ToString()
                        };
                        list.Add(cn);
                    }
                }
            }
            return list;
        }

        public void deleteCN(string MaCongNhan)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from CN_TC where MaCongNhan = @macn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macn", MaCongNhan);
                cmd.ExecuteNonQuery();

                var str2 = "delete from CongNhan where MaCongNhan = @macn";
                cmd = new MySqlCommand(str2, conn);
                cmd.Parameters.AddWithValue("macn", MaCongNhan);
                cmd.ExecuteNonQuery();
            }
        }

        public CongNhan getCNInfo(string MaCN)
        {
            CongNhan cn = new CongNhan();
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from CongNhan where MaCongNhan = @macn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macn", MaCN);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cn.MaCongNhan = reader[0].ToString();
                        cn.TenCongNhan = reader[1].ToString();
                        cn.GioiTinh = (Boolean)reader[2];
                        cn.NamSinh = Convert.ToInt32(reader[3]);
                        cn.NuocVe = reader[4].ToString();
                    }
                }
            }
            return cn;
        }

    }
}
