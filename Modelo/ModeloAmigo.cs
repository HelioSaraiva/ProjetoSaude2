﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class ModeloAmigo
    {
        public ModeloAmigo()
        {
            this.AmgCod = 0;
            this.AmgQntd = 0;
            this.AmgCat = 0;
        }

        public ModeloAmigo(int cod, int qntd, int categoria)
        {
            this.AmgCod = cod;
            this.AmgQntd = qntd;
            this.AmgCat = categoria;
        }
        private int amg_cod;

        public int AmgCod
        {
            get { return this.amg_cod; }
            set { this.amg_cod = value; }
        }
        private int amg_qntd;

        public int AmgQntd
        {
            get { return this.amg_qntd; }
            set { this.amg_qntd = value; }
        }
        private int amg_cat;

        public int AmgCat
        {
            get { return this.amg_cat; }
            set { this.amg_cat = value; }
        }
        ////////////////////
        public void AddAmigo() { }
        public void PesquisarAmigo() { }
        public void ExcluirAmigo() { }
    }
}
