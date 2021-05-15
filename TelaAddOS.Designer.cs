
namespace Atendimento
{
    partial class TelaAddOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAddOS));
            this.gbCabecalho = new System.Windows.Forms.GroupBox();
            this.txbHorario = new System.Windows.Forms.MaskedTextBox();
            this.txbData = new System.Windows.Forms.MaskedTextBox();
            this.txbPatrimonio = new System.Windows.Forms.MaskedTextBox();
            this.cbFinalizado = new System.Windows.Forms.CheckBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txbRamal = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.lblPatrimonio = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblRamal = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.txbSolicitante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.txbTecnico = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.gbDescricao = new System.Windows.Forms.GroupBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.gpSolucao = new System.Windows.Forms.GroupBox();
            this.txbSolucao = new System.Windows.Forms.TextBox();
            this.gbCabecalho.SuspendLayout();
            this.gbDescricao.SuspendLayout();
            this.gpSolucao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCabecalho
            // 
            this.gbCabecalho.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbCabecalho.Controls.Add(this.txbHorario);
            this.gbCabecalho.Controls.Add(this.txbData);
            this.gbCabecalho.Controls.Add(this.txbPatrimonio);
            this.gbCabecalho.Controls.Add(this.cbFinalizado);
            this.gbCabecalho.Controls.Add(this.lblHora);
            this.gbCabecalho.Controls.Add(this.txbRamal);
            this.gbCabecalho.Controls.Add(this.btnCancelar);
            this.gbCabecalho.Controls.Add(this.btnSalvar);
            this.gbCabecalho.Controls.Add(this.cbDept);
            this.gbCabecalho.Controls.Add(this.lblPatrimonio);
            this.gbCabecalho.Controls.Add(this.lblDept);
            this.gbCabecalho.Controls.Add(this.txbID);
            this.gbCabecalho.Controls.Add(this.lblRamal);
            this.gbCabecalho.Controls.Add(this.lblData);
            this.gbCabecalho.Controls.Add(this.lblSolicitante);
            this.gbCabecalho.Controls.Add(this.txbSolicitante);
            this.gbCabecalho.Controls.Add(this.label1);
            this.gbCabecalho.Controls.Add(this.lblTecnico);
            this.gbCabecalho.Controls.Add(this.txbTecnico);
            this.gbCabecalho.Controls.Add(this.lbl_ID);
            this.gbCabecalho.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCabecalho.Location = new System.Drawing.Point(12, 6);
            this.gbCabecalho.Name = "gbCabecalho";
            this.gbCabecalho.Size = new System.Drawing.Size(914, 168);
            this.gbCabecalho.TabIndex = 2;
            this.gbCabecalho.TabStop = false;
            this.gbCabecalho.Text = "ATENDIMENTO";
            // 
            // txbHorario
            // 
            this.txbHorario.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbHorario.Location = new System.Drawing.Point(694, 54);
            this.txbHorario.Mask = "00:00";
            this.txbHorario.Name = "txbHorario";
            this.txbHorario.Size = new System.Drawing.Size(90, 30);
            this.txbHorario.TabIndex = 29;
            this.txbHorario.ValidatingType = typeof(System.DateTime);
            // 
            // txbData
            // 
            this.txbData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbData.Location = new System.Drawing.Point(542, 54);
            this.txbData.Mask = "00/00/0000";
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(97, 29);
            this.txbData.TabIndex = 28;
            this.txbData.ValidatingType = typeof(System.DateTime);
            // 
            // txbPatrimonio
            // 
            this.txbPatrimonio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPatrimonio.Location = new System.Drawing.Point(405, 54);
            this.txbPatrimonio.Mask = "00000/00000";
            this.txbPatrimonio.Name = "txbPatrimonio";
            this.txbPatrimonio.Size = new System.Drawing.Size(108, 29);
            this.txbPatrimonio.TabIndex = 27;
            this.txbPatrimonio.ValidatingType = typeof(int);
            // 
            // cbFinalizado
            // 
            this.cbFinalizado.AutoSize = true;
            this.cbFinalizado.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFinalizado.Location = new System.Drawing.Point(795, 119);
            this.cbFinalizado.Name = "cbFinalizado";
            this.cbFinalizado.Size = new System.Drawing.Size(118, 24);
            this.cbFinalizado.TabIndex = 26;
            this.cbFinalizado.Text = "Finalizado";
            this.cbFinalizado.UseVisualStyleBackColor = true;
            this.cbFinalizado.Visible = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(694, 32);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(90, 22);
            this.lblHora.TabIndex = 24;
            this.lblHora.Text = "Horário:";
            // 
            // txbRamal
            // 
            this.txbRamal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbRamal.Location = new System.Drawing.Point(280, 54);
            this.txbRamal.Mask = "000000000";
            this.txbRamal.Name = "txbRamal";
            this.txbRamal.Size = new System.Drawing.Size(97, 29);
            this.txbRamal.TabIndex = 22;
            this.txbRamal.ValidatingType = typeof(int);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(807, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 42);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Limpar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(807, 41);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 43);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbDept
            // 
            this.cbDept.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(278, 120);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(509, 25);
            this.cbDept.TabIndex = 17;
            this.cbDept.Text = "Selecione a opção";
            // 
            // lblPatrimonio
            // 
            this.lblPatrimonio.AutoSize = true;
            this.lblPatrimonio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPatrimonio.Location = new System.Drawing.Point(405, 34);
            this.lblPatrimonio.Name = "lblPatrimonio";
            this.lblPatrimonio.Size = new System.Drawing.Size(70, 22);
            this.lblPatrimonio.TabIndex = 15;
            this.lblPatrimonio.Text = "Patri:";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDept.Location = new System.Drawing.Point(278, 96);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(140, 22);
            this.lblDept.TabIndex = 16;
            this.lblDept.Text = "Departamento:";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbID.Location = new System.Drawing.Point(172, 56);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(78, 27);
            this.txbID.TabIndex = 14;
            // 
            // lblRamal
            // 
            this.lblRamal.AutoSize = true;
            this.lblRamal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRamal.Location = new System.Drawing.Point(280, 33);
            this.lblRamal.Name = "lblRamal";
            this.lblRamal.Size = new System.Drawing.Size(70, 22);
            this.lblRamal.TabIndex = 13;
            this.lblRamal.Text = "Ramal:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(542, 33);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(60, 22);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data:";
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSolicitante.Location = new System.Drawing.Point(6, 96);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(130, 22);
            this.lblSolicitante.TabIndex = 9;
            this.lblSolicitante.Text = "Solicitante:";
            // 
            // txbSolicitante
            // 
            this.txbSolicitante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSolicitante.Location = new System.Drawing.Point(6, 119);
            this.txbSolicitante.Name = "txbSolicitante";
            this.txbSolicitante.Size = new System.Drawing.Size(245, 27);
            this.txbSolicitante.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-113, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Técnico:";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTecnico.Location = new System.Drawing.Point(6, 31);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(90, 22);
            this.lblTecnico.TabIndex = 7;
            this.lblTecnico.Text = "Técnico:";
            // 
            // txbTecnico
            // 
            this.txbTecnico.Enabled = false;
            this.txbTecnico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbTecnico.Location = new System.Drawing.Point(6, 56);
            this.txbTecnico.Name = "txbTecnico";
            this.txbTecnico.Size = new System.Drawing.Size(140, 27);
            this.txbTecnico.TabIndex = 6;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ID.Location = new System.Drawing.Point(172, 31);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(40, 22);
            this.lbl_ID.TabIndex = 5;
            this.lbl_ID.Text = "ID:";
            // 
            // gbDescricao
            // 
            this.gbDescricao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbDescricao.Controls.Add(this.txbDescricao);
            this.gbDescricao.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDescricao.Location = new System.Drawing.Point(12, 193);
            this.gbDescricao.Name = "gbDescricao";
            this.gbDescricao.Size = new System.Drawing.Size(914, 195);
            this.gbDescricao.TabIndex = 3;
            this.gbDescricao.TabStop = false;
            this.gbDescricao.Text = "Descrição do Problema";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDescricao.Location = new System.Drawing.Point(15, 28);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(878, 151);
            this.txbDescricao.TabIndex = 20;
            // 
            // gpSolucao
            // 
            this.gpSolucao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gpSolucao.Controls.Add(this.txbSolucao);
            this.gpSolucao.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpSolucao.Location = new System.Drawing.Point(12, 410);
            this.gpSolucao.Name = "gpSolucao";
            this.gpSolucao.Size = new System.Drawing.Size(914, 199);
            this.gpSolucao.TabIndex = 21;
            this.gpSolucao.TabStop = false;
            this.gpSolucao.Text = "Solução Aplicada";
            // 
            // txbSolucao
            // 
            this.txbSolucao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSolucao.Location = new System.Drawing.Point(15, 28);
            this.txbSolucao.Multiline = true;
            this.txbSolucao.Name = "txbSolucao";
            this.txbSolucao.Size = new System.Drawing.Size(878, 151);
            this.txbSolucao.TabIndex = 20;
            // 
            // TelaAddOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 621);
            this.Controls.Add(this.gpSolucao);
            this.Controls.Add(this.gbDescricao);
            this.Controls.Add(this.gbCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAddOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Ordem de Serviço";
            this.Load += new System.EventHandler(this.TelaAddOS_Load);
            this.gbCabecalho.ResumeLayout(false);
            this.gbCabecalho.PerformLayout();
            this.gbDescricao.ResumeLayout(false);
            this.gbDescricao.PerformLayout();
            this.gpSolucao.ResumeLayout(false);
            this.gpSolucao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCabecalho;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.TextBox txbTecnico;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.TextBox txbSolicitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRamal;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPatrimonio;
        private System.Windows.Forms.GroupBox gbDescricao;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.GroupBox gpSolucao;
        private System.Windows.Forms.TextBox txbSolucao;
        private System.Windows.Forms.MaskedTextBox txbRamal;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.CheckBox cbFinalizado;
        private System.Windows.Forms.MaskedTextBox txbPatrimonio;
        private System.Windows.Forms.MaskedTextBox txbData;
        private System.Windows.Forms.MaskedTextBox txbHorario;
    }
}