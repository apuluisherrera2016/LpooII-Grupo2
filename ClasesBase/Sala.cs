using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Sala
    {
        private int sala_Id;

        public int Sala_Id
        {
            get { return sala_Id; }
            set { sala_Id = value; }
        }
        private string sala_Descripcion;

        public string Sala_Descripcion
        {
            get { return sala_Descripcion; }
            set { sala_Descripcion = value; }
        }
    }
}
