using ShopHop.Models;
using System;
using System.Collections;
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
    public partial class EditListForm : Form
    {
        //Delegate
        public delegate void GroceriesHandler(object sender, UpdateGroceryItemsEventArgs e);

        //Event for Delegate 
        public event GroceriesHandler UpdateItems;


        public List<GroceryList> Items;

        public EditListForm()
        {
            InitializeComponent();
        }

        private void EditListForm_Load(object sender, EventArgs e)
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

        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (!this.PerformValidation())
                return;
            this.AddItem();
        }

        private void AddItem()
        {
            Items.Add(new GroceryList()
            {
                GroceryItem = this.txtAddItem.Text.Trim()
            });

            //Success
            MessageBox.Show("Item" + this.txtAddItem.Text.Trim() + "added!!",
                             TitlesModel.MessageBoxTitle,
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

            //textbox clear
            this.txtAddItem.Text = String.Empty;
        }

        private bool PerformValidation()
        {
            //If textbox is empty
            if (String.IsNullOrEmpty(this.txtAddItem.Text.Trim()))
            {
                MessageBox.Show("Please enter an item!", TitlesModel.MessageBoxTitle,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtAddItem.Focus();
                return false;
            }
            return true;
        }
    }
}
