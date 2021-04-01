
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaOS));
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.rbtnPatrimonio = new System.Windows.Forms.RadioButton();
            this.rbtnData = new System.Windows.Forms.RadioButton();
            this.rbtnSolicitante = new System.Windows.Forms.RadioButton();
            this.rbtnTecnico = new System.Windows.Forms.RadioButton();
            this.rbtnID = new System.Windows.Forms.RadioButton();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.gbFiltro.Location = new System.Drawing.Point(12, 398);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(282, 84);
            this.gbFiltro.TabIndex = 1;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Procurar Por";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(297, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 35);
            this.textBox1.TabIndex = 2;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesquisa.Location = new System.Drawing.Point(300, 398);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(90, 25);
            this.lblPesquisa.TabIndex = 3;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(550, 305);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNovo.Location = new System.Drawing.Point(12, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(67, 61);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // rbtnPatrimonio
            // 
            this.rbtnPatrimonio.AutoSize = true;
            this.rbtnPatrimonio.Location = new System.Drawing.Point(11, 54);
            this.rbtnPatrimonio.Name = "rbtnPatrimonio";
            this.rbtnPatrimonio.Size = new System.Drawing.Size(103, 24);
            this.rbtnPatrimonio.TabIndex = 6;
            this.rbtnPatrimonio.Text = "Patrimônio";
            this.rbtnPatrimonio.UseVisualStyleBackColor = true;
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
            // rbtnTecnico
            // 
            this.rbtnTecnico.AutoSize = true;
            this.rbtnTecnico.Location = new System.Drawing.Point(120, 54);
            this.rbtnTecnico.Name = "rbtnTecnico";
            this.rbtnTecnico.Size = new System.Drawing.Size(78, 24);
            this.rbtnTecnico.TabIndex = 9;
            this.rbtnTecnico.Text = "Técnico";
            this.rbtnTecnico.UseVisualStyleBackColor = true;
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
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditar.Location = new System.Drawing.Point(98, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 61);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // JanelaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 494);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbFiltro);
            this.Name = "JanelaOS";
            this.Text = "JanelaOS";
            this.Load += new System.EventHandler(this.JanelaOS_Load);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.RadioButton rbtnPatrimonio;
        private System.Windows.Forms.RadioButton rbtnData;
        private System.Windows.Forms.RadioButton rbtnSolicitante;
        private System.Windows.Forms.RadioButton rbtnTecnico;
        private System.Windows.Forms.RadioButton rbtnID;
        private System.Windows.Forms.Button btnEditar;
    }
}