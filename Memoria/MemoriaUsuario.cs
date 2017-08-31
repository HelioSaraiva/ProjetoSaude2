using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{

    public  class MemoriaUsuario
    {
        public static ArrayList ListaUsuario = new ArrayList();
        
        public void Incluir(ModeloUsuario modelo)
        {
            
            ListaUsuario.Add(modelo);
            
        }
        public ArrayList GetUsuario()
        {
            ArrayList al = new ArrayList();
            al = ListaUsuario;
            
            return al;
        }

    }
}
