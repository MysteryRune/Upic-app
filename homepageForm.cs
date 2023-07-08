using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text.Json;

using Upic.myMethods.firebaseFunctionCustom;
using Upic.myMethods.visualizeCustom;

using Google.Cloud.Firestore;
using Google.Cloud.Storage;
using Google.Cloud.Storage.V1;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using Google.Apis.Upload;
using Google.Apis.Util;

namespace Upic
{
    public partial class homepageForm : Form
    {

        public static homepageForm? homePageInstance;
        private String username;
        FirestoreDb database;
        String[] pathFiles;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public homepageForm()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            homePageInstance = this;

            InitializeComponent();
            (new firestoreDatabase()).connectToDatabase("firestore.json");
            flp_newfeeds.BackColor = Color.White;
            loginForm form = new loginForm();
            form.Show();
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        private void homepageForm_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;

            panel_create_post.AutoScroll = false;
            panel_create_post.VerticalScroll.Maximum = 0;
            panel_create_post.HorizontalScroll.Maximum = 0;
            panel_create_post.AutoScroll = true;

            flp_newfeeds.AutoScroll = false;
            flp_newfeeds.VerticalScroll.Maximum = 0;
            flp_newfeeds.HorizontalScroll.Maximum = 0;
            flp_newfeeds.AutoScroll = true;

            loadAllPostFromDatabaseForUserCanVisibleAsync();
        }

