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
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types.Aggregation.Types;
using System.IO;
using System.Windows.Media.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public Panel createLayoutMode2Post(String[] pathFiles, Form form, String idProperty, String oldCaptionPostStyle)
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

            if (oldCaptionPostStyle.Length >= 100 || Regex.Split(oldCaptionPostStyle, @"\r\n").ToList().Count > 1)
            {
                MessageBox.Show("Nội dung caption quá dài hoặc nhiều dòng, không thích hợp!");
                return null;
            }

            Label newCaptionPostStyle = new Label();
            newCaptionPostStyle.Font = new Font("Be Vietnam Pro", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            newCaptionPostStyle.Text = oldCaptionPostStyle;
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

        public Panel createLayoutMode3Post(String[] pathFiles, Form form, String idProperty)
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
                        panel.Size = new Size(860, 860);

                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(820, 400);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(20, 440);
                        pb.Size = new Size(820, 400);
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
                        pb.Size = new Size(400, 780);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(20 + 400 + 20, 60);
                        pb.Size = new Size(380, 380);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image3" + "_" + idProperty;
                        pb.Location = new Point(20 + 400 + 20, 60 + 380 + 20);
                        pb.Size = new Size(380, 380);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);
                        break;
                    }
                default:
                    {
                        panel.Size = new Size(860, 860);

                        PictureBox pb = new PictureBox();
                        pb.Name = "pb_image1" + "_" + idProperty;
                        pb.Location = new Point(20, 20);
                        pb.Size = new Size(380, 380);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image2" + "_" + idProperty;
                        pb.Location = new Point(20, 20 + 380 + 20);
                        pb.Size = new Size(380, 380);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image3" + "_" + idProperty;
                        pb.Location = new Point(20 + 380 + 60, 60);
                        pb.Size = new Size(380, 380);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.BorderStyle = BorderStyle.None;
                        pb.Cursor = Cursors.Hand;
                        pb.Click += (sender, EventArgs) => lbl_seeMorePicture_CLick(sender, EventArgs, pathFiles, form, idProperty);
                        panel.Controls.Add(pb);

                        pb = new PictureBox();
                        pb.Name = "pb_image4" + "_" + idProperty;
                        pb.Location = new Point(20 + 380 + 60, 60 + 380 + 20);
                        pb.Size = new Size(380, 380);
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
    }

    class postShowHomePage
    {
        public List<Image> tempFileVarible = new List<Image>();

        public async Task<FlowLayoutPanel> createFlowLayoutPanelIncludePost(String postID, Form form, String tempFolderName)
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
            flp.Size = new Size(1000, 1000);
            flp.Margin = new Padding(40, 0, 40, 10);
            flp.VerticalScroll.Maximum = 0;
            flp.HorizontalScroll.Maximum = 0;
            flp.AutoScroll = true;
            flp.BackColor = Color.Transparent;
            flp.FlowDirection = FlowDirection.TopDown;

            Panel panelPost = new Panel();
            panelPost.Name = "panel_backgroundPost_" + postID;
            panelPost.Size = new Size(950, 1000);
            panelPost.Margin = new Padding(25, 0, 25, 0);
            panelPost.BorderStyle = BorderStyle.FixedSingle;
            flp.Controls.Add(panelPost);

            Panel panel = new Panel();
            panel.Name = "panel_userInfo_" + postID;
            panel.Size = new Size(950, 80);
            panel.Margin = new Padding(0, 0, 0, 0);
            panel.Location = new Point(0, 0);
            panelPost.Controls.Add(panel);

            PictureBox ava = new PictureBox();
            ava.Name = "pb_userAvatar_" + postID;
            ava.Size = new Size(50, 50);
            ava.Location = new Point(25, 25);
            ava.SizeMode = PictureBoxSizeMode.Zoom;
            var obj = storage.GetObject(bucketName, userInfo["Avatar profile"].ToString());
            String pathFolderTemp = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"temp/", tempFolderName);
            String nameTempFile = "userAvatarTemp_" + postID.Split("_")[2] + "." + obj.ContentType.ToString().Split("/")[1];
            var fileStream = File.Create(pathFolderTemp + "/" + nameTempFile);
            await storage.DownloadObjectAsync(bucketName, userInfo["Avatar profile"].ToString(), fileStream);
            String path_tmpFile = Path.GetFullPath(fileStream.Name);

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.StreamSource = fileStream;
            image.EndInit();
            ava.Image = Image.FromStream(fileStream);
            fileStream.Close();
            File.Delete(path_tmpFile);
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

            Button likeBtn = new Button();
            likeBtn.Name = "btn_likeBtn_" + postID;
            likeBtn.FlatStyle = FlatStyle.Flat;
            likeBtn.FlatAppearance.BorderSize = 0;
            likeBtn.BackColor = Color.Transparent;
            likeBtn.BackgroundImage = global::Upic.Properties.Resources.heartIconNotFill;
            likeBtn.Text = ""; // nolike
            likeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            likeBtn.Location = new Point(890, 0);
            likeBtn.Size = new Size(40, 40);
            likeBtn.Cursor = Cursors.Hand;
            likeBtn.Click += homepageForm.homePageInstance.likeBtn_Click;
            panel.Controls.Add(likeBtn);

            Label amountLike = new Label();
            amountLike.Name = "lbl_amountLike_" + postID;
            amountLike.Font = new Font("Be Vietnam Pro", 8F, FontStyle.Regular, GraphicsUnit.Point);
            amountLike.ForeColor = Color.DarkGray;
            amountLike.Size = new Size(40, 40);
            amountLike.TextAlign = ContentAlignment.MiddleCenter;
            amountLike.Text = "0";
            amountLike.Location = new Point(890, 40);
            amountLike.BackColor = Color.Transparent;
            panel.Controls.Add(amountLike);

            List<Object> amountLikeOnDatabase = (List<Object>)postInfo["Like list"];
            amountLike.Text = amountLikeOnDatabase.Count.ToString();

            foreach (Object user in amountLikeOnDatabase)
            {
                String username = loginForm.loginPageInstance.userLogging;
                if (user.ToString() == username)
                {
                    likeBtn.BackgroundImage = global::Upic.Properties.Resources.heartIconFill;
                    likeBtn.Text = " "; // like
                    break;
                }
            }



            List<String> pathFileTempImageDownloadLocal = new List<String>();
            foreach (String path in pathFiles) 
            {
                String imagePostID = path.ToString().Split("/")[3];
                PictureBox pb = new PictureBox();
                pb.Name = "pb_imgPost_" + imagePostID;
                pb.Size = new Size(50, 50);
                pb.Location = new Point(25, 25);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                var obj_ = storage.GetObject(bucketName, path.ToString());
                String pathFolderTemp_ = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"temp/homepage");
                String nameTempFile_ = "tmp_" + imagePostID.Replace(":", "-") + "." + obj_.ContentType.ToString().Split("/")[1];
                var fileStream_ = File.Create(pathFolderTemp_ + "/" + nameTempFile_);
                await storage.DownloadObjectAsync(bucketName, path.ToString(), fileStream_);
                pathFileTempImageDownloadLocal.Add(Path.GetFullPath(fileStream_.Name));
                fileStream_.Close();
            }

            Panel listPicture = null;
            switch (layoutMode)
            {
                case 0:
                    {
                        FlowLayoutPanel flp_tmp = new FlowLayoutPanel();
                        flp_tmp.Name = "flp_contentPost_" + postID;
                        flp_tmp.AutoSize = true;
                        flp_tmp.Margin = new Padding(25, 0, 25, 0);
                        flp_tmp.Location = new Point(50, 90);
                        flp_tmp.FlowDirection = FlowDirection.TopDown;
                        flp_tmp.BackColor = Color.Transparent;
                        panelPost.Controls.Add(flp_tmp);

                        lbl = new Label();
                        lbl.Name = "lbl_captionPost_" + postID;
                        lbl.Font = new Font("Be Vietnam Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
                        lbl.Text = postInfo["Post status"].ToString();
                        lbl.ForeColor = Color.Black;
                        lbl.AutoSize = true;
                        lbl.Margin = new Padding(0, 0, 0, 10);
                        lbl.MaximumSize = new Size(900, 0);
                        lbl.Location = new Point(0, 0);
                        lbl.BackColor = Color.Transparent;
                        flp_tmp.Controls.Add(lbl);

                        listPicture = (new layoutPost()).createLayoutMode0Post(pathFileTempImageDownloadLocal.ToArray(), form, postID);
                        listPicture.Margin = new Padding(0, 0, 0, 0);
                        flp_tmp.Controls.Add(listPicture);
                        break;
                    }
                case 1:
                    {
                        FlowLayoutPanel flp_tmp = new FlowLayoutPanel();
                        flp_tmp.Name = "flp_contentPost_" + postID;
                        flp_tmp.AutoSize = true;
                        flp_tmp.Margin = new Padding(25, 0, 25, 0);
                        flp_tmp.Location = new Point(50, 90);
                        flp_tmp.FlowDirection = FlowDirection.TopDown;
                        flp_tmp.BackColor = Color.Transparent;
                        panelPost.Controls.Add(flp_tmp);

                        lbl = new Label();
                        lbl.Name = "lbl_captionPost_" + postID;
                        lbl.Font = new Font("Be Vietnam Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
                        lbl.Text = postInfo["Post status"].ToString();
                        lbl.ForeColor = Color.Black;
                        lbl.AutoSize = true;
                        lbl.Margin = new Padding(0, 0, 0, 10);
                        lbl.MaximumSize = new Size(900, 0);
                        lbl.Location = new Point(0, 0);
                        lbl.BackColor = Color.Transparent;
                        flp_tmp.Controls.Add(lbl);

                        listPicture = (new layoutPost()).createLayoutMode1Post(pathFileTempImageDownloadLocal.ToArray(), form, postID);
                        listPicture.Margin = new Padding(20, 0, 20, 0);
                        flp_tmp.Controls.Add(listPicture);
                        break;
                    }
                case 2:
                    {
                        FlowLayoutPanel flp_tmp = new FlowLayoutPanel();
                        flp_tmp.Name = "flp_contentPost_" + postID;
                        flp_tmp.AutoSize = true;
                        flp_tmp.Margin = new Padding(25, 0, 25, 0);
                        flp_tmp.Location = new Point(50, 90);
                        flp_tmp.FlowDirection = FlowDirection.TopDown;
                        flp_tmp.BackColor = Color.Transparent;
                        panelPost.Controls.Add(flp_tmp);

                        listPicture = (new layoutPost()).createLayoutMode2Post(pathFileTempImageDownloadLocal.ToArray(), form, postID, postInfo["Post status"].ToString());
                        listPicture.Margin = new Padding(20, 0, 20, 0);
                        flp_tmp.Controls.Add(listPicture);
                        break;
                    }
                case 3:
                    {
                        FlowLayoutPanel flp_tmp = new FlowLayoutPanel();
                        flp_tmp.Name = "flp_contentPost_" + postID;
                        flp_tmp.AutoSize = true;
                        flp_tmp.Margin = new Padding(25, 0, 25, 0);
                        flp_tmp.Location = new Point(50, 90);
                        flp_tmp.FlowDirection = FlowDirection.TopDown;
                        flp_tmp.BackColor = Color.Transparent;
                        panelPost.Controls.Add(flp_tmp);

                        lbl = new Label();
                        lbl.Name = "lbl_captionPost_" + postID;
                        lbl.Font = new Font("Be Vietnam Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
                        lbl.Text = postInfo["Post status"].ToString();
                        lbl.ForeColor = Color.Black;
                        lbl.AutoSize = true;
                        lbl.Margin = new Padding(0, 0, 0, 10);
                        lbl.MaximumSize = new Size(900, 0);
                        lbl.Location = new Point(0, 0);
                        lbl.BackColor = Color.Transparent;
                        flp_tmp.Controls.Add(lbl);

                        listPicture = (new layoutPost()).createLayoutMode3Post(pathFileTempImageDownloadLocal.ToArray(), form, postID);
                        listPicture.Margin = new Padding(20, 0, 20, 0);
                        flp_tmp.Controls.Add(listPicture);
                        break;
                    }
            }
            for (int i = 0; i < pathFileTempImageDownloadLocal.Count; i++)
            {
                if (i < 4)
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    Control pb = listPicture.Controls["pb_image" + (i + 1).ToString() + "_" + postID] as PictureBox;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    fileStream = File.OpenRead(pathFileTempImageDownloadLocal[i]);
                    image = new BitmapImage();
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.StreamSource = fileStream;
                    image.EndInit();
                    (pb as PictureBox).Image = Image.FromStream(fileStream);
                    fileStream.Close();
                    File.Delete(fileStream.Name);

                    //(pb as PictureBox).Image = System.Drawing.Image.FromFile(pathFileTempImageDownloadLocal[i]);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
                else
                {
                    File.Delete(pathFileTempImageDownloadLocal[i]);
                }
            }

            return flp;
        }
    }
}
