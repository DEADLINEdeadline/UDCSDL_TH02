using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DAO
{
    class DataProvider
    {
        private static DataProvider instance;//tạo một thể hiện của lớp DataProvider để toàn một chương trình chỉ có duy nhất một kết nối database

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return DataProvider.instance;
            }

            private set
            {
                DataProvider.instance = value;
            }
        }
        private DataProvider() { }

        private string connectionSTR = @"Data Source=.\;Initial Catalog=QuanLyDanhSach;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))//kết nối db/sử dụng using để tự giải phóng kết nối khi cần
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                ad.Fill(dt);
                connection.Close();
            }

            return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)//trả về số dòng ảnh hưởng trong trường hợp thêm xóa sửa
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))//kết nối db/sử dụng using để tự giải phóng kết nối khi cần
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)//trả về giá trị trong trường hợp count*..
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))//kết nối db/sử dụng using để tự giải phóng kết nối khi cần
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
