using System;
using ImplementacaoSingleton.PadraoSingleton;

namespace ImplementacaoSingleton
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.Write("Informe o primeiro valor: ");
        string valor1 = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Informe o segundo valor: ");
        string valor2 = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Selecione o tipo de operação - Soma(1), Subtração(2), Multiplicação(3), Divisão(4): ");
        string tipoOperacao = Console.ReadLine();

        switch (tipoOperacao)
        {
          case "1":
            Console.WriteLine("Resultado: " + CalcularValores.Instance.Somar(int.Parse(valor1), int.Parse(valor2)));
            break;
          case "2":
            Console.WriteLine("Resultado: " + CalcularValores.Instance.Subtrair(int.Parse(valor1), int.Parse(valor2)));
            break;
          case "3":
            Console.WriteLine("Resultado: " + CalcularValores.Instance.Multiplicar(int.Parse(valor1), int.Parse(valor2)));
            break;
          case "4":
            Console.WriteLine("Resultado: " + CalcularValores.Instance.Dividir(int.Parse(valor1), int.Parse(valor2)));
            break;
          default:
            Console.WriteLine("Operação não reconhecida.");
            break;
        }
        Console.ReadKey();
      }
    }
  }
}
