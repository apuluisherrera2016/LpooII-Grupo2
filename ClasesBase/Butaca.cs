﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Butaca
    {
        private string but_Fila;

        public string But_Fila
        {
            get { return but_Fila; }
            set { but_Fila = value; }
        }
        private int but_Numero;

        public int But_Numero
        {
            get { return but_Numero; }
            set { but_Numero = value; }
        }
        private int sala_Id;

        public int Sala_Id
        {
            get { return sala_Id; }
            set { sala_Id = value; }
        }
    }
}
