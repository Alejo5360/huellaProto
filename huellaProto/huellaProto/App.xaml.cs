
namespace huellaProto
{
    using Views;
    using Xamarin.Forms;

    public partial class App : Application
    {
        #region Constructors
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new Login()) { BarBackgroundColor = Color.FromRgba(255,255,255,1), BarTextColor = Color.Gray };
        }

        #endregion

        #region Metodos
        protected override void OnStart()
        {
            // Cuando la app de ejecuta
        }

        protected override void OnSleep()
        {
            //Dormir la app
        }

        protected override void OnResume()
        {
            // Despertar la app
        }
        #endregion
    }
}
