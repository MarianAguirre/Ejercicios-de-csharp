using EjerciciosDePOO;
using Helpers;


namespace POO
{
  class POO
  {
    static void Main(string[] args)
    {
      var ran = new Random();
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
          case "2":
            solucion.Ejercicio2(ran);
            break;
          case "3":
            solucion.Ejercicio3();
            break;
          case "4":
            solucion.Ejercicio4();
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

    public void Ejercicio2(Random ran)
    {
      string opciones;
      int limiteCoches = ran.Next(1, 5);
      int numCoches = 0;
      Concesionario concesionario = new Concesionario(limiteCoches);
      int nuevoId = concesionario.ObtenerSiguienteId();


      do
      {
        Console.WriteLine("Crea una clase Concesionario que gestione una serie de coches. Tendra un array de objetos coches (anterior ejercicio) y un limite de coches.");
        opciones = EntradaHelper.PedirTexto(@$"¿Que quieres hacer?
1) Agregar coche
2) Mostrar coches
3) Vacias coches
4) Eliminar coche
Limite de coches: {limiteCoches}
Coches actuales: {numCoches}
");
        switch (opciones)
        {
          case "1":
            if (limiteCoches != numCoches)
            {
              Coche cocheNuevo = new Coche(nuevoId, "", "", "", 0.0);
              cocheNuevo.marca = EntradaHelper.PedirTexto("Marca...");
              cocheNuevo.modelo = EntradaHelper.PedirTexto("Modelo...");
              cocheNuevo.km = EntradaHelper.PedirTexto("Km...");
              cocheNuevo.precio = EntradaHelper.PedirDouble("Precio...");
              concesionario.agregarCoche(cocheNuevo);
              numCoches++;
            }
            else
            {
              Console.WriteLine("HAZ LLEGADO AL LIMITE PARA AGREGAR COCHES");
            }
            break;
          case "2":
            Console.WriteLine("COCHES ACTUALES");
            concesionario.mostrarCoches();
            break;
          case "3":
            concesionario.vaciarCoches();
            Console.WriteLine("COCHES VACIOS");
            numCoches = 0;
            break;
          case "4":
            int cocheId = EntradaHelper.PedirEntero("Ingresa la id del coche a elimiar...");
            concesionario.eliminarCochesPorId(cocheId);
            Console.WriteLine("Coche eliminado");
            numCoches--;
            break;
          default:
            Console.WriteLine("Opcion invalida");
            break;
        }
      } while (opciones != "5");
    }
    public void Ejercicio3()
    {
      Aleatorios aleatorios = new Aleatorios();
      Console.WriteLine(@"3. Crea una clase Aleatorios
Como atributo tendra un Random.
Tendra los siguientes metodos:
– Generar un numero entre 2 numeros
– Generar un array de numeros entre dos numeros");
      int numero1 = EntradaHelper.PedirEntero("Ingresa el primer numero...");
      int numero2 = EntradaHelper.PedirEntero("Ingresa el segundo numero...");
      int numeroGenerado = aleatorios.numeroEntreDosNumeros(numero1, numero2);

      Console.WriteLine($"El numero aleatorio {numero1} y {numero2} es: {numeroGenerado}");
      int sizeArray = EntradaHelper.PedirEntero("Ingresa el tamaño del array...");
      string arrayGenerado = aleatorios.arrayDeNumeros(numero1, numero2, sizeArray);
      Console.WriteLine($"El array aleatorio {numero1} y {numero2} con tamaño en el array de {sizeArray} es: {arrayGenerado}");
    }

    public void Ejercicio4()
    {
      Aleatorios aleatorios = new Aleatorios();
      Console.WriteLine(@"Usando la clase anterior de Aleatorios
– Generar un array de números no repetidos entre dos números
");
      int numero1 = EntradaHelper.PedirEntero("Ingresa el primer numero...");
      int numero2 = EntradaHelper.PedirEntero("Ingresa el segundo numero...");
      int sizeArray = EntradaHelper.PedirEntero("Ingresa el tamaño del array...");
      string arrayGenerado = aleatorios.arrayDeNumerosNoRepetidos(numero1, numero2, sizeArray);
      Console.WriteLine(arrayGenerado);
    }
  }

}