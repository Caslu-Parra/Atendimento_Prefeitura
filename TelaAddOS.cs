using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class TelaAddOS : Form
    {
        // Variáveis Globais:
        DateTime data;
        User user = new User();
        bool modoEdicao = false;
        string departamento;

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
                var dia = data.Day.ToString();
                var mes = data.Month.ToString();
                if (dia.Length == 1 && mes.Length == 1)
                {
                    return "0" + data.Day.ToString() + "/0" + data.Month.ToString() + '/' + data.Year.ToString();
                }
                else if (dia.Length == 1)
                {
                    return "0" + data.Day.ToString() + "/" + data.Month.ToString() + '/' + data.Year.ToString();
                }
                else if (mes.Length == 1)
                {
                    return data.Day.ToString() + "/0" + data.Month.ToString() + '/' + data.Year.ToString();
                }
                else
                {
                    return data.Day.ToString() + '/' + data.Month.ToString() + '/' + data.Year.ToString();
                }
            }
        }
        public TelaAddOS(string nome, string id, string dept)
        {
            InitializeComponent();

            user.UserId = id;
            user.Nome = nome;
            departamento = dept;
        }

        // Método de edição:
        public void modoEditar(string tecnico, string data, string id, string solicitante, string dept, string ramal, string horario, string descricao, string solucao, string patr, bool estado, bool edicao)
        {
            /// ENVIAR OS DADOS DE EDIÇÃO PARA A PAGINA DE EDIÇÃO.
            txbTecnico.Text = tecnico;
            txbID.Text = id;
            txbRamal.Text = ramal;
            txbPatrimonio.Text = patr;
            txbSolicitante.Text = solicitante;
            txbDescricao.Text = descricao;
            txbSolucao.Text = solucao;
            txbData.Text = data;
            txbHorario.Text = horario;
            modoEdicao = edicao;
            btnSalvar.Text = "Editar";
            btnCancelar.Visible = false;
            this.Text = "Editar Ordem de Serviço";
            cbFinalizado.Visible = true;
            cbFinalizado.Checked = estado;
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
            this.MaximizeBox = false;

            DataTable dadosTabela = db.Os_DAO.listar("dept", "");

            cbDept.DataSource = dadosTabela;
            cbDept.DisplayMember = "nomeDept";
            cbDept.ValueMember = "nomeDept";
            cbDept.SelectedValue = departamento;
            cbDept.Text = departamento;

            if (modoEdicao != true)
            {
                cbDept.Text = "Selecione a opção";
                cbDept.SelectedItem = null;
                txbID.Text = geraID();
                txbTecnico.Text = user.Nome;
                txbData.Text = Data("data");
                txbHorario.Text = Data("minuto");
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var departValue = cbDept.SelectedItem;
            Info info = new Info();

            if (departValue == null)
            {
                departValue = null;
            }
            var resultado = false;


            if (txbSolicitante.Text != "" && txbDescricao.Text != "" && txbSolicitante.Text != "" && departValue != null)
            {
                info.Tecnico = user.UserId;

                if (txbRamal.Text.Length < 4)
                {
                    info.Ramal = "NÃO TEM";
                }
                else if (txbRamal.Text.Length == 9)
                {
                    info.Ramal = txbRamal.Text.Insert(5, "-");
                }
                else
                {
                    info.Ramal = txbRamal.Text.Replace(" ", "-");
                }
                info.Data = txbData.Text;
                info.Horario = txbHorario.Text;
                info.Solicitante = txbSolicitante.Text.ToUpper();
                info.Departamento = cbDept.SelectedValue.ToString();
                info.Descricao = txbDescricao.Text;
                if (txbPatrimonio.Text.Length <= 6)
                {
                    info.Patrimonio = "NÃO TEM";
                }
                else
                {
                    info.Patrimonio = txbPatrimonio.Text;
                }
                info.Solucao = txbSolucao.Text;
                info.Id = txbID.Text;
                if (cbFinalizado.Checked)
                {
                    info.Estado = true;
                }
                else
                {
                    info.Estado = false;
                }
            }

            if (modoEdicao)
            {
                if (cbDept.SelectedValue.ToString() == "ADMINISTRACAO REGIONAL ARARETAMA")
                {
                    info.Departamento = " ";
                }
                // Passar os dados da ordem de serviço pro .editar e obter o resultado (true ou false):
                resultado = db.Os_DAO.editar(info);
            }
            else
            {
                // Passar os dados da ordem de serviço pro .cadastrar e obter o resultado (true ou false):
                resultado = db.Os_DAO.cadastrar(info);
            }

            if (resultado == true)
            {
                if (modoEdicao == false)
                {
                    MessageBox.Show("Ordem de serviço cadastrada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ordem de serviço editada com sucesso!");
                }
                this.Hide();

            }
            else
            {
                if (modoEdicao == false)
                {
                    txbID.Text = geraID();
                }
                MessageBox.Show("Erro! Verifique os dados informados!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txbID.Text = geraID();
            txbRamal.Text = null;
            txbPatrimonio.Text = null;
            txbSolicitante.Text = null;
            txbDescricao.Text = null;
            txbSolucao.Text = null;
            cbDept.Text = "Selecione a opção";
            cbDept.SelectedItem = null;
            txbData.Text = Data("data");
            txbHorario.Text = Data("minuto");
        }
    }
}
