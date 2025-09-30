using System;

namespace EjerciciosDePOO;

public class Carro : Vehiculo
{
  public bool airbag { get; set; }
  public Carro(int id, string marca, string modelo, string km, double precio, bool airbag) : base(id, marca, modelo, km, precio)
  {
    this.airbag = airbag;
  }

  public override double precio
  {
    get
    {
      if (this.airbag)
      {
        return base.precio + 200;
      }
      else
      {
        return base.precio;
      }
    }
  }

  public override string ToString()
  {
    if (this.airbag)
    {
      return base.ToString() + " y tiene Airbag";
    }
    else
    {
      return base.ToString() + ", no tiene Airbag";
    }
  }

}
