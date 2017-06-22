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
using Windows.ApplicationModel.Contacts;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace TextScan.Pages.Contact
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class ResultPageContact : Page
    {
        string name;
        string number;
        string mail;

        public ResultPageContact()
        {
            this.InitializeComponent();
        }
        

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string result = Convert.ToString(e.Parameter);
            var res = result.Split(new char[] { '^' });
            NameText.Text = res[0];
            NumberText.Text = res[1];
            MailText.Text = res[2];
            name = res[0];
            number = res[1];
            mail = res[2];
        }

        private async void DoneContactClick(object sender, RoutedEventArgs e)
        {
            var contact = new Windows.ApplicationModel.Contacts.Contact();
            contact.FirstName = name;
           
            ContactEmail email = new ContactEmail();
            email.Address = mail;
            email.Kind = ContactEmailKind.Other;
            contact.Emails.Add(email);

            ContactPhone phone = new ContactPhone();
            phone.Number = number;
            phone.Kind = ContactPhoneKind.Mobile;
            contact.Phones.Add(phone);

            ContactStore store = await
                ContactManager.RequestStoreAsync(ContactStoreAccessType.AppContactsReadWrite);

            ContactList contactList;

            IReadOnlyList<ContactList> contactLists = await store.FindContactListsAsync();

            if (0 == contactLists.Count)
                contactList = await store.CreateContactListAsync("TestContactList");
            else
                contactList = contactLists[0];

            await contactList.SaveContactAsync(contact);
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectTextPageContact));
        }
    }
}
