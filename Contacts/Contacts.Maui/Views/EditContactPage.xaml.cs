namespace Contacts.Maui.Views;
using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact; //Refer to our contact class in models

//Whenever we recieve the parameter val from contactspage we will map that parameter value to nameof(ContactId) property
[QueryProperty(nameof(ContactId), "Id")] //(nameOfTheProperty,queryId) THIS ONE IS FOR THE CONTACTID FROM THE CONTACTSPAGE BACKEND

public partial class EditContactPage : ContentPage
{
	//Privata Contact var for setter in ContactId
	private Contact contact;
	public EditContactPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(".."); //Brings us back to the parent page (like when you're in a file system in powershell)
    }

	//This will recieve the parameter value from the contacts page, we need a property corresponding to the parameter value
	//PROPERTY FROM ABOVE (where we will have the id for this example (the passed data))
	public string ContactId
	{
		//Only need a setter in this scenario
		set
		{
			//Set the contact, now we have the contact
			contact = ContactRepository.GetContactById(int.Parse(value));
			//Assign contact to fron end label -> lbl
			lblName.Text = contact.Name; //So then we can display the contact
		}
	}
}