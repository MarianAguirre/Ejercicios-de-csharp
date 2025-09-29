using System;

namespace EjerciciosDePOO;

public class Ordenador
{
  public int tamanioDisco { get; set; }
  public int tamanioDiscoMaximo { get; set; }
  public bool encendido { get; set; }

  public Ordenador(int tamanioDiscoMaximo)
  {
    this.tamanioDisco = 0;
    this.tamanioDiscoMaximo = tamanioDiscoMaximo;
    this.encendido = false;
  }

  public void agregarDatos(int datos)
  {
    if (this.encendido)
    {
      if (datos <= 0)
      {
        Console.WriteLine("Los datos no pueden ser 0");
      }
      else if (this.tamanioDisco + datos >= this.tamanioDiscoMaximo)
      {
        this.tamanioDisco = this.tamanioDiscoMaximo;
        Console.WriteLine("No es posible agregar mas datos");
      }
      else
      {
        this.tamanioDisco += datos;
        Console.WriteLine("Datos agregados");
      }
    }
    else
    {

      Console.WriteLine("Primero enciende el ordenador");
    }
  }

  public void eliminarDatos(int datos)
  {
    if (this.encendido)
    {
      if (this.tamanioDisco - datos < 0)
      {
        this.tamanioDisco = 0;
        Console.WriteLine("No es posible eliminar mas datos, ya esta vacio");
      }
      else if (datos < 0)
      {
        Console.WriteLine("Los datos no pueden ser 0");
      }
      else
      {

        this.tamanioDisco -= datos;
        Console.WriteLine("Datos eliminados");
      }
    }
    else
    {

      Console.WriteLine("Primero enciende el ordenador");
    }
  }

  public void encender()
  {
    this.encendido = true;
  }

  public void apagar()
  {
    this.encendido = false;
  }

  public int tamanioDiscoActual()
  {
    return this.tamanioDisco;
  }

  public string estado()
  {
    string estado = "Apagado";
    if (encendido)
    {
      estado = "Encendido";
      return estado;
    }
    else
    {
      return estado;
    }
  }

}
