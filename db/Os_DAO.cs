﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

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
            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();

                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "INSERT INTO os (id, tecnico, data, solicitante, departamento, patrimonio, descricao, solucao) values (@id, @tecnico, @data, @solicitante, @departamento, @patrimonio, @descricao, @solucao)";

                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@id", info.Id);
                cmd.Parameters.AddWithValue("@tecnico", info.Tecnico);
                cmd.Parameters.AddWithValue("@data", info.Data);
                cmd.Parameters.AddWithValue("@solicitante", info.Solicitante);
                cmd.Parameters.AddWithValue("@departamento", info.Departamento);
                cmd.Parameters.AddWithValue("@patrimonio", info.Patrimonio);
                cmd.Parameters.AddWithValue("@descricao", info.Descricao);
                cmd.Parameters.AddWithValue("@solucao", info.Solucao);

                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                banco.Desconectar();
                // Se chegou até aqui é pq deu certo!
                // Retornar true:

                return true;
            }
            catch
            {
                // Desconectar
                banco.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                // Retornar false:
                return false;
            }

        }
    }
}
