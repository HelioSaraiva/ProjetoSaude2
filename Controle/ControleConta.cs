using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Lista;
using System.Collections;

namespace Controle
{
    public class ControleConta
    {
        public void Incluir(ModeloConta modelo, ListaConta RecebeLista)
        {



            if (modelo.UserName.Trim().Length == 0)
            {
                throw new Exception("o preenchimento do campo nome é obrigatório");
            }
               foreach (ModeloConta Busca in RecebeLista.GetConta())
               {
                   if (modelo.UserName == Busca.UserName)
                   {
                       throw new Exception("Username já cadastrado, escolha outro nome");
                   }
               }

            RecebeLista.SetConta(modelo);
           
            
        }
        public void Alterar(ModeloConta modelo, ListaConta RecebeLista, int N)
        {
            int number = N;


            if (modelo.UserName.Trim().Length == 0)
            {
                throw new Exception("o preenchimento do campo nome não pode estar vazio");
            }
           

            RecebeLista.AlteraConta(modelo, number);


        }


    }
}
