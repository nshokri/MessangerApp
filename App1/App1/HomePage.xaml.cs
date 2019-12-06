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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

       /* private void IconsListBox_Selected(object sender, SelectionChangedEventArgs e)
        {
            if (MySplitView.IsPaneOpen == true)
            {
                MySplitView.IsPaneOpen = false;
            }

            if (ContactsListBoxItem.IsSelected)
            {
                InnerFrame.Navigate(typeof(ContactPage));
            }
           // else if (HomeListBoxItem.IsSelected)
           // {
            //    InnerFrame.Navigate(typeof(RecentPage));
            //}
        }*/

        private void ContactButtonClick(object sender, RoutedEventArgs e)
        {
            InnerFrame.Navigate(typeof(ContactPage));
            MySplitView.IsPaneOpen = false;
        }
    }
}
