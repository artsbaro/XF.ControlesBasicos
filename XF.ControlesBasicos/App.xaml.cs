using Xamarin.Forms;
using XF.ControlesBasicos.Model;

namespace XF.ControlesBasicos
{
    public partial class App : Application
    {
        public static Email email;

        public App()
        {
            email = email ?? new Email();
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
