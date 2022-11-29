using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMachine
{
    public class VasosGrandes
    {
        private int cantidadVasos;
        private int contenido;

        public int CantidadVasos { get => cantidadVasos; set => cantidadVasos = value; }
        public int Contenido { get => contenido; set => contenido = value; }

        public bool hasVasos(int cantidadVaso)
        {
            if (CantidadVasos >= cantidadVaso)
            {
                CantidadVasos -= cantidadVaso;
                return true;
            }
            return false;
        }

        public void giveVasos(int cantidadVaso)
        {
            CantidadVasos += cantidadVaso;
        }
    }
}
