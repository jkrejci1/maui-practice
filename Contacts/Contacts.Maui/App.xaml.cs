namespace Contacts.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(); //Different main page than mainpage.xaml.cs file as that is routing to a specific page in the app, this is a member of the Application class, while the other is a member of the ContentPage class
        }
    }
}
