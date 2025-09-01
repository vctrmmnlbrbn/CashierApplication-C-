using UserAccountNameSpace;
namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            {
                string username = usernameBox.Text;         
                string password = passwordBox.Text;

                Cashier cashier = new Cashier("Clarissa Castro", "cashier101", "MaryAngelaGolagat", "Finance");

                if (cashier.validateLogin(username, password) == 1)
                {
                MessageBox.Show("Welcome " + cashier.getFullName() + " of " + cashier.getDepartment());
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password.  \nPlease try again.");
            }
        }
    }
}
