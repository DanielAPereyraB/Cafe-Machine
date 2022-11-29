using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMachine
{
    public class Vaso
    {
        VasosPequeños vasosPeque = new VasosPequeños();
        VasosMedianos vasosMedianos = new VasosMedianos();
        VasosGrandes vasosGrandes = new VasosGrandes();
        
        public bool hasVasos(int tipovaso) 
        {
            bool respuesta = false;
            switch (tipovaso)
            {
                case 1:
                    respuesta = vasosPeque.hasVasos(1); break;
                case 2:
                    respuesta = vasosMedianos.hasVasos(1); break;
                case 3:
                    respuesta = vasosGrandes.hasVasos(1); break;
                default:
                    Console.WriteLine("\nOPCION NO VALIDA"); Environment.Exit(0); break;
            }
            return respuesta;
        }

        public void giveVasos(int tipovaso, int catidad)
        {
            switch (tipovaso)
            {
                case 1:
                    vasosPeque.giveVasos(catidad); break;
                case 2:
                    vasosMedianos.giveVasos(catidad); break;
                case 3:
                    vasosGrandes.giveVasos(catidad); break;
                default:
                    Console.WriteLine("\nOPCION NO VALIDA"); Environment.Exit(0); break;
            }
        }

        public int ConsultarVasos(int opcion)
        {
            int respuesta = 0;
            switch (opcion)
            {
                case 1:
                    respuesta = vasosPeque.CantidadVasos; break;
                case 2:
                    respuesta = vasosMedianos.CantidadVasos; break;
                case 3:
                    respuesta = vasosGrandes.CantidadVasos; break;
                default:
                    Console.WriteLine("\nOPCION NO VALIDA"); Environment.Exit(0); break;
            }
            return respuesta;
        }
    }
}
