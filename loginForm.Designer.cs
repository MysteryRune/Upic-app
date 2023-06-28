
namespace Upic
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            loginAnnouncement2 = new Label();
            loginAnnouncement = new Panel();
            minimizeBtt = new Button();
            line4 = new Label();
            lapWorldLogoBrand = new PictureBox();
            signUpBtt = new Button();
            dontHaveAccAnnouncement = new Label();
            line3 = new Label();
            rememberUserAcc = new CheckBox();
            loginBtt = new Button();
            hidePasswordBtt = new Button();
            passwordLabel1 = new Label();
            passwordBox = new TextBox();
            emailAddressUserNameLabel1 = new Label();
            emailOrUserNameBox = new TextBox();
            line2 = new Label();
            line1 = new Label();
            orLabel = new Label();
            phoneIcon = new PictureBox();
            phoneNumberLogin = new Label();
            googleIcon = new PictureBox();
            googleLogin = new Label();
            facebookIcon = new PictureBox();
            facebookLogin = new Label();
            brandStore = new Label();
            forgotPassSupport = new Button();
            intro = new PictureBox();
            signInBtt = new Button();
            signUpBtt2 = new Button();
            loginAnnouncement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lapWorldLogoBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phoneIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)googleIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facebookIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intro).BeginInit();
            SuspendLayout();
            // 
            // loginAnnouncement2
            // 
            loginAnnouncement2.Font = new Font("UVN Bai Sau", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            loginAnnouncement2.Location = new Point(150, 90);
            loginAnnouncement2.Name = "loginAnnouncement2";
            loginAnnouncement2.Size = new Size(200, 39);
            loginAnnouncement2.TabIndex = 0;
            loginAnnouncement2.Text = "ĐĂNG NHẬP";
            loginAnnouncement2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginAnnouncement
            // 
            loginAnnouncement.Anchor = AnchorStyles.Top;
            loginAnnouncement.Controls.Add(minimizeBtt);
            loginAnnouncement.Controls.Add(line4);
            loginAnnouncement.Controls.Add(lapWorldLogoBrand);
            loginAnnouncement.Controls.Add(signUpBtt);
            loginAnnouncement.Controls.Add(dontHaveAccAnnouncement);
            loginAnnouncement.Controls.Add(line3);
            loginAnnouncement.Controls.Add(rememberUserAcc);
            loginAnnouncement.Controls.Add(loginBtt);
            loginAnnouncement.Controls.Add(hidePasswordBtt);
            loginAnnouncement.Controls.Add(passwordLabel1);
            loginAnnouncement.Controls.Add(passwordBox);
            loginAnnouncement.Controls.Add(emailAddressUserNameLabel1);
            loginAnnouncement.Controls.Add(emailOrUserNameBox);
            loginAnnouncement.Controls.Add(line2);
            loginAnnouncement.Controls.Add(line1);
            loginAnnouncement.Controls.Add(orLabel);
            loginAnnouncement.Controls.Add(phoneIcon);
            loginAnnouncement.Controls.Add(phoneNumberLogin);
            loginAnnouncement.Controls.Add(googleIcon);
            loginAnnouncement.Controls.Add(googleLogin);
            loginAnnouncement.Controls.Add(facebookIcon);
            loginAnnouncement.Controls.Add(facebookLogin);
            loginAnnouncement.Controls.Add(loginAnnouncement2);
            loginAnnouncement.Controls.Add(brandStore);
            loginAnnouncement.Controls.Add(forgotPassSupport);
            loginAnnouncement.Font = new Font("UVN Bai Sau", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginAnnouncement.Location = new Point(500, 30);
            loginAnnouncement.Name = "loginAnnouncement";
            loginAnnouncement.Size = new Size(500, 800);
            loginAnnouncement.TabIndex = 1;
            // 
            // minimizeBtt
            // 
            minimizeBtt.AutoSize = true;
            minimizeBtt.Cursor = Cursors.Hand;
            minimizeBtt.FlatAppearance.BorderSize = 0;
            minimizeBtt.FlatStyle = FlatStyle.Flat;
            minimizeBtt.Location = new Point(467, 3);
            minimizeBtt.Name = "minimizeBtt";
            minimizeBtt.Size = new Size(36, 33);
            minimizeBtt.TabIndex = 24;
            minimizeBtt.Text = "__";
            minimizeBtt.TextAlign = ContentAlignment.TopCenter;
            minimizeBtt.UseVisualStyleBackColor = true;
            minimizeBtt.Click += minimizeBtt_Click;
            // 
            // line4
            // 
            line4.BorderStyle = BorderStyle.Fixed3D;
            line4.FlatStyle = FlatStyle.Flat;
            line4.Location = new Point(50, 80);
            line4.Name = "line4";
            line4.Size = new Size(400, 2);
            line4.TabIndex = 23;
            // 
            // lapWorldLogoBrand
            // 
            lapWorldLogoBrand.Image = Upic.Properties.Resources.lapWorldIcon;
            lapWorldLogoBrand.Location = new Point(146, 3);
            lapWorldLogoBrand.Name = "lapWorldLogoBrand";
            lapWorldLogoBrand.Size = new Size(60, 60);
            lapWorldLogoBrand.SizeMode = PictureBoxSizeMode.Zoom;
            lapWorldLogoBrand.TabIndex = 21;
            lapWorldLogoBrand.TabStop = false;
            // 
            // signUpBtt
            // 
            signUpBtt.Cursor = Cursors.Hand;
            signUpBtt.FlatStyle = FlatStyle.Flat;
            signUpBtt.Font = new Font("UVN Bai Sau", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signUpBtt.ForeColor = Color.FromArgb(124, 124, 124);
            signUpBtt.Location = new Point(80, 690);
            signUpBtt.Name = "signUpBtt";
            signUpBtt.Size = new Size(340, 45);
            signUpBtt.TabIndex = 20;
            signUpBtt.Text = "ĐĂNG KÝ TẠI ĐÂY";
            signUpBtt.UseVisualStyleBackColor = true;
            signUpBtt.Click += signUpBtt_Click;
            // 
            // dontHaveAccAnnouncement
            // 
            dontHaveAccAnnouncement.AutoSize = true;
            dontHaveAccAnnouncement.Font = new Font("UVN Bai Sau", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dontHaveAccAnnouncement.Location = new Point(141, 660);
            dontHaveAccAnnouncement.Name = "dontHaveAccAnnouncement";
            dontHaveAccAnnouncement.Size = new Size(196, 25);
            dontHaveAccAnnouncement.TabIndex = 19;
            dontHaveAccAnnouncement.Text = "Bạn chưa có tài khoản?";
            dontHaveAccAnnouncement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // line3
            // 
            line3.BorderStyle = BorderStyle.Fixed3D;
            line3.Location = new Point(80, 619);
            line3.Name = "line3";
            line3.Size = new Size(340, 2);
            line3.TabIndex = 18;
            // 
            // rememberUserAcc
            // 
            rememberUserAcc.AutoSize = true;
            rememberUserAcc.Checked = true;
            rememberUserAcc.CheckState = CheckState.Checked;
            rememberUserAcc.Cursor = Cursors.Hand;
            rememberUserAcc.Location = new Point(80, 580);
            rememberUserAcc.Name = "rememberUserAcc";
            rememberUserAcc.Size = new Size(149, 25);
            rememberUserAcc.TabIndex = 16;
            rememberUserAcc.Text = "Ghi nhớ tài khoản";
            rememberUserAcc.UseVisualStyleBackColor = true;
            // 
            // loginBtt
            // 
            loginBtt.BackColor = Color.Black;
            loginBtt.Cursor = Cursors.Hand;
            loginBtt.FlatAppearance.BorderSize = 0;
            loginBtt.FlatStyle = FlatStyle.Flat;
            loginBtt.ForeColor = Color.White;
            loginBtt.Location = new Point(310, 570);
            loginBtt.Name = "loginBtt";
            loginBtt.Size = new Size(110, 35);
            loginBtt.TabIndex = 15;
            loginBtt.Text = "ĐĂNG NHẬP";
            loginBtt.UseVisualStyleBackColor = false;
            loginBtt.Click += loginBtt_Click;
            // 
            // hidePasswordBtt
            // 
            hidePasswordBtt.BackColor = Color.White;
            hidePasswordBtt.BackgroundImageLayout = ImageLayout.Zoom;
            hidePasswordBtt.FlatAppearance.BorderSize = 0;
            hidePasswordBtt.FlatStyle = FlatStyle.Flat;
            hidePasswordBtt.ForeColor = Color.Transparent;
            hidePasswordBtt.Location = new Point(386, 520);
            hidePasswordBtt.Name = "hidePasswordBtt";
            hidePasswordBtt.Size = new Size(29, 27);
            hidePasswordBtt.TabIndex = 14;
            hidePasswordBtt.UseVisualStyleBackColor = false;
            hidePasswordBtt.Click += hidePasswordBtt_Click;
            // 
            // passwordLabel1
            // 
            passwordLabel1.AutoSize = true;
            passwordLabel1.Font = new Font("UVN Bai Sau", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel1.Location = new Point(80, 491);
            passwordLabel1.Name = "passwordLabel1";
            passwordLabel1.Size = new Size(72, 21);
            passwordLabel1.TabIndex = 13;
            passwordLabel1.Text = "Mật khẩu";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("UVN Bai Sau", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordBox.Location = new Point(80, 516);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(340, 35);
            passwordBox.TabIndex = 12;
            // 
            // emailAddressUserNameLabel1
            // 
            emailAddressUserNameLabel1.AutoSize = true;
            emailAddressUserNameLabel1.Font = new Font("UVN Bai Sau", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailAddressUserNameLabel1.Location = new Point(80, 420);
            emailAddressUserNameLabel1.Name = "emailAddressUserNameLabel1";
            emailAddressUserNameLabel1.Size = new Size(228, 21);
            emailAddressUserNameLabel1.TabIndex = 11;
            emailAddressUserNameLabel1.Text = "Địa chỉ Email hoặc Tên đăng nhập";
            // 
            // emailOrUserNameBox
            // 
            emailOrUserNameBox.Font = new Font("UVN Bai Sau", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            emailOrUserNameBox.Location = new Point(80, 445);
            emailOrUserNameBox.Name = "emailOrUserNameBox";
            emailOrUserNameBox.Size = new Size(340, 38);
            emailOrUserNameBox.TabIndex = 10;
            // 
            // line2
            // 
            line2.BorderStyle = BorderStyle.Fixed3D;
            line2.Location = new Point(285, 382);
            line2.Name = "line2";
            line2.Size = new Size(130, 2);
            line2.TabIndex = 9;
            // 
            // line1
            // 
            line1.BorderStyle = BorderStyle.Fixed3D;
            line1.Location = new Point(85, 382);
            line1.Name = "line1";
            line1.Size = new Size(130, 2);
            line1.TabIndex = 8;
            // 
            // orLabel
            // 
            orLabel.Font = new Font("UVN Bai Sau", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orLabel.Location = new Point(230, 370);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(40, 25);
            orLabel.TabIndex = 7;
            orLabel.Text = "OR";
            orLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneIcon
            // 
            phoneIcon.BackColor = Color.White;
            phoneIcon.Image = (Image)resources.GetObject("phoneIcon.Image");
            phoneIcon.Location = new Point(109, 322);
            phoneIcon.Name = "phoneIcon";
            phoneIcon.Size = new Size(20, 20);
            phoneIcon.SizeMode = PictureBoxSizeMode.Zoom;
            phoneIcon.TabIndex = 6;
            phoneIcon.TabStop = false;
            // 
            // phoneNumberLogin
            // 
            phoneNumberLogin.BackColor = Color.FromArgb(255, 255, 255);
            phoneNumberLogin.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberLogin.Cursor = Cursors.Hand;
            phoneNumberLogin.FlatStyle = FlatStyle.Flat;
            phoneNumberLogin.Font = new Font("UVN Bai Sau", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberLogin.ForeColor = Color.FromArgb(124, 124, 124);
            phoneNumberLogin.Location = new Point(80, 308);
            phoneNumberLogin.Name = "phoneNumberLogin";
            phoneNumberLogin.Size = new Size(340, 45);
            phoneNumberLogin.TabIndex = 5;
            phoneNumberLogin.Text = "Tiếp tục với Số điện thoại";
            phoneNumberLogin.TextAlign = ContentAlignment.MiddleCenter;
            phoneNumberLogin.Click += phoneNumberLogin_Click;
            // 
            // googleIcon
            // 
            googleIcon.BackColor = Color.White;
            googleIcon.Image = Upic.Properties.Resources.gmailIcon;
            googleIcon.Location = new Point(135, 260);
            googleIcon.Name = "googleIcon";
            googleIcon.Size = new Size(20, 20);
            googleIcon.SizeMode = PictureBoxSizeMode.Zoom;
            googleIcon.TabIndex = 4;
            googleIcon.TabStop = false;
            // 
            // googleLogin
            // 
            googleLogin.BackColor = Color.FromArgb(255, 255, 255);
            googleLogin.BorderStyle = BorderStyle.FixedSingle;
            googleLogin.Cursor = Cursors.Hand;
            googleLogin.FlatStyle = FlatStyle.Flat;
            googleLogin.Font = new Font("UVN Bai Sau", 12F, FontStyle.Bold, GraphicsUnit.Point);
            googleLogin.ForeColor = Color.FromArgb(124, 124, 124);
            googleLogin.Location = new Point(80, 246);
            googleLogin.Name = "googleLogin";
            googleLogin.Size = new Size(340, 45);
            googleLogin.TabIndex = 3;
            googleLogin.Text = "Tiếp tục với Google";
            googleLogin.TextAlign = ContentAlignment.MiddleCenter;
            googleLogin.Click += googleLogin_Click;
            // 
            // facebookIcon
            // 
            facebookIcon.BackColor = Color.FromArgb(17, 120, 242);
            facebookIcon.Image = Upic.Properties.Resources.facebookIcon;
            facebookIcon.Location = new Point(125, 198);
            facebookIcon.Name = "facebookIcon";
            facebookIcon.Size = new Size(20, 20);
            facebookIcon.SizeMode = PictureBoxSizeMode.Zoom;
            facebookIcon.TabIndex = 2;
            facebookIcon.TabStop = false;
            // 
            // facebookLogin
            // 
            facebookLogin.BackColor = Color.FromArgb(17, 120, 242);
            facebookLogin.BorderStyle = BorderStyle.FixedSingle;
            facebookLogin.Cursor = Cursors.Hand;
            facebookLogin.FlatStyle = FlatStyle.Flat;
            facebookLogin.Font = new Font("UVN Bai Sau", 12F, FontStyle.Bold, GraphicsUnit.Point);
            facebookLogin.ForeColor = Color.White;
            facebookLogin.Location = new Point(80, 184);
            facebookLogin.Name = "facebookLogin";
            facebookLogin.Size = new Size(340, 45);
            facebookLogin.TabIndex = 1;
            facebookLogin.Text = "Tiếp tục với Facebook";
            facebookLogin.TextAlign = ContentAlignment.MiddleCenter;
            facebookLogin.Click += facebookLogin_Click;
            // 
            // brandStore
            // 
            brandStore.FlatStyle = FlatStyle.Flat;
            brandStore.Font = new Font("UVN Bai Sau", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            brandStore.Location = new Point(135, 0);
            brandStore.Name = "brandStore";
            brandStore.Size = new Size(230, 71);
            brandStore.TabIndex = 22;
            brandStore.Text = "LAPWORLD";
            brandStore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // forgotPassSupport
            // 
            forgotPassSupport.AutoSize = true;
            forgotPassSupport.Cursor = Cursors.Hand;
            forgotPassSupport.FlatAppearance.BorderSize = 0;
            forgotPassSupport.FlatStyle = FlatStyle.Flat;
            forgotPassSupport.Font = new Font("UVN Bai Sau", 9F, FontStyle.Underline, GraphicsUnit.Point);
            forgotPassSupport.Location = new Point(80, 550);
            forgotPassSupport.Name = "forgotPassSupport";
            forgotPassSupport.Size = new Size(154, 33);
            forgotPassSupport.TabIndex = 4;
            forgotPassSupport.Text = "Bạn quên mật khẩu?";
            forgotPassSupport.TextAlign = ContentAlignment.MiddleLeft;
            forgotPassSupport.UseVisualStyleBackColor = true;
            // 
            // intro
            // 
            intro.Dock = DockStyle.Fill;
            intro.Image = Upic.Properties.Resources.Intro;
            intro.Location = new Point(0, 0);
            intro.Name = "intro";
            intro.Size = new Size(1482, 853);
            intro.SizeMode = PictureBoxSizeMode.Zoom;
            intro.TabIndex = 2;
            intro.TabStop = false;
            // 
            // signInBtt
            // 
            signInBtt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signInBtt.BackColor = Color.Black;
            signInBtt.Cursor = Cursors.Hand;
            signInBtt.FlatAppearance.BorderSize = 0;
            signInBtt.FlatStyle = FlatStyle.Flat;
            signInBtt.Font = new Font("UVN Bai Sau", 9F, FontStyle.Bold, GraphicsUnit.Point);
            signInBtt.ForeColor = Color.White;
            signInBtt.Location = new Point(1155, 26);
            signInBtt.Name = "signInBtt";
            signInBtt.Size = new Size(100, 35);
            signInBtt.TabIndex = 25;
            signInBtt.Text = "Đăng nhập";
            signInBtt.UseVisualStyleBackColor = false;
            signInBtt.Visible = false;
            signInBtt.Click += signInBtt_Click;
            // 
            // signUpBtt2
            // 
            signUpBtt2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signUpBtt2.BackColor = Color.Black;
            signUpBtt2.BackgroundImageLayout = ImageLayout.None;
            signUpBtt2.Cursor = Cursors.Hand;
            signUpBtt2.FlatAppearance.BorderSize = 0;
            signUpBtt2.FlatStyle = FlatStyle.Flat;
            signUpBtt2.Font = new Font("UVN Bai Sau", 9F, FontStyle.Bold, GraphicsUnit.Point);
            signUpBtt2.ForeColor = Color.White;
            signUpBtt2.Location = new Point(1282, 26);
            signUpBtt2.Name = "signUpBtt2";
            signUpBtt2.Size = new Size(100, 35);
            signUpBtt2.TabIndex = 26;
            signUpBtt2.Text = "Đăng ký";
            signUpBtt2.UseVisualStyleBackColor = false;
            signUpBtt2.Visible = false;
            signUpBtt2.Click += signUpBtt2_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1482, 853);
            Controls.Add(signUpBtt2);
            Controls.Add(signInBtt);
            Controls.Add(loginAnnouncement);
            Controls.Add(intro);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LapWorld";
            Load += loginForm_Load;
            loginAnnouncement.ResumeLayout(false);
            loginAnnouncement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lapWorldLogoBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)phoneIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)googleIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)facebookIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)intro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label loginAnnouncement2;
        private Panel loginAnnouncement;
        private Label facebookLogin;
        private PictureBox facebookIcon;
        private PictureBox googleIcon;
        private Label googleLogin;
        private PictureBox phoneIcon;
        private Label phoneNumberLogin;
        private Label orLabel;
        private Label line1;
        private Label line2;
        private Label emailAddressUserNameLabel1;
        private TextBox emailOrUserNameBox;
        private Label passwordLabel1;
        private TextBox passwordBox;
        private Button hidePasswordBtt;
        private Button loginBtt;
        private CheckBox rememberUserAcc;
        private Label line3;
        private Label dontHaveAccAnnouncement;
        private Button signUpBtt;
        private PictureBox lapWorldLogoBrand;
        private Label brandStore;
        private Label line4;
        private Button forgotPassSupport;
        private PictureBox intro;
        private Button minimizeBtt;
        private Button signInBtt;
        private Button signUpBtt2;
    }
}