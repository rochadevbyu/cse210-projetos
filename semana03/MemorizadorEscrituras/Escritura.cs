using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] partes = texto.Split(' ');
        foreach (string parte in partes)
        {
            _palavras.Add(new Palavra(parte));
        }
    }

    public void OcultarPalavrasAleatorias(int qtdOcultada)
    {
        Random random = new Random();
        
        List<Palavra> palavrasVisiveis = new List<Palavra>();
        foreach (Palavra p in _palavras)
        {
            if (!p.EstaOculta())
            {
                palavrasVisiveis.Add(p);
            }
        }

        int ocultadas = 0;
        while (ocultadas < qtdOcultada && palavrasVisiveis.Count > 0)
        {
            int index = random.Next(palavrasVisiveis.Count);
            palavrasVisiveis[index].Ocultar();
            palavrasVisiveis.RemoveAt(index); 
            ocultadas++;
        }
    }

    public string ObterTextoExibicao()
    {
        string texto = "";
        foreach (Palavra p in _palavras)
        {
            texto += p.ObterTextoExibicao() + " ";
        }
        
        return $"{_referencia.ObterTextoExibicao()} {texto.Trim()}";
    }

    public bool TodasPalavrasOcultas()
    {
        foreach (Palavra p in _palavras)
        {
            if (!p.EstaOculta())
            {
                return false;
            }
        }
        return true; 
    }
}