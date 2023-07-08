using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Google.Cloud.Storage.V1;
using Google.Cloud.Firestore;

using Upic.myMethods.firebaseFunctionCustom;
using System.Globalization;

namespace Upic.myMethods.visualizeCustom
{
    class visualizeCustom
    {
        public ProgressBar createProgressBar(String nameProgressBar)
        {
            var pBar = new ProgressBar();
            pBar.Name = nameProgressBar;
            pBar.Width = 150;
            pBar.Height = 20;
            pBar.Maximum = 100;
            pBar.Minimum = 0;
            pBar.Style = ProgressBarStyle.Continuous;
            pBar.Step = 1;
            pBar.Value = 0;
            return pBar;
        }

        public void setValueProgressBar(ProgressBar pBar, int percent)
        {
            pBar.Value = percent;
        }

        public Panel createProgressPanelUploading(String namePanel)
        {
            Panel pPanel = new Panel();
            pPanel.VerticalScroll.Maximum = 0;
            pPanel.HorizontalScroll.Maximum = 0;
            pPanel.AutoScroll = true;
            pPanel.Size = new System.Drawing.Size(200, 200);
            pPanel.Name = namePanel;
            pPanel.BackColor = Color.White;

            Label label = new Label();
            label.Name = "Uploading_label";
            label.Text = "Uploading Image";
            label.Font = new Font("Be Vietnam Pro Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.Black;
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BackColor = Color.Transparent;
            label.Location = new Point(20, 20);

            pPanel.Controls.Add(label);

            return pPanel;
        }

        public Label createLabelAnnouncementProgressBar(String nameLabel, String text)
        {
            Label label = new Label();
            label.Name = nameLabel;
            label.Text = text;
            label.Font = new Font("Be Vietnam Pro", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = Color.Black;
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BackColor = Color.Transparent;

            return label;
        }
      //  public Task UploadPicturesAsync(List<Image> imageList, IProgress<int[]> progress)
      //  {
      //      int totalCount = imageList.Count;
      //      var progressCount = Enumerable.Repeat(0, totalCount).ToArray();
      //      return Task.WhenAll(imageList.map((image, index) =>
      //        UploadAndProcessAsync(image, (percent) => {
      //            progressCount[index] = percent;
      //            progress?.Report(progressCount);
      //        });              
      //));
      //  }

      //  private async void Start_Button_Click(object sender, RoutedEventArgs e)
      //  {
      //      int uploads = await UploadPicturesAsync(GenerateTestImages(),
      //          new Progress<int[]>(percents => ... do something...));
      //  }
    }

    class layoutPost
    {
        private void btn_closepanel_listImageSeeMore_ForCreatePost_CLick(object sender, EventArgs e, Form form, String idProperty)
        {
            form.Controls.Remove(form.Controls["panel_listImageSeeMore_ForCreatePost" + "_" + idProperty]);
        }

        private void createListPictureBoxSeeMore_ForCreatePost(String[] pathFiles, Form form, String idProperty)
        {
            Panel panel = new Panel();
            panel.Name = "panel_listImageSeeMore_ForCreatePost" + "_" + idProperty;
            panel.Size = new Size(1080, 810);
            panel.Location = new Point(260, 90);
            panel.AutoScroll = false;
            panel.VerticalScroll.Maximum = 0;
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = true;
            panel.Visible = true;
            form.Controls.Add(panel);
            panel.BringToFront();

            Button btn = new Button();
            btn.Name = "btn_closepanel_listImageSeeMore_ForCreatePost" + "_" + idProperty;
            btn.Size = new Size(50, 50);
            btn.Location = new Point(1010, 20);
            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackgroundImage = Properties.Resources.exit_fill;
            btn.Cursor = Cursors.Hand;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8604 // Possible null reference argument.
            btn.Click += (sender, e) => btn_closepanel_listImageSeeMore_ForCreatePost_CLick(sender, e, form, idProperty);
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            panel.Controls.Add(btn);

            int count = 1;
            Point newLoctionpb = new Point(60, 120);
            foreach (String path in pathFiles)
            {
                PictureBox pb = new PictureBox();
                pb.Name = "pb_image" + count.ToString() + "_" + idProperty;
                pb.Location = newLoctionpb;
                pb.Size = new Size(960, 540);
                pb.BackColor = Color.FromArgb(204, 0, 0, 0);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.BorderStyle = BorderStyle.None;
                pb.Image = System.Drawing.Image.FromFile(path);
                panel.Controls.Add(pb);

                count++;
                newLoctionpb.Y += 540 + 50;
            }
        }

        private void lbl_seeMorePicture_CLick(object sender, EventArgs e, String[] pathFiles, Form form, String idProperty)
        {
            createListPictureBoxSeeMore_ForCreatePost(pathFiles, form, idProperty);
        }

        public Panel createLayoutMode0Post(String[] pathFiles, Form form, String idProperty)
        {
            // Layout: None style
            // Amount picture must > 0
            int amountPicture = pathFiles.Length;
            Panel panel = new Panel();
            panel.Name = "panel_listImage" + "_" + idProperty;
            panel.BackColor = ColorTranslator.FromHtml("#f6f6f6");
            //panel.Location = new Point(45, 360);
            panel.Size = new Size(860, 860);
            panel.BorderStyle = BorderStyle.None;

            switch (amountPicture)
            {
                case 1:
                    {
                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(820, 820);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);
                        break;
                    }
                case 2:
                    {
                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(400, 820);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(440, 20);
                        pb.Size = new Size(400, 820);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);
                        break;
                    }
                case 3:
                    {
                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(400, 820);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(440, 20);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image3" + "_" + idProperty;
                        pb.Location = new Point(440, 440);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);
                        break;
                    }
                default:
                    {
                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(440, 20);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image3" + "_" + idProperty;
                        pb.Location = new Point(20, 440);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image4" + "_" + idProperty;
                        pb.Location = new Point(440, 440);
                        pb.Size = new Size(400, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        if (amountPicture > 4)
                        {
                            Label lbl = new Label();
                            lbl.Name = "lbl_seeMorePicture" + "_" + idProperty;
                            lbl.Location = new Point(0, 0);
                            lbl.Size = new Size(400, 400);
                            lbl.Parent = pb;
                            lbl.BackColor = Color.FromArgb(102, 0, 0, 0); //Color.Transparent;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            lbl.Font = new Font("Be Vietnam Pro Black", 40F, FontStyle.Bold, GraphicsUnit.Point);
                            lbl.ForeColor = ColorTranslator.FromHtml("#ffffff");
                            lbl.Text = "+" + (amountPicture - 3).ToString();
#pragma warning disable CS8604 // Possible null reference argument.
                            lbl.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                            lbl.Cursor = Cursors.Hand;
#pragma warning restore CS8604 // Possible null reference argument.
                            pb.Controls.Add(lbl);
                        }
                        break;
                    }
            }
            return panel;
        }

