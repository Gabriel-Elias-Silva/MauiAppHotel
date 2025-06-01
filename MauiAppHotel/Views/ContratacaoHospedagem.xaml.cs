namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
	private void Button_Clicked(Object sender, EventArgs e)
	{
		Navigation.PushAsync(new Sobre());
	}

}