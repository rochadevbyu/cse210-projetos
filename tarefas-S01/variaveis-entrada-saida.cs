using System;

class Program {
    static void Main() {
        Console.Write("Qual é o seu nome? ");
        string nome = Console.ReadLine();
        
        Console.Write("Qual é o seu sobrenome? ");
        string sobrenome = Console.ReadLine();
        
        Console.WriteLine($"Seu nome é {sobrenome}, {nome} {sobrenome}.");
    }
}