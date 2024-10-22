using MauiGuiaCurso.Disciplinas;

namespace MauiGuiaCurso.Anos;

public partial class Terceiro : ContentPage
{
	public Terceiro()
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
    
    private void internet_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new InternetProtocolos());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void embarcados_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new SistemasEmbarcados());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void qualidade_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new QualidadeSoftware());
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

    private void tcc_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new PlanejamentoTCC());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    
}