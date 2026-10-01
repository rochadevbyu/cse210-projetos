using System;

public class Comentario
{
    // Atributos
    public string Nome { get; set; }
    public string Texto { get; set; }

    // Construtor
    public Comentario(string nome, string texto)
    {
        Nome = nome;
        Texto = texto;
    }
}