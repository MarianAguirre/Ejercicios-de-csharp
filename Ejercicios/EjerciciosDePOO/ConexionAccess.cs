using System;
using System.Data;

namespace EjerciciosDePOO;

public class ConexionAccess
{
  public bool estadoBD { get; set; }
  // private OleDbConnection connection { get; set; };
  public ConexionAccess()
  {
    this.estadoBD = false;
    // this.connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|" + path)
  }

  public void Open()
  {
    this.estadoBD = true;
    Console.WriteLine("Base de datos abierta");

  }

  public void Close()
  {
    this.estadoBD = false;
    Console.WriteLine("Base de datos cerrada");

  }

  // public DataSet executeQuery(string sql)
  // {
  //   DataSet d = new DataSet();
  //           adapter.Fill(d);

  //           return d;
  // }

  public string EstadoBDActual()
  {
    if (estadoBD)
    {
      return "Abierta";
    }
    else
    {
      return "Cerrada";
    }
  }
}
