using Contacts.Maui.Views;

namespace Contacts.Maui
{
    public partial class AppShell : Shell
    {
        //Provides the URL based navigation (routing)
        public AppShell()
        {
            InitializeComponent();

            //In order to jump to pages with url based navigation we need to let the system know we have routes that point ot the pages
            Routing.RegisterRoute(nameof(ContactsPage), typeof(ContactsPage));
            Routing.RegisterRoute(nameof(EditContactPage), typeof(EditContactPage));
            Routing.RegisterRoute(nameof(AddContactPage), typeof(AddContactPage));


        }
    }
}
