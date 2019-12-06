
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace App1
{
    public class Contact
    {

        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public Visibility ButtonVisibility { get; set; } = Visibility.Collapsed;
        
        public Windows.UI.Xaml.Media.Imaging.BitmapImage ContactImage { get; set; }

        public MessageManager userMessages { get; set; }
    }
}
