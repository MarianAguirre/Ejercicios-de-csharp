namespace Validaciones;

public class Validador
{

  public static bool StringEsValido(string? texto)
  {
    return !string.IsNullOrWhiteSpace(texto);
  }

  public static bool IntEsValido(int? valor, int min = int.MinValue, int max = int.MaxValue)
  {
    if (!valor.HasValue)
      return false;
    return valor.Value >= min && valor.Value <= max;
  }

  public static bool DoubleEsValido(double? valor, double min = double.MinValue, double max = double.MaxValue)
  {
    if (!valor.HasValue)
      return false;
    return valor.Value >= min && valor.Value <= max;
  }

}
