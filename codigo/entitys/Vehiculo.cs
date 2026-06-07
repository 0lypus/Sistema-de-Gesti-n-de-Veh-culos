using System;

abstract class Vehiculo
{
    private string marca;
    private string modelo;
    private int velocidad;

    public string Marca { get { return this.marca; } set { this.marca = value; } }
    public string Modelo { get { return this.modelo; } set { this.modelo = value; } }
    public int Velocidad { get { return this.velocidad; } set { this.velocidad = value; } }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        Velocidad = 0;
    }

    public abstract void Acelerar();
    public abstract void Frenar();

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Vehículo: " + Marca + " " + Modelo);
        Console.WriteLine("Velocidad actual: " + Velocidad + " km/h");
    }
}