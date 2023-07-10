using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Upic.myMethods.firebaseFunctionCustom;
using System.Windows.Media.Imaging;

namespace Upic
{
    public partial class editProfileUC : UserControl
    {
        FirestoreDb database;
        String username;

        public editProfileUC()
        {
            InitializeComponent();
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        private void btn_update_info_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_edit_info.Visible = true;
            //gán giá trị hiện tại của thông tin cá nhân vào các điều khiển chỉnh sửa
            tb_edit_name.Text = lbl_user_name.Text;
            cbb_sex.SelectedItem = lbl_user_sex.Text;
            tb_edit_day.Text = lbl_user_day.Text;
            tb_edit_month.Text = lbl_user_month.Text;
            tb_edit_year.Text = lbl_user_year.Text;
            tb_edit_address.Text = lbl_user_address.Text;
            tb_edit_story.Text = lbl_storyContent.Text;
            tb_edit_hobby.Text = lbl_hobbyContent.Text;
            btn_update_info.Visible = false;
            btn_save_profile.Visible = true;
        }

        private async void editProfileUC_Load(object sender, EventArgs e)
        {
            //InitializeControls();
            btn_update_info.Click += btn_update_info_Click;
            btn_save_profile.Click += btn_save_profile_Click;

            FirestoreDb database2 = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
            CollectionReference postColl2 = database2.Collection("Users");
            DocumentReference docRef2 = postColl2.Document(username);
            DocumentSnapshot docSnap2 = await docRef2.GetSnapshotAsync();
            Dictionary<String, Object> userInfo = docSnap2.ToDictionary();

            StorageClient storage = StorageClient.Create();
            String bucketName = (new firebaseStorage()).getBucketName("firebaseStorage.json");

            var obj = storage.GetObject(bucketName, userInfo["Avatar profile"].ToString());
            String pathFolderTemp = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"temp/personal");
            String nameTempFile = "avatar_" + username + "." + obj.ContentType.ToString().Split("/")[1];
            var fileStream = File.OpenRead(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"temp/forInit.txt"));
            if (!File.Exists(pathFolderTemp + "/" + nameTempFile))
            {
                fileStream = File.Create(pathFolderTemp + "/" + nameTempFile);
                await storage.DownloadObjectAsync(bucketName, userInfo["Avatar profile"].ToString(), fileStream);
            }
            else
            {
                fileStream = File.OpenRead(pathFolderTemp + "/" + nameTempFile);
            }
            String path_tmpFile = Path.GetFullPath(fileStream.Name);


            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.StreamSource = fileStream;
            image.EndInit();
            pb_profile_user_avatar.Image = Image.FromStream(fileStream);
            fileStream.Close();
            File.Delete(fileStream.Name);

            lbl_user_name.Text = userInfo["Profile name"].ToString();
            lbl_user_sex.Text = userInfo["Sex"].ToString();
            lbl_user_day.Text = userInfo["Date of Birth"].ToString().Split("-")[0];
            lbl_user_month.Text = userInfo["Date of Birth"].ToString().Split("-")[1];
            lbl_user_year.Text = userInfo["Date of Birth"].ToString().Split("-")[2];
            lbl_user_address.Text = userInfo["Address"].ToString();
            lbl_storyContent.Text = userInfo["Story"].ToString();
            lbl_hobbyContent.Text = userInfo["Hobby"].ToString();
        }

        private async void btn_save_profile_Click(object sender, EventArgs e)
        {
            FirestoreDb database2 = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
            CollectionReference postColl2 = database2.Collection("Users");
            DocumentReference docRef2 = postColl2.Document(username);
            DocumentSnapshot docSnap2 = await docRef2.GetSnapshotAsync();
            Dictionary<String, Object> userInfo = new Dictionary<String, Object>();



            // Cập nhật thông tin cá nhân từ các chỉnh sửa
            lbl_user_name.Text = tb_edit_name.Text; userInfo.Add("Profile name", tb_edit_name.Text);
            lbl_sex.Text = cbb_sex.SelectedItem.ToString(); userInfo.Add("Sex", cbb_sex.Text);
            lbl_user_day.Text = (tb_edit_day).Text;
            lbl_user_month.Text = (tb_edit_month.Text).ToString();
            lbl_user_year.Text = (tb_edit_year.Text).ToString(); userInfo.Add("Date of Birth", (tb_edit_day).Text + '-' + (tb_edit_month.Text).ToString() + '-' + (tb_edit_year.Text).ToString());
            lbl_user_address.Text = tb_edit_address.Text.ToString(); userInfo.Add("Address", tb_edit_address.Text.ToString());
            lbl_storyContent.Text = tb_edit_story.Text; userInfo.Add("Story", tb_edit_story.Text);
            lbl_hobbyContent.Text = tb_edit_hobby.Text; userInfo.Add("Hobby", tb_edit_hobby.Text);

            if (docSnap2.Exists)
            {
                await docRef2.UpdateAsync(userInfo);
            }
            panel_edit_info.Visible = false;
            panel_info.Visible = true;
            btn_update_info.Visible = true;
            btn_save_profile.Visible = false;
            this.Visible = false;
        }

        private async void btn_edit_avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg)|*.jpg;*.png;*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String pathFile = openFileDialog.FileName;
                String FileName = pathFile.Split("/")[pathFile.Split("/").Length - 1];

                var fileStream = File.OpenRead(pathFile);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = fileStream;
                image.EndInit();
                pb_profile_user_avatar.Image = Image.FromStream(fileStream);
                fileStream.Close();
                File.Delete(fileStream.Name);

                Form formAnnouncement = new Form();
                formAnnouncement.FormBorderStyle = FormBorderStyle.FixedDialog;
                formAnnouncement.ControlBox = false;
                formAnnouncement.Size = new Size(200, 200);
                formAnnouncement.StartPosition = FormStartPosition.CenterScreen;
                formAnnouncement.BackColor = Color.White;
                formAnnouncement.Visible = false;
                Label lbl = new Label();
                lbl.Text = "Đang xử lý";
                lbl.Font = new Font("Be Vietnam Pro ExtraBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.BackColor = Color.Transparent;
                lbl.AutoSize = false;
                lbl.Size = new Size(150, 150);
                lbl.Location = new Point(25, 25);
                formAnnouncement.Controls.Add(lbl);

                formAnnouncement.Visible = true;
                this.Visible = false;

                var storage = StorageClient.Create();
                String bucketName = (new firebaseStorage()).getBucketName("firebaseStorage.json");
                String destination = "Image storage/" + username + "/" + "Avatar/" + username;
                String contentType = "image/" + Path.GetExtension(pathFile).Split('.')[1];
                fileStream = System.IO.File.OpenRead(pathFile);
                Task task = storage.UploadObjectAsync(bucketName, destination, contentType, fileStream);
                await task;
                FirestoreDb database2 = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
                CollectionReference postColl2 = database2.Collection("Users");
                DocumentReference docRef2 = postColl2.Document(username);
                DocumentSnapshot docSnap2 = await docRef2.GetSnapshotAsync();
                Dictionary<String, Object> userInfo = new Dictionary<String, Object>();
                // Cập nhật đường dẫn đến ảnh Avatar
                userInfo.Add("Avatar profile", destination);
                if (docSnap2.Exists)
                {
                    await docRef2.UpdateAsync(userInfo);
                }

                formAnnouncement.Close();
                formAnnouncement.Dispose();
                this.Visible = true;
                fileStream.Close();
            }
        }
    }
}
