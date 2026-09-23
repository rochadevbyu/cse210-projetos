using System;

class Program
{
    static void Main(string[] args)
    {
        // Testando a fração 1/1
        Fracoes f1 = new Fracoes(1, 1);
        Console.WriteLine(f1.ObterFracaoEmTexto());
        Console.WriteLine(f1.ObterFracaoEmDecimal());

        // Testando a fração 5/1
        Fracoes f2 = new Fracoes(5);
        Console.WriteLine(f2.ObterFracaoEmTexto());
        Console.WriteLine(f2.ObterFracaoEmDecimal());

        // Testando a fração 3/4
        Fracoes f3 = new Fracoes(3, 4);
        Console.WriteLine(f3.ObterFracaoEmTexto());
        Console.WriteLine(f3.ObterFracaoEmDecimal());

        // Testando a fração 1/3
        Fracoes f4 = new Fracoes(1, 3);
        Console.WriteLine(f4.ObterFracaoEmTexto());
        Console.WriteLine(f4.ObterFracaoEmDecimal());
    }
}

