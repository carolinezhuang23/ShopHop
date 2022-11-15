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
        private void EditListForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        public EditListForm(ListBox.ObjectCollection objectCollection)
        {
            InitializeComponent();
            this.listBox2.DataSource = objectCollection;

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            TextBox TextBoxItem = new TextBox();
            // set TextBoxItem properties here
            

        }

        
    }
}
