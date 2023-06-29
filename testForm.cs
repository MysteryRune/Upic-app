namespace Upic
{
    public partial class testForm : Form
    {

        public static testForm? testFireCloudInstance;

        public testForm()
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