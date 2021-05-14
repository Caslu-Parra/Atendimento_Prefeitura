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

            User user = new User();
            user.Senha = EasyEncryption.SHA.ComputeSHA256Hash(txbSenha.Text);
            user.Nome = txbUser.Text;


            if (db.UsuarioDAO.logar(user).Controle)
            {
                this.Hide();
                JanelaOS janelaOS = new JanelaOS(user.Nome, user.UserId);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
