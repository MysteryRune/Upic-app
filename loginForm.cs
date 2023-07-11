using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

using Upic.myMethods.firebaseFunctionCustom;

using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using static Google.Api.ResourceDescriptor.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Google.Cloud.Storage.V1;

namespace Upic
{
    public partial class loginForm : Form
    {
        public String userLogging = "";
        public static loginForm? loginPageInstance;
        //private String errorCode = "Lỗi bất đồng bộ kìa!!!";
        FirestoreDb database;

        public loginForm()
        {
            loginPageInstance = this;
            InitializeComponent();

            provinceBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthBoxCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            (new firestoreDatabase()).connectToDatabase("firestore.json");
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

        private void navigateToHomePage(object sender, EventArgs e, String username)
        {
            this.Visible = false;

            userLogging = username;
            homepageForm tmp = new homepageForm();
            tmp.setUsername(username);
            tmp.Show();
//#pragma warning disable CS8602 // Dereference of a possibly null reference.
//            homepageForm.homePageInstance.setUsername(username);
//#pragma warning restore CS8602 // Dereference of a possibly null reference.
//            homepageForm.homePageInstance.ShowInTaskbar = true;
//            homepageForm.homePageInstance.Visible = true;
//            homepageForm.homePageInstance.AutoScroll = true;
        }

        private bool checkDataFieldValidLoginPanel()
        {
            if (emailOrUserNameBox.Text.Length < 1 || passwordBox.Text.Length < 1)
            {
                string message = "Vui lòng nhập đầy đủ các trường thông tin!";
                MessageBox.Show(message, "Dữ liệu không hợp lệ");
                return false;
            }
            return true;
        }

        private async void loginBtt_Click(object sender, EventArgs e)
        {
            // ERROR CODE
            // "UPerror_1": User not exist
            // "UPerror_2": Wrong password
            // ------

            String userName = emailOrUserNameBox.Text;
            String password = passwordBox.Text;
            database = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
            CollectionReference collRef = database.Collection("Users");
            var email = new EmailAddressAttribute();
            //DocumentReference docRef = collRef.Document(userName);
            //DocumentSnapshot snap = await docRef.GetSnapshotAsync();

            if (!checkDataFieldValidLoginPanel())
            {
                return;
            }

            if (email.IsValid(userName))
            {
                Query queryRef = collRef.WhereEqualTo("Email", userName);
                QuerySnapshot querySnap = await queryRef.GetSnapshotAsync();
                if (querySnap.Count != 0)
                {
                    DocumentSnapshot docSnap = querySnap[0];
                    Dictionary<String, Object> userInfo = docSnap.ToDictionary();
                    if (password == userInfo["Password"].ToString())
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        navigateToHomePage(sender, e, docSnap.Id);
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Người dùng không tồn tại", "Thông báo");
                }
            }
            else
            {
                DocumentReference docRef = collRef.Document(userName);
                DocumentSnapshot docSnap = await docRef.GetSnapshotAsync();
                if (docSnap.Exists)
                {
                    Dictionary<String, Object> userInfo = docSnap.ToDictionary();
                    if (password == userInfo["Password"].ToString())
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        navigateToHomePage(sender, e, docSnap.Id);
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Người dùng không tồn tại", "Thông báo");
                }
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

            if (string.IsNullOrWhiteSpace(userNameBoxRegister.Text))
            {
                string message = "Tên đăng nhập Không được bỏ trống hoặc chứa khoảng trắng!";
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

        private async Task<String> checkValidDataInDatabase(String[] Data)
        {
            // ERROR CODE:
            // DBreader_0: Nothing's happening
            // DBreader_1: User name existed
            // DBreader_3: Phone number existed
            // DBreader_4: Email existed
            // ------

            database = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
            CollectionReference usersColl = database.Collection("Users");
            DocumentReference docRef = usersColl.Document(Data[0]);
            DocumentSnapshot snap = await docRef.GetSnapshotAsync();

            if (snap.Exists)
            {
                return "DBreader_1";
                //errorCode = "DBreader_1";
            }
            else
            {
                Query Qref = usersColl.WhereEqualTo("Phone number", Data[1]);
                QuerySnapshot snap2 = await Qref.GetSnapshotAsync();

                if (snap2.Count > 0)
                {
                    return "DBreader_3";
                    //errorCode = "DBreader_3";
                }

                Qref = usersColl.WhereEqualTo("Email", Data[2]);
                snap2 = await Qref.GetSnapshotAsync();
                if (snap2.Count > 0)
                {
                    return "DBreader_4";
                    //errorCode = "DBreader_4";
                }
            }
            return "DBreader_0";
        }

        private async Task<String> createUserOnDatabase(String username, String password, String phonenum, String email, String profileName, String sex, String dateOfBirth, String address, String avatar = "default", String story = "", String hobby = "")
        {
            // ERROR CODE:
            // DBadd_0: Add item to Database successful
            // DBadd_1: Add item to Database fail
            // ------

            database = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
            CollectionReference usersColl = database.Collection("Users");
            String[] Data = { username, phonenum, email };

            //String errorCode = checkValidDataInDatabase(Data).Result;
            Task<String> task = checkValidDataInDatabase(Data);
            String errorCode = await task;
            if (errorCode != "DBreader_0")
            {
                switch (errorCode)
                {
                    case "DBreader_1":
                        {
                            MessageBox.Show(errorCode + ": " + "Tên đăng nhập (Username) bạn nhập đã được sữ dụng");
                            break;
                        }
                    case "DBreader_3":
                        {
                            MessageBox.Show(errorCode + ": " + "Số điện thoại bạn nhập đã được sử dụng");
                            break;
                        }
                    case "DBreader_4":
                        {
                            MessageBox.Show(errorCode + ": " + "Email bạn nhập đã được sử dụng");
                            break;
                        }
                }
                return "DBadd_1";
            }
            else
            {
                Dictionary<String, Object> userInfo = new Dictionary<String, Object>();
                userInfo.Add("Username", username);
                userInfo.Add("Password", password);
                userInfo.Add("Phone number", phonenum);
                userInfo.Add("Email", email);
                userInfo.Add("Profile name", profileName);
                userInfo.Add("Sex", sex);
                userInfo.Add("Date of Birth", dateOfBirth);
                userInfo.Add("Address", address);
                userInfo.Add("Avatar profile", avatar);
                userInfo.Add("Story", story);
                userInfo.Add("Hobby", hobby);
                await usersColl.Document(username).SetAsync(userInfo);
                MessageBox.Show("Tạo tài khoản thành công");
            }
            return "DBadd_0";
        }

        private async void finishBtt_Click(object sender, EventArgs e)
        {
            if (checkDataFieldValidSignUpPanel2())
            {
                // Upload default Icon on Google Cloud Storage
                var storage = StorageClient.Create();
                String pathFileOnCloud;
                String bucketName = (new firebaseStorage()).getBucketName("firebaseStorage.json");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                String pathAvaDefault = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"res\logoImg\", "accountIcon.png");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                String destination = "Image storage/" + userNameBoxRegister.Text + "/" + "Avatar/" + "default";
                String contentType = "image/" + Path.GetExtension(pathAvaDefault).Split('.')[1];
                using var fileStream = File.OpenRead(pathAvaDefault);
                Task task_2 = storage.UploadObjectAsync(bucketName, destination, contentType, fileStream);
                await task_2;
                pathFileOnCloud = destination;
                // Upload default Icon on Google Cloud Storage

                String username_tmp = userNameBoxRegister.Text;
                String password_tmp = passwordBoxRegister.Text;
                String phonenum_tmp = phoneNumberBoxRegister.Text;
                String email_tmp = emailAddressBoxRegister.Text;
                String profileName_tmp = profileNameBox.Text;
                String sex_tmp = "";
                String dateOfBirth_tmp = dayBox.Text + "-" + monthBoxCombo.Text + "-" + yearBox.Text;
                String address_tmp = communeBox.Text + "_" + townBox.Text + "_" + provinceBox.Text + "_" + "Việt Nam";
                String avatar_tmp = destination;
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

                Task<String> task = createUserOnDatabase(username_tmp, password_tmp, phonenum_tmp, email_tmp, profileName_tmp, sex_tmp, dateOfBirth_tmp, address_tmp, avatar_tmp, story_tmp, hobby_tmp);
                String errorCode = await task;
                if (errorCode == "DBadd_0")
                {
                    userNameBoxRegister.Text = "";
                    passwordBoxRegister.Text = "";
                    phoneNumberBoxRegister.Text = "";
                    emailAddressBoxRegister.Text = "";
                    profileNameBox.Text = "";
                    maleGender.Checked = true;
                    dayBox.Text = ""; monthBoxCombo.Text = ""; yearBox.Text = "";
                    communeBox.Text = ""; townBox.Text = ""; provinceBox.Text = "";

                    signUpPanel2.Visible = false;
                    emailOrUserNameBox.Text = username_tmp;
                    passwordBox.Text = password_tmp;
                    loginAnnouncement.Visible = true;
                }

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
