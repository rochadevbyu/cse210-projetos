using System;

class Program
{
    static void Main(string[] args)
    {
        List<Figura> listaDeFiguras = new List<Figura>();

        listaDeFiguras.Add(new Quadrado("Vermelho", 3));
        listaDeFiguras.Add(new Retangulo("Azul", 4, 5));
        listaDeFiguras.Add(new Circulo("Verde", 6));

        foreach (Figura figura in listaDeFiguras)
        {
            string cor = figura.ObterCor();
            double area = figura.ObterArea();

            Console.WriteLine($"A figura da cor {cor} tem uma área de {area:F2}.");
        }
    }
}
