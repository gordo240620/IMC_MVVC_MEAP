namespace Calculadora_MVVC
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new IMCViewModel(); // Establece el contexto de datos
        }

       
    }

}
