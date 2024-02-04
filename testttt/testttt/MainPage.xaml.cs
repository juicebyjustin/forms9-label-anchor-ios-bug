using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace testttt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PhoneLabel.ActionTagTapped += ActionTagTapped;
            EmailLabel.ActionTagTapped += ActionTagTapped;
        }

        private void ActionTagTapped(object sender, Forms9Patch.ActionTagEventArgs e)
        {
            Forms9Patch.Toast.Create("Link Activated", "The link (id: " + e.Id + ", href:" + e.Href + ") was activated.");
        }
    }
}

