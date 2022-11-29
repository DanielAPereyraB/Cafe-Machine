using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMachine
{
    public class Cafetera
    {
        private int cantidadCafes;

        public int CantidadCafe { get => cantidadCafes; set => cantidadCafes = value; }

        public bool hasCafe(int cantidadCafe)
        {
            if (CantidadCafe >= cantidadCafe)
            {
                CantidadCafe -= cantidadCafe;
                return true;
            }
            return false;
        }

        public void giveCafe(int cantidadCafe)
        {
            CantidadCafe += cantidadCafe;
        }
    }
}
