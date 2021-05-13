
namespace Atendimento
{
    partial class JanelaOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaOS));
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.rBtnDepartamento = new System.Windows.Forms.RadioButton();
            this.rBtnData = new System.Windows.Forms.RadioButton();
            this.rBtnSolicitante = new System.Windows.Forms.RadioButton();
            this.rBtnID = new System.Windows.Forms.RadioButton();
            this.rBtnTecnico = new System.Windows.Forms.RadioButton();
            this.rBtnPatrimonio = new System.Windows.Forms.RadioButton();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.dgvOSList = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.gbUserAdd = new System.Windows.Forms.GroupBox();
            this.gbAddOs = new System.Windows.Forms.GroupBox();
            this.gbLimpaBusca = new System.Windows.Forms.GroupBox();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOSList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbUserAdd.SuspendLayout();
            this.gbAddOs.SuspendLayout();
            this.gbLimpaBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.rBtnDepartamento);
            this.gbFiltro.Controls.Add(this.rBtnData);
            this.gbFiltro.Controls.Add(this.rBtnSolicitante);
            this.gbFiltro.Controls.Add(this.rBtnID);
            this.gbFiltro.Controls.Add(this.rBtnTecnico);
            this.gbFiltro.Controls.Add(this.rBtnPatrimonio);
            this.gbFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbFiltro.Location = new System.Drawing.Point(211, 2);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(565, 60);
            this.gbFiltro.TabIndex = 1;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Procurar Por";
            // 
            // rBtnDepartamento
            // 
            this.rBtnDepartamento.AutoSize = true;
            this.rBtnDepartamento.Location = new System.Drawing.Point(403, 25);
            this.rBtnDepartamento.Name = "rBtnDepartamento";
            this.rBtnDepartamento.Size = new System.Drawing.Size(116, 23);
            this.rBtnDepartamento.TabIndex = 11;
            this.rBtnDepartamento.Text = "Departamento";
            this.rBtnDepartamento.UseVisualStyleBackColor = true;
            // 
            // rBtnData
            // 
            this.rBtnData.AutoSize = true;
            this.rBtnData.Location = new System.Drawing.Point(158, 25);
            this.rBtnData.Name = "rBtnData";
            this.rBtnData.Size = new System.Drawing.Size(56, 23);
            this.rBtnData.TabIndex = 7;
            this.rBtnData.Text = "Data";
            this.rBtnData.UseVisualStyleBackColor = true;
            // 
            // rBtnSolicitante
            // 
            this.rBtnSolicitante.AutoSize = true;
            this.rBtnSolicitante.Location = new System.Drawing.Point(58, 25);
            this.rBtnSolicitante.Name = "rBtnSolicitante";
            this.rBtnSolicitante.Size = new System.Drawing.Size(94, 23);
            this.rBtnSolicitante.TabIndex = 8;
            this.rBtnSolicitante.Text = "Solicitante";
            this.rBtnSolicitante.UseVisualStyleBackColor = true;
            // 
            // rBtnID
            // 
            this.rBtnID.AutoSize = true;
            this.rBtnID.Checked = true;
            this.rBtnID.Location = new System.Drawing.Point(11, 26);
            this.rBtnID.Name = "rBtnID";
            this.rBtnID.Size = new System.Drawing.Size(41, 23);
            this.rBtnID.TabIndex = 10;
            this.rBtnID.TabStop = true;
            this.rBtnID.Text = "ID";
            this.rBtnID.UseVisualStyleBackColor = true;
            // 
            // rBtnTecnico
            // 
            this.rBtnTecnico.AutoSize = true;
            this.rBtnTecnico.Location = new System.Drawing.Point(220, 25);
            this.rBtnTecnico.Name = "rBtnTecnico";
            this.rBtnTecnico.Size = new System.Drawing.Size(75, 23);
            this.rBtnTecnico.TabIndex = 9;
            this.rBtnTecnico.Text = "Técnico";
            this.rBtnTecnico.UseVisualStyleBackColor = true;
            // 
            // rBtnPatrimonio
            // 
            this.rBtnPatrimonio.AutoSize = true;
            this.rBtnPatrimonio.Location = new System.Drawing.Point(301, 25);
            this.rBtnPatrimonio.Name = "rBtnPatrimonio";
            this.rBtnPatrimonio.Size = new System.Drawing.Size(96, 23);
            this.rBtnPatrimonio.TabIndex = 6;
            this.rBtnPatrimonio.Text = "Patrimônio";
            this.rBtnPatrimonio.UseVisualStyleBackColor = true;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbPesquisa.Location = new System.Drawing.Point(12, 21);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(137, 33);
            this.txbPesquisa.TabIndex = 2;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // dgvOSList
            // 
            this.dgvOSList.AllowUserToAddRows = false;
            this.dgvOSList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOSList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOSList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOSList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOSList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOSList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOSList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvOSList.Location = new System.Drawing.Point(12, 65);
            this.dgvOSList.Name = "dgvOSList";
            this.dgvOSList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOSList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOSList.RowTemplate.Height = 25;
            this.dgvOSList.Size = new System.Drawing.Size(991, 393);
            this.dgvOSList.TabIndex = 4;
            this.dgvOSList.SelectionChanged += new System.EventHandler(this.dgvOSList_SelectionChanged);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNovo.Location = new System.Drawing.Point(7, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(43, 39);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbPesquisa);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(849, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 60);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddUser.Location = new System.Drawing.Point(6, 18);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(55, 40);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // gbUserAdd
            // 
            this.gbUserAdd.Controls.Add(this.btnAddUser);
            this.gbUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbUserAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbUserAdd.Location = new System.Drawing.Point(13, 1);
            this.gbUserAdd.Name = "gbUserAdd";
            this.gbUserAdd.Size = new System.Drawing.Size(69, 61);
            this.gbUserAdd.TabIndex = 12;
            this.gbUserAdd.TabStop = false;
            this.gbUserAdd.Text = "Usuarios";
            // 
            // gbAddOs
            // 
            this.gbAddOs.Controls.Add(this.btnNovo);
            this.gbAddOs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbAddOs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbAddOs.Location = new System.Drawing.Point(88, 1);
            this.gbAddOs.Name = "gbAddOs";
            this.gbAddOs.Size = new System.Drawing.Size(56, 61);
            this.gbAddOs.TabIndex = 13;
            this.gbAddOs.TabStop = false;
            this.gbAddOs.Text = "Novo";
            // 
            // gbLimpaBusca
            // 
            this.gbLimpaBusca.Controls.Add(this.btnRecarregar);
            this.gbLimpaBusca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbLimpaBusca.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbLimpaBusca.Location = new System.Drawing.Point(782, 2);
            this.gbLimpaBusca.Name = "gbLimpaBusca";
            this.gbLimpaBusca.Size = new System.Drawing.Size(61, 60);
            this.gbLimpaBusca.TabIndex = 15;
            this.gbLimpaBusca.TabStop = false;
            this.gbLimpaBusca.Text = "Limpar";
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecarregar.BackgroundImage")));
            this.btnRecarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecarregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRecarregar.Location = new System.Drawing.Point(6, 17);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(50, 40);
            this.btnRecarregar.TabIndex = 6;
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // JanelaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 464);
            this.Controls.Add(this.gbLimpaBusca);
            this.Controls.Add(this.gbAddOs);
            this.Controls.Add(this.gbUserAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOSList);
            this.Controls.Add(this.gbFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JanelaOS";
            this.Load += new System.EventHandler(this.JanelaOS_Load);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOSList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUserAdd.ResumeLayout(false);
            this.gbAddOs.ResumeLayout(false);
            this.gbLimpaBusca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.DataGridView dgvOSList;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.RadioButton rBtnPatrimonio;
        private System.Windows.Forms.RadioButton rBtnData;
        private System.Windows.Forms.RadioButton rBtnSolicitante;
        private System.Windows.Forms.RadioButton rBtnTecnico;
        private System.Windows.Forms.RadioButton rBtnID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox gbUserAdd;
        private System.Windows.Forms.GroupBox gbAddOs;
        private System.Windows.Forms.GroupBox gbLimpaBusca;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.RadioButton rBtnDepartamento;
    }
}