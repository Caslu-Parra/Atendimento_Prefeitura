using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace Atendimento.db
{
    class UsuarioDAO
    {
        public static bool logar(User user)
        {
            // Instanciando a classe de conexão ao bando de dados.
            db.Banco banco = new db.Banco();

            // Cria uma tabela.
            DataTable tabela = new DataTable();

            try
            {
                DataTable query = new DataTable();
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DQL será executado:
                cmd.CommandText = "SELECT * FROM usuarios WHERE nome = '" + user.Nome + "';";
                // Executar e "atribuir" o resultado em um objeto SQLiteDA
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
                // Definir qual "tabela" será preenchida com o resultado da consulta:
                da.Fill(query);
                // Desconectar:
                banco.Desconectar();

                var linha = query.Rows[0];

                //MessageBox.Show("Nome = "+ linha.Field<string>("nome")+ " Senha= "+ linha.Field<string>("senha"));
                if (linha.Field<string>("nome") == user.Nome && linha.Field<string>("senha") == user.Senha)
                {
                    /* Se não houver erro quer dizer que já há alguma os com o ID informado, portanto,
                    o programa irá gerar outro ID válido que ainda não foi utilizado. */
                    User user2 = new User();
                    user.UserId = linha.Field<Int64>("userID").ToString();
                    return true;
                }
                else
                {
                    return false;
                }
        }
            catch
            {
                return false;
            }
        }
}
}
