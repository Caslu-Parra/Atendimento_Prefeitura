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

        public string Data(string opcao)
        {
            data = DateTime.Now;
            if (opcao == "minuto")
            {
                var minuto = data.Minute.ToString();

                if (minuto.Length == 1)
                {
                   return data.Hour + ":0" + data.Minute;
                }
                else
                {
                    return data.Hour + ":" + data.Minute;
                }
            }
            else
            {
                return data.Day.ToString() + '/' + data.Month.ToString() + '/' + data.Year.ToString();
            }
        }
        public TelaAddOS()
        {
            InitializeComponent();
        }
        User user = new User();

        public void InfoUser(string nome)
        {
            user.Nome = nome;
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
            txbID.Text = geraID();
            txbTecnico.Text = user.Nome;
            txbData.Text = Data("data");
            txbHorario.Text = Data("minuto");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var departValue = cbDept.SelectedItem;

            if (departValue == null)
            {
                departValue = null;
            }
            var resultado = false;
            if (txbSolicitante.Text != "" && txbDescricao.Text != "" && txbSolicitante.Text != "" && departValue != null && txbRamal.Text.Length != 6)
            {
                Info info = new Info();
                info.Tecnico = txbTecnico.Text.ToUpper();
                info.Ramal = txbRamal.Text;
                info.Data = txbData.Text;
                info.Horario = txbHorario.Text;
                info.Solicitante = txbSolicitante.Text.ToUpper();
                info.Departamento = cbDept.SelectedItem.ToString().ToUpper();
                info.Descricao = txbDescricao.Text;
                info.Patrimonio = txbPatrimonio.Text;
                info.Solucao = txbSolucao.Text;
                info.Id = txbID.Text;


                // Passar o funcionário pro .cadastrar e obter o resultado (true ou false):
                resultado = db.Os_DAO.cadastrar(info);
            }

            if (resultado == true)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!");
            }
            else
            {
                txbID.Text = geraID();
                MessageBox.Show("Erro! Verifique os dados informados!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txbID.Text = geraID();
            txbRamal.Text = null;
            txbPatrimonio.Text = null;
            txbSolicitante.Text = null;
            txbPatrimonio.Text = null;
            txbDescricao.Text = null;
            txbSolucao.Text = null;
            cbDept.Text = "Selecione a opção";
            cbDept.SelectedItem = null;
            txbData.Text = Data("data");
            txbHorario.Text = Data("minuto");
        }
    }
}
