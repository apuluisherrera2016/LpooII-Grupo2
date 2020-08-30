using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Ticket
    {
        private int tick_Id;

        public int Tick_Id
        {
            get { return tick_Id; }
            set { tick_Id = value; }
        }
        private DateTime tick_FechaVenta;

        public DateTime Tick_FechaVenta
        {
            get { return tick_FechaVenta; }
            set { tick_FechaVenta = value; }
        }
        private int cli_Dni;

        public int Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }
        private int proy_Id;

        public int Proy_Id
        {
            get { return proy_Id; }
            set { proy_Id = value; }
        }
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
    }
}
