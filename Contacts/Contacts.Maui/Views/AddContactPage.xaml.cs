namespace Contacts.Maui.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        //Can't use nameof(contactspage) because it's the first page and the root contains // at the beginning so you also have to add those //'s at the beginning here
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}"); //Brings us back to the parent page (like when you're in a file system in powershell)
    }
}