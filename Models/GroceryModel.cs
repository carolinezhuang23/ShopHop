using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopHop.Models
{
    public class GroceryModel
    {
        public string Grocery { get; set; }

        public GroceryModel()
        {

        }

        public GroceryModel(string g)
        {
            Grocery = g;
        }

        public static List<GroceryModel> GetGroceries()
        {
            return new List<GroceryModel>
            {
                new GroceryModel("milk"),
            new GroceryModel("eggs"),
            new GroceryModel("cheese")

            };

        }
    }
}
