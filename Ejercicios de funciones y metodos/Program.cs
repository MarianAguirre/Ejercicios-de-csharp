class Funciones
{

  void Funcion1(string nombre)
  {
    Console.WriteLine($"Hola {nombre}");
  }

  public int Funcion2(int numero1, int numero2)
  {
    int resultado = numero1 + numero2;
    return resultado;
  }

  void Funcion3()
  {
    int resultado = 1;
    Console.WriteLine("Ingrese un numero...");
    int numero = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= numero; i++)
    {
      resultado *= i;
    }
    Console.WriteLine($"El factorial de {numero} es = {resultado}");
  }

  int[] Funcion4()
  {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    return array;
  }

  int Funcion5()
  {
    int suma = 0;
    int[] array = { 1, 2, 3 };
    for (int i = 0; i < array.Length; i++)
    {
      suma += array[i];
    }
    return suma;
  }

  int Funcion6()
  {
    int media = 0;
    int[] array = { 1, 2, 3 };
    for (int i = 0; i < array.Length; i++)
    {
      media += array[i];
    }
    media /= array.Length;
    return media;
  }

  int[,] Funcion7(int valor)
  {
    int[,] matriz = new int[valor, valor];

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
      for (int j = 0; j < matriz.GetLength(1); j++)
      {
        Console.Write(matriz[i, j] + " ");
      }
      Console.WriteLine();
    }
    return matriz;
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
      opcion = Console.ReadLine() ?? "";
      switch (opcion)
      {
        case "1":
          Console.WriteLine("1. Crea un método que nos salude, pasándole un nombre por parámetro.");
          Console.WriteLine("Ingrese su nombre...");
          string nombre = Console.ReadLine() ?? "";
          resolucion.Funcion1(nombre);
          break;
        case "2":
          Console.WriteLine("2. Crea una función que sume dos números pasados por parámetros, devolverá el resultado.");
          Console.WriteLine("Ingrese el primer numero...");
          int numero1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Ingrese el segundo numero...");
          int numero2 = Convert.ToInt32(Console.ReadLine());
          int resultado = resolucion.Funcion2(numero1, numero2);
          Console.WriteLine($"El resultado de la suma de {numero1} + {numero2} es = {resultado}");
          break;
        case "3":
          Console.WriteLine("3. Crea una función que calcule el factorial de un número.");
          resolucion.Funcion3();
          break;
        case "4":
          Console.WriteLine("4. Crea una función que muestre un array.");
          int[] array = resolucion.Funcion4();
          Console.WriteLine($"Este es el array que muestra la funcion: {string.Join(", ", array)}");
          break;
        case "5":
          Console.WriteLine("5. Crea una función que devuelva la suma de un array.");
          int suma = resolucion.Funcion5();
          Console.WriteLine($"Esta es la suma del array: {suma}");
          break;
        case "6":
          Console.WriteLine("6. Crea una función que devuelva la media de un array.");
          int media = resolucion.Funcion6();
          Console.WriteLine($"Esta es la media del array: {media}");
          break;
        case "7":
          Console.WriteLine("7. Rellenar una matriz pasada por parámetro con un valor dado.");
          // Console.WriteLine("Ingrese un valor...");
          // int valor = Convert.ToInt32(Console.ReadLine());
          // int[,] matriz = resolucion.Funcion7(valor);
          // Console.WriteLine($"La matriz es :\n{matriz}");
          Console.WriteLine("PENDIENTE");
          break;
        default:
          Console.WriteLine("OPCION INVALIDA");
          break;
      }
    } while (opcion != "18");
  }
}
