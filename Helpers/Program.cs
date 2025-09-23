﻿using Validaciones;

namespace Helpers;

public static class EntradaHelper
{
    public static string PedirTexto(string texto)
    {
      string valor = "";
      while (!Validador.StringEsValido(valor))
      {
        Console.WriteLine(texto);
        valor = Console.ReadLine() ?? "";
        if (!Validador.StringEsValido(valor))
        {
          Console.WriteLine("El valor no puede estar vacio");
        }
      }
      return valor;
    }

    public static int PedirEntero(string mensaje, int min = int.MinValue, int max = int.MaxValue)
    {
      int valor;
      bool valido = false;
      do
      {
        Console.WriteLine(mensaje);
        string input = Console.ReadLine() ?? "";
        if (int.TryParse(input, out valor) && Validador.IntEsValido(valor, min, max))
          valido = true;
        else
          Console.WriteLine("Entrada no válida. Intenta de nuevo.");

      } while (!valido);
      return valor;
    }

    public static double PedirDouble(string mensaje, double min = double.MinValue, double max = double.MaxValue)
    {
      double valor;
      bool valido = false;
      do
      {
        Console.WriteLine(mensaje);
        string input = Console.ReadLine() ?? "";
        if (double.TryParse(input, out valor) && Validador.DoubleEsValido(valor, min, max))
          valido = true;
        else
          Console.WriteLine("Entrada no válida. Intenta de nuevo.");

      } while (!valido);
      return valor;
    }
  }