using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMachine
{
    public class CafeMachine
    {
        Vaso vaso = new Vaso();
        Cafetera cafetera = new Cafetera();
        Azucarero azucarero = new Azucarero();

        static void Main()
        {
            CafeMachine CM = new CafeMachine();
            int opcion = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n(1) Usuario");
                Console.WriteLine("(2) Administrador");
                Console.WriteLine("(3) Salir");


                opcion = Convert.ToInt32(LiTx.input("Seleccione una opcion: "));
                switch (opcion)
                {
                    case 1: CM.UserMenu(); break;
                    case 2: CM.AdminMenu(); break;
                }
            }while(opcion != 3);
        }

        public void UserMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n============= Bienvenidos A La Maquina De Café =============");

            // SELECCION VASO
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nSeleccione el tamaño de vaso de café\n");
            Console.WriteLine("(1) Vaso pequeño -> 3 Oz de café.");
            Console.WriteLine("(2) Vaso Mediano -> 5 Oz de café.");
            Console.WriteLine("(3) Vaso Grande -> 7 Oz de café.");

            int tipoVaso = Convert.ToInt32(LiTx.input("\nRespuesta: "));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nValidando que hay vasos...");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);

            getTipoVaso(tipoVaso);

            //SELECCION CAFETERA

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Validando que hay café...");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);

            getCantCafe(tipoVaso);

            //SELECCION AZUCAR
            int cantCucharadas = Convert.ToInt32(LiTx.input("\nIngrese la cantidad de cucharadas de azúcar: "));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nValidando que hay azucar...");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);

            getCantAzucar(cantCucharadas);

        }

        public void AdminMenu()
        {
            Console.WriteLine("\n(1) Agregar Vasos");
            Console.WriteLine("(2) Agregar Café");
            Console.WriteLine("(3) Agragar Azucar");
            Console.WriteLine("(4) Consultar Maquina");

            int opcion = Convert.ToInt32(LiTx.input("Seleccione una opción: "));

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("\n1 - Pequeño \n2 - Mediano \n3 - Grande");
                    int tipovaso = Convert.ToInt32(LiTx.input("\nSeleccione El Tipo de Vaso: "));
                    SuplirVasos(tipovaso);
                    break;
                case 2:
                    SuplirCafe();
                    break;
                case 3:
                    SuplirAzucar();
                    break;
                case 4:
                    ConsultarMaquina();
                    break;
            }
        }

        public void getTipoVaso(int tipoVasos)
        {
            bool resultado = vaso.hasVasos(tipoVasos);
            if(!resultado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nMaquina sin vasos disponibles, vuelva en otro momento");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                CafeMachine.Main();
            }
        }

        public void getCantCafe(int tipoVasos)
        {
            int cant_Oz_cafe = 0;
            switch (tipoVasos)
            {
                case 1:
                    cant_Oz_cafe = 3; break;
                case 2:
                    cant_Oz_cafe = 5; break;
                case 3:
                    cant_Oz_cafe = 7; break;
            }

            bool resultado = cafetera.hasCafe(cant_Oz_cafe);
            if (!resultado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nMaquina sin café disponibles, vuelva en otro momento");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                CafeMachine.Main();
            }
        }

        public void getCantAzucar(int cantAzucar)
        {
            bool resultado = azucarero.hasAzucar(cantAzucar);
            if (!resultado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nMaquina sin azucar disponibles, vuelva en otro momento");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                CafeMachine.Main();
            }
        }

        public void SuplirVasos(int tipovaso)
        {
            int cantvaso = Convert.ToInt32(LiTx.input("Cantidad de vasos a Colocar: "));
            vaso.giveVasos(tipovaso, cantvaso);
        }

        public void SuplirCafe()
        {
            int cantcafe = Convert.ToInt32(LiTx.input("Cantidad de café a Colocar: "));
            cafetera.giveCafe(cantcafe);
        }

        public void SuplirAzucar()
        {
            int cantazucar = Convert.ToInt32(LiTx.input("Cantidad de azucar a Colocar: "));
            azucarero.giveAzucar(cantazucar);
        }

        public void ConsultarMaquina()
        {
            Console.WriteLine($"\nVasos Pequeños: {vaso.ConsultarVasos(1)}");
            Console.WriteLine($"Vasos Medianos: {vaso.ConsultarVasos(2)}");
            Console.WriteLine($"Vasos Grandes: {vaso.ConsultarVasos(3)}");
            
            Console.WriteLine($"\nOz de Café: {cafetera.CantidadCafe}");
            Console.WriteLine($"Cucharadas de Azucar: {azucarero.CantidadDeAzucar}\n");
        }


    }
}
