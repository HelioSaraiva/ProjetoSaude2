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
using Memoria;

namespace telaInicial
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
                    
        }


        private void btEntrar_Click(object sender, EventArgs e)
        {
            
            MemoriaUsuario RecebeLista = new MemoriaUsuario();
            ModeloUsuario Lista = new ModeloUsuario();
           
            foreach (ModeloUsuario Busca in RecebeLista.GetUsuario())
            {


                if (txtUsuario.Text == Busca.UserName )
               
                   {
                    telaPrincipal f = new telaPrincipal();
                    f.txtNomeUsuario.Text = "";
                    f.txtNomeUsuario.Text = Busca.UserName.ToString();
                    //MessageBox.Show("Bem vindo ao sistema, " + Busca.UserName.ToString());
                    f.ShowDialog();
                    break;
                   }
               // else { MessageBox.Show("inválido" ); }

            }

           // dataGridView1.DataSource = RecebeLista.GetUsuario(); 


        }

        private void btCadastrese_Click(object sender, EventArgs e)
        {
            Dispose();
            telaCadastro cadastro = new telaCadastro();
            cadastro.ShowDialog();
        }

        private void telaLogin_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }
    }
}
