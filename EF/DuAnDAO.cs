using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class DuAnDAO
	{
		SqlConnection conn = null;
		SqlCommand cmd = null;
		SqlDataAdapter apt = null;
		KetNoi kn = new KetNoi();

		public DuAnDAO()
		{
			conn = kn.GetConnect();
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
		}

		//get all data
		public DataTable getList()
		{
			string sql = null;
			sql = "SELECT * FROM tblDuAn";
			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);
			return dt;
		}

		//insert data
		public void InsertOne(DuAn da)
		{
			string sql = "INSERT INTO tblDuAn(Ma_Da,Ten_Da,SoNV_Da,Mota_Da)";
			sql += "VALUES(N'" + da.Ma_Da + "',N'" + da.Ten_Da + "','" + da.SoNV_Da + "',N'" + da.Mota_Da + "')";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//update data
		public void UpdateOne(string id_Da, DuAn da)
		{
			string sql = "UPDATE tblDuAn SET Ma_Da= N'" + da.Ma_Da + "',Ten_Da=N'" + da.Ten_Da + "',SoNV_Da=N'" + da.SoNV_Da + "',Mota_Da=N'" + da.Mota_Da + "'";
			sql += "WHERE Id_Da='" + id_Da + "'";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//delete data
		public void DeleteOne(int id_Da)
		{
			string sql = "DELETE FROM tblDuAn WHERE Id_Da='" + id_Da + "'";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//check exists data
		public int KiemTraMaDuAn(string ma_DuAn)
		{

			int count;
			string sql = "SELECT COUNT(Ma_Da) FROM tblDuAn WHERE Ma_Da = @ma_DuAn";

			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@ma_DuAn", ma_DuAn);
				count = Convert.ToInt32(cmd.ExecuteScalar());
			}

			return count;
		}

		//Kiểm tra nhân viên có tồn tại trong dự án chưa
		public bool IsEmployeeInProject(int projectID, int employeeID)
		{
			
				// Kiểm tra xem employee có trong project không
				string sql = "SELECT COUNT(*) FROM DuAnNhanVien WHERE Id_Da = @ProjectID AND ID_NhanVien = @EmployeeID";
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@ProjectID", projectID);
					cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

					int count = (int)cmd.ExecuteScalar();
					return count > 0;
				}
			
		}

		// Hàm thêm nhân viên vào dự án
		public bool AddEmployeeToProject(int projectID, int employeeID)
		{
			
				// Thêm nhân viên vào dự án
				string query = "INSERT INTO DuAnNhanVien (Id_Da, ID_NhanVien) VALUES (@ProjectID, @EmployeeID)";
				using (SqlCommand command = new SqlCommand(query, conn))
				{
					command.Parameters.AddWithValue("@ProjectID", projectID);
					command.Parameters.AddWithValue("@EmployeeID", employeeID);

					int rowsAffected = command.ExecuteNonQuery();
					return rowsAffected > 0;
				}
			
		}

		//Kiểm tra nhân viên có đủ chưa
		public bool CheckEnoughEmployee(int projectID, int employeeID)
		{

			// Kiểm tra xem employee có trong project không
			string sql = "SELECT COUNT(*) FROM DuAnNhanVien";
			string soNhanVien = "SELECT SoNV_Da FROM tblDuAn";
			using (SqlCommand cmdSoNhanVien = new SqlCommand(soNhanVien, conn))
			{
				int currentEmployeeCount = (int)cmdSoNhanVien.ExecuteScalar();

				// Lấy số nhân viên tối đa cho dự án
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@ProjectID", projectID);
					cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

					int count = (int)cmd.ExecuteScalar();

					return count < currentEmployeeCount;
				}
			}

		}

		//Delete employee join project
		public void DeleteProjectAndEmployeeInProject(int projectId)
		{
			string sql = "DELETE FROM DuAnNhanVien WHERE Id_Da='" + projectId + "'";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//Get data in table DuAnNhanVien
		public DataTable getDataDuAnNhanVien(int Id_Da)
		{
			string sql = "SELECT tblNhanVien.Ho_Ten FROM tblNhanVien " +
						 "INNER JOIN DuAnNhanVien ON DuAnNhanVien.ID_NhanVien = tblNhanVien.ID_NhanVien " +
						 "WHERE DuAnNhanVien.Id_Da = @Id_Da";

			cmd = new SqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@Id_Da", Id_Da);

			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);
			return dt;
		}
		//Delete one employee in project
		public void DeleteOneEmployeeInProject(string employeeId)
		{
			string sql = "DELETE DuAnNhanVien FROM DuAnNhanVien " +
						 "INNER JOIN tblNhanVien ON DuAnNhanVien.ID_NhanVien = tblNhanVien.ID_NhanVien " +
						 "WHERE tblNhanVien.Ho_Ten = @employeeId";

			cmd = new SqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@employeeId", employeeId);

			cmd.ExecuteNonQuery();
			
		}

	}
}
