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
        // Instanciar o obj User com o apelido de 'user'.
        User user = new User();

        // Contrutor da classe JanelaOS;
        public JanelaOS(string nome, string id)
        {
            InitializeComponent();
            // Iniciamos atribuindo valor aos atributos através dos parametros passados pelo construtor.
            user.UserId = id;
            user.Nome = nome;
        }

        // Método que atualiza os dados da tabela.
        private void atualizaTabela(string filtro, string campoTxb)
        {
            dgvOSList.DataSource = db.Os_DAO.listar(filtro, campoTxb);
        }

        // Método que verifica qual o campo de filtro está selecionado;
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
            else if (rBtnDepartamento.Checked)
            {
                return "departamento";
            }
            else
            {
                return "Informe um parametro válido";
            }
        }

        private void JanelaOS_Load(object sender, EventArgs e)
        {
            atualizaTabela("os",""); // Preenche a tabela assim que a tela for carregada.
            // Define estilo para as linhas da tabela.
            dgvOSList.DefaultCellStyle.ForeColor = Color.Black;
            dgvOSList.DefaultCellStyle.BackColor = Color.AliceBlue;
        }
        
        // Método que invoca a janela de adicionar Ordem de Serviço.
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Instanciamos o obj JanelaAddOS e passamos valores a seu construtor.
            TelaAddOS janelaAddOS = new TelaAddOS(user.Nome, user.UserId);
            janelaAddOS.ShowDialog();
            atualizaTabela("os", "");
            this.Show();

        }

        // Método que limpa/recarrega os filtros de busca da tabela.
        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            txbPesquisa.Text = "";
            atualizaTabela("os", "");
        }

        // Método de busca de acordo com os filtros estabelecidos.
        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            atualizaTabela(SelectedIndex(), txbPesquisa.Text.ToUpper());
        }

        // Método que seleciona uma ordem específica e aciona o modo de edição.
        private void dgvOSList_SelectionChanged(object sender, EventArgs e)
        {
            // Garantir que a pessoa selecionou alguma linha:
            var dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            Info info = new Info();

            if (contLinhas > 0)
            {
                // Declarar um DataTable para obter a resposta de um consulta:
                DataTable dt = new DataTable();

                // Obter o id do usuário selecionado:
                var id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                // Buscar o usuário com base no ID:
                // Obter o resultado da consulta no nosso datatable local:
                dt = db.Os_DAO.listar("id", id);
                // obter linha 0:
                var linha = dt.Rows[0];

                var solucao = linha.Field<string>("solucao");
                if (solucao == null) {
                    solucao = "";
                } 

                // Atribuicao dos campos da Ordem para os atribuitos do obj 'info'.
                info.Tecnico = linha.Field<string>("tecnico").ToString();
                info.Ramal = linha.Field<string>("ramal").ToString();
                info.Data = linha.Field<string>("data").ToString();
                info.Horario = linha.Field<string>("horario").ToString();
                info.Solicitante = linha.Field<string>("solicitante").ToString();
                info.Departamento = linha.Field<string>("departamento").ToString();
                info.Descricao = linha.Field<string>("descricao").ToString();
                info.Patrimonio = linha.Field<string>("patrimonio").ToString();
                info.Solucao = solucao;
                info.Id = linha.Field<string>("id").ToString();

                if (linha.Field<string>("estado") == "Finalizado") {
                    info.Estado = true;
                }

                // ENVIA OS DADOS DE EDIÇÃO PARA A PAGINA DE EDIÇÃO.
                TelaAddOS editar = new TelaAddOS(user.Nome, user.UserId);
                editar.modoEditar(info.Tecnico, info.Data, info.Id, info.Solicitante, info.Departamento, info.Ramal, info.Horario, info.Descricao, info.Solucao, info.Patrimonio, info.Estado, true);
                this.Hide();
                editar.ShowDialog();
                atualizaTabela("os", "");
                this.Show();
            }
        }

        // Método que aciona a página de usuários;
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            TelaUsuario janelaUser = new TelaUsuario();

            // Verificação de permissões.
            if (user.UserId == "0")
            {
                this.Hide();
                janelaUser.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar, contate o administrador!");
            }
            
        }
    }
}
