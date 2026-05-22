using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using SistemaCrudEscola.Data;
using SistemaCrudEscola.Models;

namespace SistemaCrudEscola.Repositories
{
    public class AlunoRepositorio
    {
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

        public List<Aluno> Listar()
        {
            var Lista = new List<Aluno>();
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand("SELECT * FROM Alunos ORDER BY Nome", con);
            using var dr = cmd.ExecuteReader();
            while (dr.Read()) lista.Add(new Aluno { Id=(int)dr["Id"], Nome=dr["Nome"].ToString()!});
        }
    }
}