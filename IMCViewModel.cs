using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Calculadora_MVVC;

public class IMCViewModel : INotifyPropertyChanged
{
    private IMCModel _imcModel;

    public IMCViewModel()
    {
        _imcModel = new IMCModel();
        CalcularCommand = new Command(CalcularIMC);
    }

    public double Peso
    {
        get => _imcModel.Peso;
        set
        {
            _imcModel.Peso = value;
            OnPropertyChanged(nameof(Peso));
        }
    }

    public double Altura
    {
        get => _imcModel.Altura;
        set
        {
            _imcModel.Altura = value;
            OnPropertyChanged(nameof(Altura));
        }
    }

    private double _resultadoIMC;
    public double ResultadoIMC
    {
        get => _resultadoIMC;
        set
        {
            _resultadoIMC = value;
            OnPropertyChanged(nameof(ResultadoIMC));
        }
    }

    public ICommand CalcularCommand { get; }

    private void CalcularIMC()
    {
        ResultadoIMC = _imcModel.CalcularIMC();
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}