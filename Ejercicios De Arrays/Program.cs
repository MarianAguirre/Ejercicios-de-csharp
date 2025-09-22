using Helpers;

class Arrays
{
  void Array1()
  {
    string[] primerArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
    Console.WriteLine(string.Join(" ", primerArray));
  }

  void Array2()
  {
    int[] arrayPosiciones = new int[10];
    for (int i = 0; i < arrayPosiciones.Length; i++)
    {
      int valores = EntradaHelper.PedirEntero($"Ingresa 10 valores, ahora estas en el valor {i}...");
      arrayPosiciones[i] = valores;

    }
    Console.WriteLine("Mostrando datos...");
    for (int i = 0; i < arrayPosiciones.Length; i++)
    {
      Console.WriteLine(arrayPosiciones[i]);
    }
  }

  void Array3()
  {
    int[] segundo = { 1, 2, 3 };
    int suma = 0;
    for (int i = 0; i < segundo.Length; i++)
    {
      suma += segundo[i];
    }
    Console.WriteLine($"El resultado de la suma del array {string.Join(", ", segundo)} es = {suma}");
  }

  void Array4()
  {
    int[] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    double media = 0;
    for (int i = 0; i < valores.Length; i++)
    {
      media += valores[i];
    }
    media = media / valores.Length;
    Console.WriteLine($"La media del array {string.Join(", ", valores)} es = {media}");
  }

  void Array5()
  {
    int[] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] resultados = new int[valores.Length];
    int valor = EntradaHelper.PedirEntero("Ingrese un número...");

    for (int i = 0; i < valores.Length; i++)
    {
      resultados[i] = valores[i] * valor;

    }
    Console.WriteLine($"El resultado de multiplicar {valor} con el array {string.Join(", ", valores)} es: ");
    Console.WriteLine($"{string.Join(", ", resultados)}");
  }

  void Array6()
  {
    int[] valores = { 4, 3, 7, 10, 1, 5, 7 };
    Console.WriteLine($"Array orginal: {string.Join(", ", valores)} ");
    Array.Sort(valores);
    Console.WriteLine($"Array ordenado: {string.Join(", ", valores)}");
  }

  void Array7()
  {
    int[] valores = { 4, 3, 7, 10, 100, 5, 7 };
    Console.WriteLine($"Array: {string.Join(", ", valores)} ");
    // Array.Sort(valores);
    int minimo = valores.Min();
    int mayor = valores.Max();
    Console.WriteLine($"Menor: {minimo}");
    Console.WriteLine($"Mayor: {mayor}");
  }
  static void Main(string[] args)
  {
    string opcion;

    Arrays resolucion = new Arrays();

    Console.WriteLine("EJERCICIOS CON ARRAYS");
    do
    {
      Console.WriteLine("=========================");
      for (int ea = 1; ea <= 7; ea++)
      {
        Console.Write($"{ea}) ");
      }
      opcion = EntradaHelper.PedirTexto("\nElige un numero para ver el ejercicio...");

      switch (opcion)
      {
        case "1":
          Console.WriteLine("1) Crea un array de 10 posiciones, con valores puestos por ti y muestra el array.");
          resolucion.Array1();
          break;
        case "2":
          Console.WriteLine("2) Crea un array de 10 posiciones, pide los valores por consola y muestra el array.");
          resolucion.Array2();
          break;
        case "3":
          Console.WriteLine("3) Sumar los valores de un array y mostrar el resultado.");
          resolucion.Array3();
          break;
        case "4":
          Console.WriteLine("4) Hacer la media de los valores de un array y mostrar el resultado.");
          resolucion.Array4();
          break;
        case "5":
          Console.WriteLine("5) Pedir un numero por teclado y multiplicar todos los valores de un array y mostrar el array.");
          resolucion.Array5();
          break;
        case "6":
          Console.WriteLine("6) Dado un array de numeros con el metodo Sort, ordenalos y muestra su contenido.");
          resolucion.Array6();
          break;
        case "7":
          Console.WriteLine("7)  Dado un array de números, muestra el mayor y el menor.");
          resolucion.Array7();
          break;
        default:
          Console.WriteLine("OPCION INVALIDA");
          break;
      }

    } while (opcion != "7");
  }
}
