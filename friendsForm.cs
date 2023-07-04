using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using static Google.Api.ResourceDescriptor.Types;

namespace Upic
{
    public partial class friendsForm : Form
    {
        private List<FriendRequest> friendRequests = new List<FriendRequest>();
        private List<string> friends = new List<string>();

        private bool close_by_X_btt;

        public friendsForm()
        {
            InitializeComponent();
            close_by_X_btt = true;
            FormClosed += new FormClosedEventHandler(friendForm_FormClosedByXBtt);
        }

        private void returnToHomePage()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.Visible = true;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.ShowInTaskbar = true;
        }

        private void friendForm_FormClosedByXBtt(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && close_by_X_btt == true)
            {
                returnToHomePage();
            }
        }

        private void btn_allfriends_Click(object sender, EventArgs e)
        {
            flp_friend_requests.Visible = false;
            flp_all_friends.Visible = true;

        }

        private void btn_friendrequests_Click(object sender, EventArgs e)
        {
            flp_all_friends.Visible = false;
            flp_friend_requests.Visible = true;
        }

        private void pb_logo_UPIC_Click(object sender, EventArgs e)
        {
            close_by_X_btt = false;
            Close();
            returnToHomePage();
        }



        private void addFriend(string friendName)
        {
            Panel newFriendRequest = new Panel();
            newFriendRequest.Name = "panel_request_of_" + friendName;
            newFriendRequest.Text = friendName;
            newFriendRequest.Visible = true;
            newFriendRequest.AutoSize = true;

            flp_friend_requests.Controls.Add(newFriendRequest);

        }
    }
}
