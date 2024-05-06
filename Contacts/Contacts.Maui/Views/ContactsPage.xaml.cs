using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact; //This is how we refer to our Contact class, gets rid of ambiguous error as well for List<Contact>

namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
		List<Contact> contacts = ContactRepository.GetContacts();

		//Need an array to display in list view and then need to provide this data to the list in frontend
		/*
		List<string> contacts = new List<string>()
		{
			"John Doe",
			"Jane Doe",
			"Tom Hanks",
			"Frank Liu"
		};
		*/

		//Takes the name of the list view on the frontend, and then sources it's items to our contacts list
		//Default behavior will take the objects and run it toString so simply doing this will print the object definitions itself NOT the actual stuff inside it
		//listContacts.ItemsSource = contacts; //LIKE THIS

		//Display the actual data like this, unlike when we did it with a simple list
		//USE DATA BINDING FROM FRONTEND
		listContacts.ItemsSource = contacts;
	}


	//Create a contact class (Create the class as a seperate file in other projects, this is just an example!)
	//We should have this class defeined inside of a Models folder
	/*
	public class Contact
	{
		public string Name { get; set; }
		public string Email { get; set; }
	}
	*/


	//Triggers when an item in the list is selected; but it's only triggered when that item selected is changed (not if you tapped it more than one time in a row)
    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		//How to fix the selected item more than once problem (deselect it after selecting it by changing selected item to nothing after it was clicked)
		//listContacts.SelectedItem = null;

		//Another way is to use display alert (Which will create a pop up after it was clicked)
		//'DisplayAlert'("test", "here i am", "OK"); //DisaplayAlert("Title", "Text paragraph", "OK button for exiting)

		//SHOULD HANDLE LOGIC HERE FOR THE BEFORE ITEM TAPPED
		//'DisplayAlert'("Test", "Paragraph", "OK"); //Doing this alone will trigger it twice
		
		//FIX HERE so only run it when an item is selected
		if (listContacts.SelectedItem != null)
		{
            //Logic go to the edit contact page
            //await Shell.Current.GoToAsync(nameof(EditContactPage));

            //Use query strings to pass data from page to page (strings and other data) -> we cast list contacts data into a Contact object and we can get contact ID
            //page#?selectedDataToSend=TheData (This is calling the ContactId data from the Contact class for the selected item in the list of contacts (the part after ?Id=)
				//We're also gonna get that data on the EditContactPage
			await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((Contact)listContacts.SelectedItem).ContactId}");

        }
	}

	//Triggers when an item is 'tapped' 
    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		//Do deselection of item inside here after the item selected logic
		listContacts.SelectedItem = null;
    }
}