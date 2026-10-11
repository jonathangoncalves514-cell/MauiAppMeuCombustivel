namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                string marca = txt_Marca.Text;
                string modelo = txt_Modelo.Text;

               
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                
                if (etanol <= (gasolina * 0.7))
                {
                    msg = $"O etanol está compensando para o seu {marca} {modelo}.";
                }
                else
                {
                    msg = $"A gasolina está compensando para o seu {marca} {modelo}.";
                }

                await DisplayAlert("Calculado", msg, "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", "Por favor, preencha todos os campos corretamente.\n" + ex.Message, "Fechar");
            }
        }
    }
}