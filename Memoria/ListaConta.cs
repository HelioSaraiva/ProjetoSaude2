using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    
    public class ListaConta
    {
        public int n;
        private ArrayList ArrListConta;
 
        
        public ListaConta() { }

        public void SetConta(ModeloConta modelo)
        {
            if (ArrListConta == null)
            {
                ArrListConta = new ArrayList();              
                ArrListConta.Add(modelo);              

            }
            else
            {        
                ArrListConta.Add(modelo);
                n = ArrListConta.Count;
            }
       
        }

        public void AlteraConta(ModeloConta modelo, int n)
        {
            int number = n-1;
          //  ModeloConta modelo = (ModeloConta)ArrListConta[number];

            ArrListConta.RemoveAt(number);

            ArrListConta.Insert(number, modelo);
        }
        public ArrayList GetConta()
        {
            
            if (ArrListConta == null)
            {
                ArrListConta = new ArrayList();
                return ArrListConta;
            }
          else
            {
                return ArrListConta;
            }
            
        }
        public int GetRes()
        {
            return n;
        }

    }
}

