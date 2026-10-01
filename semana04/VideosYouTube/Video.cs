using System;
using System.Collections.Generic; // Necessário para usar a List<>

public class Video
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Duracao { get; set; }
    
    public List<Comentario> Comentarios { get; set; }

    public Video(string titulo, string autor, int duracao)
    {
        Titulo = titulo;
        Autor = autor;
        Duracao = duracao;
        // Inicializamos a lista para ela não ficar "nula"
        Comentarios = new List<Comentario>(); 
    }

    public int RetornarQuantidadeComentarios()
    {
        return Comentarios.Count;
    }
}