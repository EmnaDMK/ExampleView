using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleView
{
   public class ItemsViewModel
    {
        public List<ItemView> ItemsView1 { get; set; }
        public ItemsViewModel()
        {
            ItemsView1 = new ItemView().GetItemsView1();
        }
    }
}
