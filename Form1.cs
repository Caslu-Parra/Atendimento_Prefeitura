using System;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancia a classe User com o apelido de 'user'.
            User user = new User();

            // Atribuição ao atributos do obj com os valores do textBox;
            user.Senha = EasyEncryption.SHA.ComputeSHA256Hash(txbSenha.Text); // Encrypta o valor da senha com o hash 256.
            user.Nome = txbUser.Text;

            /* Se resultado da estrutura abaixo for verdadeira signifca que as credenciais são válidas,
            portanto, o acesso é permitido. */
            if (db.UsuarioDAO.logar(user).Controle)
            {
                this.Hide();
                // Instanciamos o obj JanelaOS e atribuimos valores a seu construtor.
                JanelaOS janelaOS = new JanelaOS(user.Nome, user.UserId);
                janelaOS.ShowDialog();
                this.Close();
            }
            else // Caso as credênciais sejam inválidas o acesso é negado, é uma mensagem é retornada.
            {
                MessageBox.Show("Usuário e/ou senha incorretos!");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
