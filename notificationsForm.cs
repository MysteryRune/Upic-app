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
    public partial class notificationsForm : Form
    {
        String username;

        public notificationsForm()
        {
            InitializeComponent();
        }

        private void panel_bg_Paint(object sender, PaintEventArgs e)
        {
            ActiveControl = null;
        }

        private void btn_all_noti_Click(object sender, EventArgs e)
        {
            panel_unread_noti.Visible = false;
            panel_all_noti.Visible = true;
        }

        private void btn_unread_noti_Click(object sender, EventArgs e)
        {
            panel_all_noti.Visible = false;
            panel_unread_noti.Visible = true;
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
            Refresh();
        }

        private void pb_user1_Click(object sender, EventArgs e)
        {
            Close();
            userProfileForm tmp = new userProfileForm();
            tmp.setUsername(username);
            tmp.Show();
        }
    }
}
