using GeometryClasses;
namespace MauiAppLecture5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            dm = new FigureXMLDataManager();
        }

        public static FigureXMLDataManager dm { get; set; }
    }
}
