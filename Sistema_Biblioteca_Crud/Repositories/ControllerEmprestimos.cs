using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Sistema_Biblioteca_Crud.Data;
using Sistema_Biblioteca_Crud.Models;

namespace Sistema_Biblioteca_Crud.Repositories
{
    public class ControllerEmprestimo
    {
        
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

            
            var cmdEstoque = new SqlCommand(
                "UPDATE Livros SET Quantidade = Quantidade - 1 WHERE Id = @livro", con);
            cmdEstoque.Parameters.AddWithValue("@livro", e.LivroId);
            cmdEstoque.ExecuteNonQuery();
        }

        
        public List<Emprestimos> Listar()
        {
            var lista = new List<Emprestimos>();
            using var con = Conexao.Abrir();
            
            
            var cmd = new SqlCommand(
                @"SELECT emp.*, lei.Nome AS NomeLeitor, liv.Titulo AS TituloLivro 
                  FROM Emprestimos emp
                  INNER JOIN Leitores lei ON emp.LeitorId = lei.Id
                  INNER JOIN Livros liv ON emp.LivroId = liv.Id
                  ORDER BY emp.DataEmprestimo DESC", con);
                  
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
                    Devolvido = (bool)dr["Devolvido"],
                    
                    
                    NomeLeitor = dr["NomeLeitor"].ToString()!,
                    TituloLivro = dr["TituloLivro"].ToString()!
                });
            }
            return lista;
        }

        public List<Emprestimos> ListarPorLeitor(int idLeitor)
        {
            var lista = new List<Emprestimos>();
            using var con = Conexao.Abrir();
    
            var cmd = new SqlCommand(
                @"SELECT emp.*, lei.Nome AS NomeLeitor, liv.Titulo AS TituloLivro 
                  FROM Emprestimos emp
                  INNER JOIN Leitores lei ON emp.LeitorId = lei.Id
                  INNER JOIN Livros liv ON emp.LivroId = liv.Id
                  WHERE emp.LeitorId = @idLeitor
                  ORDER BY emp.DataEmprestimo DESC", con);

            cmd.Parameters.AddWithValue("@idLeitor", idLeitor);
          
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
                    Devolvido = (bool)dr["Devolvido"],
            
                    NomeLeitor = dr["NomeLeitor"].ToString()!,
                    TituloLivro = dr["TituloLivro"].ToString()!
                });
            }
            return lista;
        }

        
        public void Atualizar(Emprestimos e)
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

        
        public void Devolver(int id)
        {
            using var con = Conexao.Abrir();

            
            var cmd = new SqlCommand(
                "UPDATE Emprestimos SET Devolvido = 1 WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            
            var cmdEstoque = new SqlCommand(
                @"UPDATE Livros SET Quantidade = Quantidade + 1 
                  WHERE Id = (SELECT LivroId FROM Emprestimos WHERE Id = @id)", con);
            cmdEstoque.Parameters.AddWithValue("@id", id);
            cmdEstoque.ExecuteNonQuery();
        }

        
        public void Excluir(int id)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"DELETE FROM Emprestimos WHERE Id=@id", con);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}