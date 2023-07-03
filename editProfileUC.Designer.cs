namespace Upic
{
    partial class editProfileUC
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
            lbl_edit_profile = new Label();
            lbl_profile_avatar = new Label();
            pb_profile_user_avatar = new PictureBox();
            btn_edit_avatar = new Button();
            lbl_profile_info = new Label();
            panel_info = new Panel();
            panel_edit_info = new Panel();
            tb_edit_hobby = new TextBox();
            tb_edit_story = new TextBox();
            tb_edit_address = new TextBox();
            tb_edit_year = new TextBox();
            tb_edit_month = new TextBox();
            tb_edit_day = new TextBox();
            tb_edit_name = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_user_address = new Label();
            lbl_user_dob = new Label();
            lbl_user_sex = new Label();
            lbl_user_name = new Label();
            lbl_hobby = new Label();
            lbl_story = new Label();
            lbl_sex = new Label();
            lbl_address = new Label();
            lbl_dob = new Label();
            lbl_name = new Label();
            btn_update_info = new Button();
            btn_save_profile = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pb_profile_user_avatar).BeginInit();
            panel_info.SuspendLayout();
            panel_edit_info.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_edit_profile
            // 
            lbl_edit_profile.AutoSize = true;
            lbl_edit_profile.Font = new Font("Be Vietnam Pro ExtraBold", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_edit_profile.Location = new Point(326, 9);
            lbl_edit_profile.Name = "lbl_edit_profile";
            lbl_edit_profile.Size = new Size(321, 57);
            lbl_edit_profile.TabIndex = 2;
            lbl_edit_profile.Text = "Chỉnh sửa hồ sơ";
            // 
            // lbl_profile_avatar
            // 
            lbl_profile_avatar.AutoSize = true;
            lbl_profile_avatar.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_profile_avatar.ForeColor = Color.Black;
            lbl_profile_avatar.Location = new Point(29, 81);
            lbl_profile_avatar.Name = "lbl_profile_avatar";
            lbl_profile_avatar.Size = new Size(158, 35);
            lbl_profile_avatar.TabIndex = 3;
            lbl_profile_avatar.Text = "Ảnh đại diện";
            // 
            // pb_profile_user_avatar
            // 
            pb_profile_user_avatar.Image = Properties.Resources.accountIcon;
            pb_profile_user_avatar.Location = new Point(387, 81);
            pb_profile_user_avatar.Name = "pb_profile_user_avatar";
            pb_profile_user_avatar.Size = new Size(200, 200);
            pb_profile_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_profile_user_avatar.TabIndex = 4;
            pb_profile_user_avatar.TabStop = false;
            // 
            // btn_edit_avatar
            // 
            btn_edit_avatar.BackColor = Color.White;
            btn_edit_avatar.FlatAppearance.BorderColor = Color.White;
            btn_edit_avatar.FlatStyle = FlatStyle.Flat;
            btn_edit_avatar.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit_avatar.ForeColor = Color.SteelBlue;
            btn_edit_avatar.Location = new Point(763, 72);
            btn_edit_avatar.Name = "btn_edit_avatar";
            btn_edit_avatar.Size = new Size(159, 44);
            btn_edit_avatar.TabIndex = 5;
            btn_edit_avatar.Text = "Chỉnh sửa";
            btn_edit_avatar.UseVisualStyleBackColor = false;
            // 
            // lbl_profile_info
            // 
            lbl_profile_info.AutoSize = true;
            lbl_profile_info.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_profile_info.ForeColor = Color.Black;
            lbl_profile_info.Location = new Point(29, 307);
            lbl_profile_info.Name = "lbl_profile_info";
            lbl_profile_info.Size = new Size(258, 35);
            lbl_profile_info.TabIndex = 6;
            lbl_profile_info.Text = "Thông tin người dùng";
            // 
            // panel_info
            // 
            panel_info.Controls.Add(label2);
            panel_info.Controls.Add(label1);
            panel_info.Controls.Add(lbl_user_address);
            panel_info.Controls.Add(lbl_user_dob);
            panel_info.Controls.Add(lbl_user_sex);
            panel_info.Controls.Add(lbl_user_name);
            panel_info.Controls.Add(lbl_hobby);
            panel_info.Controls.Add(lbl_story);
            panel_info.Controls.Add(lbl_sex);
            panel_info.Controls.Add(lbl_address);
            panel_info.Controls.Add(lbl_dob);
            panel_info.Controls.Add(lbl_name);
            panel_info.Location = new Point(29, 348);
            panel_info.Name = "panel_info";
            panel_info.Size = new Size(893, 473);
            panel_info.TabIndex = 7;
            // 
            // panel_edit_info
            // 
            panel_edit_info.Controls.Add(comboBox1);
            panel_edit_info.Controls.Add(tb_edit_hobby);
            panel_edit_info.Controls.Add(tb_edit_story);
            panel_edit_info.Controls.Add(tb_edit_address);
            panel_edit_info.Controls.Add(tb_edit_year);
            panel_edit_info.Controls.Add(tb_edit_month);
            panel_edit_info.Controls.Add(tb_edit_day);
            panel_edit_info.Controls.Add(tb_edit_name);
            panel_edit_info.Controls.Add(label9);
            panel_edit_info.Controls.Add(label10);
            panel_edit_info.Controls.Add(label11);
            panel_edit_info.Controls.Add(label12);
            panel_edit_info.Controls.Add(label13);
            panel_edit_info.Controls.Add(label14);
            panel_edit_info.Location = new Point(29, 348);
            panel_edit_info.Name = "panel_edit_info";
            panel_edit_info.Size = new Size(893, 473);
            panel_edit_info.TabIndex = 9;
            panel_edit_info.Visible = false;
            // 
            // tb_edit_hobby
            // 
            tb_edit_hobby.BorderStyle = BorderStyle.None;
            tb_edit_hobby.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            tb_edit_hobby.Location = new Point(341, 370);
            tb_edit_hobby.Multiline = true;
            tb_edit_hobby.Name = "tb_edit_hobby";
            tb_edit_hobby.PlaceholderText = "Nhập địa chỉ mới";
            tb_edit_hobby.Size = new Size(495, 87);
            tb_edit_hobby.TabIndex = 21;
            // 
            // tb_edit_story
            // 
            tb_edit_story.BorderStyle = BorderStyle.None;
            tb_edit_story.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            tb_edit_story.Location = new Point(338, 253);
            tb_edit_story.Multiline = true;
            tb_edit_story.Name = "tb_edit_story";
            tb_edit_story.PlaceholderText = "Nhập tiểu sử mới";
            tb_edit_story.Size = new Size(495, 94);
            tb_edit_story.TabIndex = 20;
            // 
            // tb_edit_address
            // 
            tb_edit_address.BorderStyle = BorderStyle.None;
            tb_edit_address.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            tb_edit_address.Location = new Point(337, 176);
            tb_edit_address.Multiline = true;
            tb_edit_address.Name = "tb_edit_address";
            tb_edit_address.PlaceholderText = "Nhập địa chỉ mới";
            tb_edit_address.Size = new Size(485, 62);
            tb_edit_address.TabIndex = 19;
            // 
            // tb_edit_year
            // 
            tb_edit_year.BorderStyle = BorderStyle.None;
            tb_edit_year.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            tb_edit_year.Location = new Point(599, 122);
            tb_edit_year.Multiline = true;
            tb_edit_year.Name = "tb_edit_year";
            tb_edit_year.PlaceholderText = "Năm";
            tb_edit_year.Size = new Size(59, 34);
            tb_edit_year.TabIndex = 18;
            // 
            // tb_edit_month
            // 
            tb_edit_month.BorderStyle = BorderStyle.None;
            tb_edit_month.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            tb_edit_month.Location = new Point(459, 122);
            tb_edit_month.Multiline = true;
            tb_edit_month.Name = "tb_edit_month";
            tb_edit_month.PlaceholderText = "Tháng";
            tb_edit_month.Size = new Size(59, 34);
            tb_edit_month.TabIndex = 17;
            // 
            // tb_edit_day
            // 
            tb_edit_day.BorderStyle = BorderStyle.None;
            tb_edit_day.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            tb_edit_day.Location = new Point(337, 122);
            tb_edit_day.Multiline = true;
            tb_edit_day.Name = "tb_edit_day";
            tb_edit_day.PlaceholderText = "Ngày";
            tb_edit_day.Size = new Size(59, 34);
            tb_edit_day.TabIndex = 16;
            tb_edit_day.TextChanged += tb_edit_day_TextChanged;
            // 
            // tb_edit_name
            // 
            tb_edit_name.BorderStyle = BorderStyle.None;
            tb_edit_name.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            tb_edit_name.Location = new Point(337, 32);
            tb_edit_name.Multiline = true;
            tb_edit_name.Name = "tb_edit_name";
            tb_edit_name.PlaceholderText = "Nhập tên hồ sơ";
            tb_edit_name.Size = new Size(485, 34);
            tb_edit_name.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(168, 370);
            label9.Name = "label9";
            label9.Size = new Size(92, 28);
            label9.TabIndex = 7;
            label9.Text = "Sở thích:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(177, 255);
            label10.Name = "label10";
            label10.Size = new Size(80, 28);
            label10.TabIndex = 6;
            label10.Text = "Tiểu sử:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(164, 79);
            label11.Name = "label11";
            label11.Size = new Size(93, 28);
            label11.TabIndex = 5;
            label11.Text = "Giới tính:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(180, 176);
            label12.Name = "label12";
            label12.Size = new Size(80, 28);
            label12.TabIndex = 4;
            label12.Text = "Địa chỉ:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(154, 128);
            label13.Name = "label13";
            label13.Size = new Size(103, 28);
            label13.TabIndex = 3;
            label13.Text = "Sinh nhật:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(155, 31);
            label14.Name = "label14";
            label14.Size = new Size(102, 28);
            label14.TabIndex = 2;
            label14.Text = "Tên hồ sơ:";
            // 
            // label2
            // 
            label2.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(339, 353);
            label2.Name = "label2";
            label2.Size = new Size(522, 87);
            label2.TabIndex = 13;
            label2.Text = "Yêu một lúc 10 người\r\n";
            // 
            // label1
            // 
            label1.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(339, 250);
            label1.Name = "label1";
            label1.Size = new Size(522, 103);
            label1.TabIndex = 12;
            label1.Text = "Một chút nhớ góp thành bão giông, một chút mưa đầy biển rộng, một chút yêu thôi, mà đau như cháy lòng";
            // 
            // lbl_user_address
            // 
            lbl_user_address.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_user_address.Location = new Point(339, 174);
            lbl_user_address.Name = "lbl_user_address";
            lbl_user_address.Size = new Size(488, 78);
            lbl_user_address.TabIndex = 11;
            lbl_user_address.Text = "Một đầu xóm một cuối thôn";
            // 
            // lbl_user_dob
            // 
            lbl_user_dob.AutoSize = true;
            lbl_user_dob.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_user_dob.Location = new Point(341, 121);
            lbl_user_dob.Name = "lbl_user_dob";
            lbl_user_dob.Size = new Size(175, 28);
            lbl_user_dob.TabIndex = 10;
            lbl_user_dob.Text = "Một chín một mười\r\n";
            // 
            // lbl_user_sex
            // 
            lbl_user_sex.AutoSize = true;
            lbl_user_sex.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_user_sex.Location = new Point(339, 72);
            lbl_user_sex.Name = "lbl_user_sex";
            lbl_user_sex.Size = new Size(154, 28);
            lbl_user_sex.TabIndex = 9;
            lbl_user_sex.Text = "Một nam một nữ\r\n";
            // 
            // lbl_user_name
            // 
            lbl_user_name.AutoSize = true;
            lbl_user_name.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_user_name.Location = new Point(341, 29);
            lbl_user_name.Name = "lbl_user_name";
            lbl_user_name.Size = new Size(252, 28);
            lbl_user_name.TabIndex = 8;
            lbl_user_name.Text = "Hai chú gấu một to một lớn\r\n";
            // 
            // lbl_hobby
            // 
            lbl_hobby.AutoSize = true;
            lbl_hobby.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_hobby.Location = new Point(167, 355);
            lbl_hobby.Name = "lbl_hobby";
            lbl_hobby.Size = new Size(92, 28);
            lbl_hobby.TabIndex = 7;
            lbl_hobby.Text = "Sở thích:";
            // 
            // lbl_story
            // 
            lbl_story.AutoSize = true;
            lbl_story.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_story.Location = new Point(166, 254);
            lbl_story.Name = "lbl_story";
            lbl_story.Size = new Size(80, 28);
            lbl_story.TabIndex = 6;
            lbl_story.Text = "Tiểu sử:";
            // 
            // lbl_sex
            // 
            lbl_sex.AutoSize = true;
            lbl_sex.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_sex.Location = new Point(163, 74);
            lbl_sex.Name = "lbl_sex";
            lbl_sex.Size = new Size(93, 28);
            lbl_sex.TabIndex = 5;
            lbl_sex.Text = "Giới tính:";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_address.Location = new Point(178, 174);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(80, 28);
            lbl_address.TabIndex = 4;
            lbl_address.Text = "Địa chỉ:";
            // 
            // lbl_dob
            // 
            lbl_dob.AutoSize = true;
            lbl_dob.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dob.Location = new Point(154, 123);
            lbl_dob.Name = "lbl_dob";
            lbl_dob.Size = new Size(103, 28);
            lbl_dob.TabIndex = 3;
            lbl_dob.Text = "Sinh nhật:";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(155, 31);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(102, 28);
            lbl_name.TabIndex = 2;
            lbl_name.Text = "Tên hồ sơ:";
            // 
            // btn_update_info
            // 
            btn_update_info.BackColor = Color.White;
            btn_update_info.FlatAppearance.BorderColor = Color.White;
            btn_update_info.FlatStyle = FlatStyle.Flat;
            btn_update_info.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update_info.ForeColor = Color.SteelBlue;
            btn_update_info.Location = new Point(763, 298);
            btn_update_info.Name = "btn_update_info";
            btn_update_info.Size = new Size(159, 44);
            btn_update_info.TabIndex = 8;
            btn_update_info.Text = "Chỉnh sửa";
            btn_update_info.UseVisualStyleBackColor = false;
            btn_update_info.Click += btn_update_info_Click;
            // 
            // btn_save_profile
            // 
            btn_save_profile.BackColor = Color.SteelBlue;
            btn_save_profile.FlatAppearance.BorderColor = Color.White;
            btn_save_profile.FlatStyle = FlatStyle.Flat;
            btn_save_profile.Font = new Font("Be Vietnam Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save_profile.ForeColor = Color.White;
            btn_save_profile.Location = new Point(402, 846);
            btn_save_profile.Name = "btn_save_profile";
            btn_save_profile.Size = new Size(169, 54);
            btn_save_profile.TabIndex = 10;
            btn_save_profile.Text = "Hoàn tất";
            btn_save_profile.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Be Vietnam Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ", "Không tiết lộ" });
            comboBox1.Location = new Point(336, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 22;
            // 
            // editProfileUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_save_profile);
            Controls.Add(panel_edit_info);
            Controls.Add(btn_update_info);
            Controls.Add(panel_info);
            Controls.Add(lbl_profile_info);
            Controls.Add(btn_edit_avatar);
            Controls.Add(pb_profile_user_avatar);
            Controls.Add(lbl_profile_avatar);
            Controls.Add(lbl_edit_profile);
            Name = "editProfileUC";
            Size = new Size(952, 952);
            ((System.ComponentModel.ISupportInitialize)pb_profile_user_avatar).EndInit();
            panel_info.ResumeLayout(false);
            panel_info.PerformLayout();
            panel_edit_info.ResumeLayout(false);
            panel_edit_info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_edit_profile;
        private Label lbl_profile_avatar;
        private PictureBox pb_profile_user_avatar;
        private Button btn_edit_avatar;
        private Label lbl_profile_info;
        private Panel panel_info;
        private Label lbl_address;
        private Label lbl_dob;
        private Label lbl_name;
        private Label lbl_hobby;
        private Label lbl_story;
        private Label lbl_sex;
        private Label label1;
        private Label lbl_user_address;
        private Label lbl_user_dob;
        private Label lbl_user_sex;
        private Label lbl_user_name;
        private Button btn_update_info;
        private Panel panel_edit_info;
        private TextBox tb_edit_hobby;
        private TextBox tb_edit_story;
        private TextBox tb_edit_address;
        private TextBox tb_edit_year;
        private TextBox tb_edit_month;
        private TextBox tb_edit_day;
        private TextBox tb_edit_name;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label2;
        private Button btn_save_profile;
        private ComboBox comboBox1;
    }
}
