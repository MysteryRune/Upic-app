using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Cloud.Firestore;
using static Google.Api.ResourceDescriptor.Types;

namespace Upic
{
    public partial class loginForm : Form
    {
        private bool close_by_X_btt;
        FirestoreDb database;

        public loginForm()
        {
            InitializeComponent();

            close_by_X_btt = true;
            connectFirestoreDatabase();

#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            FormClosed += new FormClosedEventHandler(loginForm_FormClosedByXBtt);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        private void connectFirestoreDatabase()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            loginAnnouncement.AutoScroll = false;
            loginAnnouncement.VerticalScroll.Maximum = 0;
            loginAnnouncement.HorizontalScroll.Maximum = 0;
            loginAnnouncement.AutoScroll = true;
            loginAnnouncement.Visible = false;
            loginBtt.Visible = true;
            signUpBtt.Visible = true;
        }

        private void googleLogin_Click(object sender, EventArgs e)
        {
            /*close_by_X_btt = false;
            Close();
            googleLogin form = new();
            form.Show();*/
        }

        private void phoneNumberLogin_Click(object sender, EventArgs e)
        {
            /*close_by_X_btt = false;
            Close();
            phoneNumLogin form = new();
            form.Show();*/
        }

        private void hidePasswordBtt_Click(object sender, EventArgs e)
        {
            // "" Hidding password
            // " " Unhidding password
            if (hidePasswordBtt.Text == "") // Hidden password --> Unhidden password
            {
                hidePasswordBtt.Text = " ";
                hidePasswordBtt.BackgroundImage = Properties.Resources.eyeUnhideIcon;
                passwordBox.PasswordChar = '\0';
            }
            else // Unhidden password --> Hidden password
            {
                hidePasswordBtt.Text = "";
                hidePasswordBtt.BackgroundImage = Properties.Resources.eyeHiddenIcon;
                passwordBox.PasswordChar = '*';
            }
        }

        private void signUpBtt_Click(object sender, EventArgs e)
        {
            loginBtt.Visible = false;
            signUpBtt.Visible = false;
            loginAnnouncement.Visible = false;
            signUpPanel1.Visible = true;
        }

        private void loginBtt_Click(object sender, EventArgs e)
        {
            close_by_X_btt = false;
            Close();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.ShowInTaskbar = true;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.Visible = true;
            homepageForm.homePageInstance.AutoScroll = true;
        }

        private void loginForm_FormClosedByXBtt(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && close_by_X_btt == true)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                homepageForm.homePageInstance.Close();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }

        private void minimizeBtt_Click(object sender, EventArgs e)
        {
            loginAnnouncement.Visible = false;
            loginBtt.Visible = true;
            signUpBtt.Visible = true;
        }

        private void signInBtt_Click(object sender, EventArgs e)
        {
            loginBtt.Visible = false;
            signUpBtt.Visible = false;
            loginAnnouncement.Visible = true;
        }

        private void nextBtt_Click(object sender, EventArgs e)
        {
            if (checkDataFieldValidSignUpPanel1())
            {
                signUpPanel1.Visible = false;
                signUpPanel2.Visible = true;
            }
        }

        private void minimizeBtt2_Click(object sender, EventArgs e)
        {
            signUpPanel1.Visible = false;
            loginBtt.Visible = true;
            signUpBtt.Visible = true;
        }

        private void loginPanelBtt1_Click(object sender, EventArgs e)
        {
            signUpPanel1.Visible = false;
            loginAnnouncement.Visible = true;
        }

        private void minimizeBtt3_Click(object sender, EventArgs e)
        {
            signUpPanel2.Visible = false;
            loginBtt.Visible = true;
            signUpBtt.Visible = true;
        }

        private void backBtt_Click(object sender, EventArgs e)
        {
            signUpPanel2.Visible = false;
            signUpPanel1.Visible = true;
        }

        private void loginPanelBtt2_Click(object sender, EventArgs e)
        {
            signUpPanel2.Visible = false;
            loginAnnouncement.Visible = true;
        }

