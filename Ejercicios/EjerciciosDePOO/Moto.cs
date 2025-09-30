using System;

namespace EjerciciosDePOO;

public class Moto : Vehiculo
{
  public bool sidecar { get; set; }
  public Moto(int id, string marca, string modelo, string km, double precio, bool sidecar) : base(id, marca, modelo, km, precio)
  {
    this.sidecar = sidecar;
  }

  public override double precio
  {
    get
    {
      if (sidecar)
      {
        return base.precio + 50;
      }
      else
      {
        return base.precio;
      }
    }
  }

  public override string ToString()
  {
    if (this.sidecar)
    {
      return base.ToString() + " y tiene sidecar";
    }
    else
    {
      return base.ToString() + ", no tiene sidecar";
    }
  }
}
