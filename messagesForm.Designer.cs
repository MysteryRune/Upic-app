namespace Upic
{
    partial class messagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messagesForm));
            panelHeader = new Panel();
            pb_friends = new PictureBox();
            pb_mess = new PictureBox();
            pb_noti = new PictureBox();
            pb_user1 = new PictureBox();
            panel1 = new Panel();
            tb_search = new TextBox();
            pb_logo_UPIC = new PictureBox();
            panel2 = new Panel();
            btn_create_new_chat = new PictureBox();
            panel_in_chatting = new Panel();
            btn_send = new PictureBox();
            btn_add_file = new PictureBox();
            btn_add_image = new PictureBox();
            panel4 = new Panel();
            tb_enterchat = new TextBox();
            flp_chatting = new FlowLayoutPanel();
            panel_send_message = new Panel();
            lbl_send_message = new Label();
            panel_receive_message = new Panel();
            lbl_receive_message = new Label();
            lbl_chat = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel_messages = new Panel();
            lbl_unread_like_name = new Label();
            pb_unread_like_user_avatar = new PictureBox();
            panel_chat_with_user = new Panel();
            panel_user_header = new Panel();
            lbl_name_user_in_chat = new Label();
            pb_avatar_user_in_chat = new PictureBox();
            panel_bg = new Panel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_friends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_mess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_noti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_user1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_UPIC).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_create_new_chat).BeginInit();
            panel_in_chatting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_send).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_add_file).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_add_image).BeginInit();
            panel4.SuspendLayout();
            flp_chatting.SuspendLayout();
            panel_send_message.SuspendLayout();
            panel_receive_message.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel_messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unread_like_user_avatar).BeginInit();
            panel_chat_with_user.SuspendLayout();
            panel_user_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_avatar_user_in_chat).BeginInit();
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
            pb_mess.Image = Properties.Resources.mess_fill;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_create_new_chat);
            panel2.Controls.Add(panel_in_chatting);
            panel2.Controls.Add(flp_chatting);
            panel2.Controls.Add(lbl_chat);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(panel_chat_with_user);
            panel2.Location = new Point(270, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 820);
            panel2.TabIndex = 4;
            // 
            // btn_create_new_chat
            // 
            btn_create_new_chat.Cursor = Cursors.Hand;
            btn_create_new_chat.Image = Properties.Resources.createNewChat;
            btn_create_new_chat.Location = new Point(312, 22);
            btn_create_new_chat.Name = "btn_create_new_chat";
            btn_create_new_chat.Size = new Size(50, 50);
            btn_create_new_chat.SizeMode = PictureBoxSizeMode.Zoom;
            btn_create_new_chat.TabIndex = 11;
            btn_create_new_chat.TabStop = false;
            // 
            // panel_in_chatting
            // 
            panel_in_chatting.Controls.Add(btn_send);
            panel_in_chatting.Controls.Add(btn_add_file);
            panel_in_chatting.Controls.Add(btn_add_image);
            panel_in_chatting.Controls.Add(panel4);
            panel_in_chatting.Location = new Point(397, 722);
            panel_in_chatting.Name = "panel_in_chatting";
            panel_in_chatting.Size = new Size(632, 83);
            panel_in_chatting.TabIndex = 9;
            // 
            // btn_send
            // 
            btn_send.Cursor = Cursors.Hand;
            btn_send.Image = Properties.Resources.send_chat;
            btn_send.Location = new Point(569, 13);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(60, 60);
            btn_send.SizeMode = PictureBoxSizeMode.Zoom;
            btn_send.TabIndex = 7;
            btn_send.TabStop = false;
            // 
            // btn_add_file
            // 
            btn_add_file.Cursor = Cursors.Hand;
            btn_add_file.Image = Properties.Resources.dinhkemfile;
            btn_add_file.Location = new Point(503, 13);
            btn_add_file.Name = "btn_add_file";
            btn_add_file.Size = new Size(60, 60);
            btn_add_file.SizeMode = PictureBoxSizeMode.Zoom;
            btn_add_file.TabIndex = 6;
            btn_add_file.TabStop = false;
            // 
            // btn_add_image
            // 
            btn_add_image.Cursor = Cursors.Hand;
            btn_add_image.Image = Properties.Resources.addImage;
            btn_add_image.Location = new Point(437, 13);
            btn_add_image.Name = "btn_add_image";
            btn_add_image.Size = new Size(60, 60);
            btn_add_image.SizeMode = PictureBoxSizeMode.Zoom;
            btn_add_image.TabIndex = 5;
            btn_add_image.TabStop = false;
            btn_add_image.Click += btn_add_image_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.search_bg;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(tb_enterchat);
            panel4.Location = new Point(3, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(428, 62);
            panel4.TabIndex = 4;
            // 
            // tb_enterchat
            // 
            tb_enterchat.BackColor = Color.FromArgb(240, 242, 245);
            tb_enterchat.BorderStyle = BorderStyle.None;
            tb_enterchat.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            tb_enterchat.Location = new Point(36, 17);
            tb_enterchat.Multiline = true;
            tb_enterchat.Name = "tb_enterchat";
            tb_enterchat.PlaceholderText = "Nhập tin nhắn...";
            tb_enterchat.Size = new Size(322, 28);
            tb_enterchat.TabIndex = 0;
            // 
            // flp_chatting
            // 
            flp_chatting.Controls.Add(panel_send_message);
            flp_chatting.Controls.Add(panel_receive_message);
            flp_chatting.Location = new Point(397, 100);
            flp_chatting.Name = "flp_chatting";
            flp_chatting.Size = new Size(632, 616);
            flp_chatting.TabIndex = 8;
            // 
            // panel_send_message
            // 
            panel_send_message.BackColor = Color.Transparent;
            panel_send_message.BackgroundImage = Properties.Resources.search_bg;
            panel_send_message.BackgroundImageLayout = ImageLayout.Zoom;
            panel_send_message.Controls.Add(lbl_send_message);
            panel_send_message.Location = new Point(3, 3);
            panel_send_message.Name = "panel_send_message";
            panel_send_message.Size = new Size(368, 62);
            panel_send_message.TabIndex = 5;
            // 
            // lbl_send_message
            // 
            lbl_send_message.AutoSize = true;
            lbl_send_message.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_send_message.Location = new Point(25, 18);
            lbl_send_message.Name = "lbl_send_message";
            lbl_send_message.Size = new Size(242, 28);
            lbl_send_message.TabIndex = 0;
            lbl_send_message.Text = "Hế lô, nhà có gì ăn không?";
            // 
            // panel_receive_message
            // 
            panel_receive_message.BackColor = Color.Transparent;
            panel_receive_message.BackgroundImage = Properties.Resources.search_bg;
            panel_receive_message.BackgroundImageLayout = ImageLayout.Zoom;
            panel_receive_message.Controls.Add(lbl_receive_message);
            panel_receive_message.Location = new Point(3, 71);
            panel_receive_message.Name = "panel_receive_message";
            panel_receive_message.Size = new Size(368, 62);
            panel_receive_message.TabIndex = 6;
            // 
            // lbl_receive_message
            // 
            lbl_receive_message.AutoSize = true;
            lbl_receive_message.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_receive_message.Location = new Point(25, 17);
            lbl_receive_message.Name = "lbl_receive_message";
            lbl_receive_message.Size = new Size(242, 28);
            lbl_receive_message.TabIndex = 1;
            lbl_receive_message.Text = "Không có nha đi dookki đi";
            // 
            // lbl_chat
            // 
            lbl_chat.AutoSize = true;
            lbl_chat.Font = new Font("Be Vietnam Pro ExtraBold", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_chat.Location = new Point(14, 15);
            lbl_chat.Name = "lbl_chat";
            lbl_chat.Size = new Size(171, 57);
            lbl_chat.TabIndex = 2;
            lbl_chat.Text = "Hộp thư";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(panel_messages);
            flowLayoutPanel1.Location = new Point(14, 96);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(359, 721);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel_messages
            // 
            panel_messages.Controls.Add(lbl_unread_like_name);
            panel_messages.Controls.Add(pb_unread_like_user_avatar);
            panel_messages.Location = new Point(3, 3);
            panel_messages.Name = "panel_messages";
            panel_messages.Size = new Size(344, 85);
            panel_messages.TabIndex = 5;
            // 
            // lbl_unread_like_name
            // 
            lbl_unread_like_name.AutoSize = true;
            lbl_unread_like_name.Cursor = Cursors.Hand;
            lbl_unread_like_name.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_unread_like_name.Location = new Point(75, 28);
            lbl_unread_like_name.Name = "lbl_unread_like_name";
            lbl_unread_like_name.Size = new Size(223, 30);
            lbl_unread_like_name.TabIndex = 1;
            lbl_unread_like_name.Text = "Tên hồ sơ người dùng";
            // 
            // pb_unread_like_user_avatar
            // 
            pb_unread_like_user_avatar.Cursor = Cursors.Hand;
            pb_unread_like_user_avatar.Image = Properties.Resources.accountIcon;
            pb_unread_like_user_avatar.Location = new Point(9, 12);
            pb_unread_like_user_avatar.Name = "pb_unread_like_user_avatar";
            pb_unread_like_user_avatar.Size = new Size(60, 60);
            pb_unread_like_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_unread_like_user_avatar.TabIndex = 0;
            pb_unread_like_user_avatar.TabStop = false;
            // 
            // panel_chat_with_user
            // 
            panel_chat_with_user.BorderStyle = BorderStyle.FixedSingle;
            panel_chat_with_user.Controls.Add(panel_user_header);
            panel_chat_with_user.Location = new Point(379, 15);
            panel_chat_with_user.Name = "panel_chat_with_user";
            panel_chat_with_user.Size = new Size(672, 805);
            panel_chat_with_user.TabIndex = 10;
            // 
            // panel_user_header
            // 
            panel_user_header.Controls.Add(lbl_name_user_in_chat);
            panel_user_header.Controls.Add(pb_avatar_user_in_chat);
            panel_user_header.Location = new Point(17, 3);
            panel_user_header.Name = "panel_user_header";
            panel_user_header.Size = new Size(632, 78);
            panel_user_header.TabIndex = 7;
            // 
            // lbl_name_user_in_chat
            // 
            lbl_name_user_in_chat.AutoSize = true;
            lbl_name_user_in_chat.Cursor = Cursors.Hand;
            lbl_name_user_in_chat.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name_user_in_chat.Location = new Point(232, 19);
            lbl_name_user_in_chat.Name = "lbl_name_user_in_chat";
            lbl_name_user_in_chat.Size = new Size(223, 30);
            lbl_name_user_in_chat.TabIndex = 3;
            lbl_name_user_in_chat.Text = "Tên hồ sơ người dùng";
            // 
            // pb_avatar_user_in_chat
            // 
            pb_avatar_user_in_chat.Cursor = Cursors.Hand;
            pb_avatar_user_in_chat.Image = Properties.Resources.accountIcon;
            pb_avatar_user_in_chat.Location = new Point(166, 3);
            pb_avatar_user_in_chat.Name = "pb_avatar_user_in_chat";
            pb_avatar_user_in_chat.Size = new Size(60, 60);
            pb_avatar_user_in_chat.SizeMode = PictureBoxSizeMode.Zoom;
            pb_avatar_user_in_chat.TabIndex = 2;
            pb_avatar_user_in_chat.TabStop = false;
            // 
            // panel_bg
            // 
            panel_bg.BackColor = Color.FromArgb(234, 236, 238);
            panel_bg.Dock = DockStyle.Fill;
            panel_bg.Location = new Point(0, 0);
            panel_bg.Name = "panel_bg";
            panel_bg.RightToLeft = RightToLeft.No;
            panel_bg.Size = new Size(1600, 900);
            panel_bg.TabIndex = 5;
            panel_bg.Click += panel_bg_Click;
            // 
            // messagesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panel2);
            Controls.Add(panelHeader);
            Controls.Add(panel_bg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "messagesForm";
            Text = "Upic";
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_friends).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_mess).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_noti).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_user1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_UPIC).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_create_new_chat).EndInit();
            panel_in_chatting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_send).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_add_file).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_add_image).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flp_chatting.ResumeLayout(false);
            panel_send_message.ResumeLayout(false);
            panel_send_message.PerformLayout();
            panel_receive_message.ResumeLayout(false);
            panel_receive_message.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel_messages.ResumeLayout(false);
            panel_messages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unread_like_user_avatar).EndInit();
            panel_chat_with_user.ResumeLayout(false);
            panel_user_header.ResumeLayout(false);
            panel_user_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_avatar_user_in_chat).EndInit();
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
        private Panel panel2;
        private Label lbl_chat;
        private Panel panel_messages;
        private Label lbl_unread_like_name;
        private PictureBox pb_unread_like_user_avatar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel_user_header;
        private Label lbl_name_user_in_chat;
        private PictureBox pb_avatar_user_in_chat;
        private Panel panel_in_chatting;
        private Panel panel4;
        private TextBox tb_enterchat;
        private FlowLayoutPanel flp_chatting;
        private Panel panel_bg;
        private PictureBox btn_add_image;
        private PictureBox btn_add_file;
        private PictureBox btn_send;
        private Panel panel_chat_with_user;
        private PictureBox btn_create_new_chat;
        private Panel panel_send_message;
        private Label lbl_send_message;
        private Panel panel_receive_message;
        private Label lbl_receive_message;
    }
}