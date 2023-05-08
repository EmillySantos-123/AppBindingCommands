using AppBindingCommands.ViewModels;

namespace AppBindingCommands.Views;

public partial class UsuarioView : ContentPage
{
	public UsuarioView()
	{
		InitializeComponent();
		BindingContext= new  UsuarioViewModel();
	}

    private void btnAtualizarInformacoes_Clicked(object sender, EventArgs e)
    {

    }
}