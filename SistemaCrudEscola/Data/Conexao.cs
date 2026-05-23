using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace EscolaBD.Data
{
    public class Conexao
    {
        private static string _conn =
            @"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=ESCOLA_BD;
            Integrated Security=True;";

        public static SqlConnection Abrir()
        {
            var con = new SqlConnection(_conn);
            con.Open();
            return con;
        }
    }
}
