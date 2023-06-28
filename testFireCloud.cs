namespace Upic
{
    public partial class testFireCloud : Form
    {

        public static testFireCloud? testFireCloudInstance;

        public testFireCloud()
        {
            testFireCloudInstance = this;

            InitializeComponent();

            loginForm form = new loginForm();
            form.Show();
        }

        private void testFireCloud_Load(object sender, EventArgs e)
        {
            // Hide Test Firecloud form
            ShowInTaskbar = false;
            Visible = false;
        }
    }
}