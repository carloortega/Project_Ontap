using Prism.Unity;
using Project_Ontap.Views;
using Xamarin.Forms;

namespace Project_Ontap
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<HomePage>();
            Container.RegisterTypeForNavigation<About>();
            Container.RegisterTypeForNavigation<AboutVersion>();
            Container.RegisterTypeForNavigation<TargetCall>();
            Container.RegisterTypeForNavigation<ClientList>();
            Container.RegisterTypeForNavigation<Performance>();
            Container.RegisterTypeForNavigation<CallsSummary>();
            Container.RegisterTypeForNavigation<ClientSummary>();
        }
    }
}
