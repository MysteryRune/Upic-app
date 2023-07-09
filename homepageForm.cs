﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using static Google.Api.ResourceDescriptor.Types;

namespace Upic
{
    public partial class homepageForm : Form
    {

        public static homepageForm? homePageInstance;
        private String username;
        FirestoreDb database;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public homepageForm()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            homePageInstance = this;

            InitializeComponent();
            connectFirestoreDatabase();
            flp_newfeeds.BackColor = Color.White;
            loginForm form = new loginForm();
            form.Show();
        }

        private void connectFirestoreDatabase()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
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

        }

        private void pb_mess_Click(object sender, EventArgs e)
        {
            changeStateToShapeLine();
            pb_mess.Image = global::Upic.Properties.Resources.mess_fill;
        }

        private void pb_noti_Click(object sender, EventArgs e)
        {
            changeStateToShapeLine();
            pb_noti.Image = global::Upic.Properties.Resources.noti_fill;
        }

        private void changeStateToShapeLine()
        {
            pb_noti.Image = global::Upic.Properties.Resources.notificationIcon1;
            pb_mess.Image = global::Upic.Properties.Resources.mess_shape_line;
            pb_friends.Image = global::Upic.Properties.Resources.friends_shape_line;
        }

        private void pb_friends_Click(object sender, EventArgs e)
        {
            //changeStateToShapeLine();
            //pb_friends.Image = global::Upic.Properties.Resources.friends_fill;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homePageInstance.Visible = false;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homePageInstance.ShowInTaskbar = false;

            Form form = new friendsForm();
            form.Show();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_bg_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void tb_caption_Click(object sender, EventArgs e)
        {
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
            cbb_post_privacy.Text = null;
            tb_status.Text = null;
            panel_create_post.Controls.Remove(panel_create_post.Controls["panel_listImage"]);
            panel_create_post.Controls.Remove(panel_create_post.Controls["btn_accept_post"]);
            panel_create_post.Controls.Remove(panel_create_post.Controls["panel_paddingBottomPanelCreatePost"]);
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
            }

            showListImageBeforeUpload(path);
        }

        private void pb_chooseImageFromDevice_Click(object sender, EventArgs e)
        {
            btn_chooseImageFromDevice_Click(sender, e);
        }

        private void btn_closepanel_listImageSeeMore_ForCreatePost_CLick(object sender, EventArgs e)
        {
            Controls.Remove(Controls["panel_listImageSeeMore_ForCreatePost"]);
        }

        private void createListPictureBoxSeeMore_ForCreatePost(String[] pathFiles)
        {
            Panel panel = new Panel();
            panel.Name = "panel_listImageSeeMore_ForCreatePost";
            panel.Size = new Size(1080, 810);
            panel.Location = new Point(260, 90);
            panel.AutoScroll = false;
            panel.VerticalScroll.Maximum = 0;
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = true;
            panel.Visible = true;
            Controls.Add(panel);
            panel.BringToFront();

            Button btn = new Button();
            btn.Name = "btn_closepanel_listImageSeeMore_ForCreatePost";
            btn.Size = new Size(50, 50);
            btn.Location = new Point(1010, 20);
            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackgroundImage = Properties.Resources.exit_fill;
            btn.Cursor = Cursors.Hand;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            btn.Click += btn_closepanel_listImageSeeMore_ForCreatePost_CLick;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            panel.Controls.Add(btn);

            int count = 1;
            Point newLoctionpb = new Point(60, 120);
            foreach (String path in pathFiles)
            {
                PictureBox pb = new PictureBox();
                pb.Name = "pb_image" + count.ToString();
                pb.Location = newLoctionpb;
                pb.Size = new Size(960, 540);
                pb.BackColor = Color.FromArgb(204, 0, 0, 0);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.BorderStyle = BorderStyle.None;
                pb.Image = Image.FromFile(path);
                panel.Controls.Add(pb);

                count++;
                newLoctionpb.Y += 540 + 50;
            }
        }

        private void lbl_seeMorePicture_CLick(object sender, EventArgs e, String[] pathFiles)
        {
            createListPictureBoxSeeMore_ForCreatePost(pathFiles);
        }

        private Panel createListPictureBoxLayout0_ForCreatePost(String[] pathFiles)
        {
            // Layout: None style
            // Amount picture must > 0
            int amountPicture = pathFiles.Length;
            Panel panel = new Panel();
            panel.Name = "panel_listImage";
            panel.BackColor = ColorTranslator.FromHtml("#f6f6f6");
            panel.Location = new Point(45, 360);
            panel.Size = new Size(860, 860);
            panel.BorderStyle = BorderStyle.None;

            switch (amountPicture)
            {
                case 1:
                    {
                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1";
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(820, 820);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        panel.Controls.Add(pb);
                        break;
                    }
                case 2:
                    {
                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1";
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(400, 820);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2";
                        pb.Location = new Point(440, 20);
                        pb.Size = new Size(400, 820);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        panel.Controls.Add(pb);
                        break;
                    }
                case 3:
                    {
                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1";
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(400, 820);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2";
                        pb.Location = new Point(440, 20);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image3";
                        pb.Location = new Point(440, 440);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        panel.Controls.Add(pb);
                        break;
                    }
                default:
                    {
                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1";
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2";
                        pb.Location = new Point(440, 20);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image3";
                        pb.Location = new Point(20, 440);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image4";
                        pb.Location = new Point(440, 440);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        panel.Controls.Add(pb);

                        if (amountPicture > 4)
                        {
                            Label lbl = new Label();
                            lbl.Name = "lbl_seeMorePicture";
                            lbl.Location = new Point(0, 0);
                            lbl.Size = new Size(400, 400);
                            lbl.Parent = pb;
                            lbl.BackColor = Color.FromArgb(102, 0, 0, 0); //Color.Transparent;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            lbl.Font = new Font("Be Vietnam Pro Black", 40F, FontStyle.Bold, GraphicsUnit.Point);
                            lbl.ForeColor = ColorTranslator.FromHtml("#ffffff");
                            lbl.Text = "+" + (amountPicture - 3).ToString();
#pragma warning disable CS8604 // Possible null reference argument.
                            lbl.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles);
                            lbl.Cursor = Cursors.Hand;
#pragma warning restore CS8604 // Possible null reference argument.
                            pb.Controls.Add(lbl);
                        }
                        break;
                    }
            }
            return panel;
        }

        private async Task btn_accept_post_Click(object sender, EventArgs e, String[] pathFile, String postStatus, int layoutMode)
        {
            DateTime dateNow = DateTime.Now;
            String dateUpload = dateNow.ToString("dd'-'MM'-'yyyy'_'HH':'mm':'ss");
            String postID = dateUpload + "_" + username;
            String[] tmp = { };
            Dictionary<String, Object> tmp2 = new Dictionary<String, Object>();
            List<String> imgNameFile = new List<string>();
            int visibleMode;
            int count = 1;
            database = FirestoreDb.Create("social-app-c-sharp-programming");
            CollectionReference postColl = database.Collection("Post");
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

            foreach (String file in pathFile)
            {
                imgNameFile.Add(postID + "_" + count.ToString());
                count++;
            }

            postDetail.Add("Post status", postStatus);
            postDetail.Add("Post image", imgNameFile);
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
                MessageBox.Show("Đăng bài thành công", "Thông báo");
                btn_exit_post_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Lỗi khi đăng tải! Vui lòng thử lại", "Thông báo");
            }
        }

        private void showListImageBeforeUpload(String[] pathFile)
        {
            if (pathFile.Length > 0)
            {
                pb_chooseImageFromDevice.Visible = false;
                btn_chooseImageFromDevice.Visible = false;

                panel_create_post.Controls.Add(createListPictureBoxLayout0_ForCreatePost(pathFile));

                int count = 1;
                foreach (String path in pathFile)
                {
                    if (count > 4)
                    {

                        break;
                    }
                    Image loadedImage = Image.FromFile(path);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    Control panel_listImage = panel_create_post.Controls["panel_listImage"];
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    Control pb = (PictureBox)panel_listImage.Controls["pb_image" + count.ToString()] as PictureBox;
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
                btn_accept_post.Location = new Point(765, 1240);
                btn_accept_post.Name = "btn_accept_post";
                btn_accept_post.Size = new Size(140, 45);
                btn_accept_post.TabIndex = 12;
                btn_accept_post.TextAlign = ContentAlignment.MiddleCenter;
                btn_accept_post.Text = "Đăng bài";
                btn_accept_post.UseVisualStyleBackColor = false;
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                btn_accept_post.Click += (sender, EventArgs) => btn_accept_post_Click(sender, EventArgs, pathFile, tb_status.Text, 0);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
#pragma warning restore CS8604 // Possible null reference argument.
                panel_create_post.Controls.Add(btn_accept_post);

                Label panel_paddingBottomPanelCreatePost = new Label();
                panel_paddingBottomPanelCreatePost.Name = "panel_paddingBottomPanelCreatePost";
                panel_paddingBottomPanelCreatePost.Size = new Size(930, 20);
                panel_paddingBottomPanelCreatePost.Location = new Point(10, 1285);
                panel_paddingBottomPanelCreatePost.BackColor = Color.Transparent;
                panel_create_post.Controls.Add(panel_paddingBottomPanelCreatePost);
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            tb_caption_Click(sender, e);
        }
    }


}
