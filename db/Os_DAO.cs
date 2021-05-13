using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace Atendimento.db
{
    static class Os_DAO
    {
        public static DataTable listar(string filtro, string campoTxb)
        {
            // Instanciando a classe de conexão ao bando de dados.
            db.Banco banco = new db.Banco();

            // Cria uma tabela.
            DataTable tabela = new DataTable();

            // Conecta do Banco.
            banco.Conectar();
            // Variável de comandos SQL.
            var cmd = banco.conexao.CreateCommand();
            if (filtro == "*" && campoTxb == "")
            {
                // Comando SQL à ser exectado.
                cmd.CommandText = "SELECT * FROM OS";
            }
            else
            {
                // Comando SQL à ser exectado.
                cmd.CommandText = "SELECT * FROM OS WHERE " + filtro + " = '" + campoTxb + "';";
            }
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

            // Variável Flag de controle.
            bool busca = false;
            try
            {
                DataTable query = new DataTable();
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DQL será executado:
                cmd.CommandText = "SELECT * FROM os WHERE id == '" + info.Id + "';";
                // Executar e "atribuir" o resultado em um objeto SQLiteDA
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
                // Definir qual "tabela" será preenchida com o resultado da consulta:
                da.Fill(query);
                // Desconectar:
                banco.Desconectar();
                var linha = query.Rows[0];

                /* Se não houver erro quer dizer que já há alguma os com o ID informado, portanto,
                o programa irá gerar outro ID válido que ainda não foi utilizado. */
                busca = true;
            }
            catch
            {
                busca = false;
            }

            if (busca == false)
            {
                try
                {
                    banco.Conectar();
                    // Criar o objeto SQLiteCommand:
                    var cmd = banco.conexao.CreateCommand();

                    // Definir qual comando DML (Insert - Delete - Update) será executado:
                    cmd.CommandText = "INSERT INTO os (id, estado, tecnico, data, horario, solicitante, ramal, departamento, patrimonio, descricao, solucao) values (@id, @estado, @tecnico, @data, @horario,@solicitante, @ramal, @departamento, @patrimonio, @descricao, @solucao)";

                    // Definir a substituição dos parametros:
                    cmd.Parameters.AddWithValue("@id", info.Id);
                    cmd.Parameters.AddWithValue("@estado", "Não finalizado");
                    cmd.Parameters.AddWithValue("@tecnico", info.Tecnico);
                    cmd.Parameters.AddWithValue("@data", info.Data);
                    cmd.Parameters.AddWithValue("@horario", info.Horario);
                    cmd.Parameters.AddWithValue("@solicitante", info.Solicitante);
                    cmd.Parameters.AddWithValue("@ramal", info.Ramal);
                    cmd.Parameters.AddWithValue("@departamento", info.Departamento);
                    cmd.Parameters.AddWithValue("@patrimonio", info.Patrimonio);
                    cmd.Parameters.AddWithValue("@descricao", info.Descricao);
                    cmd.Parameters.AddWithValue("@solucao", info.Solucao);

                    // Executar:
                    cmd.ExecuteNonQuery();
                    // Desconectar
                    banco.Desconectar();
                    // Se chegou até aqui é pq deu certo!
                    return true;
                }
                catch
                {
                    // Desconectar
                    banco.Desconectar();
                    // Se chegou aqui é pq deu algum erro!
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static bool editar(Info info) {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            try
            {
                var estado = "";
                if (info.Estado)
                {
                    estado = "Finalizado";
                }
                else
                {
                    estado = "Não finalizado";
                }

                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();

                MessageBox.Show(info.Id.ToString());

                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "UPDATE os SET estado = @estado, tecnico = @tecnico, data = @data, horario = @horario, solicitante = @solicitante, ramal = @ramal, departamento = @departamento, patrimonio = @patrimonio, descricao = @descricao, solucao = @solucao WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", info.Id);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@tecnico", info.Tecnico);
                cmd.Parameters.AddWithValue("@data", info.Data);
                cmd.Parameters.AddWithValue("@horario", info.Horario);
                cmd.Parameters.AddWithValue("@solicitante", info.Solicitante);
                cmd.Parameters.AddWithValue("@ramal", info.Ramal);
                cmd.Parameters.AddWithValue("@departamento", info.Departamento);
                cmd.Parameters.AddWithValue("@patrimonio", info.Patrimonio);
                cmd.Parameters.AddWithValue("@descricao", info.Descricao);
                cmd.Parameters.AddWithValue("@solucao", info.Solucao);

                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                banco.Desconectar();
                // Se chegou até aqui é pq deu certo!
                return true;
            }
            catch
            {
                // Desconectar
                banco.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                return false;
            }
        }
    }
}
