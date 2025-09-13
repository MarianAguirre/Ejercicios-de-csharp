class Ejercicios
{
  void Ejercicio1()
  {
    int valor1 = 1;
    int valor2 = 2;
    int valor3 = 3;
    int resultado = valor1 + valor2 + valor3;
    Console.WriteLine($"El resultado de la suma de {valor1} + {valor2} + {valor3} es igual a = {resultado}");
  }

  public string Ejercicio2()
  {
    Console.WriteLine("Por favor ingresa un nombre...");
    string nombre = Console.ReadLine() ?? "";
    Console.WriteLine("Ahora escriba el nombre de una ciudad... ");
    string ciudad = Console.ReadLine() ?? "";
    Console.WriteLine($"Hola {nombre} bienvenido a {ciudad}");
    return nombre;
  }

  void Ejercicio3()
  {
    Console.WriteLine("Ingresa tu edad...");
    int edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Te llamas {Ejercicio2()} y tienes {edad} años");
  }

  void Ejercicio4()
  {
    Console.WriteLine("Ingresa un numero...");
    int numero1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingresa un segundo numero...");
    int numero2 = Convert.ToInt32(Console.ReadLine());
    if (numero1 >= numero2)
    {
      Console.WriteLine($"{numero1} es mayor que {numero2}");
    } else if (numero1 == numero2) {
      Console.WriteLine("Los dos numeros son iguales");
    }
    else
    {
      Console.WriteLine($"{numero2} es mayor que {numero1}");
    }
  }

  void Ejercicio5()
  {
    string[] dias = { "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES" };
    Console.WriteLine("Escribe el nombre del día...");
    string dia = Console.ReadLine() ?? "";
    if ((dia.ToUpper() == "SABADO") || ( dia.ToUpper() == "DOMINGO"))
    {
      Console.WriteLine($"{dia.ToUpper()} es un dia de fin de semana");
    } else if (dias.Contains(dia.ToUpper()))
    {
      Console.WriteLine($"{dia.ToUpper()} es un dia de entre semana");
    }
    else
    {
      Console.WriteLine("No es un dia valido");
    }
    
  }

  void Ejercicio6()
  {
    Console.WriteLine("Escribe el precio del producto....");
    double precio = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(@"Elige la forma de pago:
1) Efectivo
2) Tarjeta
");
    int formaPago = Convert.ToInt32(Console.ReadLine());

    if (precio < 0)
    {
      Console.WriteLine("No es un precio valido");
      Ejercicio6();
    }
    else if (formaPago == 2)
    {
      Console.WriteLine("Ingrese el numero de cuenta....");
      string cuenta = Console.ReadLine() ?? "";
      Console.WriteLine($"El producto con precio {precio} a sido pagado con la tarjeta {cuenta}");
    }
    else if (formaPago == 1)
    {
      Console.WriteLine($"El producto con precio {precio} a sido pagado");
    }
    else
    {
      Console.WriteLine("La forma de pago no es correcta");
    }
  }

  void Ejercicio7()
  {
    for (int i = 1; i <= 100; i++)
    {
      Console.WriteLine(i);
    }
  }

  void Ejercicio8()
  {
    int numero = 1;
    while (numero <= 100)
    {
      Console.WriteLine(numero);
      numero++;
    }
  }

  void Ejercicio9()
  {
    for (int a = 0; a <= 100; a+=2)
    {
      Console.WriteLine(a);
    }
  }

  void Ejercicio10()
  {
    for (int b = 0; b <= 100; b++)
    {
      if ((b%2==0) || (b%3==0))
      {
        Console.WriteLine(b);
      }
    }
  }

  public static void Main(string[] args)
  {
    string opcion;
    
    Console.WriteLine("EJERCICIOS PRACTICOS");
    Ejercicios resolucion = new Ejercicios();
    do
    {
      Console.WriteLine("=================================");
      Console.WriteLine("Elige un numero para ver el ejercicio... ");
      for (int e = 1; e <= 10; e++)
      {
        Console.WriteLine(e);
      }
      opcion = Console.ReadLine() ?? "";
      switch (opcion)
      {
        case "1":
          Console.WriteLine(@"1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.");
          resolucion.Ejercicio1();
          break;
        case "2":
          Console.WriteLine(@"2) Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) y mostrar por pantalla, el siguiente mensaje «Hola » <nombre> » bienvenido a » <ciudad>");
          resolucion.Ejercicio2();
          break;
        case "3":
          Console.WriteLine(@"3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: «Te llamas » <nombre> » y tienes » <años> » años»");
          resolucion.Ejercicio3();
          break;
        case "4":
          Console.WriteLine(@"4) Pedir dos números al usuario por teclado y decir que número es el mayor.");
          resolucion.Ejercicio4();
          break;
        case "5":
          Console.WriteLine(@"5) Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo.");
          resolucion.Ejercicio5();
          break;
        case "6":
          Console.WriteLine(@"6) Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado)");
          resolucion.Ejercicio6();
          break;
        case "7":
          Console.WriteLine(@"7) Recorre los números del 1 al 100. Usa un bucle for.");
          resolucion.Ejercicio7();
          break;
        case "8":
          Console.WriteLine(@"8) Recorre los números del 1 al 100. Usa un bucle while.");
          resolucion.Ejercicio8();
          break;
        case "9":
          Console.WriteLine(@"9) Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.");
          resolucion.Ejercicio9();
          break;
        case "10":
          Console.WriteLine(@"10) Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.");
          resolucion.Ejercicio10();
          break;
        default:
        Console.WriteLine("OPCION NO VALIDA. PRESIONES ENTER PARA CONTINUAR...");
          Console.ReadKey();
          break;
      }
      
    } while (opcion != "10");
  }
}