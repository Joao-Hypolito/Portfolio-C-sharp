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
public class ControllerLivros
    {
        // CREATE
        public void Inserir(Livros l)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"INSERT INTO Livros (Titulo, Autor, ISBN, Categoria, Quantidade, Ativo)
                  VALUES (@t, @a, @i, @c, @q, @at)", con);
            
            cmd.Parameters.AddWithValue("@t", l.Titulo);
            cmd.Parameters.AddWithValue("@a", l.Autor);      
            cmd.Parameters.AddWithValue("@i", l.ISBN ?? (object)DBNull.Value);   
            cmd.Parameters.AddWithValue("@c", l.Categoria);
            cmd.Parameters.AddWithValue("@q", l.Quantidade);
            cmd.Parameters.AddWithValue("@at", l.Ativo);
            
            cmd.ExecuteNonQuery();
        }

        // READ - FILTRAR POR UM LIVRO ESPECÍFICO
        public List<Livros> ListarPorLivro(int id)
        {
            var lista = new List<Livros>();
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand("SELECT * FROM Livros WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            using var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Livros
                {
                    Id = (int)dr["Id"],
                    Titulo = dr["Titulo"].ToString()!,
                    Autor = dr["Autor"].ToString()!,
                    ISBN = dr["ISBN"] == DBNull.Value ? null : dr["ISBN"].ToString(),
                    Categoria = dr["Categoria"].ToString()!,
                    Quantidade = (int)dr["Quantidade"],
                    Ativo = (bool)dr["Ativo"]
                });
            }
            return lista;
        }

        // READ
        public List<Livros> Listar()
        {
            var lista = new List<Livros>();
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand("SELECT * FROM Livros ORDER BY Titulo", con);
            using var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Livros
                {
                    Id = (int)dr["Id"],
                    Titulo = dr["Titulo"].ToString()!,
                    Autor = dr["Autor"].ToString()!,
                    ISBN = dr["ISBN"] == DBNull.Value ? null : dr["ISBN"].ToString(),
                    Categoria = dr["Categoria"].ToString()!,
                    Quantidade = (int)dr["Quantidade"],
                    Ativo = (bool)dr["Ativo"]
                });
            }
            return lista;
        }

        // UPDATE
        public void Atuaisar(Livros l)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"UPDATE Livros SET Titulo=@t, Autor=@a, ISBN=@i, Categoria=@c, Quantidade=@q, Ativo=@at
                  WHERE Id=@id", con);
            
            cmd.Parameters.AddWithValue("@t", l.Titulo);
            cmd.Parameters.AddWithValue("@a", l.Autor);
            cmd.Parameters.AddWithValue("@i", l.ISBN ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@c", l.Categoria);
            cmd.Parameters.AddWithValue("@q", l.Quantidade);
            cmd.Parameters.AddWithValue("@at", l.Ativo);
            cmd.Parameters.AddWithValue("@id", l.Id);
            
            cmd.ExecuteNonQuery();
        }

        // DELETE
        public void Excluir(int id)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"DELETE FROM Livros
                  WHERE Id=@id", con);      
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
