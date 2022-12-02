using ShopHop.Models;
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
        }

        private void GroceryDetailsForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.PopulateGroceries();
        }

        private void PopulateGroceries()
        {
            //Example grocery items 
            lstGroceryList.Items.Add("milk");
            lstGroceryList.Items.Add("eggs");
            lstGroceryList.Items.Add("cheese");
            lstGroceryList.SelectionMode = SelectionMode.MultiSimple;
        }

        //Editing Grocery List
        private void editListButton_Click(object sender, EventArgs e)
        {
            //display edit form

            //Grocery list shows up on edit list page
            
        }

        private void deleteListButton_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete the Grocery List?";

            DialogResult result = MessageBox.Show(message, TitlesModel.MessageBoxTitle,
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.lstGroceryList.Items.Clear();
                
            }


            //display confirmation of deletion

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.PopulateGroceries();
        }

    
    }
}
