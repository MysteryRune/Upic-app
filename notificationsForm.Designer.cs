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
            button1 = new Button();
            btn_friendrequests = new Button();
            lbl_noti_today = new Label();
            panel_all_noti = new Panel();
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
            panel_all_noti.SuspendLayout();
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
            panel2.Location = new Point(271, 107);
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
            panel_today_noti.Controls.Add(panel_all_noti);
            panel_today_noti.Controls.Add(button1);
            panel_today_noti.Controls.Add(btn_friendrequests);
            panel_today_noti.Location = new Point(46, 75);
            panel_today_noti.Name = "panel_today_noti";
            panel_today_noti.Size = new Size(980, 718);
            panel_today_noti.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(213, 216, 220);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(178, 14);
            button1.Name = "button1";
            button1.Size = new Size(159, 44);
            button1.TabIndex = 2;
            button1.Text = "Chưa đọc";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_friendrequests
            // 
            btn_friendrequests.BackColor = Color.FromArgb(213, 216, 220);
            btn_friendrequests.FlatAppearance.BorderColor = Color.White;
            btn_friendrequests.FlatStyle = FlatStyle.Flat;
            btn_friendrequests.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_friendrequests.Location = new Point(13, 14);
            btn_friendrequests.Name = "btn_friendrequests";
            btn_friendrequests.Size = new Size(159, 44);
            btn_friendrequests.TabIndex = 1;
            btn_friendrequests.Text = "Tất cả ";
            btn_friendrequests.UseVisualStyleBackColor = false;
            // 
            // lbl_noti_today
            // 
            lbl_noti_today.AutoSize = true;
            lbl_noti_today.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_noti_today.Location = new Point(3, 11);
            lbl_noti_today.Name = "lbl_noti_today";
            lbl_noti_today.Size = new Size(116, 35);
            lbl_noti_today.TabIndex = 0;
            lbl_noti_today.Text = "Hôm nay";
            // 
            // panel_all_noti
            // 
            panel_all_noti.Controls.Add(lbl_noti_today);
            panel_all_noti.Location = new Point(13, 64);
            panel_all_noti.Name = "panel_all_noti";
            panel_all_noti.Size = new Size(952, 193);
            panel_all_noti.TabIndex = 3;
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
            panel_all_noti.ResumeLayout(false);
            panel_all_noti.PerformLayout();
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
        private Label lbl_noti_today;
        private Label lbl_noti;
        private Button button1;
        private Button btn_friendrequests;
        private Panel panel_all_noti;
    }
}