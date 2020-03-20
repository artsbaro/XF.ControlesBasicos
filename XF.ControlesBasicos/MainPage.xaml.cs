using System;
using System.ComponentModel;
using Xamarin.Forms;
using XF.ControlesBasicos.Model;

namespace XF.ControlesBasicos
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            if (App.email.AceitaReceber && !string.IsNullOrWhiteSpace(App.email.Conta))
                DisplayAlert("Sucesso", $"E-mail enviado para {App.email.Conta}", "OK");
            else
                DisplayAlert("Ops", "E-mail não autorizado.", "OK");
        }

        private async void btnConfiguracao_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigPage { BindingContext = App.email });
        }
    }
}
