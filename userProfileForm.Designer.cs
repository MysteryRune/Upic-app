namespace Upic
{
    partial class userProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userProfileForm));
            panelHeader = new Panel();
            pb_friends = new PictureBox();
            pb_mess = new PictureBox();
            pb_noti = new PictureBox();
            pb_user1 = new PictureBox();
            panel1 = new Panel();
            tb_search = new TextBox();
            pb_logo_UPIC = new PictureBox();
            panel_bg = new Panel();
            panel_profile_and_posts = new Panel();
            btn_edit_profile = new Button();
            lbl_numbers_of_friends = new Label();
            lbl_profile_username = new Label();
            lbl_profile_name = new Label();
            pb_profile_user_avatar = new PictureBox();
            editProfileuc1 = new editProfileUC();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_friends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_mess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_noti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_user1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_UPIC).BeginInit();
            panel_bg.SuspendLayout();
            panel_profile_and_posts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_profile_user_avatar).BeginInit();
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
            pb_friends.Image = Properties.Resources.friends_shape_line;
            pb_friends.Location = new Point(1286, 7);
            pb_friends.Name = "pb_friends";
            pb_friends.Size = new Size(55, 55);
            pb_friends.SizeMode = PictureBoxSizeMode.Zoom;
            pb_friends.TabIndex = 5;
            pb_friends.TabStop = false;
            pb_friends.Click += pb_friends_Click;
            // 
            // pb_mess
            // 
            pb_mess.Image = Properties.Resources.mess_shape_line;
            pb_mess.Location = new Point(1362, 12);
            pb_mess.Name = "pb_mess";
            pb_mess.Size = new Size(50, 50);
            pb_mess.SizeMode = PictureBoxSizeMode.Zoom;
            pb_mess.TabIndex = 4;
            pb_mess.TabStop = false;
            pb_mess.Click += pb_mess_Click;
            // 
            // pb_noti
            // 
            pb_noti.BackColor = Color.Transparent;
            pb_noti.Image = Properties.Resources.notificationIcon1;
            pb_noti.Location = new Point(1430, 8);
            pb_noti.Name = "pb_noti";
            pb_noti.Size = new Size(55, 55);
            pb_noti.SizeMode = PictureBoxSizeMode.Zoom;
            pb_noti.TabIndex = 3;
            pb_noti.TabStop = false;
            pb_noti.Click += pb_noti_Click;
            // 
            // pb_user1
            // 
            pb_user1.BackColor = Color.Transparent;
            pb_user1.Image = Properties.Resources.accountIcon1;
            pb_user1.Location = new Point(1500, 6);
            pb_user1.Name = "pb_user1";
            pb_user1.Size = new Size(60, 60);
            pb_user1.SizeMode = PictureBoxSizeMode.Zoom;
            pb_user1.TabIndex = 2;
            pb_user1.TabStop = false;
            pb_user1.Click += pb_user1_Click;
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
            panel_bg.Controls.Add(panel_profile_and_posts);
            panel_bg.Controls.Add(editProfileuc1);
            panel_bg.Dock = DockStyle.Fill;
            panel_bg.Location = new Point(0, 0);
            panel_bg.Name = "panel_bg";
            panel_bg.Size = new Size(1600, 900);
            panel_bg.TabIndex = 4;
            panel_bg.Click += panel_bg_Click;
            // 
            // panel_profile_and_posts
            // 
            panel_profile_and_posts.BackColor = Color.White;
            panel_profile_and_posts.Controls.Add(btn_edit_profile);
            panel_profile_and_posts.Controls.Add(lbl_numbers_of_friends);
            panel_profile_and_posts.Controls.Add(lbl_profile_username);
            panel_profile_and_posts.Controls.Add(lbl_profile_name);
            panel_profile_and_posts.Controls.Add(pb_profile_user_avatar);
            panel_profile_and_posts.ForeColor = Color.FromArgb(128, 139, 150);
            panel_profile_and_posts.Location = new Point(260, 90);
            panel_profile_and_posts.Name = "panel_profile_and_posts";
            panel_profile_and_posts.Size = new Size(1080, 200);
            panel_profile_and_posts.TabIndex = 0;
            // 
            // btn_edit_profile
            // 
            btn_edit_profile.BackColor = Color.Transparent;
            btn_edit_profile.BackgroundImage = Properties.Resources.edit_bg;
            btn_edit_profile.BackgroundImageLayout = ImageLayout.Stretch;
            btn_edit_profile.Cursor = Cursors.Hand;
            btn_edit_profile.FlatAppearance.BorderColor = Color.White;
            btn_edit_profile.FlatStyle = FlatStyle.Flat;
            btn_edit_profile.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit_profile.ForeColor = Color.Black;
            btn_edit_profile.Location = new Point(702, 34);
            btn_edit_profile.Name = "btn_edit_profile";
            btn_edit_profile.Size = new Size(273, 65);
            btn_edit_profile.TabIndex = 5;
            btn_edit_profile.Text = "  Chỉnh sửa hồ sơ";
            btn_edit_profile.UseVisualStyleBackColor = false;
            btn_edit_profile.Click += btn_edit_profile_Click;
            // 
            // lbl_numbers_of_friends
            // 
            lbl_numbers_of_friends.AutoSize = true;
            lbl_numbers_of_friends.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_numbers_of_friends.ForeColor = Color.FromArgb(86, 101, 115);
            lbl_numbers_of_friends.Location = new Point(265, 123);
            lbl_numbers_of_friends.Name = "lbl_numbers_of_friends";
            lbl_numbers_of_friends.Size = new Size(92, 28);
            lbl_numbers_of_friends.TabIndex = 3;
            lbl_numbers_of_friends.Text = "... bạn bè";
            lbl_numbers_of_friends.Visible = false;
            // 
            // lbl_profile_username
            // 
            lbl_profile_username.AutoSize = true;
            lbl_profile_username.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_profile_username.ForeColor = Color.FromArgb(86, 101, 115);
            lbl_profile_username.Location = new Point(261, 84);
            lbl_profile_username.Name = "lbl_profile_username";
            lbl_profile_username.Size = new Size(116, 28);
            lbl_profile_username.TabIndex = 2;
            lbl_profile_username.Text = "@username";
            // 
            // lbl_profile_name
            // 
            lbl_profile_name.AutoSize = true;
            lbl_profile_name.Font = new Font("Be Vietnam Pro SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_profile_name.ForeColor = Color.Black;
            lbl_profile_name.Location = new Point(261, 42);
            lbl_profile_name.Name = "lbl_profile_name";
            lbl_profile_name.Size = new Size(197, 42);
            lbl_profile_name.TabIndex = 1;
            lbl_profile_name.Text = "Profile Name";
            // 
            // pb_profile_user_avatar
            // 
            pb_profile_user_avatar.Image = Properties.Resources.accountIcon;
            pb_profile_user_avatar.Location = new Point(77, 24);
            pb_profile_user_avatar.Name = "pb_profile_user_avatar";
            pb_profile_user_avatar.Size = new Size(160, 160);
            pb_profile_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_profile_user_avatar.TabIndex = 0;
            pb_profile_user_avatar.TabStop = false;
            // 
            // editProfileuc1
            // 
            editProfileuc1.AutoScroll = true;
            editProfileuc1.BackColor = Color.White;
            editProfileuc1.Location = new Point(324, 90);
            editProfileuc1.Name = "editProfileuc1";
            editProfileuc1.Size = new Size(952, 800);
            editProfileuc1.TabIndex = 2;
            editProfileuc1.Visible = false;
            editProfileuc1.VisibleChanged += editProfileuc1_VisibleChanged;
            // 
            // userProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panelHeader);
            Controls.Add(panel_bg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "userProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upic";
            Load += userProfileForm_Load;
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_friends).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_mess).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_noti).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_user1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_UPIC).EndInit();
            panel_bg.ResumeLayout(false);
            panel_profile_and_posts.ResumeLayout(false);
            panel_profile_and_posts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_profile_user_avatar).EndInit();
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
        private Panel panel_profile_and_posts;
        private Label lbl_numbers_of_friends;
        private Label lbl_profile_username;
        private Label lbl_profile_name;
        private PictureBox pb_profile_user_avatar;
        private Button btn_edit_profile;
        private editProfileUC editProfileuc1;
    }
}