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
using Upic;


namespace Upic
{
    public partial class friendsForm : Form
    {
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

        private List<FriendRequest> friendRequests = new List<FriendRequest>();
        private List<string> friends = new List<string>();


        private void btn_add_friend_Click(object sender, EventArgs e)
        {
            //string friendName = lbl_profile_name.Text;
            //Image friendAvatar = pb_.Image;
            string friendName = "Nguyễn Thị Như Vân";
            Image friendAvatar = Upic.Properties.Resources.accountIcon1;

            FriendRequest friendRequest = new FriendRequest(friendName, friendAvatar);

            friendRequests.Add(friendRequest);
            AddFriendRequestPanel(friendRequest);
        }

        private void AddFriendRequestPanel(FriendRequest friendRequest)
        {
            //lời mời kết bạn
            Panel panel_request_per_user = new Panel();
            panel_request_per_user.BorderStyle = BorderStyle.FixedSingle;
            panel_request_per_user.Size = new Size(237, 337);

            //ảnh đại diện
            PictureBox pb_avatar_of_user_request = new PictureBox();
            pb_avatar_of_user_request.Image = friendRequest.Avatar;
            pb_avatar_of_user_request.SizeMode = PictureBoxSizeMode.Zoom;
            pb_avatar_of_user_request.Size = new Size(160, 160);
            pb_avatar_of_user_request.BackColor = Color.White;
            pb_avatar_of_user_request.Cursor = Cursors.Hand;
            panel_request_per_user.Controls.Add(pb_avatar_of_user_request);

            //tên hồ sơ
            Label lbl_friend_name = new Label();
            lbl_friend_name.Text = friendRequest.Name;
            lbl_friend_name.AutoSize = true;
            lbl_friend_name.Font = new Font("Be Vietnam Pro SemiBold", 12, FontStyle.Bold);
            lbl_friend_name.Size = new Size(204, 30);
            panel_request_per_user.Controls.Add(lbl_friend_name);

            //tên người dùng
            Label lbl_profile_username = new Label();
            lbl_profile_username.Text = "@" + "username"; //chưa biết get username nên để tạm vậy
            lbl_profile_username.AutoSize = true;
            lbl_profile_username.Font = new Font("Be Vietnam Pro SemiBold", 11, FontStyle.Regular);
            lbl_profile_username.Size = new Size(116, 28);
            lbl_profile_username.ForeColor = Color.FromArgb(86, 101, 115);
            panel_request_per_user.Controls.Add(lbl_profile_username);



            //Chấp nhận
            Button btn_accept_request = new Button();
            btn_accept_request.Text = "Chấp nhận";
            btn_accept_request.AutoSize = false;
            btn_accept_request.FlatStyle = FlatStyle.Flat;
            btn_accept_request.FlatAppearance.BorderColor = Color.White;
            btn_accept_request.Font = new Font("Be Vietnam Pro SemiBold", 10, FontStyle.Bold);
            btn_accept_request.ForeColor = Color.White;
            btn_accept_request.Size = new Size(139, 44);
            btn_accept_request.UseVisualStyleBackColor = false;
            btn_accept_request.Cursor = Cursors.Hand;
            btn_accept_request.Click += (sender, e) =>
            {
                friends.Add(friendRequest.Name);
                friendRequests.Remove(friendRequest);
                flp_friend_requests.Controls.Remove(panel_request_per_user);
                //AddFriendToList(friendRequest.Name);
            };
            panel_request_per_user.Controls.Add(btn_accept_request);

            // button Xóa
            Button btn_delete_request = new Button();
            btn_delete_request.Text = "Xóa";
            btn_delete_request.AutoSize = false;
            btn_delete_request.Font = new Font("Be Vietnam Pro SemiBold", 10, FontStyle.Bold);
            btn_delete_request.FlatStyle = FlatStyle.Flat;
            btn_delete_request.Size = new Size(139, 44);
            btn_delete_request.FlatAppearance.BorderColor = Color.White;
            btn_delete_request.ForeColor = Color.Black;
            btn_delete_request.UseVisualStyleBackColor = false;
            btn_delete_request.Cursor = Cursors.Hand;
            btn_delete_request.Click += (sender, e) =>
            {
                friendRequests.Remove(friendRequest);
                flp_friend_requests.Controls.Remove(panel_request_per_user);
            };
            panel_request_per_user.Controls.Add(btn_delete_request);

            // Thêm panel vào flp
            flp_friend_requests.Controls.Add(panel_request_per_user);
        }

        public class FriendRequest
        {
            public string Name { get; }
            public Image Avatar { get; }

            public FriendRequest(string name, Image avatar)
            {
                Name = name;
                Avatar = avatar;
            }
        }

    }
}
