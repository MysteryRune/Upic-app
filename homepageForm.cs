using System;
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

namespace Upic
{
    public partial class homepageForm : Form
    {

        public static homepageForm? homePageInstance;

        public homepageForm()
        {
            homePageInstance = this;

            InitializeComponent();
            flp_newfeeds.BackColor = Color.White;
            loginForm form = new loginForm();
            form.Show();
        }
        private void homepageForm_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;

            panel_create_post.AutoScroll = false;
            panel_create_post.VerticalScroll.Maximum = 0;
            panel_create_post.HorizontalScroll.Maximum = 0;
            panel_create_post.AutoScroll = true;

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
            changeStateToShapeLine();
            pb_friends.Image = global::Upic.Properties.Resources.friends_fill;
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

        private Panel createListPictureBoxLayout0(int amountPicture)
        {
            // Layout: None style
            // Amount picture must > 0
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
                        break;
                    }
            }
            return panel;
        }

        private void showListImageBeforeUpload(String[] pathFile)
        {
            if (pathFile.Length > 0)
            {
                pb_chooseImageFromDevice.Visible = false;
                btn_chooseImageFromDevice.Visible = false;

                panel_create_post.Controls.Add(createListPictureBoxLayout0(pathFile.Length));

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
            }
        }
    }


}
