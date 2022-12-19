using ShellSampleNavigation.Views;

namespace ShellSampleNavigation
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        { 

            //Routing.RegisterRoute("mainPage", typeof(MainPage));

            //just normal navigation
            Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));
            Routing.RegisterRoute(nameof(ThirdPage), typeof(ThirdPage));

            //below is used to demo modal and non modal pages interaction
            Routing.RegisterRoute(nameof(ModalSamplePage), typeof(ModalSamplePage));  //loaded modal (Shell.PresentationMode="ModalAnimated")

            //all below pages should not load modal
            Routing.RegisterRoute(nameof(PageA), typeof(PageA));
            Routing.RegisterRoute(nameof(PageB), typeof(PageB));
            Routing.RegisterRoute(nameof(PageC), typeof(PageC));
        }
    }
}
