using System.Diagnostics;
using System.Security.Policy;
using System.Xml.Linq;
using ItemNameSpace;
namespace CashierApplication
{
    public partial class Form1 : Form
    {
        DiscountedItem item;
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            double payment = Convert.ToDouble(paymentBox.Text);
            item.setPayment(payment);
            changeLabel.Text = Convert.ToString(item.getChange());
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            string name = ItemNameTBox.Text;
            double discount = Convert.ToDouble(DiscountTbox.Text);
            double price = Convert.ToDouble(pricetBox.Text);
            int quantity = Convert.ToInt32(quantibox.Text);
            item = new DiscountedItem(name, price, quantity, discount);
            double total = item.getTotalPrice();
            amountLabel.Text = total.ToString();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide(); // Hide the main form

            using (frmLoginAccount loginForm = new frmLoginAccount())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // If login is successful, show Form1 again
                    Show();
                }
                else
                {
                    // If login cancelled or failed, close the main form (exit app)
                    Close();
                }
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
