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
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            cbb_post_privacy = new ComboBox();
            lbl_username = new Label();
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit_post).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_user3).BeginInit();
            panel_bg.SuspendLayout();
            flp_newfeeds.SuspendLayout();
            SuspendLayout();
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
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // panel_before_post
            // 
            panel_before_post.BackColor = Color.White;
            panel_before_post.Controls.Add(lbl_image);
            panel_before_post.Controls.Add(pb_image);
            panel_before_post.Controls.Add(pb_user2);
            panel_before_post.Controls.Add(panel3);
            panel_before_post.Location = new Point(3, 3);
            panel_before_post.Name = "panel_before_post";
            panel_before_post.Size = new Size(1065, 84);
            panel_before_post.TabIndex = 3;
            // 
            // lbl_image
            // 
            lbl_image.AutoSize = true;
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
            panel3.Size = new Size(752, 60);
            panel3.TabIndex = 4;
            // 
            // tb_caption
            // 
            tb_caption.BackColor = Color.FromArgb(240, 242, 245);
            tb_caption.BorderStyle = BorderStyle.None;
            tb_caption.Font = new Font("Be Vietnam Pro", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_caption.Location = new Point(26, 15);
            tb_caption.Multiline = true;
            tb_caption.Name = "tb_caption";
            tb_caption.PlaceholderText = "Hôm nay của bạn thế nào?";
            tb_caption.Size = new Size(621, 37);
            tb_caption.TabIndex = 0;
            tb_caption.Click += tb_caption_Click;
            // 
            // panel_create_post
            // 
            panel_create_post.BackColor = Color.White;
            panel_create_post.BorderStyle = BorderStyle.FixedSingle;
            panel_create_post.Controls.Add(button1);
            panel_create_post.Controls.Add(pictureBox2);
            panel_create_post.Controls.Add(label1);
            panel_create_post.Controls.Add(textBox1);
            panel_create_post.Controls.Add(cbb_post_privacy);
            panel_create_post.Controls.Add(lbl_username);
            panel_create_post.Controls.Add(label2);
            panel_create_post.Controls.Add(btn_exit_post);
            panel_create_post.Controls.Add(pb_user3);
            panel_create_post.Location = new Point(270, 100);
            panel_create_post.Name = "panel_create_post";
            panel_create_post.Size = new Size(947, 441);
            panel_create_post.TabIndex = 0;
            panel_create_post.Visible = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(346, 365);
            button1.Name = "button1";
            button1.Size = new Size(276, 44);
            button1.TabIndex = 11;
            button1.Text = "Chọn ảnh từ máy tính";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.upload;
            pictureBox2.Location = new Point(416, 260);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
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
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Be Vietnam Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(44, 196);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Chia sẻ với mọi người bạn đang suy nghĩ gì nhé? ♪(´▽`)";
            textBox1.Size = new Size(621, 37);
            textBox1.TabIndex = 9;
            // 
            // cbb_post_privacy
            // 
            cbb_post_privacy.BackColor = Color.FromArgb(240, 242, 245);
            cbb_post_privacy.FlatStyle = FlatStyle.Popup;
            cbb_post_privacy.FormattingEnabled = true;
            cbb_post_privacy.Items.AddRange(new object[] { "Chỉ mình tôi", "Bạn bè", "Công khai" });
            cbb_post_privacy.Location = new Point(130, 149);
            cbb_post_privacy.Name = "cbb_post_privacy";
            cbb_post_privacy.Size = new Size(179, 28);
            cbb_post_privacy.TabIndex = 8;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(171, 178, 185);
            label2.Location = new Point(-9, 71);
            label2.Name = "label2";
            label2.Size = new Size(1083, 20);
            label2.TabIndex = 1;
            label2.Text = "___________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // btn_exit_post
            // 
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
            pb_user3.Location = new Point(44, 107);
            pb_user3.Name = "pb_user3";
            pb_user3.Size = new Size(70, 70);
            pb_user3.SizeMode = PictureBoxSizeMode.Zoom;
            pb_user3.TabIndex = 4;
            pb_user3.TabStop = false;
            // 
            // panel_bg
            // 
            panel_bg.BackColor = Color.FromArgb(234, 236, 238);
            panel_bg.Controls.Add(flp_newfeeds);
            panel_bg.Controls.Add(panel_create_post);
            panel_bg.Dock = DockStyle.Fill;
            panel_bg.Location = new Point(0, 0);
            panel_bg.Name = "panel_bg";
            panel_bg.Size = new Size(1600, 900);
            panel_bg.TabIndex = 4;
            panel_bg.Click += panel_bg_Click;
            // 
            // flp_newfeeds
            // 
            flp_newfeeds.BackColor = Color.White;
            flp_newfeeds.Controls.Add(panel_before_post);
            flp_newfeeds.Location = new Point(199, 87);
            flp_newfeeds.Name = "flp_newfeeds";
            flp_newfeeds.Size = new Size(1077, 813);
            flp_newfeeds.TabIndex = 1;
            // 
            // homepageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 244);
            ClientSize = new Size(1600, 900);
            Controls.Add(panelHeader);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit_post).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_user3).EndInit();
            panel_bg.ResumeLayout(false);
            flp_newfeeds.ResumeLayout(false);
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
        private Label label2;
        private ComboBox cbb_post_privacy;
        private Label lbl_username;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flp_newfeeds;
    }
}