using System;

public class Natacao : Atividade
{
    private int _voltas;

    public Natacao(string data, int duracaoMinutos, int voltas) : base("Natação", data, duracaoMinutos)
    {
        _voltas = voltas;
    }

    public override double GetDistancia()
    {
        return (_voltas * 50.0) / 1000.0;
    }

    public override double GetVelocidade()
    {
        return (GetDistancia() / GetDuracao()) * 60;
    }

    public override double GetRitmo()
    {
        return GetDuracao() / GetDistancia();
    }
}