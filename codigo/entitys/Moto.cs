using System;

class Moto : Vehiculo
{
    public Moto(string marca, string modelo)
        : base(marca, modelo)
    {

    }

    public override void Acelerar()
    {
        Velocidad = Velocidad + 35;
    }

    public override void Frenar()
    {
        Velocidad = Velocidad - 15;

        if (Velocidad < 0)
        {
            Velocidad = 0;
        }
    }
}