using EjerciciosDePOO;
using Helpers;

namespace POO
{
  class POO
  {
    static void Main(string[] args)
    {
      Console.WriteLine("EJERCICIOS DE POO");
      POO solucion = new POO();
      string opcion = "";
      do
      {
        Console.WriteLine("================================================");
        for (int i = 1; i < 7; i++)
        {
          Console.Write($"{i}) ");
        }
        opcion = EntradaHelper.PedirTexto("\nIngrese el numero de ejercicios que desea ver...");
        Console.WriteLine("================================================");

        switch (opcion)
        {
          case "1":
            solucion.Ejercicio1();
            break;
          default:
            Console.WriteLine("OPCION INVALIDA");
            break;
        }
      } while (opcion != "7");

    }

    public void Ejercicio1()
    {
      Console.WriteLine(@"Crea una clase Coche con las siguientes propiedades:
– ID
– Marca
– Modelo
– KM
– Precio

Debemos crear un constructor donde le pasemos los valores.
Crea sus get y set de cada propiedad.
Crea el metodo toString.");
      Coche coche1 = new Coche(1, "Mustang", "3", "150km", 90000);
      Console.WriteLine("Clase coche con las propiedades:");
      Console.WriteLine(coche1.ToString());
      Console.WriteLine("Cambio del precio");
      coche1.precio = 4;
      Console.WriteLine(coche1.ToString());
    }
  }
}