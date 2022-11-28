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
        ArrayList groceryItems = new ArrayList();
        public GroceryList()
        {
            //original items
            groceryItems.Add(new GroceryItem("milk"));
            groceryItems.Add(new GroceryItem("cheese"));
            groceryItems.Add(new GroceryItem("eggs"));
        }

        //showing grocery list
        public void ShowGroceryList(ArrayList items)
        {
            foreach (GroceryItem i in items)
                Console.WriteLine(i.ToString());
        }

        //adding items to grocery list 
        public  void addItem(string name)
        {
            groceryItems.Add(new GroceryItem(name));
        }

        
    }


    //Grocery Item Class
    public class GroceryItem
    {
        public string Title;
        public int amount;

        public GroceryItem(string _title)
        {
            this.Title = _title;
            
        }

        
    }
}
