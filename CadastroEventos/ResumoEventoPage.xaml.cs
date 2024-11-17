using CadastroEventos.models;

namespace CadastroEventos
{
    public partial class ResumoEventoPage : ContentPage
    {
        // Construtor que recebe um objeto Evento e o associa ao BindingContext da página
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;  // O BindingContext é associado ao objeto Evento que foi passado
        }

        // Método para voltar à página anterior
        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();  // Navega para a página anterior na pilha de navegação
        }
    }
}

