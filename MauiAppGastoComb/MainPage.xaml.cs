namespace MauiAppGastoComb
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try {
                double etanol = Convert.ToDouble(Etanol_Button.Text);
                double gasolina = Convert.ToDouble(Gasolina_Button.Text);
                string marca = Marca_Button.Text;
                string modelo = Modelo_Button.Text;
                string message = "";

                if (etanol <= (gasolina * 0.7)) {
                    message = ("Etanol compensa mais para o seu "+marca+ ", "+modelo);
                }
                else
                {
                   message = ("Gasolina compensa mais para o seu " + marca + ", " + modelo);
                }

                DisplayAlert("Verificação Concluída",message,"OK");

            } catch (Exception ex) {
                DisplayAlert("Ops!", ex.Message, "Fechar");
            }
        }
    }
}
