namespace Upic
{
    partial class homepageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepageForm));
            pb_logo_UPIC = new PictureBox();
            panelHeader = new Panel();
            pb_friends = new PictureBox();
            pb_mess = new PictureBox();
            pb_noti = new PictureBox();
            pb_user1 = new PictureBox();
            panel1 = new Panel();
            tb_search = new TextBox();
            panel_before_post = new Panel();
            lbl_image = new Label();
            pb_image = new PictureBox();
            pb_user2 = new PictureBox();
            panel3 = new Panel();
            tb_caption = new TextBox();
            panel_create_post = new Panel();
            flp_groupLayoutModeBtn = new FlowLayoutPanel();
            btn_noneLayout = new Button();
            btn_columnLayout = new Button();
            btn_bannerLayout = new Button();
            btn_frameLayout = new Button();
            line_splitCreatePostPanel1 = new Button();
            btn_chooseImageFromDevice = new Button();
            pb_chooseImageFromDevice = new PictureBox();
            label1 = new Label();
            tb_status = new TextBox();
            cbb_post_privacy = new ComboBox();
            lbl_username = new Label();
            btn_exit_post = new PictureBox();
            pb_user3 = new PictureBox();
            panel_bg = new Panel();
            flp_newfeeds = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pb_logo_UPIC).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_friends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_mess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_noti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_user1).BeginInit();
            panel1.SuspendLayout();
            panel_before_post.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_user2).BeginInit();
            panel3.SuspendLayout();
            panel_create_post.SuspendLayout();
            flp_groupLayoutModeBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_chooseImageFromDevice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit_post).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_user3).BeginInit();
            panel_bg.SuspendLayout();
            SuspendLayout();
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
            panelHeader.TabIndex = 2;
            // 
            // pb_friends
            // 
            pb_friends.Cursor = Cursors.Hand;
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
            pb_mess.Cursor = Cursors.Hand;
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
            pb_noti.Cursor = Cursors.Hand;
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
            pb_user1.Cursor = Cursors.Hand;
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
            tb_search.Cursor = Cursors.IBeam;
            tb_search.Font = new Font("Be Vietnam Pro", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_search.Location = new Point(20, 21);
            tb_search.Multiline = true;
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Tìm kiếm trên Upic";
            tb_search.Size = new Size(291, 27);
            tb_search.TabIndex = 0;
            // 
            // panel_before_post
            // 
            panel_before_post.BackColor = Color.White;
            panel_before_post.Controls.Add(lbl_image);
            panel_before_post.Controls.Add(pb_image);
            panel_before_post.Controls.Add(pb_user2);
            panel_before_post.Controls.Add(panel3);
            panel_before_post.Location = new Point(263, 90);
            panel_before_post.Name = "panel_before_post";
            panel_before_post.Size = new Size(1074, 84);
            panel_before_post.TabIndex = 3;
            // 
            // lbl_image
            // 
            lbl_image.AutoSize = true;
            lbl_image.Cursor = Cursors.Hand;
            lbl_image.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_image.ForeColor = Color.FromArgb(17, 122, 101);
            lbl_image.Location = new Point(968, 27);
            lbl_image.Name = "lbl_image";
            lbl_image.Size = new Size(46, 28);
            lbl_image.TabIndex = 6;
            lbl_image.Text = "Ảnh";
            lbl_image.Click += lbl_image_Click;
            // 
            // pb_image
            // 
            pb_image.Cursor = Cursors.Hand;
            pb_image.Image = Properties.Resources.image;
            pb_image.Location = new Point(902, 12);
            pb_image.Name = "pb_image";
            pb_image.Size = new Size(60, 60);
            pb_image.SizeMode = PictureBoxSizeMode.Zoom;
            pb_image.TabIndex = 5;
            pb_image.TabStop = false;
            pb_image.Click += pb_image_Click;
            // 
            // pb_user2
            // 
            pb_user2.BackColor = Color.Transparent;
            pb_user2.Image = Properties.Resources.accountIcon1;
            pb_user2.Location = new Point(44, 12);
            pb_user2.Name = "pb_user2";
            pb_user2.Size = new Size(60, 60);
            pb_user2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_user2.TabIndex = 3;
            pb_user2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.post_bg;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(tb_caption);
            panel3.Location = new Point(110, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(750, 60);
            panel3.TabIndex = 4;
            panel3.Click += panel3_Click;
            // 
            // tb_caption
            // 
            tb_caption.BackColor = Color.FromArgb(240, 242, 245);
            tb_caption.BorderStyle = BorderStyle.None;
            tb_caption.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            tb_caption.Location = new Point(26, 15);
            tb_caption.Name = "tb_caption";
            tb_caption.PlaceholderText = "Hôm nay của bạn thế nào?";
            tb_caption.Size = new Size(690, 30);
            tb_caption.TabIndex = 0;
            tb_caption.Click += tb_caption_Click;
            // 
            // panel_create_post
            // 
            panel_create_post.BackColor = Color.White;
            panel_create_post.BorderStyle = BorderStyle.FixedSingle;
            panel_create_post.Controls.Add(flp_groupLayoutModeBtn);
            panel_create_post.Controls.Add(line_splitCreatePostPanel1);
            panel_create_post.Controls.Add(btn_chooseImageFromDevice);
            panel_create_post.Controls.Add(pb_chooseImageFromDevice);
            panel_create_post.Controls.Add(label1);
            panel_create_post.Controls.Add(tb_status);
            panel_create_post.Controls.Add(cbb_post_privacy);
            panel_create_post.Controls.Add(lbl_username);
            panel_create_post.Controls.Add(btn_exit_post);
            panel_create_post.Controls.Add(pb_user3);
            panel_create_post.Font = new Font("Be Vietnam Pro", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            panel_create_post.Location = new Point(325, 100);
            panel_create_post.Name = "panel_create_post";
            panel_create_post.Size = new Size(950, 600);
            panel_create_post.TabIndex = 0;
            panel_create_post.Visible = false;
            // 
            // flp_groupLayoutModeBtn
            // 
            flp_groupLayoutModeBtn.Controls.Add(btn_noneLayout);
            flp_groupLayoutModeBtn.Controls.Add(btn_columnLayout);
            flp_groupLayoutModeBtn.Controls.Add(btn_bannerLayout);
            flp_groupLayoutModeBtn.Controls.Add(btn_frameLayout);
            flp_groupLayoutModeBtn.Location = new Point(2, 360);
            flp_groupLayoutModeBtn.Name = "flp_groupLayoutModeBtn";
            flp_groupLayoutModeBtn.Size = new Size(40, 200);
            flp_groupLayoutModeBtn.TabIndex = 14;
            flp_groupLayoutModeBtn.Visible = false;
            // 
            // btn_noneLayout
            // 
            btn_noneLayout.BackgroundImage = Properties.Resources.NoneIcon;
            btn_noneLayout.BackgroundImageLayout = ImageLayout.Zoom;
            btn_noneLayout.Cursor = Cursors.Hand;
            btn_noneLayout.FlatAppearance.BorderColor = Color.LightGray;
            btn_noneLayout.FlatAppearance.BorderSize = 3;
            btn_noneLayout.FlatStyle = FlatStyle.Flat;
            btn_noneLayout.Location = new Point(0, 5);
            btn_noneLayout.Margin = new Padding(0, 5, 0, 5);
            btn_noneLayout.Name = "btn_noneLayout";
            btn_noneLayout.Size = new Size(40, 40);
            btn_noneLayout.TabIndex = 0;
            btn_noneLayout.UseVisualStyleBackColor = true;
            btn_noneLayout.Click += btn_noneLayout_Click;
            // 
            // btn_columnLayout
            // 
            btn_columnLayout.BackgroundImage = Properties.Resources.ColumnLayoutIcon;
            btn_columnLayout.BackgroundImageLayout = ImageLayout.Zoom;
            btn_columnLayout.Cursor = Cursors.Hand;
            btn_columnLayout.FlatAppearance.BorderColor = Color.LightGray;
            btn_columnLayout.FlatAppearance.BorderSize = 3;
            btn_columnLayout.FlatStyle = FlatStyle.Flat;
            btn_columnLayout.Location = new Point(0, 55);
            btn_columnLayout.Margin = new Padding(0, 5, 0, 5);
            btn_columnLayout.Name = "btn_columnLayout";
            btn_columnLayout.Size = new Size(40, 40);
            btn_columnLayout.TabIndex = 1;
            btn_columnLayout.UseVisualStyleBackColor = true;
            btn_columnLayout.Click += btn_columnLayout_Click;
            // 
            // btn_bannerLayout
            // 
            btn_bannerLayout.BackgroundImage = Properties.Resources.BannerLayoutIcon;
            btn_bannerLayout.BackgroundImageLayout = ImageLayout.Zoom;
            btn_bannerLayout.Cursor = Cursors.Hand;
            btn_bannerLayout.FlatAppearance.BorderColor = Color.LightGray;
            btn_bannerLayout.FlatAppearance.BorderSize = 3;
            btn_bannerLayout.FlatStyle = FlatStyle.Flat;
            btn_bannerLayout.Location = new Point(0, 105);
            btn_bannerLayout.Margin = new Padding(0, 5, 0, 5);
            btn_bannerLayout.Name = "btn_bannerLayout";
            btn_bannerLayout.Size = new Size(40, 40);
            btn_bannerLayout.TabIndex = 2;
            btn_bannerLayout.UseVisualStyleBackColor = true;
            btn_bannerLayout.Click += btn_bannerLayout_Click;
            // 
            // btn_frameLayout
            // 
            btn_frameLayout.BackgroundImage = Properties.Resources.FrameLayoutIcon;
            btn_frameLayout.BackgroundImageLayout = ImageLayout.Zoom;
            btn_frameLayout.Cursor = Cursors.Hand;
            btn_frameLayout.FlatAppearance.BorderColor = Color.LightGray;
            btn_frameLayout.FlatAppearance.BorderSize = 3;
            btn_frameLayout.FlatStyle = FlatStyle.Flat;
            btn_frameLayout.Location = new Point(0, 155);
            btn_frameLayout.Margin = new Padding(0, 5, 0, 5);
            btn_frameLayout.Name = "btn_frameLayout";
            btn_frameLayout.Size = new Size(40, 40);
            btn_frameLayout.TabIndex = 3;
            btn_frameLayout.UseVisualStyleBackColor = true;
            btn_frameLayout.Visible = false;
            // 
            // line_splitCreatePostPanel1
            // 
            line_splitCreatePostPanel1.BackColor = Color.FromArgb(171, 178, 185);
            line_splitCreatePostPanel1.Enabled = false;
            line_splitCreatePostPanel1.FlatAppearance.BorderSize = 0;
            line_splitCreatePostPanel1.FlatStyle = FlatStyle.Flat;
            line_splitCreatePostPanel1.Location = new Point(5, 90);
            line_splitCreatePostPanel1.Name = "line_splitCreatePostPanel1";
            line_splitCreatePostPanel1.Size = new Size(940, 1);
            line_splitCreatePostPanel1.TabIndex = 12;
            line_splitCreatePostPanel1.Text = "s";
            line_splitCreatePostPanel1.UseVisualStyleBackColor = false;
            // 
            // btn_chooseImageFromDevice
            // 
            btn_chooseImageFromDevice.Cursor = Cursors.Hand;
            btn_chooseImageFromDevice.FlatAppearance.BorderColor = Color.White;
            btn_chooseImageFromDevice.FlatStyle = FlatStyle.Flat;
            btn_chooseImageFromDevice.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chooseImageFromDevice.Location = new Point(337, 450);
            btn_chooseImageFromDevice.Name = "btn_chooseImageFromDevice";
            btn_chooseImageFromDevice.Size = new Size(276, 45);
            btn_chooseImageFromDevice.TabIndex = 11;
            btn_chooseImageFromDevice.Text = "Chọn ảnh từ máy tính";
            btn_chooseImageFromDevice.UseVisualStyleBackColor = true;
            btn_chooseImageFromDevice.Click += btn_chooseImageFromDevice_Click;
            // 
            // pb_chooseImageFromDevice
            // 
            pb_chooseImageFromDevice.Cursor = Cursors.Hand;
            pb_chooseImageFromDevice.Image = Properties.Resources.upload;
            pb_chooseImageFromDevice.Location = new Point(411, 360);
            pb_chooseImageFromDevice.Name = "pb_chooseImageFromDevice";
            pb_chooseImageFromDevice.Size = new Size(128, 90);
            pb_chooseImageFromDevice.SizeMode = PictureBoxSizeMode.Zoom;
            pb_chooseImageFromDevice.TabIndex = 10;
            pb_chooseImageFromDevice.TabStop = false;
            pb_chooseImageFromDevice.Click += pb_chooseImageFromDevice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Be Vietnam Pro ExtraBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(364, 21);
            label1.Name = "label1";
            label1.Size = new Size(226, 52);
            label1.TabIndex = 5;
            label1.Text = "Tạo bài viết";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_status
            // 
            tb_status.BackColor = Color.White;
            tb_status.BorderStyle = BorderStyle.None;
            tb_status.Font = new Font("Be Vietnam Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_status.Location = new Point(45, 196);
            tb_status.Multiline = true;
            tb_status.Name = "tb_status";
            tb_status.PlaceholderText = "Chia sẻ với mọi người bạn đang suy nghĩ gì nhé? ♪(´▽`)";
            tb_status.Size = new Size(860, 150);
            tb_status.TabIndex = 9;
            tb_status.TextChanged += tb_status_TextChanged;
            // 
            // cbb_post_privacy
            // 
            cbb_post_privacy.BackColor = Color.FromArgb(240, 242, 245);
            cbb_post_privacy.FlatStyle = FlatStyle.Popup;
            cbb_post_privacy.FormattingEnabled = true;
            cbb_post_privacy.Items.AddRange(new object[] { "Chỉ mình tôi", "Bạn bè", "Công khai" });
            cbb_post_privacy.Location = new Point(130, 149);
            cbb_post_privacy.Name = "cbb_post_privacy";
            cbb_post_privacy.Size = new Size(179, 31);
            cbb_post_privacy.TabIndex = 8;
            cbb_post_privacy.Text = "Công khai";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(124, 107);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(243, 35);
            lbl_username.TabIndex = 7;
            lbl_username.Text = "Nguyễn Thị Như Vân";
            // 
            // btn_exit_post
            // 
            btn_exit_post.Cursor = Cursors.Hand;
            btn_exit_post.Image = Properties.Resources.exit_fill;
            btn_exit_post.Location = new Point(877, 21);
            btn_exit_post.Name = "btn_exit_post";
            btn_exit_post.Size = new Size(50, 50);
            btn_exit_post.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exit_post.TabIndex = 6;
            btn_exit_post.TabStop = false;
            btn_exit_post.Click += btn_exit_post_Click;
            // 
            // pb_user3
            // 
            pb_user3.BackColor = Color.Transparent;
            pb_user3.Image = Properties.Resources.accountIcon1;
            pb_user3.Location = new Point(45, 107);
            pb_user3.Name = "pb_user3";
            pb_user3.Size = new Size(70, 70);
            pb_user3.SizeMode = PictureBoxSizeMode.Zoom;
            pb_user3.TabIndex = 4;
            pb_user3.TabStop = false;
            // 
            // panel_bg
            // 
            panel_bg.BackColor = Color.FromArgb(234, 236, 238);
            panel_bg.Controls.Add(panel_before_post);
            panel_bg.Controls.Add(flp_newfeeds);
            panel_bg.Controls.Add(panel_create_post);
            panel_bg.Controls.Add(panelHeader);
            panel_bg.Dock = DockStyle.Fill;
            panel_bg.Location = new Point(0, 0);
            panel_bg.Name = "panel_bg";
            panel_bg.Size = new Size(1600, 900);
            panel_bg.TabIndex = 4;
            panel_bg.Click += panel_bg_Click;
            // 
            // flp_newfeeds
            // 
            flp_newfeeds.AutoScroll = true;
            flp_newfeeds.BackColor = Color.White;
            flp_newfeeds.FlowDirection = FlowDirection.TopDown;
            flp_newfeeds.Location = new Point(260, 177);
            flp_newfeeds.Name = "flp_newfeeds";
            flp_newfeeds.Size = new Size(1080, 723);
            flp_newfeeds.TabIndex = 1;
            // 
            // homepageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 244);
            ClientSize = new Size(1600, 900);
            Controls.Add(panel_bg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "homepageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upic";
            Load += homepageForm_Load;
            ((System.ComponentModel.ISupportInitialize)pb_logo_UPIC).EndInit();
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_friends).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_mess).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_noti).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_user1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_before_post.ResumeLayout(false);
            panel_before_post.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_user2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel_create_post.ResumeLayout(false);
            panel_create_post.PerformLayout();
            flp_groupLayoutModeBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_chooseImageFromDevice).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit_post).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_user3).EndInit();
            panel_bg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pb_logo_UPIC;
        private Panel panelHeader;
        private Panel panel1;
        private TextBox tb_search;
        private PictureBox pb_user1;
        private PictureBox pb_noti;
        private PictureBox pb_mess;
        private PictureBox pb_friends;
        private Panel panel_before_post;
        private PictureBox pb_user2;
        private Panel panel3;
        private TextBox tb_caption;
        private Panel panel_bg;
        private Label lbl_image;
        private PictureBox pb_image;
        private Panel panel_create_post;
        private Label label1;
        private PictureBox pb_user3;
        private PictureBox btn_exit_post;
        private ComboBox cbb_post_privacy;
        private Label lbl_username;
        private TextBox tb_status;
        private Button btn_chooseImageFromDevice;
        private PictureBox pb_chooseImageFromDevice;
        private FlowLayoutPanel flp_newfeeds;
        private Button line_splitCreatePostPanel1;
        private Button btn_noneLayout;
        private Button btn_bannerLayout;
        private Button btn_columnLayout;
        private Button btn_frameLayout;
        private FlowLayoutPanel flp_groupLayoutModeBtn;
    }
}