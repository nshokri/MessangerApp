using System;
using System.Collections.Generic;
using System.Net.Mail;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Net;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MessagePage : Page
    {
        Contact contact = ContactManager.getCurrectContact();
        //FILL IN INFO HERE
        private string username = "";
        private string password = "";

       // private MessageManager pastMessages;
        private List<UserMessage> userMessages;

        public MessagePage()
        {
            this.InitializeComponent();
            userMessages = ContactManager.GetUserMessages().GetPastMessages();

        }

        private void SendButtonClicked(object sender, RoutedEventArgs e)
        {
            //THIS CODE IS NOT MINE
            //CODE TAKEN FROM: http://csharp.net-informations.com/communications/csharp-smtp-mail.htm
            try
            {

                MailMessage mail = new MailMessage();
                //FILL IN EMAIL BELOW
                mail.To.Add("");

                mail.From = new MailAddress(username);
                //Fill in subject
                mail.Subject = "";
                //Fille in email body
                mail.Body = "";

                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                //Change to your email provider
                smtp.Host = "http.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential
                     (username, password); // ***use valid credentials***
                smtp.Port = 587;

                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);

            }
            catch (Exception ex)
            {
                Console.WriteLine("IT CRASHED");
            }

            //----------------------------------------------------------------------
            //Weird thing to make data binding go verticle
            string temp = "";
            
            for (int i = 0; i < 2000; i++)
            {
                temp += " ";
            }
            temp += "-";

            userMessages.Add(new UserMessage { message = "You: " + MessageTextBox.Text + temp});
            MessageTextBox.Text = "";
            this.Frame.Navigate(typeof(MessagePage));
        }
    }
}