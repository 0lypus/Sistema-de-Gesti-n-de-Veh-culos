using System;
class Program
{
    static List<Moto> motos = new List<Moto>();
    static List<Auto> autos = new List<Auto>();
    static void Main()
    {
        Console.WriteLine("Bienvenido a la aplicación de vehículos");
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Crear Moto");
            Console.WriteLine("2. Crear Auto");
            Console.WriteLine("3. Listar Vehículos");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarVehiculo();
                    break;
                case "2":
                    Simulacion();
                    break;
                case "3":
                    MostrarInformacion();
                    break;
                case "4":
                    Console.WriteLine("Cerrando programa..");
                    return;
                default:
                    Console.WriteLine("Opción no válida, intente nuevamente.");
                    break;
            }
        }
    }
}