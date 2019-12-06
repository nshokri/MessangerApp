using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using App1;

namespace IndependentProject
{

    public sealed partial class AddNewContactPage : Page
    {
        private Windows.UI.Xaml.Media.Imaging.BitmapImage ContactPictureSave;

        public AddNewContactPage()
        {
            this.InitializeComponent();
        }

        private async void FileExplorerButtonClick(object sender, RoutedEventArgs e)
        {

            //THIS CODE IS NOT MINE
            //CODE WAS TAKEN FROM: https://docs.microsoft.com/en-us/windows/uwp/files/quickstart-using-file-and-folder-pickers

            //---------------------------------------------------------------------------------
             var picker = new Windows.Storage.Pickers.FileOpenPicker();
             picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
             picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
             picker.FileTypeFilter.Add(".jpg");
             picker.FileTypeFilter.Add(".jpeg");
             picker.FileTypeFilter.Add(".png");

             Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();

             if (file != null)
             {
                // Application now has read/write access to the picked file
                //  this.textBlock.Text = "Picked photo: " + file.Name;
                //ViewModel.Source = file.Path;
                using (Windows.Storage.Streams.IRandomAccessStream fileStream =
            await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
                {
                    // Set the image source to the selected bitmap.
                    ContactPictureSave =
                        new Windows.UI.Xaml.Media.Imaging.BitmapImage();

                    ContactPictureSave.SetSource(fileStream);
                    ContactPicture.Source = ContactPictureSave;
                }
            }
             //----------------------------------------------------------------------------------------------
         }

        private void CreateContactButtonClick(object sender, RoutedEventArgs e)
        {
            ContactManager.GetContacts().Add(new Contact { Name = NameBlock.Text, PhoneNum = PhoneBlock.Text, ContactImage = ContactPictureSave, ButtonVisibility = Visibility.Collapsed, userMessages = new MessageManager() });
            Frame.Navigate(typeof(ContactPage));
        }
    }
}
