namespace CashierApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show login form first as a dialog
            using (var loginForm = new frmLoginAccount())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Login successful, start Form1
                    Application.Run(new Form1());   
                }
            }
        }
    }
}

    