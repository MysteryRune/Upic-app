﻿namespace Upic
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
            lbl_chat = new Label();
            panel_messages = new Panel();
            lbl_unread_like_name = new Label();
            pb_unread_like_user_avatar = new PictureBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_friends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_mess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_noti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_user1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_UPIC).BeginInit();
            panel2.SuspendLayout();
            panel_messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unread_like_user_avatar).BeginInit();
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel_messages);
            panel2.Controls.Add(lbl_chat);
            panel2.Location = new Point(270, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 820);
            panel2.TabIndex = 4;
            // 
            // lbl_chat
            // 
            lbl_chat.AutoSize = true;
            lbl_chat.Font = new Font("Be Vietnam Pro ExtraBold", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_chat.Location = new Point(46, 15);
            lbl_chat.Name = "lbl_chat";
            lbl_chat.Size = new Size(171, 57);
            lbl_chat.TabIndex = 2;
            lbl_chat.Text = "Hộp thư";
            // 
            // panel_messages
            // 
            panel_messages.Controls.Add(lbl_unread_like_name);
            panel_messages.Controls.Add(pb_unread_like_user_avatar);
            panel_messages.Location = new Point(46, 97);
            panel_messages.Name = "panel_messages";
            panel_messages.Size = new Size(382, 117);
            panel_messages.TabIndex = 5;
            // 
            // lbl_unread_like_name
            // 
            lbl_unread_like_name.AutoSize = true;
            lbl_unread_like_name.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_unread_like_name.Location = new Point(95, 40);
            lbl_unread_like_name.Name = "lbl_unread_like_name";
            lbl_unread_like_name.Size = new Size(223, 30);
            lbl_unread_like_name.TabIndex = 1;
            lbl_unread_like_name.Text = "Tên hồ sơ người dùng";
            // 
            // pb_unread_like_user_avatar
            // 
            pb_unread_like_user_avatar.Image = Properties.Resources.accountIcon;
            pb_unread_like_user_avatar.Location = new Point(9, 16);
            pb_unread_like_user_avatar.Name = "pb_unread_like_user_avatar";
            pb_unread_like_user_avatar.Size = new Size(80, 80);
            pb_unread_like_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_unread_like_user_avatar.TabIndex = 0;
            pb_unread_like_user_avatar.TabStop = false;
            // 
            // messagesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panel2);
            Controls.Add(panelHeader);
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
            panel_messages.ResumeLayout(false);
            panel_messages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_unread_like_user_avatar).EndInit();
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
    }
}