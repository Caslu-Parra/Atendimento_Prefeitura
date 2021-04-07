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

        public static bool cadastrar(Info info)
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            //try
            //{
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "INSERT INTO os (id, tecnico, data, solicitante, departamento, patrimonio, descricao, solucao) " +
                    " VALUES (" + info.Id + "," +
                     info.Tecnico + "," +
                     info.Data + "," +
                     info.Solicitante + "," +
                     info.Departamento + "," +
                     info.Patrimonio + "," +
                     info.Descricao + "," +
                     info.Solucao + ");";

                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                banco.Desconectar();
                // Se chegou até aqui é pq deu certo!
                // Retornar true:
                return false;
            //}
            //catch
            //{
            //    // Desconectar
            //    banco.Desconectar();
            //    // Se chegou aqui é pq deu algum erro!
            //    // Retornar false:
            //    return false;
            //}
        }
    }
}
