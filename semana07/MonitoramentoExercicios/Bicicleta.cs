using System;

public class Bicicleta : Atividade
{
    private double _velocidade;

    public Bicicleta(string data, int duracaoMinutos, double velocidade) : base("Bicicleta", data, duracaoMinutos)
    {
        _velocidade = velocidade;
    }

    public override double GetDistancia()
    {
        return (_velocidade * GetDuracao()) / 60;
    }

    public override double GetVelocidade()
    {
        return _velocidade;
    }

    public override double GetRitmo()
    {
        return 60 / _velocidade;
    }
}