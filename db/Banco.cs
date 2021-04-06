using System;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace Atendimento.db
{
    class Banco
    {
        // Obj de conexão SQL.
        public SQLiteConnection conexao;

        // Construtor de conexão.
        public Banco()
        {
            // Aponta onde está o arquivo ".sql".
            conexao = new SQLiteConnection("Data Source=C:/Users/Public/BDE-OS/banco.sqlite3");

            // Definir o caminho
            string caminho = "C:/Users/Public/BDE-OS";

            // Verificar se o arquivo banco.sqlite3 NÃO existe:
            if (!File.Exists(caminho + "/banco.sqlite3"))
            {
                // Criar a pasta no caminho
                Directory.CreateDirectory(caminho);

                // Criar o arquivo de banco de dados:
                SQLiteConnection.CreateFile(caminho + "/banco.sqlite3");

                // COMANDOS SQL PARA CRIAR A ESTRUTURA PADRÃO DO BANCO:
                // Será executado apenas na primeira vez que o código rodar:
                // Conectar com o banco:
                this.Conectar();
                var cmd = this.conexao.CreateCommand();
                // Comando SQL:
                cmd.CommandText = "CREATE TABLE 'os' (" +
                "'id'    TEXT NOT NULL UNIQUE, " +
                "'tecnico'   TEXT NOT NULL, " +
                "'solicitante'   TEXT NOT NULL, " +
                "'setor' TEXT NOT NULL, " +
                "'data'  TEXT NOT NULL, " +
                "'descricao' TEXT NOT NULL, " +
                "'solucao'   TEXT " +
                "PRIMARY KEY('id'));";

                // Executar o comando:
                cmd.ExecuteNonQuery();
                // Desconectar:
                this.Desconectar();
            }
        }


        // Classe para conectar.
        public void Conectar()
        {
            // Se conexão não estiver Open irá conectar, caso contrário não irá.
            if (conexao.State != ConnectionState.Open)
            {
                conexao.Open();
            }
        }


        // Classe para desconectar.
        public void Desconectar()
        {
            // Se conexão estiver Open irá desconectar.
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
