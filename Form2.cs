using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_Online_Thrifiting_Store
{
    public partial class Form2 : Form
    {
        public Form2(string user)
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnPants_Click(object sender, EventArgs e)
        {
            OpenCategory("Pants");
        }

        private void btnJackets_Click(object sender, EventArgs e)
        {
            OpenCategory("Jackets");
        }

        private void btnSwaters_Click(object sender, EventArgs e)
        {
            OpenCategory("Sweaters");
        }

        private void btnTshirts_Click(object sender, EventArgs e)
        {
            OpenCategory("T-Shirts");
        }

        private void OpenCategory(string category) {

            var categoryForm = new Form3(category);
            categoryForm.Show();
            this.Hide();
        
        }
    }
}
