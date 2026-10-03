using System;
using System.Collections.Generic;

class Program
{
   static void Main(string[] args)
    {
        List<Video> listaDeVideos = new List<Video>();

        // VÍDEO 1
        Video video1 = new Video("Aprenda C# em 10 minutos", "João Programador", 600);
        video1.Comentarios.Add(new Comentario("Thiago", "Muito bom, me ajudou bastante!"));
        video1.Comentarios.Add(new Comentario("Lohan", "Excelente didática."));
        video1.Comentarios.Add(new Comentario("Pedro", "Poderia fazer um sobre classes?"));
        video1.Comentarios.Add(new Comentario("Roberto", "Eu estava realmente precisando de um vídeo assim, obrigado!"));
        listaDeVideos.Add(video1);

        // VÍDEO 2 
        Video video2 = new Video("O que é Abstração?", "Maria Silva", 450);
        video2.Comentarios.Add(new Comentario("Ana", "Ficou muito claro agora. Por favor, faça um vídeo sobre herança."));
        video2.Comentarios.Add(new Comentario("Carlos", "Gostei dos exemplos práticos. Agora entendi melhor o conceito de abstração."));
        video2.Comentarios.Add(new Comentario("Beatriz", "Pode dar mais exemplos no próximo vídeo? Mas ficou ótimo!"));
        video2.Comentarios.Add(new Comentario("Fernanda", "Muito bom, obrigado! Você é uma ótima professora."));
        listaDeVideos.Add(video2);

        // VÍDEO 3
        Video video3 = new Video("O que é Herança?", "Roberto Rocha", 900);
        video3.Comentarios.Add(new Comentario("Lucas", "Agora entendi melhor o conceito de herança. Obrigado!"));
        video3.Comentarios.Add(new Comentario("Mariana", "Gostei muito do vídeo, ficou bem explicado."));
        video3.Comentarios.Add(new Comentario("João", "Excelente didática! Agora ficou claro para mim."));
        video3.Comentarios.Add(new Comentario("Carla", "Muito bom, obrigado! Vou me preparar bem melhor para a prova agora."));
        listaDeVideos.Add(video3);

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