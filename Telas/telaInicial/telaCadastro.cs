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
using Controle;
using Lista;

namespace telaInicial
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

       // public static ArrayList ListaUsuario = new ArrayList();
        
        private void button1_Click(object sender, EventArgs e)
        {

            telaLogin login = new telaLogin();
            this.Close();
            login.ShowDialog();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

        try {
                ModeloConta modelo = new ModeloConta();

                // aq é necessário gerar o id do usuário, o id pode ser número do vetor usuário
                modelo.UserName = txtUsuari.Text;
                modelo.UserPW = txtSenh.Text;
                modelo.UserEmail = txtEmai.Text;
              //  modelo.UserNasc = dtNasc.Value;
             //   ListaUsuario.Add(modelo);

                ControleConta MandaProControle = new ControleConta();
                MandaProControle.Incluir(modelo);

                MessageBox.Show("Cadastro efetuado");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void telaCadastro_Load(object sender, EventArgs e)
        {

        }


    }
}
