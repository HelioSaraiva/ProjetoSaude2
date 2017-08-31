using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Memoria;

namespace Controle
{
   public class ControleUsuario
    {
        public void Incluir(ModeloUsuario modelo)
        {

            if (modelo.UserName.Trim().Length == 0)
            {
                throw new Exception("o preenchimento do campo nome é obrigatório");
            }
            MemoriaUsuario DALobj = new MemoriaUsuario();
            DALobj.Incluir(modelo);
        }
    }
}
