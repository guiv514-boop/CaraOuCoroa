using System.ComponentModel.Design;

namespace CaraOuCoroa
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void JogarMoedaButton_Clicked(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int sorteio = aleatorio.Next(0, 2); // Gera 0 ou 1

            if (picker.SelectedItem == null)
            {
                ResultadoLabel.Text = ("SELECIONE UM ITEM");
                return;
            }
            string resultado = picker.SelectedItem.ToString();

            string ladoSorteado = "";

            if (sorteio == 0)
            {
                ladoSorteado = "CARA";
            }
            else
            {
                ladoSorteado = "COROA";
            }

            if (resultado == ladoSorteado)
            {
                ResultadoLabel.Text = $"Deu {ladoSorteado}! Você GANHOU! ";
            }
            else
            {
                ResultadoLabel.Text = $"Deu {ladoSorteado}! Você PERDEU! ";
            }
        }
        
    }
}
