using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterDetailsPageLogin.Views
{
    public partial class DrawerPage : ContentPage
    {
        public Action<ContentPage> OnMenuSelect
        {
            get;
            set;
        }
        public DrawerPage()
        {
            InitializeComponent();
            img.Source = "icon.png";
            var categories = new List<Category>()
            {
                new Category("Menu Page1", () => new ComingSoon(),"icon.png"),
                new Category("Menu Page2", () => new ComingSoon(),"icon.png"),
                new Category("Menu Page3", () => new ComingSoon(),"icon.png"),
                new Category("Logout", () => new Login(),"ic_sign_out.png")
            };

            listed.BackgroundColor = Color.White;

            string howILook = Constants.Image;

            img.Source = new UriImageSource
            {
                Uri = new Uri(howILook),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(1, 0, 0, 0) //Caching image for a day
            };

            myName.Text = "Welcome Mr. " + Constants.Username;

            listed.ItemsSource = categories;


            listed.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                if (OnMenuSelect != null)
                {
                    var category = (Category)e.SelectedItem;
                    if (category.Name == "Logout")
                    {
                        App.Current.MainPage = new NavigationPage(new Login())
                        {
                            BarBackgroundColor = Color.FromHex("#B2DFDB"),
                            BarTextColor = Color.Black
                        };
                    }
                    var categoryPage = category.PageFn();
                    OnMenuSelect(categoryPage);
                }
            };
        }
    }
}
