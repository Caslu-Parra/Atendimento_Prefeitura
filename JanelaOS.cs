using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class JanelaOS : Form
    {
        public JanelaOS()
        {
            InitializeComponent();
        }
        User user = new User();

        private void atualizaTabela()
        {
            dgvOSList.DataSource = db.Os_DAO.listar();
        }

        public void InfoUser(string nome)
        {
            user.Nome = nome;
        }

        private void JanelaOS_Load(object sender, EventArgs e)
        {
            atualizaTabela();
            dgvOSList.DefaultCellStyle.ForeColor = Color.Black;
            dgvOSList.DefaultCellStyle.BackColor = Color.AliceBlue;
            if (user.Nome == "Leandro")
            {

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaAddOS janelaAddOS = new TelaAddOS();
            janelaAddOS.InfoUser(user.Nome);
            janelaAddOS.ShowDialog();
            dgvOSList.DataSource = db.Os_DAO.listar();
            this.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }
    }
}
