using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Atendimento.db
{
    static class Os_DAO
    {
        public static DataTable listar()
        {
            // Instanciando a classe de conexão ao bando de dados.
            db.Banco banco = new db.Banco();

            // Cria uma tabela.
            DataTable tabela = new DataTable();

            // Conecta do Banco.
            banco.Conectar();

            // Variável de comandos SQL.
            var cmd = banco.conexao.CreateCommand();
            // Comando SQL à ser exectado.
            cmd.CommandText = "SELECT * FROM OS";
            // Executar e obter dadoas de uma consulta.
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
            // Preencher uma "tabela" com o resultado da consulta no banco armazenado em "da".
            da.Fill(tabela);
            // Desconecta do Banco.
            banco.Desconectar();
            return tabela;
        }
    }
}
