using System.Data;
using Microsoft.Data.SqlClient;

namespace Lab11_ClassManager
{
    public class LopRepository
    {
        // SQL Server tren may ca nhan.
        // Su dung Windows Authentication.
        public const string ConnectionString =
            "Server=localhost;" +
            "Database=EduManagerDB;" +
            "Integrated Security=True;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        // ==================== DANH SACH KHOA ====================

        public DataTable GetKhoa()
        {
            const string sql = @"
                SELECT
                    MaKhoa,
                    TenKhoa
                FROM dbo.KHOA
                ORDER BY TenKhoa;";

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            using (SqlDataAdapter adapter =
                new SqlDataAdapter(command))
            {
                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        // ==================== DANH SACH VA TIM KIEM LOP ====================

        public DataTable GetLop(string keyword)
        {
            const string sql = @"
                SELECT
                    l.MaLop,
                    l.TenLop,
                    l.MaKhoa,
                    k.TenKhoa
                FROM dbo.LOP AS l
                INNER JOIN dbo.KHOA AS k
                    ON l.MaKhoa = k.MaKhoa
                WHERE
                    l.MaLop LIKE @TuKhoa
                    OR l.TenLop LIKE @TuKhoa
                ORDER BY l.MaLop;";

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            using (SqlDataAdapter adapter =
                new SqlDataAdapter(command))
            {
                command.Parameters.Add(
                    "@TuKhoa",
                    SqlDbType.NVarChar,
                    202).Value = "%" + keyword + "%";

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        // ==================== KIEM TRA MA TRUNG ====================

        public bool Exists(string maLop)
        {
            const string sql = @"
                SELECT COUNT(*)
                FROM dbo.LOP
                WHERE MaLop = @MaLop;";

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            {
                command.Parameters.Add(
                    "@MaLop",
                    SqlDbType.VarChar,
                    10).Value = maLop;

                connection.Open();

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        // ==================== THEM LOP ====================

        public int Insert(
            string maLop,
            string tenLop,
            string maKhoa)
        {
            const string sql = @"
                INSERT INTO dbo.LOP
                (
                    MaLop,
                    TenLop,
                    MaKhoa
                )
                VALUES
                (
                    @MaLop,
                    @TenLop,
                    @MaKhoa
                );";

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            {
                command.Parameters.Add(
                    "@MaLop",
                    SqlDbType.VarChar,
                    10).Value = maLop;

                command.Parameters.Add(
                    "@TenLop",
                    SqlDbType.NVarChar,
                    100).Value = tenLop;

                command.Parameters.Add(
                    "@MaKhoa",
                    SqlDbType.VarChar,
                    10).Value = maKhoa;

                connection.Open();

                return command.ExecuteNonQuery();
            }
        }

        // ==================== CAP NHAT TEN LOP ====================

        public int Update(string maLop, string tenLop)
        {
            const string sql = @"
                UPDATE dbo.LOP
                SET TenLop = @TenLop
                WHERE MaLop = @MaLop;";

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            {
                command.Parameters.Add(
                    "@MaLop",
                    SqlDbType.VarChar,
                    10).Value = maLop;

                command.Parameters.Add(
                    "@TenLop",
                    SqlDbType.NVarChar,
                    100).Value = tenLop;

                connection.Open();

                return command.ExecuteNonQuery();
            }
        }

        // ==================== KIEM TRA SINH VIEN THUOC LOP ====================

        public bool HasStudents(string maLop)
        {
            const string sql = @"
                SELECT COUNT(*)
                FROM dbo.SINHVIEN
                WHERE MaLop = @MaLop;";

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            {
                command.Parameters.Add(
                    "@MaLop",
                    SqlDbType.VarChar,
                    10).Value = maLop;

                connection.Open();

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        // ==================== XOA LOP ====================

        public int Delete(string maLop)
        {
            const string sql = @"
                DELETE FROM dbo.LOP
                WHERE MaLop = @MaLop;";

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            {
                command.Parameters.Add(
                    "@MaLop",
                    SqlDbType.VarChar,
                    10).Value = maLop;

                connection.Open();

                return command.ExecuteNonQuery();
            }
        }
    }
}