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
    public partial class Form3 : Form
    {
        public Form3( string category)
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2("Back To Menu");
            form2.Show();
            this.Close();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            string cardNum = txtCardNum.Text.Trim();
            string cardName = txtCardName.Text.Trim();  
            string expDate = txtExpDate.Text.Trim();
            string cvv = txtCCV.Text.Trim();

            if (string.IsNullOrWhiteSpace(cardNum) || string.IsNullOrWhiteSpace(cardName)
                || string.IsNullOrWhiteSpace(expDate) || string.IsNullOrWhiteSpace(cvv))
            {
                lblMessage.Text = "Please Fill In All The Fields";
                return;
            }
            if (!IsValidCard(cardNum))
            {
                lblMessage.Text = "Invalid Credit Card Number. Please Enter A Valid 16-Digit Number";
                return;
            }

            if (!IsValidExpDate(expDate))
            {
                lblMessage.Text = "Invalid Expiration Date. Please Enter In MM/YY Format";
                return;
            }

            if (!IsValidCVV(cvv))
            {
                lblMessage.Text = "Invalud CVV. Please Enter A Valid 3-Digit CVV";
                return;
            }

            lblMessage.Text = "Purchase Successful!";
            ClearFields();

        }

        private bool IsValidCard(string num)
        {
            return num.Length == 16 && long.TryParse(num, out _);
        }

        private bool IsValidExpDate(string date)
        {
            if (date.Length == 5 && date[2] == '/')
            {
                string[] datePart = date.Split('/');
                return datePart.Length == 2 && int.TryParse(datePart[0], out _) && int.TryParse(datePart[1], out _);
            }
            return false;
        }

        private bool IsValidCVV(string cvv)
        {
            return cvv.Length == 3 && int.TryParse(cvv, out _);
        }

        private void ClearFields()
        {
            txtCardNum.Clear();
            txtExpDate.Clear();
            txtCCV.Clear();
            txtCardName.Clear();
        }

    }
}
