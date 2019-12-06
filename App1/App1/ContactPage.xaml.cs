using App1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IndependentProject
{
    
    public sealed partial class ContactPage : Page
    {

        private Contact UserBeingContacted;

        private List<Contact> Contacts;

        public ContactPage()
        {
            this.InitializeComponent();
            Contacts = ContactManager.GetContacts();
            
        }

        private void AddNewContactButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddNewContactPage));
        }

        private void MessageButtonClicked(object sender, RoutedEventArgs e)
        {
    
            this.Frame.Navigate(typeof(MessagePage));
        }

        public Contact getUserBeingContacted()
        {
            return UserBeingContacted;
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var contact = (Contact)e.ClickedItem;
            UserBeingContacted = contact;

            ContactManager.setCurrectContact(UserBeingContacted);


            contact.ButtonVisibility = Visibility.Visible;
            this.Frame.Navigate(typeof(ContactPage));
        }

        /*private void DeleteButtonClicked(object sender, RoutedEventArgs e)
        {
            ContactManager.GetContacts().Remove(UserBeingContacted);
            this.Frame.Navigate(typeof(ContactPage));
        }*/
    }
}
