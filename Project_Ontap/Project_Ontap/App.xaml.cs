using Prism.Unity;
using Project_Ontap.Data;
using Project_Ontap.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Ontap
{
    public partial class App : PrismApplication
    {

        static RecordsDatabase database;

        public App() : this(null) { }

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage");
        }

        public static RecordsDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new RecordsDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("Ontap.db"));
                }
                return database;
            }
        }
        public int ResumeAtTodoId { get; set; }



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
            Container.RegisterTypeForNavigation<ClientCall>();
        }
    }
}
