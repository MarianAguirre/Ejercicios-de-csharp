class CajeroAutomatico
{
  double saldo = 10000;

  void Menu()
  {
    string opcion;
    do
    {
      Console.Clear();
      Console.WriteLine(@"=======Selecciones la operacion=====
      1.Consultar saldo
      2.Depositar
      3.Retirar
      4.Salir"
      );
      Console.WriteLine("Seleccione una opcion");
      opcion = Console.ReadLine() ?? "";

      switch (opcion)
      {
        case "1":
          ConsultarSaldo();
          break;
        case "2":
          Depositar();
          break;
        case "3":
          Retirar();
          break;
        case "4":
          Salir();
          break;
        default:
          Console.WriteLine("OPCION NO VALIDA. PRESIONES ENTER PARA CONTINUAR...");
          Console.ReadKey();
          break;
      }
    } while (opcion != "4");

    void ConsultarSaldo()
    {
      Console.Clear();
      Console.WriteLine($"SALDO ACTUAL: {saldo}");
      OtraOperacion();
    }
    void Depositar()
    {
      Console.WriteLine("Ingrese el monto a depositar...");
      double monto = Convert.ToDouble(Console.ReadLine());
      if (monto <= 0)
      {
        Console.WriteLine("MONTO INVALIDO. NO DEBE SER 0, INTENTE DE NUEVO");
        Depositar();
      }
      else
      {
        saldo += monto;
        Console.WriteLine($"Deposito correctamente, nuevo saldo: ${saldo}");
        OtraOperacion();
      }
    }

    void Retirar()
    {
      Console.WriteLine("Ingrese el monto a retirar...");
      double retiro = Convert.ToDouble(Console.ReadLine());
      if (retiro == 0)
      {
        Console.WriteLine("MONTO INVALIDO. NO PUEDE SER 0, INTENTE DE NUEVO");
        Retirar();
      }
      if (retiro > saldo)
      {
        Console.WriteLine("FONDOS INSUFICIENTES. INTENTE DE NUEVO");
        Retirar();
      }
      else
      {
        saldo -= retiro;
        Console.WriteLine($"Retiro completo, nuevo saldo: ${saldo}");
        OtraOperacion();
      }
    }

    void Salir()
    {
      Console.WriteLine(@"      =====================
      GRACIAS POR USAR NUESTROS SERVICIOS
      ===================================
      ");
      Environment.Exit(0);
    }

    void OtraOperacion()
    {
      Console.WriteLine("\n DESEA REALIZAR OTRA OPERACION? (1=SI / 2=NO)");
      int respuesta = Convert.ToInt32(Console.ReadLine());
      if (respuesta == 1)
      {
        Menu();
      }
      else
      {
        Salir();
      }
    }
  }


  static void Main(string[] args)
  {
    CajeroAutomatico cajero = new CajeroAutomatico();
    cajero.Menu();
  }
}