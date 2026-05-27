using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Biblioteca_Crud.Data
{
    public class Conexao
    {
        private static string _conn =
            @"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=BibliotecaDB;
            Integrated Security=True;";

        public static SqlConnection Abrir()
        {
            var con = new SqlConnection(_conn);
            con.Open();
            return con;
        }
    }
}
