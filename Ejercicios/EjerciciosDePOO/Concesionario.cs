using System;

namespace EjerciciosDePOO;

public class Concesionario
{

  public Coche[] coches { get; set; }
  public int limiteCoches { get; set; }
  public int numCoches { get; set; }


  public Concesionario(int limiteCoches)
  {
    this.coches = new Coche[limiteCoches];
    this.limiteCoches = limiteCoches;
    this.numCoches = 0;
  }

  public void agregarCoche(Coche c)
  {
    if (c != null && numCoches < limiteCoches)
    {
      coches[numCoches] = c;
      numCoches++;
      int cochesRestantes = numCoches - limiteCoches;
      Console.WriteLine("Coche agregado con exito");
      Console.WriteLine($"Limite disponible: {cochesRestantes}");

    }
    else if (numCoches == limiteCoches)
    {
      Console.WriteLine("Limite de coches alcanzado");
      return;
    }
  }

  public void mostrarCoches()
  {
    for (int i = 0; i < numCoches; i++)
    {
      Console.WriteLine(@$"Coches actuales:
      {coches[i].ToString()}");
    }
  }

  public void vaciarCoches()
  {
    this.coches = new Coche[limiteCoches];
  }

  public void eliminarCoches(Coche c)
  {
    if (c != null && numCoches < limiteCoches)
    {
      int posicion = -1;
      for (int i = 0; i < numCoches; i++)
      {
        if (c.id == coches[i].id)
        {
          posicion = i;
          break;
        }
      }
      if (posicion == -1)
      {
        Console.WriteLine("El coche no existe");
      }
      else
      {
        for (int i = posicion; i < numCoches; i++)
        {
          coches[i] = coches[i + 1];
        }
        coches[numCoches - 1] = null;
      }
    }
  }

  public int ObtenerSiguienteId()
  {
    int id = 1;
    for (int i = 0; i < numCoches; i++)
    {
      id = coches[i].id + 1;
    }
    return id;
  }

  public void eliminarCochesPorId(int id)
  {
        if (id != null && numCoches < limiteCoches)
    {
      int posicion = -1;
      for (int i = 0; i < numCoches; i++)
      {
        if (id == coches[i].id)
        {
          posicion = i;
          break;
        }
      }
      if (posicion == -1)
      {
        Console.WriteLine("El coche no existe");
      }
      else
      {
        for (int i = posicion; i < numCoches; i++)
        {
          coches[i] = coches[i + 1];
        }
        coches[numCoches - 1] = null;
      }
    }
  }

}
