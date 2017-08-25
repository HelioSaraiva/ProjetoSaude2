using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace telaInicial
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }
        public string N = "";
        public string S = "";
        public void Incluir(ModeloUsuario modelo)
        {
           
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            

            if (N== txtUsuario.Text && S == txtPw.Text)
            {
                MessageBox.Show("login efetuado com sucesso " + N.ToString());
            }
            else
            {
                MessageBox.Show("Falhou " + N.ToString());
            }

        }

        private void btCadastrese_Click(object sender, EventArgs e)
        {
            Dispose();
            telaCadastro cadastro = new telaCadastro();
            cadastro.ShowDialog();
        }
    }
}
