namespace aperezS3B.Views;

public partial class Login : ContentPage
{

    string user = "x", pass = "x";
	public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contrasena)
    {
        InitializeComponent();
        user = usuario;
        pass = contrasena;
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Registro());
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && pass == txtContraseña.Text)
        {
            Navigation.PushAsync(new Views.Home());
        }
        else 
        {
            DisplayAlert("Error", "Usario/Contraseña Incorrectos", "Cerrar");
        }
    }
}