        private async void loadAllPostFromDatabaseForUserCanVisibleAsync()
        {
            database = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
            CollectionReference collRef = database.Collection("Posts");
            QuerySnapshot snapshot = await collRef.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                FlowLayoutPanel flp = await (new postShowHomePage()).createFlowLayoutPanelIncludePost(document.Id);
                flp_newfeeds.Controls.Add(flp);
            }
        }

        private void pb_logo_UPIC_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pb_friends_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homePageInstance.Visible = false;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homePageInstance.ShowInTaskbar = false;

            Form form = new friendsForm();
            form.Show();
        }

        private void pb_mess_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homePageInstance.Visible = false;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homePageInstance.ShowInTaskbar = false;

            Form form = new messagesForm();
            form.Show();
        }

        private void pb_noti_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homePageInstance.Visible = false;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homePageInstance.ShowInTaskbar = false;

            Form form = new notificationsForm();
            form.Show();
        }

        private void pb_user1_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homePageInstance.Visible = false;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homePageInstance.ShowInTaskbar = false;

            Form form = new userProfileForm();
            form.Show();
        }

        private void panel_bg_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private async void tb_caption_Click(object sender, EventArgs e)
        {
            database = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
            CollectionReference collRef = database.Collection("Users");
            DocumentReference docRef = collRef.Document(username);
            DocumentSnapshot snap = await docRef.GetSnapshotAsync();
            Dictionary<String, Object> userInfo = snap.ToDictionary();
            lbl_username.Text = userInfo["Profile name"].ToString();

            cbb_post_privacy.DropDownStyle = ComboBoxStyle.DropDownList;

            panel_before_post.Visible = false;
            panel_create_post.Visible = true;
            //flp_newfeeds.Visible = false;
            panel_create_post.BringToFront();
        }

        private void pb_image_Click(object sender, EventArgs e)
        {
            panel_before_post.Visible = false;
            panel_create_post.Visible = true;
            //flp_newfeeds.Visible = false;
            panel_create_post.BringToFront();
        }

        private void lbl_image_Click(object sender, EventArgs e)
        {
            panel_before_post.Visible = false;
            panel_create_post.Visible = true;
            //flp_newfeeds.Visible = false;
            panel_create_post.BringToFront();
        }

        private void resetCreatePostState()
        {
            ActiveControl = null;
            cbb_post_privacy.Text = "Công khai";
            tb_status.Text = null;
            panel_create_post.Controls.Remove(panel_create_post.Controls["panel_listImage_tmp"]);
            panel_create_post.Controls.Remove(panel_create_post.Controls["btn_accept_post"]);
            panel_create_post.Controls.Remove(panel_create_post.Controls["panel_paddingBottomPanelCreatePost"]);
            flp_groupLayoutModeBtn.Visible = false;
            pb_chooseImageFromDevice.Visible = true;
            btn_chooseImageFromDevice.Visible = true;
        }

        private void btn_exit_post_Click(object sender, EventArgs e)
        {
            resetCreatePostState();
            panel_create_post.Visible = false;
            panel_before_post.Visible = true;
            flp_newfeeds.Visible = true;
            flp_newfeeds.BringToFront();
        }

        private void tb_status_TextChanged(object sender, EventArgs e)
        {
            tb_status.ScrollBars = ScrollBars.Vertical;
        }

        private void btn_chooseImageFromDevice_Click(object sender, EventArgs e)
        {
            String[] path = { };

            //Declare the File Dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Image files (*.bmp, *.tif, *.tiff, *.jpg, *.jpeg, *.gif, *.png, *.eps, *.raw, *.cr2, *.nef, *.orf, *.sr2)|*.bmp; *.tif; *.tiff; *.jpg; *.jpeg; *.gif; *.png; *.eps; *.raw; *.cr2; *.nef; *.orf; *.sr2";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileNames;
                pathFiles = path;
            }
            showListImageBeforeUpload(path, 0);
            if (path.Length > 1)
            {
                flp_groupLayoutModeBtn.Visible = true;
            }
        }

        private void pb_chooseImageFromDevice_Click(object sender, EventArgs e)
        {
            btn_chooseImageFromDevice_Click(sender, e);
        }

        private async Task<List<String>> storeImage2FirebaseStorage(String postID, String[] pathFile)
        {
            var storage = StorageClient.Create();
            String bucketName = (new firebaseStorage()).getBucketName("firebaseStorage.json");
            List<String> pathFilesOnCLoud = new List<String>();

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
            foreach (int i in Enumerable.Range(0, pathFile.Length))
            {
                String destination = "Image storage/" + username + "/" + "Image/" + postID + "_" + (i + 1).ToString();
                String contentType = "image/" + Path.GetExtension(pathFile[i]).Split('.')[1];
                using var fileStream = File.OpenRead(pathFile[i]);

                Task task = storage.UploadObjectAsync(bucketName, destination, contentType, fileStream);
                await task;
                pathFilesOnCLoud.Add(destination);
            }
            formAnnouncement.Close();
            this.Visible = true;

            return pathFilesOnCLoud;
        }

        private async Task btn_accept_post_Click(object sender, EventArgs e, String[] pathFile, String postStatus, int layoutMode)
        {
            DateTime dateNow = DateTime.Now;
            String dateUpload = dateNow.ToString("dd'-'MM'-'yyyy'_'HH':'mm':'ss");
            String postID = dateUpload + "_" + username;
            String[] tmp = { };
            Dictionary<String, Object> tmp2 = new Dictionary<String, Object>();
            List<String> pathFilesOnCloud = new List<string>();
            int visibleMode;
            database = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
            CollectionReference postColl = database.Collection("Posts");
            Dictionary<String, Object> postDetail = new Dictionary<String, Object>();

            switch (cbb_post_privacy.Text)
            {
                case "Công khai":
                    {
                        visibleMode = 0; // Công khai
                        break;
                    }
                case "Bạn bè":
                    {
                        visibleMode = 1; // Bạn bè
                        break;
                    }
                case "Chỉ mình tôi":
                    {
                        visibleMode = -1; // Chỉ mình tôi
                        break;
                    }
                default:
                    {
                        visibleMode = 0; // Công khai
                        break;
                    }
            }

            pathFilesOnCloud = await storeImage2FirebaseStorage(postID, pathFile);
            postDetail.Add("Post status", postStatus);
            postDetail.Add("Post image", pathFilesOnCloud);
            postDetail.Add("Date upload", dateUpload);
            postDetail.Add("Layout mode", layoutMode);
            postDetail.Add("Visible mode", visibleMode);
            postDetail.Add("Visible list", tmp);
            postDetail.Add("Like list", tmp);
            postDetail.Add("Comment list", tmp2);
            Task task = postColl.Document(postID).SetAsync(postDetail);
            await task;
            if (task.IsCompleted)
            {
                MessageBox.Show("Đăng bài viết thành công", "Thông báo");
                btn_exit_post_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Lỗi khi đăng tải! Vui lòng thử lại", "Thông báo");
            }
        }

        private void showListImageBeforeUpload(String[] pathFile, int layoutMode)
        {
            if (pathFile.Length > 0)
            {
                pb_chooseImageFromDevice.Visible = false;
                btn_chooseImageFromDevice.Visible = false;

                Panel panelListImage;
                switch (layoutMode)
                {
                    case 1:
                        {
                            panelListImage = (new layoutPost()).createLayoutMode1Post(pathFile, this, "tmp");
                            break;
                        }
                    case 2:
                        {
                            panelListImage = (new layoutPost()).createLayoutMode2Post(pathFile, this, "tmp");
                            if (panelListImage == null)
                            {
                                panelListImage = (new layoutPost()).createLayoutMode0Post(pathFile, this, "tmp");
                            }
                            break;
                        }
                    default:
                        {
                            panelListImage = (new layoutPost()).createLayoutMode0Post(pathFile, this, "tmp");
                            break;
                        }
                }
                panelListImage.Location = new Point((panel_create_post.Width - panelListImage.Width) / 2, 360);
                //panel_create_post.Controls.Add(createListPictureBoxLayout0_ForCreatePost(pathFile));
                panel_create_post.Controls.Add(panelListImage);

                int count = 1;
                foreach (String path in pathFile)
                {
                    if (count > 4)
                    {

                        break;
                    }
                    System.Drawing.Image loadedImage = System.Drawing.Image.FromFile(path);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    Control panel_listImage = panel_create_post.Controls["panel_listImage_tmp"];
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    Control pb = (PictureBox)panel_listImage.Controls["pb_image" + count.ToString() + "_tmp"] as PictureBox;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    (pb as PictureBox).Image = loadedImage;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    count++;
                }

                Button btn_accept_post = new Button();
                btn_accept_post.BackColor = Color.FromArgb(52, 152, 219);
                btn_accept_post.FlatAppearance.BorderColor = Color.White;
                btn_accept_post.FlatStyle = FlatStyle.Flat;
                btn_accept_post.Font = new Font("Be Vietnam Pro ExtraBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
                btn_accept_post.ForeColor = Color.White;
                btn_accept_post.Location = new Point(765, 360 + panelListImage.Height + 20);
                btn_accept_post.Name = "btn_accept_post";
                btn_accept_post.Size = new Size(140, 45);
                btn_accept_post.TabIndex = 12;
                btn_accept_post.TextAlign = ContentAlignment.MiddleCenter;
                btn_accept_post.Text = "Đăng bài";
                btn_accept_post.UseVisualStyleBackColor = false;
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                btn_accept_post.Click += (sender, EventArgs) => btn_accept_post_Click(sender, EventArgs, pathFile, tb_status.Text, layoutMode);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
#pragma warning restore CS8604 // Possible null reference argument.
                panel_create_post.Controls.Add(btn_accept_post);

                Label panel_paddingBottomPanelCreatePost = new Label();
                panel_paddingBottomPanelCreatePost.Name = "panel_paddingBottomPanelCreatePost";
                panel_paddingBottomPanelCreatePost.Size = new Size(930, 20);
                panel_paddingBottomPanelCreatePost.Location = new Point(10, btn_accept_post.Location.Y + 20 + 25);
                panel_paddingBottomPanelCreatePost.BackColor = Color.Transparent;
                panel_create_post.Controls.Add(panel_paddingBottomPanelCreatePost);
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            tb_caption_Click(sender, e);
        }

        private void btn_noneLayout_Click(object sender, EventArgs e)
        {
            panel_create_post.Controls.Remove(panel_create_post.Controls["panel_listImage_tmp"]);
            panel_create_post.Controls.Remove(panel_create_post.Controls["btn_accept_post"]);
            panel_create_post.Controls.Remove(panel_create_post.Controls["panel_paddingBottomPanelCreatePost"]);
            showListImageBeforeUpload(pathFiles, 0);
        }

        private void btn_columnLayout_Click(object sender, EventArgs e)
        {
            panel_create_post.Controls.Remove(panel_create_post.Controls["panel_listImage_tmp"]);
            panel_create_post.Controls.Remove(panel_create_post.Controls["btn_accept_post"]);
            panel_create_post.Controls.Remove(panel_create_post.Controls["panel_paddingBottomPanelCreatePost"]);
            showListImageBeforeUpload(pathFiles, 1);
        }

        private void btn_bannerLayout_Click(object sender, EventArgs e)
        {
            panel_create_post.Controls.Remove(panel_create_post.Controls["panel_listImage_tmp"]);
            panel_create_post.Controls.Remove(panel_create_post.Controls["btn_accept_post"]);
            panel_create_post.Controls.Remove(panel_create_post.Controls["panel_paddingBottomPanelCreatePost"]);
            showListImageBeforeUpload(pathFiles, 2);
        }
    }


}
