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
    public partial class messagesForm : Form
    {
        String username;

        public messagesForm()
        {
            InitializeComponent();
        }

        public void setUsername(String username)
        {
            this.username = username;
        }


        private void panel_bg_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void btn_add_image_Click(object sender, EventArgs e)
        {

        }

        private void pb_friends_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new friendsForm();
            form.Show();
        }

        private void pb_logo_UPIC_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Close();
            homepageForm tmp = new homepageForm();
            tmp.Show();
            //#pragma warning disable CS8602 // Dereference of a possibly null reference.
            //            homepageForm.homePageInstance.Visible = true;
            //#pragma warning restore CS8602 // Dereference of a possibly null reference.
            //            homepageForm.homePageInstance.ShowInTaskbar = true;
        }

        private void pb_mess_Click(object sender, EventArgs e)
        {
            Refresh();
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
            userProfileForm tmp = new userProfileForm();
            tmp.setUsername(username);
            tmp.Show();
        }
    }
}
