using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Upic
{
    public partial class editProfileUC : UserControl
    {
        public editProfileUC()
        {
            InitializeComponent();
        }

        private void btn_update_info_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_edit_info.Visible = true;
            //gán giá trị hiện tại của thông tin cá nhân vào các điều khiển chỉnh sửa
            tb_edit_name.Text = lbl_name.Text;
            cbb_sex.SelectedItem = lbl_sex.Text;
            tb_edit_day.Text = lbl_user_day.Text;
            tb_edit_month.Text = lbl_user_month.Text;
            tb_edit_year.Text = lbl_user_year.Text;
            tb_edit_address.Text = lbl_user_address.Text;
            tb_edit_story.Text = lbl_story.Text;
            tb_edit_hobby.Text = lbl_hobby.Text;

        }

        private void editProfileUC_Load(object sender, EventArgs e)
        {
            //InitializeControls();
            btn_update_info.Click += btn_update_info_Click;
            btn_save_profile.Click += btn_save_profile_Click;
        }

        private void btn_save_profile_Click(object sender, EventArgs e)
        {
            // Cập nhật thông tin cá nhân từ các chỉnh sửa
            lbl_name.Text = tb_edit_name.Text;
            lbl_sex.Text = cbb_sex.SelectedItem.ToString();
            lbl_user_day.Text = (tb_edit_day).Text;
            lbl_user_month.Text = (tb_edit_month.Text).ToString();
            lbl_user_year.Text = (tb_edit_year.Text).ToString();
            lbl_address.Text = tb_edit_address.Text.ToString();
            lbl_story.Text = tb_edit_story.Text;
            lbl_hobby.Text = tb_edit_hobby.Text;

            panel_edit_info.Visible = true;

        }
    }
}
