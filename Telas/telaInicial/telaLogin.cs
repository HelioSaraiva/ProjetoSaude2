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

namespace telaInicial
{
    public partial class telaLogin : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        public telaLogin()
        {
            InitializeComponent();
        }
        ListaConta RecebeLista = new ListaConta();
        ControleConta MandaProControle = new ControleConta();

        private void telaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            telaHome f = new telaHome(RecebeLista);
            this.Hide();
            f.ShowDialog();
            this.Dispose();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloConta modelo = new ModeloConta();
                modelo.ContaId = RecebeLista.GetConta().Count + 1;
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

          //  metroGrid1.Refresh();
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

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(metroGrid1.Rows[e.RowIndex].Cells[0].Value);
            //    this.Close();
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = null;
            dataGridView1.DataSource = null;
            metroGrid1.DataSource = RecebeLista.GetConta();
            dataGridView1.DataSource = RecebeLista.GetConta();
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
    }
}
