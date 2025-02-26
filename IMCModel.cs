namespace Calculadora_MVVC;

public class IMCModel : ContentPage
{
    public double Peso { get; set; }
    public double Altura { get; set; }

    public double CalcularIMC()
    {
        if (Altura <= 0) return 0; // Evitar división por cero
        return Peso / (Altura * Altura);
    }
}