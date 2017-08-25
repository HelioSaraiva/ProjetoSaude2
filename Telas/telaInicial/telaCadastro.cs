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
using System.Collections;

namespace telaInicial
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

        public ArrayList ListaUsuario = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            this.Close();
            login.ShowDialog();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            // aq é necessário gerar o id do usuário, o id pode ser número do vetor usuário
            modelo.UserName = txtUsuario.Text;
            modelo.UserPW = txtSenha.Text;
            modelo.UserEmail = txtEmail.Text;
            modelo.UserNasc = dtNasc.Value;
            ListaUsuario.Add(modelo);
            MessageBox.Show("Cadastro efetuado: Dados " + modelo.UserName.ToString());            
        }

        private void telaCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
