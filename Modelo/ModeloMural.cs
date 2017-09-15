using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
  public class ModeloMural
    {
        public ModeloMural()
        {
            this.MuralId = 0;
            this.MuralPost = "";
        }
        public ModeloMural(int idmural, string muralpost)
        {
            this.MuralId = idmural;

            this.MuralPost = muralpost;
        }

        private int mural_id;
        public int MuralId
        {
            get { return this.mural_id; }
            set { this.mural_id = value; }
        }

        private string mural_post;
        public string MuralPost
        {
            get { return this.mural_post; }
            set { this.mural_post = value; }
        }
    }
}
