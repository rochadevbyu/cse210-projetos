using System;

public class Comentario
{
    private string _nome;
    private string _texto;

    // Propriedades públicas
    public string Nome { get { return _nome; } }
    public string Texto { get { return _texto; } }

    public Comentario(string nome, string texto)
    {
        _nome = nome;
        _texto = texto;
    }
}