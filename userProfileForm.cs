using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Upic.myMethods.firebaseFunctionCustom;
using System.Windows.Media.Imaging;

namespace Upic
{
    public partial class userProfileForm : Form
    {
        FirestoreDb database;
        String username;

        public userProfileForm()
        {
            InitializeComponent();
            editProfileuc1.VerticalScroll.Maximum = 0;
            editProfileuc1.HorizontalScroll.Maximum = 0;
            flp_profile_and_posts.VerticalScroll.Maximum = 0;
            flp_profile_and_posts.HorizontalScroll.Maximum = 0;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        private void panel_bg_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void pb_logo_UPIC_Click(object sender, EventArgs e)
        {
            Close();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.Visible = true;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.ShowInTaskbar = true;
        }

        private void pb_friends_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new friendsForm();
            form.Show();
        }

        private void pb_mess_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new messagesForm();
            form.Show();
        }

        private void pb_noti_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new notificationsForm();
            form.Show();
        }

        private void pb_user1_Click(object sender, EventArgs e)
        {
            Close();
            userProfileForm tmp = new userProfileForm();
            tmp.setUsername(username);
            tmp.Show();
        }

        private void btn_edit_profile_Click(object sender, EventArgs e)
        {
            editProfileuc1.setUsername(username);
            flp_profile_and_posts.Visible = false;
            panel_profile_and_posts.Visible = false;
            editProfileuc1.Visible = true;
        }

        private async void userProfileForm_Load(object sender, EventArgs e)
        {
            panel_profile_and_posts.Visible = true;
            flp_profile_and_posts.Visible = true;

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
            var fileStream = File.Create(pathFolderTemp + "/" + nameTempFile);
            await storage.DownloadObjectAsync(bucketName, userInfo["Avatar profile"].ToString(), fileStream);
            String path_tmpFile = Path.GetFullPath(fileStream.Name);


            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.StreamSource = fileStream;
            image.EndInit();
            pb_profile_user_avatar.Image = Image.FromStream(fileStream);
            fileStream.Close();
            File.Delete(path_tmpFile);

            lbl_profile_name.Text = userInfo["Profile name"].ToString();
            lbl_profile_username.Text = '@' + userInfo["Username"].ToString();
        }

        private void editProfileuc1_VisibleChanged(object sender, EventArgs e)
        {
            if (editProfileuc1.Visible == false)
            {
                userProfileForm_Load(sender, e);
            }
        }
    }
}
