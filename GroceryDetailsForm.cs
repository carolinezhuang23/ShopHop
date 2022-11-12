using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopHop
{
    public partial class GroceryDetailsForm : Form
    {
        public GroceryDetailsForm()
        {
            InitializeComponent();
            //Example grocery items 
            groceryList.Items.Add("milk");
            groceryList.Items.Add("eggs");
            groceryList.Items.Add("cheese");
            groceryList.SelectionMode = SelectionMode.MultiSimple;
        }

        //Header
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Grocery List

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Editing Grocery List
        private void editListButton_Click(object sender, EventArgs e)
        {
            //display edit form

            //Grocery list shows up on edit list page
            EditListForm form = new EditListForm(groceryList.Items);
            form.Show();
        }
    }
}
