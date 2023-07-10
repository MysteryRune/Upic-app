using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Upic
{
    public partial class popupUC : UserControl
    {
        public popupUC()
        {
            InitializeComponent();
        }

        private void panel_profile_user_Click(object sender, EventArgs e)
        {
            this.Visible = false;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.Visible = false;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.ShowInTaskbar = false;

            userProfileForm tmp = new userProfileForm();
            tmp.setUsername(homepageForm.homePageInstance.username);
            tmp.Show();
        }

        private void pb_profile_avatar_Click(object sender, EventArgs e)
        {
            panel_profile_user_Click(sender, e);
        }

        private void lbl_profile_user_Click(object sender, EventArgs e)
        {
            panel_profile_user_Click(sender, e);
        }

        private void panel_logout_Click(object sender, EventArgs e)
        {
            homepageForm.homePageInstance.username = "";
            homepageForm.homePageInstance.resetHomePageNone();
            homepageForm.homePageInstance.Visible = false;

            loginForm tmp = new loginForm();
            tmp.Show();
        }

        private void pb_logout_Click(object sender, EventArgs e)
        {
            panel_logout_Click(sender, e);
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            panel_logout_Click(sender, e);
        }
    }
}
