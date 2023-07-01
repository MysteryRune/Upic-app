namespace Upic
{
    partial class notificationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notificationsForm));
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
            lbl_noti = new Label();
            panel_today_noti = new Panel();
            panel_unread_noti = new Panel();
            lbl_unread_date = new Label();
            panel_unread_likecmt = new Panel();
            lbl_unread_likedcmt = new Label();
            lbl_likecmt_name = new Label();
            pb_unread_likecmt_user_avatar = new PictureBox();
            panel_unread_comment = new Panel();
            lbl_unread_commentedyourpost = new Label();
            lbl_unread_name = new Label();
            pb_unread_comment_user_avatar = new PictureBox();
            panel_unread_like = new Panel();
            lbl_unread_likedyourpost = new Label();
            lbl_unread_like_name = new Label();
            pb_unread_like_user_avatar = new PictureBox();
            lbl_unread_today = new Label();
            panel_all_noti = new Panel();
            lbl_all_noti_date = new Label();
            panel_all_noti_likecmt = new Panel();
            lbl_all_noti_likedyourcmt = new Label();
            lbl_all_noti_likecmt_name = new Label();
            pb_all_noti_likecmt_user_avatar = new PictureBox();
            panel_all_noti_comment = new Panel();
            lbl_all_noti_commented_your_post = new Label();
            lbl_all_noti_comment_name = new Label();
            pb_all_noti_comment_user_avatar = new PictureBox();
            panel_all_noti_like = new Panel();
            label_all_noti_liked_your_post = new Label();
            lbl_all_noti_like_name = new Label();
            pb_all_noti_like_user_avatar = new PictureBox();
            lbl_all_noti_today = new Label();
            btn_unread_noti = new Button();
            btn_all_noti = new Button();
            flp_notifications = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_friends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_mess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_noti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_user1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_UPIC).BeginInit();
            panel_bg.SuspendLayout();
            panel2.SuspendLayout();
            panel_today_noti.SuspendLayout();
            panel_unread_noti.SuspendLayout();
            panel_unread_likecmt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unread_likecmt_user_avatar).BeginInit();
            panel_unread_comment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unread_comment_user_avatar).BeginInit();
            panel_unread_like.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unread_like_user_avatar).BeginInit();
            panel_all_noti.SuspendLayout();
            panel_all_noti_likecmt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_all_noti_likecmt_user_avatar).BeginInit();
            panel_all_noti_comment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_all_noti_comment_user_avatar).BeginInit();
            panel_all_noti_like.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_all_noti_like_user_avatar).BeginInit();
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
            panel_bg.Paint += panel_bg_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_noti);
            panel2.Controls.Add(panel_today_noti);
            panel2.Controls.Add(flp_notifications);
            panel2.Location = new Point(271, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 820);
            panel2.TabIndex = 0;
            // 
            // lbl_noti
            // 
            lbl_noti.AutoSize = true;
            lbl_noti.Font = new Font("Be Vietnam Pro ExtraBold", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_noti.Location = new Point(46, 15);
            lbl_noti.Name = "lbl_noti";
            lbl_noti.Size = new Size(229, 57);
            lbl_noti.TabIndex = 1;
            lbl_noti.Text = "Thông báo";
            // 
            // panel_today_noti
            // 
            panel_today_noti.Controls.Add(panel_unread_noti);
            panel_today_noti.Controls.Add(panel_all_noti);
            panel_today_noti.Controls.Add(btn_unread_noti);
            panel_today_noti.Controls.Add(btn_all_noti);
            panel_today_noti.Location = new Point(46, 75);
            panel_today_noti.Name = "panel_today_noti";
            panel_today_noti.Size = new Size(980, 718);
            panel_today_noti.TabIndex = 0;
            // 
            // panel_unread_noti
            // 
            panel_unread_noti.Controls.Add(lbl_unread_date);
            panel_unread_noti.Controls.Add(panel_unread_likecmt);
            panel_unread_noti.Controls.Add(panel_unread_comment);
            panel_unread_noti.Controls.Add(panel_unread_like);
            panel_unread_noti.Controls.Add(lbl_unread_today);
            panel_unread_noti.Location = new Point(13, 64);
            panel_unread_noti.Name = "panel_unread_noti";
            panel_unread_noti.Size = new Size(952, 652);
            panel_unread_noti.TabIndex = 4;
            panel_unread_noti.Visible = false;
            // 
            // lbl_unread_date
            // 
            lbl_unread_date.AutoSize = true;
            lbl_unread_date.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_unread_date.Location = new Point(3, 449);
            lbl_unread_date.Name = "lbl_unread_date";
            lbl_unread_date.Size = new Size(233, 35);
            lbl_unread_date.TabIndex = 4;
            lbl_unread_date.Text = "Ngày dd/mm/yyyy";
            // 
            // panel_unread_likecmt
            // 
            panel_unread_likecmt.Controls.Add(lbl_unread_likedcmt);
            panel_unread_likecmt.Controls.Add(lbl_likecmt_name);
            panel_unread_likecmt.Controls.Add(pb_unread_likecmt_user_avatar);
            panel_unread_likecmt.Location = new Point(3, 311);
            panel_unread_likecmt.Name = "panel_unread_likecmt";
            panel_unread_likecmt.Size = new Size(946, 125);
            panel_unread_likecmt.TabIndex = 3;
            // 
            // lbl_unread_likedcmt
            // 
            lbl_unread_likedcmt.AutoSize = true;
            lbl_unread_likedcmt.Font = new Font("Be Vietnam Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_unread_likedcmt.Location = new Point(373, 35);
            lbl_unread_likedcmt.Name = "lbl_unread_likedcmt";
            lbl_unread_likedcmt.Size = new Size(271, 30);
            lbl_unread_likedcmt.TabIndex = 2;
            lbl_unread_likedcmt.Text = "đã thích bình luận của bạn";
            // 
            // lbl_likecmt_name
            // 
            lbl_likecmt_name.AutoSize = true;
            lbl_likecmt_name.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_likecmt_name.Location = new Point(144, 35);
            lbl_likecmt_name.Name = "lbl_likecmt_name";
            lbl_likecmt_name.Size = new Size(223, 30);
            lbl_likecmt_name.TabIndex = 1;
            lbl_likecmt_name.Text = "Tên hồ sơ người dùng";
            // 
            // pb_unread_likecmt_user_avatar
            // 
            pb_unread_likecmt_user_avatar.Image = Properties.Resources.accountIcon;
            pb_unread_likecmt_user_avatar.Location = new Point(45, 22);
            pb_unread_likecmt_user_avatar.Name = "pb_unread_likecmt_user_avatar";
            pb_unread_likecmt_user_avatar.Size = new Size(80, 80);
            pb_unread_likecmt_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_unread_likecmt_user_avatar.TabIndex = 0;
            pb_unread_likecmt_user_avatar.TabStop = false;
            // 
            // panel_unread_comment
            // 
            panel_unread_comment.Controls.Add(lbl_unread_commentedyourpost);
            panel_unread_comment.Controls.Add(lbl_unread_name);
            panel_unread_comment.Controls.Add(pb_unread_comment_user_avatar);
            panel_unread_comment.Location = new Point(3, 180);
            panel_unread_comment.Name = "panel_unread_comment";
            panel_unread_comment.Size = new Size(946, 125);
            panel_unread_comment.TabIndex = 2;
            // 
            // lbl_unread_commentedyourpost
            // 
            lbl_unread_commentedyourpost.AutoSize = true;
            lbl_unread_commentedyourpost.Font = new Font("Be Vietnam Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_unread_commentedyourpost.Location = new Point(373, 35);
            lbl_unread_commentedyourpost.Name = "lbl_unread_commentedyourpost";
            lbl_unread_commentedyourpost.Size = new Size(294, 30);
            lbl_unread_commentedyourpost.TabIndex = 2;
            lbl_unread_commentedyourpost.Text = "đã bình luận bài viết của bạn";
            // 
            // lbl_unread_name
            // 
            lbl_unread_name.AutoSize = true;
            lbl_unread_name.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_unread_name.Location = new Point(144, 35);
            lbl_unread_name.Name = "lbl_unread_name";
            lbl_unread_name.Size = new Size(223, 30);
            lbl_unread_name.TabIndex = 1;
            lbl_unread_name.Text = "Tên hồ sơ người dùng";
            // 
            // pb_unread_comment_user_avatar
            // 
            pb_unread_comment_user_avatar.Image = Properties.Resources.accountIcon;
            pb_unread_comment_user_avatar.Location = new Point(45, 22);
            pb_unread_comment_user_avatar.Name = "pb_unread_comment_user_avatar";
            pb_unread_comment_user_avatar.Size = new Size(80, 80);
            pb_unread_comment_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_unread_comment_user_avatar.TabIndex = 0;
            pb_unread_comment_user_avatar.TabStop = false;
            // 
            // panel_unread_like
            // 
            panel_unread_like.Controls.Add(lbl_unread_likedyourpost);
            panel_unread_like.Controls.Add(lbl_unread_like_name);
            panel_unread_like.Controls.Add(pb_unread_like_user_avatar);
            panel_unread_like.Location = new Point(3, 49);
            panel_unread_like.Name = "panel_unread_like";
            panel_unread_like.Size = new Size(946, 125);
            panel_unread_like.TabIndex = 1;
            // 
            // lbl_unread_likedyourpost
            // 
            lbl_unread_likedyourpost.AutoSize = true;
            lbl_unread_likedyourpost.Font = new Font("Be Vietnam Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_unread_likedyourpost.Location = new Point(373, 35);
            lbl_unread_likedyourpost.Name = "lbl_unread_likedyourpost";
            lbl_unread_likedyourpost.Size = new Size(258, 30);
            lbl_unread_likedyourpost.TabIndex = 2;
            lbl_unread_likedyourpost.Text = "đã thích bài viết của bạn";
            // 
            // lbl_unread_like_name
            // 
            lbl_unread_like_name.AutoSize = true;
            lbl_unread_like_name.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_unread_like_name.Location = new Point(144, 35);
            lbl_unread_like_name.Name = "lbl_unread_like_name";
            lbl_unread_like_name.Size = new Size(223, 30);
            lbl_unread_like_name.TabIndex = 1;
            lbl_unread_like_name.Text = "Tên hồ sơ người dùng";
            // 
            // pb_unread_like_user_avatar
            // 
            pb_unread_like_user_avatar.Image = Properties.Resources.accountIcon;
            pb_unread_like_user_avatar.Location = new Point(45, 22);
            pb_unread_like_user_avatar.Name = "pb_unread_like_user_avatar";
            pb_unread_like_user_avatar.Size = new Size(80, 80);
            pb_unread_like_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_unread_like_user_avatar.TabIndex = 0;
            pb_unread_like_user_avatar.TabStop = false;
            // 
            // lbl_unread_today
            // 
            lbl_unread_today.AutoSize = true;
            lbl_unread_today.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_unread_today.Location = new Point(3, 11);
            lbl_unread_today.Name = "lbl_unread_today";
            lbl_unread_today.Size = new Size(116, 35);
            lbl_unread_today.TabIndex = 0;
            lbl_unread_today.Text = "Hôm nay";
            // 
            // panel_all_noti
            // 
            panel_all_noti.Controls.Add(lbl_all_noti_date);
            panel_all_noti.Controls.Add(panel_all_noti_likecmt);
            panel_all_noti.Controls.Add(panel_all_noti_comment);
            panel_all_noti.Controls.Add(panel_all_noti_like);
            panel_all_noti.Controls.Add(lbl_all_noti_today);
            panel_all_noti.Location = new Point(13, 64);
            panel_all_noti.Name = "panel_all_noti";
            panel_all_noti.Size = new Size(952, 652);
            panel_all_noti.TabIndex = 3;
            // 
            // lbl_all_noti_date
            // 
            lbl_all_noti_date.AutoSize = true;
            lbl_all_noti_date.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_all_noti_date.Location = new Point(3, 449);
            lbl_all_noti_date.Name = "lbl_all_noti_date";
            lbl_all_noti_date.Size = new Size(233, 35);
            lbl_all_noti_date.TabIndex = 4;
            lbl_all_noti_date.Text = "Ngày dd/mm/yyyy";
            // 
            // panel_all_noti_likecmt
            // 
            panel_all_noti_likecmt.Controls.Add(lbl_all_noti_likedyourcmt);
            panel_all_noti_likecmt.Controls.Add(lbl_all_noti_likecmt_name);
            panel_all_noti_likecmt.Controls.Add(pb_all_noti_likecmt_user_avatar);
            panel_all_noti_likecmt.Location = new Point(3, 311);
            panel_all_noti_likecmt.Name = "panel_all_noti_likecmt";
            panel_all_noti_likecmt.Size = new Size(946, 125);
            panel_all_noti_likecmt.TabIndex = 3;
            // 
            // lbl_all_noti_likedyourcmt
            // 
            lbl_all_noti_likedyourcmt.AutoSize = true;
            lbl_all_noti_likedyourcmt.Font = new Font("Be Vietnam Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_all_noti_likedyourcmt.Location = new Point(373, 35);
            lbl_all_noti_likedyourcmt.Name = "lbl_all_noti_likedyourcmt";
            lbl_all_noti_likedyourcmt.Size = new Size(271, 30);
            lbl_all_noti_likedyourcmt.TabIndex = 2;
            lbl_all_noti_likedyourcmt.Text = "đã thích bình luận của bạn";
            // 
            // lbl_all_noti_likecmt_name
            // 
            lbl_all_noti_likecmt_name.AutoSize = true;
            lbl_all_noti_likecmt_name.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_all_noti_likecmt_name.Location = new Point(144, 35);
            lbl_all_noti_likecmt_name.Name = "lbl_all_noti_likecmt_name";
            lbl_all_noti_likecmt_name.Size = new Size(223, 30);
            lbl_all_noti_likecmt_name.TabIndex = 1;
            lbl_all_noti_likecmt_name.Text = "Tên hồ sơ người dùng";
            // 
            // pb_all_noti_likecmt_user_avatar
            // 
            pb_all_noti_likecmt_user_avatar.Image = Properties.Resources.accountIcon;
            pb_all_noti_likecmt_user_avatar.Location = new Point(45, 22);
            pb_all_noti_likecmt_user_avatar.Name = "pb_all_noti_likecmt_user_avatar";
            pb_all_noti_likecmt_user_avatar.Size = new Size(80, 80);
            pb_all_noti_likecmt_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_all_noti_likecmt_user_avatar.TabIndex = 0;
            pb_all_noti_likecmt_user_avatar.TabStop = false;
            // 
            // panel_all_noti_comment
            // 
            panel_all_noti_comment.Controls.Add(lbl_all_noti_commented_your_post);
            panel_all_noti_comment.Controls.Add(lbl_all_noti_comment_name);
            panel_all_noti_comment.Controls.Add(pb_all_noti_comment_user_avatar);
            panel_all_noti_comment.Location = new Point(3, 180);
            panel_all_noti_comment.Name = "panel_all_noti_comment";
            panel_all_noti_comment.Size = new Size(946, 125);
            panel_all_noti_comment.TabIndex = 2;
            // 
            // lbl_all_noti_commented_your_post
            // 
            lbl_all_noti_commented_your_post.AutoSize = true;
            lbl_all_noti_commented_your_post.Font = new Font("Be Vietnam Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_all_noti_commented_your_post.Location = new Point(373, 35);
            lbl_all_noti_commented_your_post.Name = "lbl_all_noti_commented_your_post";
            lbl_all_noti_commented_your_post.Size = new Size(294, 30);
            lbl_all_noti_commented_your_post.TabIndex = 2;
            lbl_all_noti_commented_your_post.Text = "đã bình luận bài viết của bạn";
            // 
            // lbl_all_noti_comment_name
            // 
            lbl_all_noti_comment_name.AutoSize = true;
            lbl_all_noti_comment_name.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_all_noti_comment_name.Location = new Point(144, 35);
            lbl_all_noti_comment_name.Name = "lbl_all_noti_comment_name";
            lbl_all_noti_comment_name.Size = new Size(223, 30);
            lbl_all_noti_comment_name.TabIndex = 1;
            lbl_all_noti_comment_name.Text = "Tên hồ sơ người dùng";
            // 
            // pb_all_noti_comment_user_avatar
            // 
            pb_all_noti_comment_user_avatar.Image = Properties.Resources.accountIcon;
            pb_all_noti_comment_user_avatar.Location = new Point(45, 22);
            pb_all_noti_comment_user_avatar.Name = "pb_all_noti_comment_user_avatar";
            pb_all_noti_comment_user_avatar.Size = new Size(80, 80);
            pb_all_noti_comment_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_all_noti_comment_user_avatar.TabIndex = 0;
            pb_all_noti_comment_user_avatar.TabStop = false;
            // 
            // panel_all_noti_like
            // 
            panel_all_noti_like.Controls.Add(label_all_noti_liked_your_post);
            panel_all_noti_like.Controls.Add(lbl_all_noti_like_name);
            panel_all_noti_like.Controls.Add(pb_all_noti_like_user_avatar);
            panel_all_noti_like.Location = new Point(3, 49);
            panel_all_noti_like.Name = "panel_all_noti_like";
            panel_all_noti_like.Size = new Size(946, 125);
            panel_all_noti_like.TabIndex = 1;
            // 
            // label_all_noti_liked_your_post
            // 
            label_all_noti_liked_your_post.AutoSize = true;
            label_all_noti_liked_your_post.Font = new Font("Be Vietnam Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_all_noti_liked_your_post.Location = new Point(373, 35);
            label_all_noti_liked_your_post.Name = "label_all_noti_liked_your_post";
            label_all_noti_liked_your_post.Size = new Size(258, 30);
            label_all_noti_liked_your_post.TabIndex = 2;
            label_all_noti_liked_your_post.Text = "đã thích bài viết của bạn";
            // 
            // lbl_all_noti_like_name
            // 
            lbl_all_noti_like_name.AutoSize = true;
            lbl_all_noti_like_name.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_all_noti_like_name.Location = new Point(144, 35);
            lbl_all_noti_like_name.Name = "lbl_all_noti_like_name";
            lbl_all_noti_like_name.Size = new Size(223, 30);
            lbl_all_noti_like_name.TabIndex = 1;
            lbl_all_noti_like_name.Text = "Tên hồ sơ người dùng";
            // 
            // pb_all_noti_like_user_avatar
            // 
            pb_all_noti_like_user_avatar.Image = Properties.Resources.accountIcon;
            pb_all_noti_like_user_avatar.Location = new Point(45, 22);
            pb_all_noti_like_user_avatar.Name = "pb_all_noti_like_user_avatar";
            pb_all_noti_like_user_avatar.Size = new Size(80, 80);
            pb_all_noti_like_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_all_noti_like_user_avatar.TabIndex = 0;
            pb_all_noti_like_user_avatar.TabStop = false;
            // 
            // lbl_all_noti_today
            // 
            lbl_all_noti_today.AutoSize = true;
            lbl_all_noti_today.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_all_noti_today.Location = new Point(3, 11);
            lbl_all_noti_today.Name = "lbl_all_noti_today";
            lbl_all_noti_today.Size = new Size(116, 35);
            lbl_all_noti_today.TabIndex = 0;
            lbl_all_noti_today.Text = "Hôm nay";
            // 
            // btn_unread_noti
            // 
            btn_unread_noti.BackColor = Color.FromArgb(213, 216, 220);
            btn_unread_noti.FlatAppearance.BorderColor = Color.White;
            btn_unread_noti.FlatStyle = FlatStyle.Flat;
            btn_unread_noti.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_unread_noti.Location = new Point(178, 14);
            btn_unread_noti.Name = "btn_unread_noti";
            btn_unread_noti.Size = new Size(159, 44);
            btn_unread_noti.TabIndex = 2;
            btn_unread_noti.Text = "Chưa đọc";
            btn_unread_noti.UseVisualStyleBackColor = false;
            btn_unread_noti.Click += btn_unread_noti_Click;
            // 
            // btn_all_noti
            // 
            btn_all_noti.BackColor = Color.FromArgb(213, 216, 220);
            btn_all_noti.FlatAppearance.BorderColor = Color.White;
            btn_all_noti.FlatStyle = FlatStyle.Flat;
            btn_all_noti.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_all_noti.Location = new Point(13, 14);
            btn_all_noti.Name = "btn_all_noti";
            btn_all_noti.Size = new Size(159, 44);
            btn_all_noti.TabIndex = 1;
            btn_all_noti.Text = "Tất cả ";
            btn_all_noti.UseVisualStyleBackColor = false;
            btn_all_noti.Click += btn_all_noti_Click;
            // 
            // flp_notifications
            // 
            flp_notifications.Location = new Point(33, 75);
            flp_notifications.Name = "flp_notifications";
            flp_notifications.Size = new Size(1001, 718);
            flp_notifications.TabIndex = 1;
            // 
            // notificationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panelHeader);
            Controls.Add(panel_bg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "notificationsForm";
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
            panel2.PerformLayout();
            panel_today_noti.ResumeLayout(false);
            panel_unread_noti.ResumeLayout(false);
            panel_unread_noti.PerformLayout();
            panel_unread_likecmt.ResumeLayout(false);
            panel_unread_likecmt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unread_likecmt_user_avatar).EndInit();
            panel_unread_comment.ResumeLayout(false);
            panel_unread_comment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unread_comment_user_avatar).EndInit();
            panel_unread_like.ResumeLayout(false);
            panel_unread_like.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unread_like_user_avatar).EndInit();
            panel_all_noti.ResumeLayout(false);
            panel_all_noti.PerformLayout();
            panel_all_noti_likecmt.ResumeLayout(false);
            panel_all_noti_likecmt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_all_noti_likecmt_user_avatar).EndInit();
            panel_all_noti_comment.ResumeLayout(false);
            panel_all_noti_comment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_all_noti_comment_user_avatar).EndInit();
            panel_all_noti_like.ResumeLayout(false);
            panel_all_noti_like.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_all_noti_like_user_avatar).EndInit();
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
        private Panel panel_today_noti;
        private Label lbl_all_noti_today;
        private Label lbl_noti;
        private Button btn_unread_noti;
        private Button btn_all_noti;
        private Panel panel_all_noti;
        private Panel panel_all_noti_like;
        private Label label_all_noti_liked_your_post;
        private Label lbl_all_noti_like_name;
        private PictureBox pb_all_noti_like_user_avatar;
        private Panel panel_all_noti_comment;
        private Label lbl_all_noti_commented_your_post;
        private Label lbl_all_noti_comment_name;
        private PictureBox pb_all_noti_comment_user_avatar;
        private Panel panel_all_noti_likecmt;
        private Label lbl_all_noti_likedyourcmt;
        private Label lbl_all_noti_likecmt_name;
        private PictureBox pb_all_noti_likecmt_user_avatar;
        private FlowLayoutPanel flp_notifications;
        private Panel panel_unread_noti;
        private Label lbl_unread_date;
        private Panel panel_unread_likecmt;
        private Label lbl_unread_likedcmt;
        private Label lbl_likecmt_name;
        private PictureBox pb_unread_likecmt_user_avatar;
        private Panel panel_unread_comment;
        private Label lbl_unread_commentedyourpost;
        private Label lbl_unread_name;
        private PictureBox pb_unread_comment_user_avatar;
        private Panel panel_unread_like;
        private Label lbl_unread_likedyourpost;
        private Label lbl_unread_like_name;
        private PictureBox pb_unread_like_user_avatar;
        private Label lbl_unread_today;
        private Label lbl_all_noti_date;
    }
}