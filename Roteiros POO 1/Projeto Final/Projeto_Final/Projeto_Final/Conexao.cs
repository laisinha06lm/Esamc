using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace Projeto_Final
{
    internal class Conexao
    {
        private readonly string connectionString;

        public Conexao()
        {
            string? senha = Environment.GetEnvironmentVariable("SUPERMARKET_DB_PASSWORD");

            if (string.IsNullOrWhiteSpace(senha))
            {
                throw new InvalidOperationException("A variável de ambiente 'SUPERMARKET_DB_PASSWORD' não está definida.");
            }
            connectionString = $"Host=localhost;Port=5432;Database=supermarket_db;Username=postgres;Password={senha}";
        }

        public NpgsqlConnection AbrirConexao()
        {
            NpgsqlConnection conexao = new NpgsqlConnection(connectionString);

            conexao.Open();

            return conexao;
        }

        public bool TestarConexao()
        {
            using (NpgsqlConnection conexao = AbrirConexao())
            {
                return conexao.State == System.Data.ConnectionState.Open;
            }
        }
    }
}
