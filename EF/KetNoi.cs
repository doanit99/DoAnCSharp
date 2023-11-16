using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class KetNoi
	{
		string sqlConmect;
		public KetNoi() {
			sqlConmect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString();
		}

		public SqlConnection GetConnect()
		{
			SqlConnection conn = new SqlConnection(sqlConmect);
			return conn;
		}
	}
}
