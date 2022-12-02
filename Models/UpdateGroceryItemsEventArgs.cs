using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopHop.Models
{
    public class UpdateGroceryItemsEventArgs : EventArgs
    {

        //ArrayList
        private List<GroceryList> items = new List<GroceryList>();

        public UpdateGroceryItemsEventArgs(List<GroceryList> i)
        {
            items = i;
        }

        public List<GroceryList> GetGroceryLists
        {
            get
            {
                return items;
            }
        }
    }
}
