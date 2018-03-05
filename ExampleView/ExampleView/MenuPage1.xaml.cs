using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage1 : MasterDetailPage
    {
        public MenuPage1()
        {
            InitializeComponent();

            ListView1.ItemsSource = new string[]
            {
                "My ACCOUNT",
                "Shop",
                "FAQ",
                "NOTIFICATIONS"

            };
           
        }


        private void ListView1_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           if (ListView1.SelectedItem.Equals("My ACCOUNT"))
            {
                Detail=new MyAccount();
                IsPresented = false;
            }
            else 
               if (ListView1.SelectedItem.Equals("Shop"))
               {
                   Detail = new ShopPage();
                   IsPresented = false;
               }
               else
               if (ListView1.SelectedItem.Equals("FAQ"))
               {
                   Detail = new FAQPage();
                   IsPresented = false;
               }
               else
               if (ListView1.SelectedItem.Equals("NOTIFICATIONS"))
               {
                   Detail = new NotificationsPage();
                   IsPresented = false;
               }
        }
    }
}