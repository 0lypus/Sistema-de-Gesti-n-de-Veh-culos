using System;

class Auto : Vehiculo
{
    public Auto(string marca, string modelo): base(marca, modelo)
    {

    }

    public override void Acelerar()
    {
        Velocidad = Velocidad + 20;
    }

    public override void Frenar()
    {
        Velocidad = Velocidad - 10;

        if (Velocidad < 0)
        {
            Velocidad = 0;
        }
    }
}