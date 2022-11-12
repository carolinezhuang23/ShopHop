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

        }

        
    }
}
