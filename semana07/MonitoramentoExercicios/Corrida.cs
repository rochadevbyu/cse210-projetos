using System;

public class Corrida : Atividade
{
    private double _distancia;

    public Corrida(string data, int duracaoMinutos, double distancia) : base("Corrida", data, duracaoMinutos)
    {
        _distancia = distancia;
    }

    public override double GetDistancia()
    {
        return _distancia;
    }

    public override double GetVelocidade()
    {
        return (_distancia / GetDuracao()) * 60;
    }

    public override double GetRitmo()
    {
        return GetDuracao() / _distancia;
    }
}