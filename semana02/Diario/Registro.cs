using System;

public class Registro 
{
  public string _data;
  public string _pergunta;
  public string _resposta;

  public Registro()
  {
    _data = DateTime.Now.ToShortDateString();
  }

  public void Exibir()
  {
    Console.WriteLine($"Data: {_data} - Pergunta: {_pergunta}");
    Console.WriteLine($"Resposta: {_resposta}");
    Console.WriteLine ();
  }
}
