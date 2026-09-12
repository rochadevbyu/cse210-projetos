using System;

class Program {
    static void Main() {
        Random geradorAleatorio = new Random();
        int numeroMagico = geradorAleatorio.Next(1, 101);
        int palpite = -1;

        while (palpite != numeroMagico) {
            Console.Write("Qual é o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            if (palpite > numeroMagico) Console.WriteLine("Mais baixo");
            else if (palpite < numeroMagico) Console.WriteLine("Mais alto");
            else Console.WriteLine("Você adivinhou!");
        }
    }
}