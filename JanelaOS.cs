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
            dgvOSList.DataSource = db.Os_DAO.listar("*","");
        }

        public void InfoUser(string nome)
        {
            user.Nome = nome;
        }

        private string SelectedIndex()
        {
            if (rBtnData.Checked)
            {
                return "data";
            }
            else if (rBtnID.Checked)
            {
                return "id";
            }
            else if (rBtnTecnico.Checked)
            {
                return "tecnico";
            }
            else if (rBtnSolicitante.Checked)
            {
                return "solicitante";
            }
            else if (rBtnPatrimonio.Checked)
            {
                return "patrimonio";
            }
            else
            {
                return "Informe um parametro válido";  
            }
        }

        private void JanelaOS_Load(object sender, EventArgs e)
        {
            atualizaTabela();
            dgvOSList.DefaultCellStyle.ForeColor = Color.Black;
            dgvOSList.DefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaAddOS janelaAddOS = new TelaAddOS();
            janelaAddOS.InfoUser(user.Nome);
            janelaAddOS.ShowDialog();
            dgvOSList.DataSource = db.Os_DAO.listar("*", "");
            this.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvOSList.DataSource = db.Os_DAO.listar(SelectedIndex(), textBox1.Text);
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            dgvOSList.DataSource = db.Os_DAO.listar("*", "");
        }
    }
}
