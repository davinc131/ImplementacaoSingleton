using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementacaoSingleton.PadraoSingleton
{
  public class CalcularValores
  {
    private static CalcularValores _instance;

    private CalcularValores() { }

    public static CalcularValores Instance
    {
      get
      {
        if (_instance == null)
          _instance = new CalcularValores();
        return _instance;
      }
    }

    public int Somar(int valor1, int valor2)
    {
      return valor1 + valor2;
    }

    public int Subtrair(int valor1, int valor2)
    {
      return valor1 - valor2;
    }

    public int Multiplicar(int valor1, int valor2)
    {
      return valor1 * valor2;
    }

    public int Dividir(int valor1, int valor2)
    {
      return valor1 / valor2;
    }
  }
}
