namespace Combustivel_MAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalcClicked(object sender, EventArgs e)
    {
        double.TryParse(TextValorAlcool.Text, out double valorAlcool); //Pega numero do Entry e insere em "valor"
        double.TryParse(TextValorGasolina.Text, out double valorGasolina);

        if (valorAlcool / valorGasolina < 0.7)
        {
            TextResultado.Text = $"⛽ Abasteça com Álcool!";
        }
        else
        {
            TextResultado.Text = $"⛽ Abasteça com Gasolina!";
        }
    }
}

