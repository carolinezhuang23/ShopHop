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
    public partial class AddItemsForm : Form
    {
        public delegate void GroceriesHandler(object sender, UpdateGroceryItemsEventArgs e);

        public event GroceriesHandler UpdateGroceries;

        public List<GroceryModel> Items; 

        public AddItemsForm()
        {
            InitializeComponent();
        }

        private void AddItemsForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false; 
        }
        

        private void addFormCloseButton_Click(object sender, EventArgs e)
        {
            UpdateGroceryItemsEventArgs args = new UpdateGroceryItemsEventArgs(Items);

            UpdateGroceries(this, args);

            this.Close();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (!this.PerformValidation())
                return;
            this.AddItem();

            
        }

        private void AddItem()
        {
            //User adding grocery list. Add to the list
            Items.Add(new GroceryModel()
            {
                Grocery = this.txtItem.Text.Trim()
            });

            //Success
            MessageBox.Show("Item " + this.txtItem.Text.Trim() + " sucessfully added!",
                              TitlesModel.MessageBoxTitle,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            //Clear text box 
            this.txtItem.Text = String.Empty; 
        }

        private bool PerformValidation()
        {
            //Verify that textbox is not empty
            if (String.IsNullOrEmpty(this.txtItem.Text.Trim()))
            {
                MessageBox.Show("An item must be entered!", TitlesModel.MessageBoxTitle,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Set Focus to Item Textbox
                this.txtItem.Focus();
                return false;
            }

            return true;
        }
    }
}
