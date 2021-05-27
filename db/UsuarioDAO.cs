using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Atendimento.db
{
    class UsuarioDAO
    {
        // Método de verificação de credênciais.
        public static User logar(User user)
        {
            // Instanciando a classe de conexão ao bando de dados.
            db.Banco banco = new db.Banco();

            // Cria uma variável do tipo tabela, e os valores serão manipulados abaixo.
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

                if (linha.Field<string>("nome") == user.Nome && linha.Field<string>("senha") == user.Senha)
                {
                    /* Se não houver erro quer dizer que já há alguma os com o ID informado, portanto,
                    o programa irá gerar outro ID válido que ainda não foi utilizado. */
                    User user2 = new User();
                    user.UserId = linha.Field<Int64>("userID").ToString();
                    user.Controle = true;
                    return user;
                }
                else
                {
                    user.Controle = false;
                    return user;
                }
            }
            catch
            {
                user.Controle = false;
                return user;
            }
        }

        // Método de cadastro de usuário.
        public static bool addUser(User user)
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();

            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();

                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "INSERT INTO 'main'.'usuarios'" +
                "('nome', 'senha') " +
                "VALUES (@nome, @senha);";

                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@nome", user.Nome);
                cmd.Parameters.AddWithValue("@senha", user.Senha);

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
        // Método de remover usuários.
        public static bool removeUser(User user)
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();

            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();

                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "DELETE FROM usuarios WHERE userID = @id;";

                cmd.Parameters.AddWithValue("@id", user.UserId);

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
        // Metodo de edição de usuários.
        public static bool editUser(User user)
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();

            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();

                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "UPDATE usuarios SET nome = @nome, senha = @senha WHERE userID = @id";

                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@nome", user.Nome);
                cmd.Parameters.AddWithValue("@senha", user.Senha);
                cmd.Parameters.AddWithValue("@id", user.UserId);
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
