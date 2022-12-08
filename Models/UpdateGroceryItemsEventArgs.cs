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
        private List<GroceryModel> items = new List<GroceryModel>();

        public UpdateGroceryItemsEventArgs(List<GroceryModel> i)
        {
            items = i;
        }

        public List<GroceryModel> GetGroceries
        {
            get
            {
                return items;
            }
        }
    }
}
