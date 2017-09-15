using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telaInicial
{
     class ClasseTeste
    {

        private ArrayList ArrListConta;
        public int Nn;
        
        public ClasseTeste() { }

        public void SetConta(ModeloConta modelo)
        {
            if (ArrListConta == null)
            {
                ArrListConta = new ArrayList();
                ArrListConta.Add(modelo);
                Nn = ArrListConta.Count;

            }
            else
            {
                ArrListConta.Add(modelo);
                 Nn = ArrListConta.Count;
            }

        }
        public int GetRes()
        {
            return Nn;
        }


    }
}
