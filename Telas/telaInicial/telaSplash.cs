using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaInicial
{
    public partial class telaSplash : Form
    {
        public telaSplash()
        {
            InitializeComponent();
        }

        private void telaSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <100){
                progressBar1.Value = progressBar1.Value + 2;
            }else
            {
                timer1.Enabled = false;
                this.Visible = false;
                telaLogin login = new telaLogin();
                login.ShowDialog();
            }
        }
    }
}
