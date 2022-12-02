using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ShopHop
{
    public class GroceryList
    {
        public string GroceryItem { get; set; }
        public GroceryList()
        {
            
        }

        public GroceryList(string g)
        {
            GroceryItem = g;
        }
        
        public static List<GroceryList> GetGroceryLists()
        {
            return new List<GroceryList>
            {
                new GroceryList("milk"),
                new GroceryList("eggs"),
                new GroceryList("cheese")
            };
        }
       

        
    }

}
