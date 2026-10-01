using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> listaDeVideos = new List<Video>();

        Video video1 = new Video("Aprenda C# em 10 minutos", "João Programador", 600);
        
        video1.Comentarios.Add(new Comentario("Thiago", "Muito bom, me ajudou bastante!"));
        video1.Comentarios.Add(new Comentario("Lohan", "Excelente didática."));
        video1.Comentarios.Add(new Comentario("Pedro", "Poderia fazer um sobre classes?"));
        video1.Comentarios.Add(new Comentario("Roberto", "Eu estava realmente precisando de um vídeo assim, obrigado!"));

        
        listaDeVideos.Add(video1);

        foreach (Video v in listaDeVideos)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Título: {v.Titulo}");
            Console.WriteLine($"Autor: {v.Autor}");
            Console.WriteLine($"Duração: {v.Duracao} segundos");
            Console.WriteLine($"Número de Comentários: {v.RetornarQuantidadeComentarios()}");
            Console.WriteLine("Comentários:");
            
            foreach (Comentario c in v.Comentarios)
            {
                Console.WriteLine($"- {c.Nome}: {c.Texto}");
            }
            Console.WriteLine("---------------------------------------------\n");
        }
    }
}