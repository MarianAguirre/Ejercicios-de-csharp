using System;

namespace EjerciciosDePOO;

public class Aleatorios
{
  public Random random { get; set; }

  public Aleatorios()
  {
    this.random = new Random();
  }

  public int numeroEntreDosNumeros(int numero1, int numero2)
  {
    int numeroGenerado = random.Next(numero1, numero2);
    return numeroGenerado;
  }

  public string arrayDeNumeros(int numero1, int numero2, int sizeArray)
  {
    int[] arrayGenerado = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
      arrayGenerado[i] = random.Next(numero1, numero2);
    }
    return string.Join(", ", arrayGenerado);
  }

  public string arrayDeNumerosNoRepetidos(int numero1, int numero2, int sizeArray)
  {
    bool repetido;
    int[] arrayGenerado = new int[sizeArray];
    int numeroGenerado;
    int indice = 0;
    if ((numero1 | numero2) > sizeArray)
    {
      while (indice < arrayGenerado.Length)
      {
        repetido = false;
        numeroGenerado = numeroEntreDosNumeros(numero1, numero2);
        for (int i = 0; i < indice; i++)
        {
          if (arrayGenerado[i] == numeroGenerado)
          {
            repetido = true;
          }
        }
          if (!repetido)
          {
            arrayGenerado[indice] = numeroGenerado;
            indice++;
          }
      }

    }
    else
    {
      return ("No es posible genera un array asi, el tamaño del primer o segundo numero debe ser mas grande que el tamaño del array");
    }
    return ($"El array aleatorio entre {numero1} y {numero2} con tamaño en el array de {sizeArray} es {string.Join(", ", arrayGenerado)}");
  }
}
