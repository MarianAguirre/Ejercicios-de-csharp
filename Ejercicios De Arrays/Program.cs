class Arrays
{
  void Array1()
  {
    string[] primerArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
    Console.WriteLine(string.Join(" ",primerArray));
  }
  static void Main(string[] args)
  {
    string opcion;
    Arrays resolucion = new Arrays();

    Console.WriteLine("EJERCICIOS CON ARRAYS");
    do
    {
      Console.WriteLine("=========================");
      Console.WriteLine("Elige un numero para ver el ejercicio...");
      for (int ea = 1; ea <= 7; ea++)
      {
        Console.WriteLine(ea);
      }
      opcion = Console.ReadLine() ?? "";

      switch (opcion)
      {
        case "1":
          Console.WriteLine("1) Crea un array de 10 posiciones, con valores puestos por ti y muestra el array.");
          resolucion.Array1();
          break;
        default:
          Console.WriteLine("OPCION INVALIDA");
          break;
      }

    } while (opcion != "7");
  }
}
