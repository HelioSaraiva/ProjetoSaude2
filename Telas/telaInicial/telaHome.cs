using Lista;
using System;
using System.Collections;
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

    public partial class telaHome : MetroFramework.Forms.MetroForm
    {
        ListaConta Recebe = new ListaConta();
        public int codigo =0;
       public DateTime data = DateTime.Now;


       public string texto = "eu sei lá o que posso escrever sobre isso, apenas to preenchendo caixa de texto...";
       public string nome = "João Pedro diz:";
        public telaHome(ListaConta RecebeLista)
        {
            InitializeComponent();


            try
            { metroGrid2.DataSource = RecebeLista.GetConta();
                metroGrid2.Columns[0].Visible = false;
                metroGrid2.Columns[2].Visible = false;
                metroGrid2.Columns[3].Visible = false;
                metroGrid2.Columns[4].Visible = false;
                metroGrid2.Columns[5].Visible = false;


                metroGrid2.Columns[1].HeaderText = "Amigos";
            }
            catch { }
            
            

        }
        private void SetWatermark(string watermark)
        {
      //      textBox1.Watermark = watermark;
        }

        private void telaHome_Load(object sender, EventArgs e)
        {
            ArrayList L = new ArrayList();
            ModeloMural Mural1 = new ModeloMural();
            ModeloMural Mural2 = new ModeloMural();
            ModeloMural Mural3 = new ModeloMural();
            ModeloMural Mural4 = new ModeloMural();
            string tema1 = "Como tratar Brotoeja", tema2 = "5 exercícios de se manter saudável em 10minutos",
                tema3 = "vivendo plenamente na terceira idade", tema4 = "como me livrei do alcoolismo definitivamente";
            Mural1.MuralPost = tema1;
            Mural2.MuralPost = tema2;
            Mural3.MuralPost = tema3;
            Mural4.MuralPost = tema4;

            L.Add(Mural1);
            L.Add(Mural2);
            L.Add(Mural3);
            L.Add(Mural4);

            metroGrid1.DataSource = L;
          //  metroGrid1.Columns[0].HeaderText = "Código";
            metroGrid1.Columns[0].Width = 100;
            metroGrid1.Columns[0].Visible = false;
           metroGrid1.Columns[1].Width = 400;
            metroGrid1.DefaultCellStyle.Font = new Font("Tahoma", 12);


            
            richTextBox1.Font = new Font("Consolas", 18f, FontStyle.Bold);
            richTextBox1.BackColor = Color.AliceBlue;
            string datas = data.ToString();
            string[] words =
            {
                datas,
                nome,
                texto,                
                "is",
                "a",
                "nice",
                "website."
            };
            Color[] colors =
            {
                Color.Blue,
                Color.BlueViolet,
                Color.Brown,
                Color.Gold,
                Color.Cyan,
                Color.Lavender,
                Color.Moccasin
            };
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                Color color = colors[i];
                {
                    richTextBox1.SelectionColor = color;
                    richTextBox1.AppendText(word);
                    richTextBox1.SelectionColor = Color.AliceBlue;
                    richTextBox1.AppendText(" ");
                }
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
  
            

          
                    richTextBox1.Select(0, 0);


                    if (e.RowIndex == 0)
                    {
                        richTextBox1.SelectedText = (data + "\n" + "João Pedro diz:" + texto + "\r\n\n") + Environment.NewLine;
                        richTextBox1.Visible = true;
                        metroGrid1.Visible = false;

                    }
                    if (e.RowIndex == 1)
                    {
                         
                     //   texto = "só testando outra mensagem";
                    //    richTextBox1.SelectionBackColor = color;
                   //     richTextBox1.AppendText(word);
                    //    richTextBox1.SelectionBackColor = Color.AliceBlue;
                  //      richTextBox1.AppendText(" ");
                        //   richTextBox1.SelectedText = (data + "\n" + "João Pedro diz:" + texto + "\r\n\n") + Environment.NewLine;
                        richTextBox1.Visible = true;
                        metroGrid1.Visible = false;

                    }

                    if (e.RowIndex == 2)
                    {
                        texto = "vivendo plenamente na terceira idade, que história é essa? aushauhsauhauhs";
                        richTextBox1.SelectedText = (data + "\n" + "João Pedro diz:" + texto + "\r\n\n") + Environment.NewLine;
                        texto = "só mais um teste";
                        richTextBox1.SelectedText = (data + "\n" + "João Pedro diz:" + texto + "\r\n\n") + Environment.NewLine;
                        richTextBox1.Visible = true;
                        metroGrid1.Visible = false;

                    }
                
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Visible = false;
            metroGrid1.Visible = true;
        }
    }
}
