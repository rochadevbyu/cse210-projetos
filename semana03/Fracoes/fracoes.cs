using System;

public class Fracoes
{
    private int _numerador;
    private int _denominador;

    public Fracoes ()
    {
        _numerador = 1;
        _denominador = 7;
    }

    public Fracoes (int numerador)
    {
        _numerador = numerador;
        _denominador = 1;
    }

    public Fracoes (int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }

   // Getter e Setter para o Numerador
    public int ObterNumerador()
    {
        return _numerador;
    }

    public void DefinirNumerador(int numerador)
    {
        _numerador = numerador;
    }

    // Getter e Setter para o Denominador
    public int ObterDenominador()
    {
        return _denominador;
    }

    public void DefinirDenominador(int denominador)
    {
        _denominador = denominador;
    }

    // Método que retorna a fração em formato de texto (ex: "3/4")
    public string ObterFracaoEmTexto()
    {
        // Retorna o numerador e o denominador separados por uma barra
        return _numerador + "/" + _denominador;
    }

    // Método que retorna o valor decimal (ex: 0.75)
    public double ObterFracaoEmDecimal()
    {
        // O (double) garante que a divisão seja decimal e não inteira
        return (double)_numerador / (double)_denominador;
    }

}



