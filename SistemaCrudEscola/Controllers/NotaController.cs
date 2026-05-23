using System;
using Microsoft.Data.SqlClient;
using EscolaBD.Data;
using EscolaBD.Models;

namespace EscolaBD.Controllers
{
    public class NotaController
    {
        //CREATE
        public void Inserir(Notas n)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"INSERT INTO Notas (AlunoId, Disciplina, Valor, Periodo)
				VALUES (@aid, @disc, @val, @per)", con);
            cmd.Parameters.AddWithValue("@aid", n.AlunoId);
            cmd.Parameters.AddWithValue("@disc", n.Disciplina);
            cmd.Parameters.AddWithValue("@val", n.Valor);
            cmd.Parameters.AddWithValue("@per", n.Periodo);
            cmd.ExecuteNonQuery();
        }

        //READ
        public List<Notas> ListarPorAluno(int alunoId)
        {
            var lista = new List<Notas>();
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
            @"SELECT n.*, a.Nome AS AlunoNome
                FROM Notas n
                INNER JOIN Alunos a ON a.Id = n.AlunoId
                WHERE n.AlunoId = @aid
                ORDER BY n.Disciplina", con);
            cmd.Parameters.AddWithValue("@aid", alunoId);
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
                lista.Add(new Notas
                {
                    Id = (int)dr["Id"],
                    AlunoId = (int)dr["AlunoId"],
                    AlunoNome = dr["AlunoNome"].ToString()!,
                    Disciplina = dr["Disciplina"].ToString()!,
                    Valor = (decimal)dr["Valor"],
                    Periodo = dr["Periodo"].ToString()!
                });
            return lista;
        }

        //UPDATE
        public void Atualizar(Notas n)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
            @"UPDATE Notas
            SET Disciplina=@disc, Valor=@val, Periodo=@per
            WHERE Id=@id", con);
                        cmd.Parameters.AddWithValue("@disc", n.Disciplina);
                        cmd.Parameters.AddWithValue("@val", n.Valor);
                        cmd.Parameters.AddWithValue("@per", n.Periodo);
                        cmd.Parameters.AddWithValue("@id", n.Id);
            
            cmd.ExecuteNonQuery();
        }

        //DELETE
        public void Excluir(int id)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
            "DELETE FROM Notas WHERE Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}