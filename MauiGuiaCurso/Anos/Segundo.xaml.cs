using MauiGuiaCurso.Disciplinas;

namespace MauiGuiaCurso.Anos;

public partial class Segundo : ContentPage
{
	public Segundo()
	{
		InitializeComponent();
	}

    private void mobile_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ProgramacaoMobile());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void banco_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new BancoDados());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void ds_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new DesenvolvimentoSistemas());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void web_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ProgramacaoWeb());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}