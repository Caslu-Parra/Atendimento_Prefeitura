using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            JanelaOS janelaOS = new JanelaOS();

            User user = new User();
            user.Senha = EasyEncryption.SHA.ComputeSHA256Hash(txbSenha.Text);
            user.Nome = txbUser.Text;

            if (db.UsuarioDAO.logar(user))
            {
                this.Hide();
                janelaOS.InfoUser(user.Nome);
                janelaOS.ShowDialog();
                txbSenha.Text = "";
                txbUser.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos!");
            }
            
        }
    }
}
