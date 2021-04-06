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
       

        private void JanelaOS_Load(object sender, EventArgs e)
        {
            dgvOSList.DataSource = db.Os_DAO.listar();
            //btnNovo.Image = Image.FromFile(@"C:\Users\lparra\Downloads\doc.png");
            //btnNovo.ImageAlign = ContentAlignment.MiddleRight;
            //btnNovo.TextAlign = ContentAlignment.MiddleLeft;
            //btnNovo.FlatStyle = FlatStyle.Flat;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaAddOS janelaAddOS = new TelaAddOS();
            janelaAddOS.ShowDialog();
            this.Show();

        }
    }
}
