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
}
