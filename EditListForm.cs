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
    public partial class EditListForm : Form
    {
        private object listBox;

        public EditListForm(ListBox.ObjectCollection objectCollection)
        {
            InitializeComponent();
            this.listBox.DataSource = objectCollection;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text != "")
            {
                groceryList.Items.Add(this.textBoxName.Text);
                this.textBoxName.Focus();
                this.textBoxName.Clear();
            }
            //If user did not enter any values then else block executes
            else
            {
                MessageBox.Show("Please enter a name to add..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBoxName.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.groceryList.SelectedIndex >= 0)
            {
                this.groceryList.Items.RemoveAt(this.groceryList.SelectedIndex);
            }
        }
        

        }
}
