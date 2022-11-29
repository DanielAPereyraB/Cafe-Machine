using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMachine
{
    public class Azucarero
    {
        private int cantidadDeAzucar;

        public int CantidadDeAzucar { get => cantidadDeAzucar; set => cantidadDeAzucar = value; }

        public bool hasAzucar(int cantidaddeazucar)
        {
            if (CantidadDeAzucar >= cantidaddeazucar)
            {
                CantidadDeAzucar -= cantidaddeazucar;
                return true;
            }
            return false;
        }

        public void giveAzucar(int cantidaddeazucar)
        {
            CantidadDeAzucar += cantidaddeazucar;
        }
    }
}
