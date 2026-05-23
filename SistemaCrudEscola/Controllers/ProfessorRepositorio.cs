using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using EscolaBD.Models; 
using EscolaBD.Data;   

namespace EscolaBD.Repositories
{
    public class ProfessorRepositorio
    {
        // 1. CREATE - Inserir
        public void Inserir(Professores p)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"INSERT INTO Professores (Nome, CPF, Email, Especialidade, Telefone, DataAdmissao, Ativo) 
                  VALUES (@nome, @cpf, @email, @esp, @tel, @data, @ativo)", con);

            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@cpf", p.CPF);
            cmd.Parameters.AddWithValue("@email", p.Email);
            cmd.Parameters.AddWithValue("@esp", p.Especialidade);
            cmd.Parameters.AddWithValue("@tel", p.Telefone);
            cmd.Parameters.AddWithValue("@data", p.DataAdmissao);
            cmd.Parameters.AddWithValue("@ativo", p.Ativo);

            cmd.ExecuteNonQuery();
        }

        // 2. READ - Listar
        public List<Professores> Listar()
        {
            var lista = new List<Professores>();
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand("SELECT * FROM Professores ORDER BY Nome", con);
            using var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Professores
                {
                    Id = (int)dr["Id"],
                    Nome = dr["Nome"].ToString()!,
                    CPF = dr["CPF"] != DBNull.Value ? dr["CPF"].ToString() : null,
                    Email = dr["Email"].ToString()!,
                    Especialidade = dr["Especialidade"].ToString()!,
                    Telefone = dr["Telefone"] != DBNull.Value ? dr["Telefone"].ToString() : null,
                    DataAdmissao = Convert.ToDateTime(dr["DataAdmissao"]),
                    Ativo = (bool)dr["Ativo"]
                });
            }
            return lista;
        }

        // 3. UPDATE - Atualizar
        public void Atualizar(Professores p)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"UPDATE Professores 
                  SET Nome=@nome, CPF=@cpf, Email=@email, Especialidade=@esp, Telefone=@tel, DataAdmissao=@data, Ativo=@ativo 
                  WHERE Id=@id", con);

            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@cpf", string.IsNullOrEmpty(p.CPF) ? DBNull.Value : p.CPF);
            cmd.Parameters.AddWithValue("@email", p.Email);
            cmd.Parameters.AddWithValue("@esp", p.Especialidade);
            cmd.Parameters.AddWithValue("@tel", string.IsNullOrEmpty(p.Telefone) ? DBNull.Value : p.Telefone);
            cmd.Parameters.AddWithValue("@data", p.DataAdmissao);
            cmd.Parameters.AddWithValue("@ativo", p.Ativo);
            cmd.Parameters.AddWithValue("@id", p.Id);

            cmd.ExecuteNonQuery();
        }

        // 4. DELETE - Excluir
        public void Excluir(int id)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand("DELETE FROM Professores WHERE Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