        private bool checkDataFieldValidSignUpPanel1()
        {
            var email = new EmailAddressAttribute();

            if (emailAddressBoxRegister.Text.Length < 1)
            {
                string message = "Trường Email không được bỏ trống!";
                MessageBox.Show(message, "Dữ liệu không hợp lệ");
                return false;
            }
            else if (!email.IsValid(emailAddressBoxRegister.Text))
            {
                string message = "Email đã nhập không hợp lệ!";
                MessageBox.Show(message, "Dữ liệu không hợp lệ");
                return false;
            }

            if (emailConfirmBoxRegister.Text != emailAddressBoxRegister.Text)
            {
                string message = "Email xác nhận không trùng khớp với Email đã nhập!";
                MessageBox.Show(message, "Dữ liệu không hợp lệ");
                return false;
            }

            if (phoneNumberBoxRegister.Text.Length < 10 || phoneNumberBoxRegister.Text.Length > 10)
            {
                string message = "Số điện thoại đã nhập không hợp lệ!";
                MessageBox.Show(message, "Dữ liệu không hợp lệ");
                return false;
            }

            if (userNameBoxRegister.Text.Length < 6)
            {
                string message = "Tên đăng nhập phải từ 6 kí tự trở lên!";
                MessageBox.Show(message, "Dữ liệu không hợp lệ");
                return false;
            }

            if (passwordBoxRegister.Text.Length < 6)
            {
                string message = "Mật khẩu phải từ 6 kí tự trở lên!";
                MessageBox.Show(message, "Dữ liệu không hợp lệ");
                return false;
            }

            if (passwordConfirmBoxRegister.Text != passwordBoxRegister.Text)
            {
                string message = "Mật khẩu xác nhận không trùng khớp với mật khẩu đã nhập!";
                MessageBox.Show(message, "Dữ liệu không hợp lệ");
                return false;
            }

            return true;
        }

        private bool checkDataFieldValidSignUpPanel2()
        {
            var email = new EmailAddressAttribute();

            if (profileNameBox.Text.Length == 0)
            {
                string message = "Tên hồ sơ người dùng phải có ít nhất 1 kí tự!";
                MessageBox.Show(message, "Dữ liệu không hợp lệ");
                return false;
            }

            if (dayBox.Text.Length == 0 || monthBoxCombo.Text.Length == 0 || yearBox.Text.Length == 0)
            {
                string message = "Vui lòng nhập đầy đủ Ngày, Tháng, Năm";
                MessageBox.Show(message, "Dữ liệu không hợp lệ");
                return false;
            }

            return true;
        }

        private void createUserOnDatabase(String username, String password, String phonenum, String email, String profileName, String sex, String dateOfBirth, String address, String avatar = "default", String story = "", String hobby = "")
        {
        }

        private void finishBtt_Click(object sender, EventArgs e)
        {
            if (checkDataFieldValidSignUpPanel2())
            {
                String username_tmp = userNameBoxRegister.Text;
                String password_tmp = passwordBoxRegister.Text;
                String phonenum_tmp = phoneNumberBoxRegister.Text;
                String email_tmp = emailAddressBoxRegister.Text;
                String profileName_tmp = profileNameBox.Text;
                String sex_tmp = "";
                String dateOfBirth_tmp = dayBox.Text + "-" + monthBoxCombo.Text + "-" + yearBox.Text;
                String address_tmp = communeBox.Text + "_" + townBox.Text + "_" + provinceBox.Text + "_" + "Việt Nam";
                String avatar_tmp = "default";
                String story_tmp = "";
                String hobby_tmp = "";

                if (maleGender.Checked == true)
                {
                    sex_tmp = "Nam";
                }
                else if (femaleGender.Checked == true)
                {
                    sex_tmp = "Nữ";
                }
                else
                {
                    sex_tmp = "Không tiết lộ";
                }

                createUserOnDatabase(username_tmp, password_tmp, phonenum_tmp, email_tmp, profileName_tmp, sex_tmp, dateOfBirth_tmp, address_tmp, avatar_tmp, story_tmp, hobby_tmp);
                signUpPanel2.Visible = false;
                emailOrUserNameBox.Text = username_tmp;
                passwordBox.Text = password_tmp;
                loginAnnouncement.Visible = true;
            }
        }

        private void hidePasswordBtt2_Click(object sender, EventArgs e)
        {
            // "" Hidding password
            // " " Unhidding password
            if (hidePasswordBtt2.Text == "") // Hidden password --> Unhidden password
            {
                hidePasswordBtt2.Text = " ";
                hidePasswordBtt2.BackgroundImage = Properties.Resources.eyeUnhideIcon;
                passwordBoxRegister.PasswordChar = '\0';
            }
            else // Unhidden password --> Hidden password
            {
                hidePasswordBtt2.Text = "";
                hidePasswordBtt2.BackgroundImage = Properties.Resources.eyeHiddenIcon;
                passwordBoxRegister.PasswordChar = '*';
            }
        }
    }
}
