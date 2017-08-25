using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
  public class ModeloGrupo
    {
        public ModeloGrupo()
        {
            this.GrupCod = 0;
            this.GrupName = "";
            this.GrupTema = "";
            this.GrupPost = "";
        }

        public ModeloGrupo(int cod, string name, string tema, string post)
        {
            this.GrupCod = cod;
            this.GrupName = name;
            this.GrupTema = tema;
            this.GrupPost = post;
        }
        private int grup_cod;

        public int GrupCod
        {
            get { return this.grup_cod; }
            set { this.grup_cod = value; }
        }
        private string grup_name;

        public string GrupName
        {
            get { return this.grup_name; }
            set { this.grup_name = value; }
        }
        private string grup_tema;

        public string GrupTema
        {
            get { return this.grup_tema; }
            set { this.grup_tema = value; }
        }
        private string grup_post;

        public string GrupPost
        {
            get { return this.grup_post; }
            set { this.grup_post = value; }
        }
        //////////////////////////////

        public void CriarGrupo() { }
        public void PesquisarGrupo() { }
        public void ExcluirGrupo() { }
        public void ParticiparGrupo() { }
        public void SairGrupo() { }
    }
}
