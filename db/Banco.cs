using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Atendimento.db
{
    class Banco
    {
        // Obj de conexão SQL.
        public SQLiteConnection conexao;

        // Construtor de conexão.
        public Banco()
        {
            string ip = "10.0.1.230";
            // Aponta onde está o arquivo ".sql".
            conexao = new SQLiteConnection(@"Data Source=\\" + ip + @"\Arquivos\Programas\Ordem de Servico\Banco de Dados\banco.sqlite3", true);

            // Definir o caminho
            //string caminho = "C:/Users/Public/BDE-OS/";
            string caminho = @"\\"+ ip + @"\Arquivos\Programas\Ordem de Servico\Banco de Dados";

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
                for (var i = 1; i <= 3; i++)
                {
                    if (i == 1)
                    {
                        var cmd = this.conexao.CreateCommand();
                        // Comando SQL:
                        cmd.CommandText = "CREATE TABLE 'os' (" +
                        "id" + "  TEXT NOT NULL," +
                        "estado" + "   TEXT NOT NULL," +
                        "tecnico" + "   TEXT NOT NULL," +
                        "data" + "  TEXT NOT NULL," +
                        "horario" + "   TEXT NOT NULL," +
                        "solicitante" + "   TEXT NOT NULL," +
                        "ramal" + "  TEXT," +
                        "departamento" + "   TEXT NOT NULL," +
                        "patrimonio" + "   TEXT," +
                        "descricao" + "   TEXT NOT NULL," +
                        "solucao" + "  TEXT," +
                        "PRIMARY KEY('id')," +
                        "FOREIGN KEY('tecnico') REFERENCES 'usuarios'('id'));";
                        // Executar o comando:
                        cmd.ExecuteNonQuery();
                    }
                    else if (i == 2)
                    {
                        var cmd = this.conexao.CreateCommand();
                        cmd.CommandText = "CREATE TABLE " + "usuarios" + "(" +
                        "nome" + " TEXT NOT NULL UNIQUE," +
                        "senha" + " TEXT NOT NULL," +
                        "userID" + "  INTEGER NOT NULL," +
                        "PRIMARY KEY('userID' AUTOINCREMENT));";

                        // Executar o comando:
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        var cmd = this.conexao.CreateCommand();
                        cmd.CommandText = "CREATE TABLE " + "departamentos" + "(" +
                        "idDept" + " INTEGER NOT NULL," +
                        "nomeDept" + " TEXT NOT NULL," +
                        "PRIMARY KEY('idDept' AUTOINCREMENT));";

                        // Executar o comando:
                        cmd.ExecuteNonQuery();
                    }
                }
                // Desconectar:
                this.Desconectar();
            }

        }


        // Método para conectar.
        public void Conectar()
        {
            // Se conexão não estiver Open irá conectar, caso contrário não irá.
            if (conexao.State != ConnectionState.Open)
            {
                conexao.Open();
            }
        }


        // Método para desconectar.
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
