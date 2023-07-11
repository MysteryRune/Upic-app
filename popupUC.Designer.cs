namespace Upic
{
    partial class popupUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flp_popup = new FlowLayoutPanel();
            panel_profile_user = new Panel();
            lbl_profile_user = new Label();
            pb_profile_avatar = new PictureBox();
            panel_setting = new Panel();
            lbl_setting = new Label();
            pb_setting_outline = new PictureBox();
            panel_logout = new Panel();
            lbl_logout = new Label();
            pb_logout = new PictureBox();
            flp_popup.SuspendLayout();
            panel_profile_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_profile_avatar).BeginInit();
            panel_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_setting_outline).BeginInit();
            panel_logout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logout).BeginInit();
            SuspendLayout();
            // 
            // flp_popup
            // 
            flp_popup.BackColor = Color.White;
            flp_popup.Controls.Add(panel_profile_user);
            flp_popup.Controls.Add(panel_setting);
            flp_popup.Controls.Add(panel_logout);
            flp_popup.Location = new Point(0, 0);
            flp_popup.Name = "flp_popup";
            flp_popup.Size = new Size(243, 195);
            flp_popup.TabIndex = 0;
            // 
            // panel_profile_user
            // 
            panel_profile_user.BackColor = Color.White;
            panel_profile_user.Controls.Add(lbl_profile_user);
            panel_profile_user.Controls.Add(pb_profile_avatar);
            panel_profile_user.Cursor = Cursors.Hand;
            panel_profile_user.Location = new Point(3, 3);
            panel_profile_user.Name = "panel_profile_user";
            panel_profile_user.Size = new Size(232, 57);
            panel_profile_user.TabIndex = 1;
            panel_profile_user.Click += panel_profile_user_Click;
            // 
            // lbl_profile_user
            // 
            lbl_profile_user.AutoSize = true;
            lbl_profile_user.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_profile_user.Location = new Point(64, 14);
            lbl_profile_user.Name = "lbl_profile_user";
            lbl_profile_user.Size = new Size(140, 28);
            lbl_profile_user.TabIndex = 3;
            lbl_profile_user.Text = "Trang cá nhân";
            lbl_profile_user.Click += lbl_profile_user_Click;
            // 
            // pb_profile_avatar
            // 
            pb_profile_avatar.Image = Properties.Resources.accountIcon;
            pb_profile_avatar.Location = new Point(3, 0);
            pb_profile_avatar.Name = "pb_profile_avatar";
            pb_profile_avatar.Size = new Size(55, 55);
            pb_profile_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_profile_avatar.TabIndex = 2;
            pb_profile_avatar.TabStop = false;
            pb_profile_avatar.Click += pb_profile_avatar_Click;
            // 
            // panel_setting
            // 
            panel_setting.BackColor = Color.White;
            panel_setting.Controls.Add(lbl_setting);
            panel_setting.Controls.Add(pb_setting_outline);
            panel_setting.Cursor = Cursors.Hand;
            panel_setting.Location = new Point(3, 66);
            panel_setting.Name = "panel_setting";
            panel_setting.Size = new Size(232, 57);
            panel_setting.TabIndex = 2;
            // 
            // lbl_setting
            // 
            lbl_setting.AutoSize = true;
            lbl_setting.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_setting.Location = new Point(64, 14);
            lbl_setting.Name = "lbl_setting";
            lbl_setting.Size = new Size(79, 28);
            lbl_setting.TabIndex = 3;
            lbl_setting.Text = "Cài đặt";
            // 
            // pb_setting_outline
            // 
            pb_setting_outline.Image = Properties.Resources.setting_shape_line;
            pb_setting_outline.Location = new Point(3, 0);
            pb_setting_outline.Name = "pb_setting_outline";
            pb_setting_outline.Size = new Size(55, 55);
            pb_setting_outline.SizeMode = PictureBoxSizeMode.Zoom;
            pb_setting_outline.TabIndex = 2;
            pb_setting_outline.TabStop = false;
            // 
            // panel_logout
            // 
            panel_logout.BackColor = Color.White;
            panel_logout.Controls.Add(lbl_logout);
            panel_logout.Controls.Add(pb_logout);
            panel_logout.Cursor = Cursors.Hand;
            panel_logout.Location = new Point(3, 129);
            panel_logout.Name = "panel_logout";
            panel_logout.Size = new Size(232, 57);
            panel_logout.TabIndex = 3;
            panel_logout.Click += panel_logout_Click;
            // 
            // lbl_logout
            // 
            lbl_logout.AutoSize = true;
            lbl_logout.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_logout.Location = new Point(64, 14);
            lbl_logout.Name = "lbl_logout";
            lbl_logout.Size = new Size(106, 28);
            lbl_logout.TabIndex = 3;
            lbl_logout.Text = "Đăng xuất";
            lbl_logout.Click += lbl_logout_Click;
            // 
            // pb_logout
            // 
            pb_logout.Image = Properties.Resources.logoutIcon1;
            pb_logout.Location = new Point(3, 3);
            pb_logout.Name = "pb_logout";
            pb_logout.Size = new Size(50, 50);
            pb_logout.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logout.TabIndex = 2;
            pb_logout.TabStop = false;
            pb_logout.Click += pb_logout_Click;
            // 
            // popupUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flp_popup);
            Name = "popupUC";
            Size = new Size(243, 195);
            flp_popup.ResumeLayout(false);
            panel_profile_user.ResumeLayout(false);
            panel_profile_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_profile_avatar).EndInit();
            panel_setting.ResumeLayout(false);
            panel_setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_setting_outline).EndInit();
            panel_logout.ResumeLayout(false);
            panel_logout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_popup;
        private PictureBox pb_profile_avatar;
        private Label lbl_profile_user;
        private Panel panel_profile_user;
        private Panel panel_setting;
        private Label lbl_setting;
        private PictureBox pb_setting_outline;
        private Panel panel_logout;
        private Label lbl_logout;
        private PictureBox pb_logout;
    }
}
