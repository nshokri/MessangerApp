using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class ContactManager
    {
        private static List<Contact> Contacts = new List<Contact>();
        private static Contact currentContact;

        public static List<Contact> GetContacts()
        {
            return Contacts;
        }

        public static MessageManager GetUserMessages()
        {
            return currentContact.userMessages;
        }

        public static void setCurrectContact(Contact contact)
        {
            currentContact = contact;
        }

        public static Contact getCurrectContact()
        {
            return currentContact;
        }
    }
}
