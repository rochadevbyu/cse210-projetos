using System;
using System.Collections.Generic;

public class Video
{
    private string _titulo;
    private string _autor;
    private int _duracao;
    
    public List<Comentario> Comentarios { get; set; }

    public string Titulo { get { return _titulo; } }
    public string Autor { get { return _autor; } }
    public int Duracao { get { return _duracao; } }

    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
        Comentarios = new List<Comentario>(); 
    }

    public int RetornarQuantidadeComentarios()
    {
        return Comentarios.Count;
    }
}