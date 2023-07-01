using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upic
{
    public partial class friendsForm : Form
    {
        private bool close_by_X_btt;

        public friendsForm()
        {
            InitializeComponent();
            close_by_X_btt = true;
            FormClosed += new FormClosedEventHandler(friendForm_FormClosedByXBtt);
        }

        private void returnToHomePage()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.Visible = true;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            homepageForm.homePageInstance.ShowInTaskbar = true;
        }

        private void friendForm_FormClosedByXBtt(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && close_by_X_btt == true)
            {
                returnToHomePage();
            }
        }

        private void btn_allfriends_Click(object sender, EventArgs e)
        {
            panel_requests.Visible = false;
            panel_allfriends.Visible = true;

        }

        private void btn_friendrequests_Click(object sender, EventArgs e)
        {
            panel_allfriends.Visible = false;
            panel_requests.Visible = true;
        }

        private void pb_logo_UPIC_Click(object sender, EventArgs e)
        {
            close_by_X_btt = false;
            Close();
            returnToHomePage();
        }
    }
}
