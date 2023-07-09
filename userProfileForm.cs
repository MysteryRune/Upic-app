using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upic
{
    public partial class userProfileForm : Form
    {
        public userProfileForm()
        {
            InitializeComponent();
        }

        private void panel_bg_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void pb_logo_UPIC_Click(object sender, EventArgs e)
        {
            Close();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.Visible = true;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.ShowInTaskbar = true;
        }

        private void pb_friends_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new friendsForm();
            form.Show();
        }

        private void pb_mess_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new messagesForm();
            form.Show();
        }

        private void pb_noti_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new notificationsForm();
            form.Show();
        }

        private void pb_user1_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new userProfileForm();
            form.Show();
        }
    }
}
