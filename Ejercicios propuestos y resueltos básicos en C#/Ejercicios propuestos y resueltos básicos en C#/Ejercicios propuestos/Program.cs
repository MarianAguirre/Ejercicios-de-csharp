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
    }
    else
    {
      Console.WriteLine($"{numero2} es mayor que {numero1}");
    }
  }

  public static void Main(string[] args)
  {
    Console.WriteLine("EJERCICIOS PRACTICOS");
    Ejercicios resolucion = new Ejercicios();
    Console.WriteLine(@"1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.");
    resolucion.Ejercicio1();
    Console.WriteLine("=======================================");
    Console.WriteLine("=======================================");
    Console.WriteLine(@"2) Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) y mostrar por pantalla, el siguiente mensaje «Hola » <nombre> » bienvenido a » <ciudad>");
    Console.WriteLine(@"3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: «Te llamas » <nombre> » y tienes » <años> » años»");
    resolucion.Ejercicio3();
    Console.WriteLine("=======================================");
    Console.WriteLine("=======================================");
    Console.WriteLine(@"4) Pedir dos números al usuario por teclado y decir que número es el mayor.");
    resolucion.Ejercicio4();
    
  }
}