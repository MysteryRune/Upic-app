namespace Upic
{
    public partial class test : Form
    {

        public static test? testFireCloudInstance;

        public test()
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