using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string username;

        public MainPage()
        {
            this.InitializeComponent();

        }

        public string getUsername()
        {
            return username;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameBox.Text.Length < 3)
            {
                displayNoUsernameError();
            }
            else
            {
                ErrorMessage.Visibility = Visibility.Collapsed;
                username = NameBox.Text;
                this.Frame.Navigate(typeof(HomePage));
            }
        }
        
        private void displayNoUsernameError()
        {
            ErrorMessage.Visibility = Visibility.Visible;
        }
    }
}
