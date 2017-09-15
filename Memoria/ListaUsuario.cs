using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{

    public  class ListaUsuario
    {
        public static ArrayList ArrListaUsuario = new ArrayList();
        
        public void Incluir(ModeloUsuario modelo)
        {
            
            ArrListaUsuario.Add(modelo);
            
        }
        public ArrayList GetUsuario()
        {
            ArrayList al = new ArrayList();
            al = ArrListaUsuario;
            
            return al;
        }

    }
}
