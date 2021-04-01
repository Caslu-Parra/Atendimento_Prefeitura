using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            btnNovo.Image = Image.FromFile(@"C:\Users\lparra\Downloads\doc.png");
            btnNovo.ImageAlign = ContentAlignment.MiddleRight;
            btnNovo.TextAlign = ContentAlignment.MiddleLeft;
            btnNovo.FlatStyle = FlatStyle.Flat;
        }
    }
}
