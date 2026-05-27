using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Sistema_Biblioteca_Crud.Data;
using Sistema_Biblioteca_Crud.Models;

namespace Sistema_Biblioteca_Crud.Repositories
{
public class ControllerEmprestimo
    {
        // CREATE
        public void Inserir(Emprestimos e)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"INSERT INTO Emprestimos (LeitorId, LivroId, DataEmprestimo, DataDevolucao, Devolvido)
                  VALUES (@leitor, @livro, @dataEmp, @dataDev, @dev)", con);

            cmd.Parameters.AddWithValue("@leitor", e.LeitorId);
            cmd.Parameters.AddWithValue("@livro", e.LivroId);
            cmd.Parameters.AddWithValue("@dataEmp", e.DataEmprestimo);
            cmd.Parameters.AddWithValue("@dataDev", e.DataDevolucao);
            cmd.Parameters.AddWithValue("@dev", e.Devolvido);

            cmd.ExecuteNonQuery();
        }

        // READ
        public List<Emprestimos> Listar()
        {
            var lista = new List<Emprestimos>();
            using var con = Conexao.Abrir();
            // Ordenado pela data de empréstimo mais recente
            var cmd = new SqlCommand("SELECT * FROM Emprestimos ORDER BY DataEmprestimo DESC", con);
            using var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Emprestimos
                {
                    Id = (int)dr["Id"],
                    LeitorId = (int)dr["LeitorId"],
                    LivroId = (int)dr["LivroId"],
                    DataEmprestimo = (DateTime)dr["DataEmprestimo"],
                    DataDevolucao = (DateTime)dr["DataDevolucao"],
                    Devolvido = (bool)dr["Devolvido"]
                });
            }
            return lista;
        }

        // UPDATE
        public void Ultualizar(Emprestimos e)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"UPDATE Emprestimos SET LeitorId=@leitor, LivroId=@livro, DataEmprestimo=@dataEmp, DataDevolucao=@dataDev, Devolvido=@dev
                  WHERE Id=@id", con);

            cmd.Parameters.AddWithValue("@leitor", e.LeitorId);
            cmd.Parameters.AddWithValue("@livro", e.LivroId);
            cmd.Parameters.AddWithValue("@dataEmp", e.DataEmprestimo);
            cmd.Parameters.AddWithValue("@dataDev", e.DataDevolucao);
            cmd.Parameters.AddWithValue("@dev", e.Devolvido);
            cmd.Parameters.AddWithValue("@id", e.Id);

            cmd.ExecuteNonQuery();
        }

        // DELETE
        public void Excluir(int id)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"DELETE FROM Emprestimos
                  WHERE Id=@id", con);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
