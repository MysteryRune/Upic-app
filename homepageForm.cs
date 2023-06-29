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

        public homepageForm()
        {
            InitializeComponent();
            tb_search.Focus();
            flp_newfeeds.BackColor = Color.White;
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

        private void btn_exit_post_Click(object sender, EventArgs e)
        {
            panel_create_post.Visible = false;
            panel_before_post.Visible = true;
            flp_newfeeds.Visible = true;
            flp_newfeeds.BringToFront();
        }
    }


}
