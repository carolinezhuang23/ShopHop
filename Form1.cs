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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Main Page Header
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Grocery Details Button
        private void groceryDetails_Click(object sender, EventArgs e)
        {
            GroceryDetailsForm groceryDetails = new GroceryDetailsForm();
            groceryDetails.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
