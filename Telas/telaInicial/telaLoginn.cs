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
using Lista;
using Controle;
using Menulab;

namespace telaInicial 
{
    public partial class telaLoginn : Form
    {
        public int codigo = 0;
        public telaLoginn()
        {
            InitializeComponent();
              
        }
        ListaConta RecebeLista = new ListaConta();
        ControleConta MandaProControle = new ControleConta();

        private void btEntrar_Click(object sender, EventArgs e)
        {

            telaHome f = new telaHome(RecebeLista);
            this.Hide();
            f.ShowDialog();
            this.Dispose();



            // MessageBox.Show(string.Format("{0}", C.GetConta()));
            //  MessageBox.Show(string.Format("Código de Barras: {0}", C.Nn), "Saída");
            // txtSenha.Text = Convert.ToString(RecebeLista.GetRes());


        }

        private void btCadastrese_Click(object sender, EventArgs e)
        {

        }

        private void telaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                ModeloConta modelo = new ModeloConta();
                modelo.ContaId = RecebeLista.GetConta().Count+1;
                modelo.UserName = txtNome.Text;
                modelo.UserPW = txtSenha.Text;
                modelo.UserEmail = txtEmail.Text;
                modelo.UserNasc = dtNasc.Value;



                
                MandaProControle.Incluir(modelo, RecebeLista);

                MessageBox.Show("Cadastro efetuado");
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            metroGrid1.Refresh();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void telaLogin_Load_1(object sender, EventArgs e)
        {
            //btCadastrar.Enabled = true;
         
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            metroGrid1.DataSource = null;
            dataGridView1.DataSource = null;
            metroGrid1.DataSource = RecebeLista.GetConta();
            dataGridView1.DataSource = RecebeLista.GetConta();

            /*metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[2].HeaderText = "Amigos";
            metroGrid1.Columns[2].Visible = false;
            metroGrid1.Columns[3].Visible = false;
            metroGrid1.Columns[4].Visible = false;*/
            // dgvDados.Columns[0].HeaderText = "Código";



        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(metroGrid1.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }

            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                
            }
            foreach (ModeloConta Busca in RecebeLista.GetConta())
            {
                if (codigo == Busca.ContaId)
                {
                    txtNome.Text = Busca.UserName;
                    txtEmail.Text = Busca.UserEmail;
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ModeloConta modelo = new ModeloConta();
            //ModeloConta modelo = (ModeloConta) RecebeLista.GetConta()[codigo];
            modelo.ContaId = codigo;
            modelo.UserName = txtNome.Text;
            modelo.UserPW = txtSenha.Text;
            modelo.UserEmail = txtEmail.Text;
            modelo.UserNasc = dtNasc.Value;
            MandaProControle.Alterar(modelo, RecebeLista, codigo);

            MessageBox.Show("Cadastro alterado");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string texto = txtNome.Text;
            DateTime data = DateTime.Now;
            // richTextBox1.AppendText(data+"\n"+"João Pedro diz:"+texto+"\n\n");
            richTextBox1.Select(0, 0);
            richTextBox1.SelectedText = (data + "\n" + "João Pedro diz:" + texto + "\r\n\n") + Environment.NewLine;
       
            
        }
       
    }
}