        public Panel createLayoutMode1Post(String[] pathFiles, Form form, String idProperty)
        {
            // Layout: Column style
            // Amount picture must > 1
            int amountPicture = pathFiles.Length;
            Panel panel = new Panel();
            panel.Name = "panel_listImage" + "_" + idProperty;
            panel.BackColor = ColorTranslator.FromHtml("#f6f6f6");
            //panel.Location = new Point(45, 360);
            panel.BorderStyle = BorderStyle.None;

            switch (amountPicture)
            {
                case 2:
                    {
                        panel.Size = new Size(860, 640);

                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(400, 600);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(20 + 400 + 20, 20);
                        pb.Size = new Size(400, 600);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);
                        break;
                    }
                case 3:
                    {
                        panel.Size = new Size(860, 640);

                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 10);
                        pb.Size = new Size(260, 560);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(20 + 260 + 20, 70);
                        pb.Size = new Size(260, 560);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image3" + "_" + idProperty;
                        pb.Location = new Point(20 + 260 + 20 + 260 + 20, 10);
                        pb.Size = new Size(260, 560);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);
                        break;
                    }
                default:
                    {
                        panel.Size = new Size(860, 640);

                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 10);
                        pb.Size = new Size(190, 560);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(20 + 190 + 20, 70);
                        pb.Size = new Size(190, 560);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image3" + "_" + idProperty;
                        pb.Location = new Point(20 + 190 + 20 + 190 + 20, 10);
                        pb.Size = new Size(190, 560);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image4" + "_" + idProperty;
                        pb.Location = new Point(20 + 190 + 20 + 190 + 20 + 190 + 20, 70);
                        pb.Size = new Size(190, 560);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        if (amountPicture > 4)
                        {
                            Label lbl = new Label();
                            lbl.Name = "lbl_seeMorePicture" + "_" + idProperty;
                            lbl.Location = new Point(0, 0);
                            lbl.Size = new Size(190, 560);
                            lbl.Parent = pb;
                            lbl.BackColor = Color.FromArgb(102, 0, 0, 0); //Color.Transparent;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            lbl.Font = new Font("Be Vietnam Pro Black", 40F, FontStyle.Bold, GraphicsUnit.Point);
                            lbl.ForeColor = ColorTranslator.FromHtml("#ffffff");
                            lbl.Text = "+" + (amountPicture - 3).ToString();
#pragma warning disable CS8604 // Possible null reference argument.
                            lbl.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                            lbl.Cursor = Cursors.Hand;
#pragma warning restore CS8604 // Possible null reference argument.
                            pb.Controls.Add(lbl);
                        }
                        break;
                    }
            }
            return panel;
        }

        public Panel createLayoutMode2Post(String[] pathFiles, Form form, String idProperty)
        {
            // Layout: Banner style
            // Amount picture must > 1
            // Caption text length < 256
            int amountPicture = pathFiles.Length;
            Panel panel = new Panel();
            panel.Name = "panel_listImage" + "_" + idProperty;
            //panel.BackColor = ColorTranslator.FromHtml("#f6f6f6");
            panel.BackColor = ColorTranslator.FromHtml("#f0f0f0");
            //panel.Location = new Point(45, 360);
            panel.BorderStyle = BorderStyle.None;

            TextBox oldCaptionPostStyle = (TextBox)form.Controls["panel_bg"].Controls["panel_create_post"].Controls["tb_status"];
            if (oldCaptionPostStyle.TextLength >= 100 || Regex.Split(oldCaptionPostStyle.Text, @"\r\n").ToList().Count > 1)
            {
                MessageBox.Show("Nội dung caption quá dài hoặc nhiều dòng, không thích hợp!");
                return null;
            }

            Label newCaptionPostStyle = new Label();
            newCaptionPostStyle.Font = new Font("Be Vietnam Pro", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            newCaptionPostStyle.Text = oldCaptionPostStyle.Text;
            newCaptionPostStyle.TextAlign = ContentAlignment.MiddleCenter;
            newCaptionPostStyle.BorderStyle = BorderStyle.None;
            newCaptionPostStyle.BackColor = Color.Transparent;
            newCaptionPostStyle.Location = new Point(50, (860 - newCaptionPostStyle.Height - 20) / 2 + 10);
            newCaptionPostStyle.MinimumSize = new Size(760, 0);
            newCaptionPostStyle.MaximumSize = new Size(760, 5000);
            newCaptionPostStyle.AutoSize = true;
            panel.Controls.Add(newCaptionPostStyle);


            switch (amountPicture)
            {
                case 2:
                    {
                        panel.Size = new Size(860, 860);

                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(820, (860 - newCaptionPostStyle.Height - 20) / 2 - 20);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(20, (860 - newCaptionPostStyle.Height - 20) / 2 + 10 + newCaptionPostStyle.Height + 10);
                        pb.Size = new Size(820, (860 - newCaptionPostStyle.Height - 20) / 2 - 20);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);
                        break;
                    }
                case 3:
                    {
                        panel.Size = new Size(860, 860);

                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(820, (860 - newCaptionPostStyle.Height - 20) / 2 - 20);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(20, (860 - newCaptionPostStyle.Height - 20) / 2 + 10 + newCaptionPostStyle.Height + 10);
                        pb.Size = new Size(400, (860 - newCaptionPostStyle.Height - 20) / 2 - 20);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image3" + "_" + idProperty;
                        pb.Location = new Point(20 + 400 + 20, (860 - newCaptionPostStyle.Height - 20) / 2 + 10 + newCaptionPostStyle.Height + 10);
                        pb.Size = new Size(400, (860 - newCaptionPostStyle.Height - 20) / 2 - 20);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);
                        break;
                    }
                default:
                    {
                        panel.Size = new Size(840, 840);

                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(820, (860 - newCaptionPostStyle.Height - 20) / 2 - 20);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(20, (860 - newCaptionPostStyle.Height - 20) / 2 + 10 + newCaptionPostStyle.Height + 10);
                        pb.Size = new Size(260, (860 - newCaptionPostStyle.Height - 20) / 2 - 20);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image3" + "_" + idProperty;
                        pb.Location = new Point(20 + 260 + 20, (860 - newCaptionPostStyle.Height - 20) / 2 + 10 + newCaptionPostStyle.Height + 10);
                        pb.Size = new Size(260, (860 - newCaptionPostStyle.Height - 20) / 2 - 20);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image4" + "_" + idProperty;
                        pb.Location = new Point(20 + 260 + 20 + 260 + 20, (860 - newCaptionPostStyle.Height - 20) / 2 + 10 + newCaptionPostStyle.Height + 10);
                        pb.Size = new Size(260, (860 - newCaptionPostStyle.Height - 20) / 2 - 20);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        if (amountPicture > 4)
                        {
                            Label lbl = new Label();
                            lbl.Name = "lbl_seeMorePicture" + "_" + idProperty;
                            lbl.Location = new Point(0, 0);
                            lbl.Size = new Size(260, (840 - newCaptionPostStyle.Height - 20) / 2 - 10);
                            lbl.Parent = pb;
                            lbl.BackColor = Color.FromArgb(102, 0, 0, 0); //Color.Transparent;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            lbl.Font = new Font("Be Vietnam Pro Black", 40F, FontStyle.Bold, GraphicsUnit.Point);
                            lbl.ForeColor = ColorTranslator.FromHtml("#ffffff");
                            lbl.Text = "+" + (amountPicture - 3).ToString();
#pragma warning disable CS8604 // Possible null reference argument.
                            lbl.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                            lbl.Cursor = Cursors.Hand;
#pragma warning restore CS8604 // Possible null reference argument.
                            pb.Controls.Add(lbl);
                        }
                        break;
                    }
            }
            return panel;
        }
    }

    class postShowHomePage
    {
        public async Task<FlowLayoutPanel> createFlowLayoutPanelIncludePost(String postID)
        {
            FirestoreDb database = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
            CollectionReference postColl = database.Collection("Posts");
            DocumentReference docRef = postColl.Document(postID);
            DocumentSnapshot docSnap = await docRef.GetSnapshotAsync();
            Dictionary<String, Object> postInfo = docSnap.ToDictionary();

            FirestoreDb database2 = FirestoreDb.Create((new firestoreDatabase()).getProjectID("firestore.json"));
            CollectionReference postColl2 = database2.Collection("Users");
            DocumentReference docRef2 = postColl2.Document(postID.Split("_")[2]);
            DocumentSnapshot docSnap2 = await docRef2.GetSnapshotAsync();
            Dictionary<String, Object> userInfo = docSnap2.ToDictionary();

            StorageClient storage = StorageClient.Create();
            String bucketName = (new firebaseStorage()).getBucketName("firebaseStorage.json");

            //MessageBox.Show(postID);
            String userName = postID.Split("_")[2];
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String dateUpload = postInfo["Date upload"].ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            List<Object> pathFiles = (List<Object>)postInfo["Post image"];
            int layoutMode = Int32.Parse(postInfo["Layout mode"].ToString());
            int visibleMode = Int32.Parse(postInfo["Visible mode"].ToString());

            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Name = "flp_" + postID;
            flp.Size = new Size(1074, 800);
            flp.VerticalScroll.Maximum = 0;
            flp.HorizontalScroll.Maximum = 0;
            flp.AutoScroll = true;
            flp.BackColor = Color.Transparent;
            flp.FlowDirection = FlowDirection.TopDown;

            Panel panel = new Panel();
            panel.Name = "panel_userInfo_" + postID;
            panel.Size = new Size(950, 150);
            panel.Margin = new Padding(62, 0, 62, 10);
            flp.Controls.Add(panel);

            PictureBox ava = new PictureBox();
            ava.Name = "pb_userAvatar_" + postID;
            ava.Size = new Size(50, 50);
            ava.Location = new Point(25, 25);
            ava.SizeMode = PictureBoxSizeMode.Zoom;
            var obj = storage.GetObject(bucketName, userInfo["Avatar profile"].ToString());
            var fileStream = File.Create("tmp." + obj.ContentType.ToString().Split("/")[1]);
            await storage.DownloadObjectAsync(bucketName, userInfo["Avatar profile"].ToString(), fileStream);
            String path_tmpFile = Path.GetFullPath(fileStream.Name);
            //Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"temp", "product2.txt")
            fileStream.Close();
            ava.Image = Image.FromFile(path_tmpFile);
            panel.Controls.Add(ava);
            
            Label lbl = new Label();
            lbl.Name = "lbl_userProfileName_" + postID;
            lbl.Font = new Font("Be Vietnam Pro Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.AutoSize = true;
            lbl.Text = userInfo["Profile name"].ToString();
            lbl.Location = new Point(25 + ava.Size.Width + 10, 25);
            lbl.BackColor = Color.Transparent;
            panel.Controls.Add(lbl);

            lbl = new Label();
            lbl.Name = "lbl_dateUpload_" + postID;
            lbl.Font = new Font("Be Vietnam Pro", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.DarkGray;
            lbl.AutoSize = true;
            String dateUpolad = postInfo["Date upload"].ToString();
            String oldFormatDateUpload = "dd'-'MM'-'yyyy'_'HH':'mm':'ss";
            String newFormatDateUpload = "HH':'mm':'ss', 'dd'/'MM'/'yyyy";
            lbl.Text = "Đăng lúc " + DateTime.ParseExact(dateUpolad, oldFormatDateUpload, CultureInfo.InvariantCulture).ToString(newFormatDateUpload);
            lbl.Location = new Point(25 + ava.Size.Width + 10, 25 + 22 + 5);
            lbl.BackColor = Color.Transparent;
            panel.Controls.Add(lbl);

            return flp;
        }
    }
}
