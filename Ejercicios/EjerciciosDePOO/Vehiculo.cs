using System;

namespace EjerciciosDePOO;

public class Vehiculo
{
  private int _id;
  private string _marca;
  private string _modelo;
  private string _km;
  private double _precio;

  public Vehiculo(int id, string marca, string modelo, string km, double precio)
  {
    this._id = id;
    this._marca = marca;
    this._modelo = modelo;
    this._km = km;
    this._precio = precio;
  }

  public int id { get => _id; set => _id = value; }
  public string marca { get => _marca; set => _marca = value; }
  public string modelo { get => _modelo; set => _modelo = value; }
  public string km { get => _km; set => _km = value; }
  public virtual double precio { get => _precio; set => _precio = value; }



  public override string ToString()
  {
    return @$"ID: {id} 
    Marca: {marca} 
    Modelo: {modelo}
    Km: {km} 
    Precio: {precio}";
  }
}
