using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleView
{
  public  class ItemView
    {


        public string Items { get; set; }
        public string status { get; set; }

        public List<ItemView> GetItemsView1()
        {
            List<ItemView> ItemsView1 = new List<ItemView>()
            {
                  new ItemView{ Items ="My ACCOUNT"},
                new ItemView{ Items ="SHOP"},
                new ItemView{ Items ="FAQ"},
                new ItemView{ Items ="NOTIFICATIONS" , status="2"}
               
            };
            return ItemsView1;
        }

    }
}

