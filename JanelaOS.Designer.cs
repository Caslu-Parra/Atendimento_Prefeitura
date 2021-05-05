
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaOS));
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.rbtnData = new System.Windows.Forms.RadioButton();
            this.rbtnSolicitante = new System.Windows.Forms.RadioButton();
            this.rbtnID = new System.Windows.Forms.RadioButton();
            this.rbtnTecnico = new System.Windows.Forms.RadioButton();
            this.rbtnPatrimonio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvOSList = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.gbUserAdd = new System.Windows.Forms.GroupBox();
            this.gbAddOs = new System.Windows.Forms.GroupBox();
            this.gbEditOS = new System.Windows.Forms.GroupBox();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOSList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbUserAdd.SuspendLayout();
            this.gbAddOs.SuspendLayout();
            this.gbEditOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.rbtnData);
            this.gbFiltro.Controls.Add(this.rbtnSolicitante);
            this.gbFiltro.Controls.Add(this.rbtnID);
            this.gbFiltro.Controls.Add(this.rbtnTecnico);
            this.gbFiltro.Controls.Add(this.rbtnPatrimonio);
            this.gbFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbFiltro.Location = new System.Drawing.Point(275, 2);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(475, 60);
            this.gbFiltro.TabIndex = 1;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Procurar Por";
            // 
            // rbtnData
            // 
            this.rbtnData.AutoSize = true;
            this.rbtnData.Location = new System.Drawing.Point(220, 26);
            this.rbtnData.Name = "rbtnData";
            this.rbtnData.Size = new System.Drawing.Size(59, 24);
            this.rbtnData.TabIndex = 7;
            this.rbtnData.Text = "Data";
            this.rbtnData.UseVisualStyleBackColor = true;
            // 
            // rbtnSolicitante
            // 
            this.rbtnSolicitante.AutoSize = true;
            this.rbtnSolicitante.Location = new System.Drawing.Point(120, 26);
            this.rbtnSolicitante.Name = "rbtnSolicitante";
            this.rbtnSolicitante.Size = new System.Drawing.Size(98, 24);
            this.rbtnSolicitante.TabIndex = 8;
            this.rbtnSolicitante.Text = "Solicitante";
            this.rbtnSolicitante.UseVisualStyleBackColor = true;
            // 
            // rbtnID
            // 
            this.rbtnID.AutoSize = true;
            this.rbtnID.Checked = true;
            this.rbtnID.Location = new System.Drawing.Point(11, 26);
            this.rbtnID.Name = "rbtnID";
            this.rbtnID.Size = new System.Drawing.Size(103, 24);
            this.rbtnID.TabIndex = 10;
            this.rbtnID.TabStop = true;
            this.rbtnID.Text = "Número ID";
            this.rbtnID.UseVisualStyleBackColor = true;
            // 
            // rbtnTecnico
            // 
            this.rbtnTecnico.AutoSize = true;
            this.rbtnTecnico.Location = new System.Drawing.Point(285, 26);
            this.rbtnTecnico.Name = "rbtnTecnico";
            this.rbtnTecnico.Size = new System.Drawing.Size(78, 24);
            this.rbtnTecnico.TabIndex = 9;
            this.rbtnTecnico.Text = "Técnico";
            this.rbtnTecnico.UseVisualStyleBackColor = true;
            // 
            // rbtnPatrimonio
            // 
            this.rbtnPatrimonio.AutoSize = true;
            this.rbtnPatrimonio.Location = new System.Drawing.Point(369, 26);
            this.rbtnPatrimonio.Name = "rbtnPatrimonio";
            this.rbtnPatrimonio.Size = new System.Drawing.Size(103, 24);
            this.rbtnPatrimonio.TabIndex = 6;
            this.rbtnPatrimonio.Text = "Patrimônio";
            this.rbtnPatrimonio.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(10, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 33);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvOSList
            // 
            this.dgvOSList.AllowUserToAddRows = false;
            this.dgvOSList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOSList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOSList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOSList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOSList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOSList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOSList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvOSList.Location = new System.Drawing.Point(12, 65);
            this.dgvOSList.Name = "dgvOSList";
            this.dgvOSList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOSList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOSList.RowTemplate.Height = 25;
            this.dgvOSList.Size = new System.Drawing.Size(991, 393);
            this.dgvOSList.TabIndex = 4;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNovo.Location = new System.Drawing.Point(7, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(65, 39);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditar.Location = new System.Drawing.Point(6, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(66, 38);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(814, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 60);
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
            this.btnAddUser.Size = new System.Drawing.Size(66, 40);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // gbUserAdd
            // 
            this.gbUserAdd.Controls.Add(this.btnAddUser);
            this.gbUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbUserAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbUserAdd.Location = new System.Drawing.Point(13, 1);
            this.gbUserAdd.Name = "gbUserAdd";
            this.gbUserAdd.Size = new System.Drawing.Size(78, 61);
            this.gbUserAdd.TabIndex = 12;
            this.gbUserAdd.TabStop = false;
            this.gbUserAdd.Text = "Add User";
            // 
            // gbAddOs
            // 
            this.gbAddOs.Controls.Add(this.btnNovo);
            this.gbAddOs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbAddOs.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbAddOs.Location = new System.Drawing.Point(97, 1);
            this.gbAddOs.Name = "gbAddOs";
            this.gbAddOs.Size = new System.Drawing.Size(78, 61);
            this.gbAddOs.TabIndex = 13;
            this.gbAddOs.TabStop = false;
            this.gbAddOs.Text = "Criar OS";
            // 
            // gbEditOS
            // 
            this.gbEditOS.Controls.Add(this.btnEditar);
            this.gbEditOS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbEditOS.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbEditOS.Location = new System.Drawing.Point(181, 2);
            this.gbEditOS.Name = "gbEditOS";
            this.gbEditOS.Size = new System.Drawing.Size(78, 60);
            this.gbEditOS.TabIndex = 14;
            this.gbEditOS.TabStop = false;
            this.gbEditOS.Text = "Editar OS";
            // 
            // JanelaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 464);
            this.Controls.Add(this.gbEditOS);
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
            this.gbEditOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvOSList;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.RadioButton rbtnPatrimonio;
        private System.Windows.Forms.RadioButton rbtnData;
        private System.Windows.Forms.RadioButton rbtnSolicitante;
        private System.Windows.Forms.RadioButton rbtnTecnico;
        private System.Windows.Forms.RadioButton rbtnID;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox gbUserAdd;
        private System.Windows.Forms.GroupBox gbAddOs;
        private System.Windows.Forms.GroupBox gbEditOS;
    }
}