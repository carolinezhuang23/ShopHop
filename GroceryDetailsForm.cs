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
        List<GroceryModel> Items = new List<GroceryModel>();
        public GroceryDetailsForm()
        {
            InitializeComponent();
        }

        private void GroceryDetailsForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();

            Items = GroceryModel.GetGroceries();

            this.PopulateGroceries();
        }

        private void SetControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void PopulateGroceries()
        {
            //Get grocery items from the GroceryModel
            var items = (from i in Items
                         select i.Grocery).ToList();
            lstGroceryList.Sorted = true;
            lstGroceryList.DataSource = items;
            
        }

        

        private void deleteListButton_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete the Grocery List?";

            DialogResult result = MessageBox.Show(message, TitlesModel.MessageBoxTitle,
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.lstGroceryList.DataSource = null;
                lstGroceryList.Items.Clear();
                
            }


            //display confirmation of deletion

        }


        private void addFormButton_Click(object sender, EventArgs e)
        {
            AddItemsForm frm2 = new AddItemsForm();

            frm2.Items = this.Items;

            frm2.UpdateGroceries += new AddItemsForm.GroceriesHandler(GroceriesUpdate);

            frm2.ShowDialog();
        }

        private void GroceriesUpdate(object s, UpdateGroceryItemsEventArgs e)
        {
            Items = e.GetGroceries;

            this.PopulateGroceries();
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this item?";

            DialogResult result = MessageBox.Show(message, TitlesModel.MessageBoxTitle,
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Items.RemoveAll(x => x.Grocery == this.lstGroceryList.SelectedValue.ToString());

                this.PopulateGroceries();
            }

        }

       

        
    }
}
