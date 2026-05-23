using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using EscolaBD.Data;
using EscolaBD.Models;

namespace EscolaBD.Controllers
{
    public class AlunoController
    {
        // CREATE
        public void Inserir(Aluno a)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"INSERT INTO Alunos (Nome, Email, DataNascimento, Turma)
                  VALUES (@n, @e, @d, @t)", con);
            cmd.Parameters.AddWithValue("@n", a.Nome);
            cmd.Parameters.AddWithValue("@e", a.Email);
            cmd.Parameters.AddWithValue("@d", a.DataNascimento);
            cmd.Parameters.AddWithValue("@t", a.Turma);
            cmd.ExecuteNonQuery();
        }

        // READ
        public List<Aluno> Listar()
        {
            var lista = new List<Aluno>();
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand("SELECT * FROM Alunos ORDER BY Nome", con);
            using var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Aluno
                {
                    Id = (int)dr["Id"],
                    Nome = dr["Nome"].ToString()!,
                    Email = dr["Email"].ToString()!,
                    DataNascimento = (DateTime)dr["DataNascimento"],
                    Turma = dr["Turma"].ToString()!
                });
            }
            return lista;
        }

        // UPDATE
        public void Atualizar(Aluno a)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"UPDATE Alunos SET Nome=@n, Email=@e, DataNascimento=@d, Turma=@t
                  WHERE Id=@id", con);
            cmd.Parameters.AddWithValue("@n", a.Nome);
            cmd.Parameters.AddWithValue("@e", a.Email);
            cmd.Parameters.AddWithValue("@d", a.DataNascimento);
            cmd.Parameters.AddWithValue("@t", a.Turma);
            cmd.Parameters.AddWithValue("@id", a.Id);
            cmd.ExecuteNonQuery();
        }

        // DELETE
        public void Excluir(int id)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"DELETE FROM Alunos
                  WHERE Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
