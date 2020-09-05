using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pelicula
    {
        private int peli_Id;
        private string peli_Titulo;
        private int peli_Duracion;
        private int gen_Id;
        private int clas_Id;

        public int Peli_Id
        {
            get { return peli_Id; }
            set { peli_Id = value; }
        }
       

        public string Peli_Titulo
        {
            get { return peli_Titulo; }
            set { peli_Titulo = value; }
        }
     

        public int Peli_Duracion
        {
            get { return peli_Duracion; }
            set { peli_Duracion = value; }
        }

        

        public int Gen_Id
        {
            get { return gen_Id; }
            set { gen_Id = value; }
        }
     

        public int Clas_Id
        {
            get { return clas_Id; }
            set { clas_Id = value; }
        }
    }
}
