using MauiGuiaCurso.Disciplinas;

namespace MauiGuiaCurso.Anos;

public partial class Primeiro : ContentPage
{
	public Primeiro()
	{
		InitializeComponent();
	}

    private void analise_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Analise());
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

    private void design_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new DesignDigital());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void fundamentos_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new FundamentosInformatica());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void tecnicas_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new TecnicasProgramacao());
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