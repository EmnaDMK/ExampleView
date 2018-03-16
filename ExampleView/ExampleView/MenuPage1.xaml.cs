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
            ItemsViewModel IV;
            InitializeComponent();
            IV = new ItemsViewModel();
            ListView1.ItemsSource = IV.ItemsView1;
        }

           private void LV1(object sender, SelectedItemChangedEventArgs e)
            {
                var Item = e.SelectedItem as ItemView;

                if (Item.Items.Equals("My ACCOUNT"))
                {

                    Detail = new MyAccount();
                    IsPresented = false;
                }


                else
                   if (Item.Items.Equals("SHOP"))
                {
                    Detail = new ShopPage();
                    IsPresented = false;
                }
                else
                   if (Item.Items.Equals("FAQ"))
                {
                    Detail = new FAQPage();
                    IsPresented = false;
                }
                else
                   if (Item.Items.Equals("NOTIFICATIONS"))
                {
                    Detail = new NotificationsPage();
                    IsPresented = false;
                }

            }
        }
    } 

