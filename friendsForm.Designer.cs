namespace Upic
{
    partial class friendsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(friendsForm));
            panelHeader = new Panel();
            pb_friends = new PictureBox();
            pb_mess = new PictureBox();
            pb_noti = new PictureBox();
            pb_user1 = new PictureBox();
            panel1 = new Panel();
            tb_search = new TextBox();
            pb_logo_UPIC = new PictureBox();
            panel_bg = new Panel();
            panel2 = new Panel();
            btn_allfriends = new Button();
            btn_friendrequests = new Button();
            flp_all_friends = new FlowLayoutPanel();
            panel_friend_per_user = new Panel();
            btn_delete_friend = new Button();
            lbl_request_user_name = new Label();
            lbl_request_name = new Label();
            pb_request_avt = new PictureBox();
            flp_friend_requests = new FlowLayoutPanel();
            panel_request_per_user = new Panel();
            btn_accept_request = new Button();
            btn_delete_request = new Button();
            lbl_profile_username = new Label();
            lbl_friend_name = new Label();
            pb_avatar_of_user_request = new PictureBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_friends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_mess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_noti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_user1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_UPIC).BeginInit();
            panel_bg.SuspendLayout();
            panel2.SuspendLayout();
            flp_all_friends.SuspendLayout();
            panel_friend_per_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_request_avt).BeginInit();
            flp_friend_requests.SuspendLayout();
            panel_request_per_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_avatar_of_user_request).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(pb_friends);
            panelHeader.Controls.Add(pb_mess);
            panelHeader.Controls.Add(pb_noti);
            panelHeader.Controls.Add(pb_user1);
            panelHeader.Controls.Add(panel1);
            panelHeader.Controls.Add(pb_logo_UPIC);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1600, 70);
            panelHeader.TabIndex = 3;
            // 
            // pb_friends
            // 
            pb_friends.Cursor = Cursors.Hand;
            pb_friends.Image = Properties.Resources.friends_fill;
            pb_friends.Location = new Point(1286, 7);
            pb_friends.Name = "pb_friends";
            pb_friends.Size = new Size(55, 55);
            pb_friends.SizeMode = PictureBoxSizeMode.Zoom;
            pb_friends.TabIndex = 5;
            pb_friends.TabStop = false;
            // 
            // pb_mess
            // 
            pb_mess.Cursor = Cursors.Hand;
            pb_mess.Image = Properties.Resources.mess_shape_line;
            pb_mess.Location = new Point(1362, 12);
            pb_mess.Name = "pb_mess";
            pb_mess.Size = new Size(50, 50);
            pb_mess.SizeMode = PictureBoxSizeMode.Zoom;
            pb_mess.TabIndex = 4;
            pb_mess.TabStop = false;
            // 
            // pb_noti
            // 
            pb_noti.BackColor = Color.Transparent;
            pb_noti.Cursor = Cursors.Hand;
            pb_noti.Image = Properties.Resources.notificationIcon1;
            pb_noti.Location = new Point(1430, 8);
            pb_noti.Name = "pb_noti";
            pb_noti.Size = new Size(55, 55);
            pb_noti.SizeMode = PictureBoxSizeMode.Zoom;
            pb_noti.TabIndex = 3;
            pb_noti.TabStop = false;
            // 
            // pb_user1
            // 
            pb_user1.BackColor = Color.Transparent;
            pb_user1.Cursor = Cursors.Hand;
            pb_user1.Image = Properties.Resources.accountIcon1;
            pb_user1.Location = new Point(1500, 6);
            pb_user1.Name = "pb_user1";
            pb_user1.Size = new Size(60, 60);
            pb_user1.SizeMode = PictureBoxSizeMode.Zoom;
            pb_user1.TabIndex = 2;
            pb_user1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.search_bg;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(tb_search);
            panel1.Location = new Point(94, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 70);
            panel1.TabIndex = 0;
            // 
            // tb_search
            // 
            tb_search.BackColor = Color.FromArgb(240, 242, 245);
            tb_search.BorderStyle = BorderStyle.None;
            tb_search.Cursor = Cursors.IBeam;
            tb_search.Font = new Font("Be Vietnam Pro", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_search.Location = new Point(20, 21);
            tb_search.Multiline = true;
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Tìm kiếm trên Upic";
            tb_search.Size = new Size(291, 27);
            tb_search.TabIndex = 0;
            // 
            // pb_logo_UPIC
            // 
            pb_logo_UPIC.BackColor = Color.White;
            pb_logo_UPIC.BackgroundImageLayout = ImageLayout.Zoom;
            pb_logo_UPIC.Cursor = Cursors.Hand;
            pb_logo_UPIC.Image = Properties.Resources.upic_logo;
            pb_logo_UPIC.Location = new Point(33, 7);
            pb_logo_UPIC.Name = "pb_logo_UPIC";
            pb_logo_UPIC.Size = new Size(55, 55);
            pb_logo_UPIC.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo_UPIC.TabIndex = 1;
            pb_logo_UPIC.TabStop = false;
            pb_logo_UPIC.Click += pb_logo_UPIC_Click;
            // 
            // panel_bg
            // 
            panel_bg.BackColor = Color.FromArgb(234, 236, 238);
            panel_bg.Controls.Add(panel2);
            panel_bg.Dock = DockStyle.Fill;
            panel_bg.Location = new Point(0, 0);
            panel_bg.Name = "panel_bg";
            panel_bg.Size = new Size(1600, 900);
            panel_bg.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_allfriends);
            panel2.Controls.Add(btn_friendrequests);
            panel2.Controls.Add(flp_friend_requests);
            panel2.Controls.Add(flp_all_friends);
            panel2.Location = new Point(271, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 807);
            panel2.TabIndex = 0;
            // 
            // btn_allfriends
            // 
            btn_allfriends.BackColor = Color.FromArgb(213, 216, 220);
            btn_allfriends.FlatAppearance.BorderColor = Color.White;
            btn_allfriends.FlatStyle = FlatStyle.Flat;
            btn_allfriends.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_allfriends.Location = new Point(539, 21);
            btn_allfriends.Name = "btn_allfriends";
            btn_allfriends.Size = new Size(512, 44);
            btn_allfriends.TabIndex = 1;
            btn_allfriends.Text = "Bạn bè";
            btn_allfriends.UseVisualStyleBackColor = false;
            btn_allfriends.Click += btn_allfriends_Click;
            // 
            // btn_friendrequests
            // 
            btn_friendrequests.BackColor = Color.FromArgb(213, 216, 220);
            btn_friendrequests.FlatAppearance.BorderColor = Color.White;
            btn_friendrequests.FlatStyle = FlatStyle.Flat;
            btn_friendrequests.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_friendrequests.Location = new Point(21, 21);
            btn_friendrequests.Name = "btn_friendrequests";
            btn_friendrequests.Size = new Size(512, 44);
            btn_friendrequests.TabIndex = 0;
            btn_friendrequests.Text = "Lời mời kết bạn";
            btn_friendrequests.UseVisualStyleBackColor = false;
            btn_friendrequests.Click += btn_friendrequests_Click;
            // 
            // flp_all_friends
            // 
            flp_all_friends.BackColor = Color.White;
            flp_all_friends.Controls.Add(panel_friend_per_user);
            flp_all_friends.Location = new Point(21, 71);
            flp_all_friends.Name = "flp_all_friends";
            flp_all_friends.Size = new Size(1030, 715);
            flp_all_friends.TabIndex = 2;
            flp_all_friends.Visible = false;
            // 
            // panel_friend_per_user
            // 
            panel_friend_per_user.BorderStyle = BorderStyle.FixedSingle;
            panel_friend_per_user.Controls.Add(btn_delete_friend);
            panel_friend_per_user.Controls.Add(lbl_request_user_name);
            panel_friend_per_user.Controls.Add(lbl_request_name);
            panel_friend_per_user.Controls.Add(pb_request_avt);
            panel_friend_per_user.Location = new Point(3, 3);
            panel_friend_per_user.Name = "panel_friend_per_user";
            panel_friend_per_user.Size = new Size(509, 155);
            panel_friend_per_user.TabIndex = 1;
            // 
            // btn_delete_friend
            // 
            btn_delete_friend.BackColor = Color.FromArgb(213, 216, 220);
            btn_delete_friend.FlatAppearance.BorderColor = Color.White;
            btn_delete_friend.FlatStyle = FlatStyle.Flat;
            btn_delete_friend.Font = new Font("Be Vietnam Pro SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_friend.Location = new Point(379, 20);
            btn_delete_friend.Name = "btn_delete_friend";
            btn_delete_friend.Size = new Size(114, 44);
            btn_delete_friend.TabIndex = 1;
            btn_delete_friend.Text = "Xóa bạn";
            btn_delete_friend.UseVisualStyleBackColor = false;
            // 
            // lbl_request_user_name
            // 
            lbl_request_user_name.AutoSize = true;
            lbl_request_user_name.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_request_user_name.ForeColor = Color.FromArgb(86, 101, 115);
            lbl_request_user_name.Location = new Point(136, 55);
            lbl_request_user_name.Name = "lbl_request_user_name";
            lbl_request_user_name.Size = new Size(116, 28);
            lbl_request_user_name.TabIndex = 3;
            lbl_request_user_name.Text = "@username";
            // 
            // lbl_request_name
            // 
            lbl_request_name.AutoSize = true;
            lbl_request_name.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_request_name.Location = new Point(136, 25);
            lbl_request_name.Name = "lbl_request_name";
            lbl_request_name.Size = new Size(204, 30);
            lbl_request_name.TabIndex = 1;
            lbl_request_name.Text = "Phạm Bùi Nhật Huy";
            // 
            // pb_request_avt
            // 
            pb_request_avt.Image = Properties.Resources.accountIcon;
            pb_request_avt.Location = new Point(10, 14);
            pb_request_avt.Name = "pb_request_avt";
            pb_request_avt.Size = new Size(120, 120);
            pb_request_avt.SizeMode = PictureBoxSizeMode.Zoom;
            pb_request_avt.TabIndex = 0;
            pb_request_avt.TabStop = false;
            // 
            // flp_friend_requests
            // 
            flp_friend_requests.BackColor = Color.White;
            flp_friend_requests.Controls.Add(panel_request_per_user);
            flp_friend_requests.Location = new Point(21, 71);
            flp_friend_requests.Name = "flp_friend_requests";
            flp_friend_requests.Size = new Size(1030, 715);
            flp_friend_requests.TabIndex = 1;
            // 
            // panel_request_per_user
            // 
            panel_request_per_user.BorderStyle = BorderStyle.FixedSingle;
            panel_request_per_user.Controls.Add(btn_accept_request);
            panel_request_per_user.Controls.Add(btn_delete_request);
            panel_request_per_user.Controls.Add(lbl_profile_username);
            panel_request_per_user.Controls.Add(lbl_friend_name);
            panel_request_per_user.Controls.Add(pb_avatar_of_user_request);
            panel_request_per_user.Location = new Point(3, 3);
            panel_request_per_user.Name = "panel_request_per_user";
            panel_request_per_user.Size = new Size(237, 337);
            panel_request_per_user.TabIndex = 1;
            // 
            // btn_accept_request
            // 
            btn_accept_request.BackColor = Color.FromArgb(52, 152, 219);
            btn_accept_request.FlatAppearance.BorderColor = Color.White;
            btn_accept_request.FlatStyle = FlatStyle.Flat;
            btn_accept_request.Font = new Font("Be Vietnam Pro SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_accept_request.ForeColor = Color.White;
            btn_accept_request.Location = new Point(49, 231);
            btn_accept_request.Name = "btn_accept_request";
            btn_accept_request.Size = new Size(139, 44);
            btn_accept_request.TabIndex = 2;
            btn_accept_request.Text = "Chấp nhận";
            btn_accept_request.UseVisualStyleBackColor = false;
            // 
            // btn_delete_request
            // 
            btn_delete_request.BackColor = Color.FromArgb(213, 216, 220);
            btn_delete_request.FlatAppearance.BorderColor = Color.White;
            btn_delete_request.FlatStyle = FlatStyle.Flat;
            btn_delete_request.Font = new Font("Be Vietnam Pro SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_request.Location = new Point(49, 281);
            btn_delete_request.Name = "btn_delete_request";
            btn_delete_request.Size = new Size(139, 44);
            btn_delete_request.TabIndex = 1;
            btn_delete_request.Text = "Xóa";
            btn_delete_request.UseVisualStyleBackColor = false;
            // 
            // lbl_profile_username
            // 
            lbl_profile_username.AutoSize = true;
            lbl_profile_username.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_profile_username.ForeColor = Color.FromArgb(86, 101, 115);
            lbl_profile_username.Location = new Point(63, 194);
            lbl_profile_username.Name = "lbl_profile_username";
            lbl_profile_username.Size = new Size(116, 28);
            lbl_profile_username.TabIndex = 3;
            lbl_profile_username.Text = "@username";
            // 
            // lbl_friend_name
            // 
            lbl_friend_name.AutoSize = true;
            lbl_friend_name.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_friend_name.Location = new Point(14, 166);
            lbl_friend_name.Name = "lbl_friend_name";
            lbl_friend_name.Size = new Size(204, 30);
            lbl_friend_name.TabIndex = 1;
            lbl_friend_name.Text = "Phạm Bùi Nhật Huy";
            // 
            // pb_avatar_of_user_request
            // 
            pb_avatar_of_user_request.Image = Properties.Resources.accountIcon;
            pb_avatar_of_user_request.Location = new Point(37, 2);
            pb_avatar_of_user_request.Name = "pb_avatar_of_user_request";
            pb_avatar_of_user_request.Size = new Size(160, 160);
            pb_avatar_of_user_request.SizeMode = PictureBoxSizeMode.Zoom;
            pb_avatar_of_user_request.TabIndex = 0;
            pb_avatar_of_user_request.TabStop = false;
            // 
            // friendsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panelHeader);
            Controls.Add(panel_bg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "friendsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upic";
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_friends).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_mess).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_noti).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_user1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_UPIC).EndInit();
            panel_bg.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flp_all_friends.ResumeLayout(false);
            panel_friend_per_user.ResumeLayout(false);
            panel_friend_per_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_request_avt).EndInit();
            flp_friend_requests.ResumeLayout(false);
            panel_request_per_user.ResumeLayout(false);
            panel_request_per_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_avatar_of_user_request).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pb_friends;
        private PictureBox pb_mess;
        private PictureBox pb_noti;
        private PictureBox pb_user1;
        private Panel panel1;
        private TextBox tb_search;
        private PictureBox pb_logo_UPIC;
        private Panel panel_bg;
        private Panel panel2;
        private Button btn_friendrequests;
        private Button btn_allfriends;
        private Panel panel_friend_per_user;
        private Button btn_delete_friend;
        private Label lbl_request_user_name;
        private Label lbl_request_name;
        private PictureBox pb_request_avt;
        private FlowLayoutPanel flp_all_friends;
        private FlowLayoutPanel flp_friend_requests;
        private Panel panel_request_per_user;
        private Button btn_accept_request;
        private Button btn_delete_request;
        private Label lbl_profile_username;
        private Label lbl_friend_name;
        private PictureBox pb_avatar_of_user_request;
    }
}