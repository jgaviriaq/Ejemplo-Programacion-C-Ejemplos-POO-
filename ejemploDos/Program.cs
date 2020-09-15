using System;

namespace ejemploDos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( " Hotel WCG!");

            Console.WriteLine("Cantidad de Huespedes");
            int Huespedes = int.Parse(Console.ReadLine());

            Console.WriteLine("Dias de estadia");
            int cant_dias = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de la habitacion");
            string nom_hab = Console.ReadLine();

            // Instancia

            var hotelUno = new GestionHotel(){
                habitacion = nom_hab,
                huesped = Huespedes,
                dias = cant_dias
            };

            hotelUno.cuentaCobro();
        }
    }
}
