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
public class ControllerLeitores
    {
        // CREATE
        public void Inserir(Leitores l)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"INSERT INTO Leitores (Nome, Email, Telefone, Turma, Ativo)
                  VALUES (@n, @e, @tel, @tur, @at)", con);

            cmd.Parameters.AddWithValue("@n", l.Nome);
            cmd.Parameters.AddWithValue("@e", l.Email);
            
            // Tratamento para campos opcionais (permitem nulo)
            cmd.Parameters.AddWithValue("@tel", l.Telefone ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@tur", l.Turma ?? (object)DBNull.Value);
            
            cmd.Parameters.AddWithValue("@at", l.Ativo);

            cmd.ExecuteNonQuery();
        }

        // READ
        public List<Leitores> Listar()
        {
            var lista = new List<Leitores>();
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand("SELECT * FROM Leitores ORDER BY Nome", con);
            using var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Leitores
                {
                    Id = (int)dr["Id"],
                    Nome = dr["Nome"].ToString()!,
                    Email = dr["Email"].ToString()!,
                    
                    // Verificação caso o valor esteja nulo na tabela
                    Telefone = dr["Telefone"] == DBNull.Value ? null : dr["Telefone"].ToString(),
                    Turma = dr["Turma"] == DBNull.Value ? null : dr["Turma"].ToString(),
                    
                    Ativo = (bool)dr["Ativo"]
                });
            }
            return lista;
        }

        // UPDATE
        public void Atualizar(Leitores l)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"UPDATE Leitores SET Nome=@n, Email=@e, Telefone=@tel, Turma=@tur, Ativo=@at
                  WHERE Id=@id", con);

            cmd.Parameters.AddWithValue("@n", l.Nome);
            cmd.Parameters.AddWithValue("@e", l.Email);
            
            // Tratamento caso os campos opcionais sejam alterados para nulo
            cmd.Parameters.AddWithValue("@tel", l.Telefone ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@tur", l.Turma ?? (object)DBNull.Value);
            
            cmd.Parameters.AddWithValue("@at", l.Ativo);
            cmd.Parameters.AddWithValue("@id", l.Id);

            cmd.ExecuteNonQuery();
        }

        // DELETE
        public void Excluir(int id)
        {
            using var con = Conexao.Abrir();
            var cmd = new SqlCommand(
                @"DELETE FROM Leitores
                  WHERE Id=@id", con);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
