using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> numeros = new List<int>();
        int numero = -1;

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");
        while (numero != 0) {
            Console.Write("Insira o número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero != 0) numeros.Add(numero);
        }

        int soma = 0;
        int maximo = numeros[0];

        foreach (int num in numeros) {
            soma += num;
            if (num > maximo) maximo = num;
        }

        double media = (double)soma / numeros.Count;

        Console.WriteLine($"A soma é: {soma}");
        Console.WriteLine($"A média é: {media}");
        Console.WriteLine($"O maior número é: {maximo}");
    }
}