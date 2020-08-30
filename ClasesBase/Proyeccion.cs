using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Proyeccion
    {
        private int proy_Id;

        public int Proy_Id
        {
            get { return proy_Id; }
            set { proy_Id = value; }
        }
        private string proy_Fecha;

        public string Proy_Fecha
        {
            get { return proy_Fecha; }
            set { proy_Fecha = value; }
        }
        private string proy_Hora;

        public string Proy_Hora
        {
            get { return proy_Hora; }
            set { proy_Hora = value; }
        }
        private int sala_Id;

        public int Sala_Id
        {
            get { return sala_Id; }
            set { sala_Id = value; }
        }
        private int peli_Id;

        public int Peli_Id
        {
            get { return peli_Id; }
            set { peli_Id = value; }
        }
    }
}
