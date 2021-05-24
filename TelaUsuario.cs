using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class TelaUsuario : Form
    {
        string id = "";
        public TelaUsuario()
        {
            InitializeComponent();
        }
        private void atualizaTabela()
        {
            dgvUsuario.DataSource = db.Os_DAO.listar("usuarios", " ");
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            atualizaTabela();
        }

        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            var dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;

            if (contLinhas > 0)
            {
                // Declarar um DataTable para obter a resposta de um consulta:
                DataTable dt = new DataTable();

                // Obter o id do usuário selecionado:
                id = dgv.SelectedRows[0].Cells[0].Value.ToString();

                // Buscar o usuário com base no ID:
                // Obter o resultado da consulta no nosso datatable local:
                dt = db.Os_DAO.listar("usuarios", id);
                // obter linha 0:
                var linha = dt.Rows[0];

                gbUsuario.Text = "UserID - " + id;
                txbNome.Text = linha.Field<string>("nome").ToString();
            }



        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (txbNome.Text.Length > 2 && txbSenha.Text != "")
            {
                user.Nome = txbNome.Text;
                user.Senha = EasyEncryption.SHA.ComputeSHA256Hash(txbSenha.Text);

                bool resposta = db.UsuarioDAO.addUser(user);

                if (resposta)
                {
                    atualizaTabela();
                    btnLimpar_Click("", e);
                }
                else
                {
                    MessageBox.Show("Não foi possivel adicionar o usuário, verifique se nome é válido.");
                }
            }else
            {
                MessageBox.Show("Campos vazios, verifique-os!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            gbUsuario.Text = "UserID";
            txbNome.Text = "";
            txbSenha.Text = "";
            id = "";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txbNome.Text != "")
            {
                if (id == "0")
                {
                    MessageBox.Show("Não é possível remover o usuário administrador!");
                }
                else
                {
                    DialogResult confirm = MessageBox.Show("Você realmente deseja excluir o usuário " + txbNome.Text + "?", "Confirmação", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);

                    if (confirm == DialogResult.Yes)
                    {
                        User user = new User();
                        user.UserId = id;
                        bool resposta = db.UsuarioDAO.removeUser(user);

                        if (resposta)
                        {
                            atualizaTabela();
                            btnLimpar_Click("", e);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel remover o usuário.");
                        }
                    }
                }
            }
            else 
            { MessageBox.Show("Selecione um usuário!"); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (id != "")
            {
                if (txbNome.Text.Length > 2 && txbSenha.Text != "")
                {
                    user.Nome = txbNome.Text;
                    user.Senha = EasyEncryption.SHA.ComputeSHA256Hash(txbSenha.Text);
                    user.UserId = id;

                    bool resposta = db.UsuarioDAO.editUser(user);

                    if (resposta)
                    {
                        atualizaTabela();
                        btnLimpar_Click("", e);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel editar o usuário, verifique se os campos são válidos.");
                    }
                }
                else { MessageBox.Show("Campos vazios, verifique-os!");  }
            } else
            { MessageBox.Show("Selecione um usuário!"); }
        }
    }
}
