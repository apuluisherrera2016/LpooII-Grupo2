using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Clasificacion
    {
        private int clas_Id;

        public int Clas_Id
        {
            get { return clas_Id; }
            set { clas_Id = value; }
        }
        private string clas_Descripcion;

        public string Clas_Descripcion
        {
            get { return clas_Descripcion; }
            set { clas_Descripcion = value; }
        }
    }
}
