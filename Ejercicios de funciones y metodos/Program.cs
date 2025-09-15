class Funciones
{

  void Funcion1(string nombre)
  {
    Console.WriteLine($"Hola {nombre}");
  }
  static void Main(string[] args)
  {
    Console.WriteLine("EJERCICIOS DE FUNCIONES");
    string opcion;
    Funciones resolucion = new Funciones();
    do
    {
      Console.WriteLine("====================");
      Console.WriteLine("Seleccione un ejercicio...");
      for (int i = 1; i <= 18; i++)
      {
        Console.Write($"{i}) ");
      }
      opcion = Console.ReadLine()?? "";
      switch (opcion)
      {
        case "1":
          Console.WriteLine("1. Crea un método que nos salude, pasándole un nombre por parámetro.");
          Console.WriteLine("Ingrese su nombre...");
          string nombre = Console.ReadLine()??"";
          resolucion.Funcion1(nombre);
          break;
        default:
          Console.WriteLine("OPCION INVALIDA");
          break;
      }
    } while (opcion != "18");
  }
}
