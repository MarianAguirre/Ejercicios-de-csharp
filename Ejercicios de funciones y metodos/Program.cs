using Microsoft.VisualBasic;

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

  int[,] Funcion7(int valor, int size)
  {
    int[,] matriz = new int[size, size];

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
      for (int j = 0; j < matriz.GetLength(1); j++)
      {
        matriz[i, j] = valor;
      }
      Console.WriteLine();
    }
    return matriz;
  }

  string[,] Funcion8(string cadena)
  {
    string[,] matriz = new string[3, 3];

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
      for (int j = 0; j < matriz.GetLength(1); j++)
      {
        matriz[i, j] = cadena;
      }
      Console.WriteLine();
    }
    return matriz;
  }

  bool Funcion9(int fila, int columna, int[,] matriz)
  {
    return fila >= 0 && columna < matriz.GetLength(0)
    && columna >= 0 && fila < matriz.GetLength(1);
  }

  void Funcion10()
  {
    Console.WriteLine(@"Ingrese el numero de acuerdo a lo que necesite 
1) Decimal a binario
2) Binario a decimal");
    int seleccion = Convert.ToInt32(Console.ReadLine());
    if (seleccion == 1)
    {
      Console.WriteLine("Por favor ingrese un numero");
      int numeroDecimal = Convert.ToInt32(Console.ReadLine());
      double binarioSolucion = Funcion10DB(numeroDecimal);
      Console.WriteLine($"El numero {numeroDecimal} en binario es {binarioSolucion}");
    }
    else if (seleccion == 2)
    {
      Console.WriteLine("Por favor ingrese un binario");
      int numeroBinario = Convert.ToInt32(Console.ReadLine());
      double decimalSolucion = Funcion10BD(numeroBinario);
      Console.WriteLine($"El binario {numeroBinario} en decimal es {decimalSolucion}");
    }
    else
    {
      Console.WriteLine("Opcion invalidad");
      Funcion10();
    }
  }

  double Funcion10DB(int numeroDecimal)
  {
    double binario=0;
    for (int i = numeroDecimal, j = 0; i > 0; i /= 2, j++)
    {
      numeroDecimal = i % 2;
      binario += numeroDecimal * Math.Pow(10, j);
    }
    return binario; 
  }

  double Funcion10BD(int numeroBinario)
  {
    double decimalN = 0;
    for (int i = numeroBinario, j = 0; i > 0; i /= 10, j++)
    {
      numeroBinario = i % 10;
      if (numeroBinario != 0 && numeroBinario != 1)
      {
        return -1;
      }
      decimalN += numeroBinario * Math.Pow(2, j);
    }
    return decimalN;
  }

  void Funcion11()
  {
    Console.WriteLine(@"Ingrese el numero de acuerdo a lo que necesite 
1) Decimal a octal
2) Octal a decimal");
    int seleccion = Convert.ToInt32(Console.ReadLine());
    if (seleccion == 1)
    {
      Console.WriteLine("Por favor ingrese un numero");
      int numeroDecimal = Convert.ToInt32(Console.ReadLine());
      double octalSolucion = Funcion11DO(numeroDecimal);
      Console.WriteLine($"El numero {numeroDecimal} en octal es {octalSolucion}");
    }
    else if (seleccion == 2)
    {
      Console.WriteLine("Por favor ingrese un octal");
      int numeroOctal = Convert.ToInt32(Console.ReadLine());
      double decimalSolucion = Funcion11OD(numeroOctal);
      Console.WriteLine($"El octal {numeroOctal} en decimal es {decimalSolucion}");
    }
    else
    {
      Console.WriteLine("Opcion invalidad");
      Funcion11();
    }
  }

  double Funcion11DO(int numeroDecimal)
  {
    double octal=0;
    for (int i = numeroDecimal, j = 0; i > 0; i /= 8, j++)
    {
      numeroDecimal = i % 8;
      octal += numeroDecimal * Math.Pow(10, j);
    }
    return octal; 
  }

  double Funcion11OD(int numeroOctal)
  {
    double decimalN = 0;
    for (int i = numeroOctal, j = 0; i > 0; i /= 10, j++)
    {
      numeroOctal = i % 10;
      if (!(numeroOctal >= 0 && numeroOctal <= 7))
      {
        return -1;
      }
      decimalN += numeroOctal * Math.Pow(8, j);
    }
    return decimalN;
  }

  void Funcion12()
  {
    Console.WriteLine(@"Ingrese el numero de acuerdo a lo que necesite 
1) Decimal a Hexa
2) Hexa a decimal");
    int seleccion = Convert.ToInt32(Console.ReadLine());
    if (seleccion == 1)
    {
      Console.WriteLine("Por favor ingrese un numero");
      int numeroDecimal = Convert.ToInt32(Console.ReadLine());
      string HexaSolucion = Funcion12DH(numeroDecimal);
      Console.WriteLine($"El numero {numeroDecimal} en hexadecimal es {HexaSolucion}");
    }
    else if (seleccion == 2)
    {
      Console.WriteLine("Por favor ingrese un hexadecimal");
      string numeroHexa = Console.ReadLine() ?? "";
      int decimalSolucion = Funcion12HD(numeroHexa);
      Console.WriteLine($"El hexadecimal {numeroHexa} en decimal es {decimalSolucion}");
    }
    else
    {
      Console.WriteLine("Opcion invalidad");
      Funcion12();
    }
  }

  string Funcion12DH(int numeroDecimal)
  {
    char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };
    string Hexa = "";
    long resto=0;
    for (int i = numeroDecimal, j = 0; i > 0; i /= 16, j++)
    {
     resto = i % 16;
                if (resto >= 10)
                {
                    Hexa = letras[resto - 10] + Hexa;
 
                }
                else
                {
                    Hexa = resto + Hexa;
                }
    }
    return Hexa; 
  }

  int Funcion12HD(string numeroHexa)
  {
    int decimalN = 0;
    for (int i = 0, j = numeroHexa.Length - 1; i < numeroHexa.Length; i++, j--)
    {
      if (numeroHexa[i] >= '0' && numeroHexa[i] <= '9')
                {
                    decimalN += (int)Math.Pow(16, j) * Convert.ToInt32(numeroHexa[i] + "");
                } else if (numeroHexa[i] >= 'A' && numeroHexa[i] <= 'F') {
                    decimalN += (int)Math.Pow(16, j) * Convert.ToInt32((numeroHexa[i] - 'A' + 10) + "");
                }
                else
                {
                    return -1;
                }
    }
    return decimalN;
  }

  int Funcion14()
  {
    int[] array = { 7, 4, 3, 10, 9, 3, 2, 1, 2 };
    int mayor = array.Max();
    return mayor;
  } 

  int Funcion15()
  {
    int[] array = { 7, 4, 3, 10, 9, 3, 2, 1, -2 };
    int menor = array.Min();
    return menor;
  } 

  int Funcion16(int[] array)
  {
    int posicion = array[0];
    int indice = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] > posicion)
      {
        posicion = array[i];
        indice = i;
      }
    }
    return indice;
  } 

  int Funcion17(int[] array)
  {
    int posicion = array[0];
    int indice = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] < posicion)
      {
        posicion = array[i];
        indice = i;
      }
    }
    return indice;
  }

  int Funcion18(int numero)
  {
    int factorial = 1;
    for (int i = 1; i <= numero; i++)
    {
      factorial *= i ;

    }
    return factorial;
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
          Console.WriteLine("Ingrese el tamaño de la matriz...");
          int size = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Ingrese el numero que llenara la matriz...");
          int valor = Convert.ToInt32(Console.ReadLine());

          int[,] matriz = resolucion.Funcion7(valor, size);

          Console.WriteLine("La matriz es: ");
          for (int i = 0; i < matriz.GetLength(0); i++)
          {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
              Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
          }
          break;
        case "8":
          Console.WriteLine("8. Mostrar una matriz pasada por parámetro.");
          Console.WriteLine("Ingrese una palabra o caracter...");
          string cadena = Console.ReadLine() ?? "";
          string[,] matrizCadena = resolucion.Funcion8(cadena);

          Console.WriteLine("La matriz es: ");
          for (int i = 0; i < matrizCadena.GetLength(0); i++)
          {
            for (int j = 0; j < matrizCadena.GetLength(1); j++)
            {
              Console.Write(matrizCadena[i, j] + "\t");
            }
            Console.WriteLine();
          }
          break;
        case "9":
          Console.WriteLine("9. Indicar si una posición (fila y columna) esta dentro de una matriz.");
          Console.WriteLine("Ingresa un numero de columna...");
          int columna = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Ingresa un numero de fila...");
          int fila = Convert.ToInt32(Console.ReadLine());

          int[,] matrizPosicion = new int[4, 3];
          Console.WriteLine($"La posicion columna ({columna}) con fila ({fila}) es: " + resolucion.Funcion9(fila, columna, matrizPosicion));
          break;
        case "10":
          Console.WriteLine("10. Dado un numero decimal, pásalo a binario. Haz otra función que dado un binario, nos devuelva su numero decimal.");
          resolucion.Funcion10();
          break;
        case "11":
          Console.WriteLine("11. Dado un numero decimal, pásalo a octal y viceversa.");
          resolucion.Funcion11();
          break;
        case "12":
          Console.WriteLine("12. Dado un numero decimal, pásalo a hexadecimal y viceversa.");
          resolucion.Funcion12();
          break;
        case "13":
          Console.WriteLine("13. Realiza una función que dado un numero y dos bases. Que convierta un numero a otra base.");
          Console.WriteLine("SIN SOLUCION POR EL MOMENTO");
          break;
        case "14":
          Console.WriteLine("14. Crea una función que devuelva el número mayor de un array.");
          Console.WriteLine($"El numero mayor del array es {resolucion.Funcion14()}");
          break;
        case "15":
          Console.WriteLine("15. Crea una función que devuelva el número menor de un array.");
          Console.WriteLine($"El numero menor del array es {resolucion.Funcion15()}");
          break;
        case "16":
          Console.WriteLine("16. Crea una función que devuelva la posición del número mayor de un array.");
          int[] arrayPosicionMayor = { 7, 4, 3, -10, 9, 3, 2, 1, 2 };
          int mayorA = arrayPosicionMayor.Max();
          int arrayPMayor = resolucion.Funcion16(arrayPosicionMayor);
          Console.WriteLine($"El array es ({string.Join(", ", arrayPosicionMayor)}) y el numero mayor del array es {mayorA} ocupa la posicion {arrayPMayor}");
          break;
        case "17":
          Console.WriteLine("17. Crea una función que devuelva la posición del número menor de un array.");
          int[] arrayPosicionMenor = { 7, 4, 3, 10, 9, 3, 2, 1, 1 };
          int menorA = arrayPosicionMenor.Min();
          int arrayPMenor = resolucion.Funcion17(arrayPosicionMenor);
          Console.WriteLine($"El array es ({string.Join(", ", arrayPosicionMenor)}) y el numero menor del array es {menorA} ocupa la posicion {arrayPMenor}");
          break;
        case "18":
          Console.WriteLine("18. Crea una función que devuelva el factorial de un número.");
          Console.WriteLine("Ingresa un numero...");
          int numeroAFactorial = Convert.ToInt32(Console.ReadLine());
          int factorial = resolucion.Funcion18(numeroAFactorial);
          Console.WriteLine($"El factorial de {numeroAFactorial} es: {factorial}");
          break;
        default:
          Console.WriteLine("OPCION INVALIDA");
          break;
      }
    } while (opcion != "18");
  }
}
