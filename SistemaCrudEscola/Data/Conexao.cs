using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace SistemaCrudEscola.Data
{
    public class Conexao
    {
        public static string _conn =
            @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;";

        public static SqlConnection Abrir()
        {
        var con = new SqlConnection( _conn );
        con.Open();
        return con;
        }
    }
}
