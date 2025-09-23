using Helpers;
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
      opcion = EntradaHelper.PedirTexto("Seleccione una opcion");

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
      double monto = EntradaHelper.PedirDouble("Ingrese el monto a depositar...",0.01);
      // if (monto <= 0)
      // {
      //   Console.WriteLine("MONTO INVALIDO. NO DEBE SER 0, INTENTE DE NUEVO");
      //   Depositar();
      // }
      // else
      // {
        saldo += monto;
        Console.WriteLine($"Deposito correctamente, nuevo saldo: ${saldo}");
        OtraOperacion();
      // }
    }

    void Retirar()
    {
      double retiro = EntradaHelper.PedirDouble("Ingrese el monto a retirar...", 0.01);
      // if (retiro == 0)
      // {
      //   Console.WriteLine("MONTO INVALIDO. NO PUEDE SER 0, INTENTE DE NUEVO");
      //   Retirar();
      // }
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
      Console.WriteLine(@"      ===================================
      GRACIAS POR USAR NUESTROS SERVICIOS
      ===================================
      ");
      Environment.Exit(0);
    }

    void OtraOperacion()
    {
      int respuesta = EntradaHelper.PedirEntero("\n DESEA REALIZAR OTRA OPERACION? (1=SI / 2=NO)",1,2);
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