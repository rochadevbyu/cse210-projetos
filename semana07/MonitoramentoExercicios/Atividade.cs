using System;

public abstract class Atividade
{
    private string _nomeAtividade;
    private string _data;
    private int _duracaoMinutos;

    public Atividade(string nomeAtividade, string data, int duracaoMinutos)
    {
        _nomeAtividade = nomeAtividade;
        _data = data;
        _duracaoMinutos = duracaoMinutos;
    }

    public int GetDuracao()
    {
        return _duracaoMinutos;
    }

    public abstract double GetDistancia();
    public abstract double GetVelocidade();
    public abstract double GetRitmo();

    public string GetSummary()
    {
        return $"{_data} {_nomeAtividade} ({_duracaoMinutos} min) - Distância: {GetDistancia():0.0} km, Velocidade: {GetVelocidade():0.0} km/h, Ritmo: {GetRitmo():0.00} min por km";
    }
}