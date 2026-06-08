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
            Console.WriteLine("1. Registrar vehiculo");
            Console.WriteLine("2. Simulación de Aceleración y Frenado");
            Console.WriteLine("3. Mostrar información");
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
           static void RegistrarVehiculo()
            {
                Console.WriteLine("Seleccione el tipo de vehículo a registrar: (moto/auto)");

                string tipo = Console.ReadLine();

                Console.WriteLine("Ingrese la marca del vehículo:");
                string marca = Console.ReadLine();

                Console.WriteLine("Ingrese el modelo del vehículo:");
                string modelo = Console.ReadLine();

                if (tipo.ToLower()== "moto")
                {
                    motos.Add(new Moto(marca, modelo));
                    Console.WriteLine("Moto registrada exitosamente.");
                }
                else if (tipo.ToLower()== "auto")
                {
                    autos.Add(new Auto(marca, modelo));
                    Console.WriteLine("Auto registrado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Tipo de vehículo no válido.");
                }
            }
            static void Simulacion()
            {
                Console.WriteLine("Simulación de Aceleración y Frenado");
                Console.WriteLine("Seleccione el tipo de vehículo para simular: (moto/auto)");

                string tipo = Console.ReadLine();

                if (tipo.ToLower() == "moto")
                {
                    foreach (var moto in motos)
                    {
                        Console.WriteLine($"Simulando para {moto.Marca} {moto.Modelo}");
                        moto.Acelerar();
                        moto.MostrarInformacion();
                        moto.Frenar();
                        moto.MostrarInformacion();
                    }
                }
                else if (tipo.ToLower() == "auto")
                {
                    foreach (var auto in autos)
                    {
                         Console.WriteLine("\nAcelerando...");
                        auto.Acelerar();
                        Console.WriteLine($"Simulando para {auto.Marca} {auto.Modelo}");
                        
                        Console.WriteLine("\nFrenando...");
                        auto.Frenar();
                        Console.WriteLine("La simulación ha finalizado. Información final del vehículo:");
                    
                    }
                }
                else
                {
                    Console.WriteLine("Tipo de vehículo no válido.");
                }
            }
        }
    }
}