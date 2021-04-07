using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class TelaAddOS : Form
    {
        DateTime data;
        public TelaAddOS()
        {
            InitializeComponent();
        }

        public static string letraRamdom(int tamanho)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        public static string numRamdom(int min, int max)
        {
            Random rdn = new Random();
            return rdn.Next(min, max).ToString();
        }

        public static string geraID()
        {
            var id = letraRamdom(1) + numRamdom(0, 9) + letraRamdom(1) + numRamdom(0, 9);
            return id;
        }

        private void TelaAddOS_Load(object sender, EventArgs e)
        {
            data = DateTime.Now;
            txbID.Text = geraID();
            txbTecnico.Text = "Lucas Parra";
            txbData.Text = data.Day.ToString() + '/' + data.Month.ToString() + '/' + data.Year.ToString() 
            + ' ' + data.Hour + ':' + data.Minute;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Tecnico = txbTecnico.Text;
            info.Data = txbData.Text;
            info.Departamento = cbDept.SelectedIndex;
            info.Descricao = txbDescricao.Text;
            info.Patrimonio = txbPatrimonio.Text;
            info.Solucao = txbSolucao.Text;
            info.Id = txbID.Text;
            // Passar o funcionário pro .cadastrar e obter o resultado (true ou false):
            var resultado = db.Os_DAO.cadastrar(info);
            if (resultado == true)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                // Limpar os campos do formulário:
                this.Close();
                JanelaOS janelaOS = new JanelaOS();
                janelaOS.ShowDialog();

            }
            else
            {
                MessageBox.Show("Erro! Verifique os dados informados!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txbRamal.Text = null;
            txbPatrimonio.Text = null;
            txbSolicitante.Text = null;
            txbPatrimonio.Text = null;
            txbDescricao.Text = null;
            txbSolucao.Text = null;
            cbDept.Text = "Selecione a opção";
            cbDept.SelectedItem = null;
            txbData.Text = null;
            txbData.Text = data.Day.ToString() + '/' + data.Month.ToString() + '/' + data.Year.ToString()
            + ' ' + data.Hour + ':' + data.Minute;
        }
    }
}
