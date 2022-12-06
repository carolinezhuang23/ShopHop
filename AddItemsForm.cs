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

        public List<GroceryModel> Groceries; 

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
        private void addItemButton_Click(object sender, EventArgs e)
        {
            UpdateGroceryItemsEventArgs args = new UpdateGroceryItemsEventArgs(Groceries);


            UpdateGroceries(this, args);

            this.Close();
        }
    }
}
