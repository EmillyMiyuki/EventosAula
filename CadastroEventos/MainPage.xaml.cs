


using CadastroEventos.models;
using Microsoft.Maui.Controls;
//using CadastroEventos.models; // Para usar a classe Evento
//using Microsoft.Maui.Controls; // Necessário para o MAUI



namespace CadastroEventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            var evento = BindingContext as Evento;

            if (evento != null)
            {
                // Verifica se os dados estão corretos
                if (evento.DataInicio >= evento.DataTermino)
                {
                    await DisplayAlert("Erro", "A data de término deve ser posterior à data de início.", "OK");
                    return;
                }

                // Navega para a página de resumo
                await Navigation.PushAsync(new ResumoEventoPage(evento));
            }
        }
    }
}

namespace CadastroEventos
{
    public partial class MainPage : ContentPage
    {
        // Construtor da páginaprivate
        public MainPage()
        {
            InitializeComponent();
        }

        // Este método é chamado quando o botão "Cadastrar Evento" é clicado
        private async void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            var evento = BindingContext as Evento;  // Obtemos o objeto Evento associado ao BindingContext

            if (evento != null)
            {
                // Verifica se a data de término é posterior à data de início
                if (evento.DataInicio >= evento.DataTermino)
                {
                    await DisplayAlert("Erro", "A data de término deve ser posterior à data de início.", "OK");
                    return; // Se a verificação falhar, não navega
                }

                // Navega para a página de resumo, passando o objeto Evento como parâmetro
                await Navigation.PushAsync(new ResumoEventoPage(evento));
            }
        }
    }
}

