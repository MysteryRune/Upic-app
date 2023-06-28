using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upic
{
    public partial class loginForm : Form
    {
        private bool close_by_X_btt;
        public loginForm()
        {
            close_by_X_btt = true;
            InitializeComponent();
            /*FormClosed += new FormClosedEventHandler(loginForm_FormClosedByXBtt);*/
        }

        private void facebookLogin_Click(object sender, EventArgs e)
        {
            /*close_by_X_btt = false;
            Close();
            facebookLogin form = new();
            form.Show();*/
        }

        private void googleLogin_Click(object sender, EventArgs e)
        {
            /*close_by_X_btt = false;
            Close();
            googleLogin form = new();
            form.Show();*/
        }

        private void phoneNumberLogin_Click(object sender, EventArgs e)
        {
            /*close_by_X_btt = false;
            Close();
            phoneNumLogin form = new();
            form.Show();*/
        }

        private void hidePasswordBtt_Click(object sender, EventArgs e)
        {
            // "" Hidding password
            // " " Unhidding password
            if (hidePasswordBtt.Text == "") // Hidden password --> Unhidden password
            {
                hidePasswordBtt.Text = " ";
                hidePasswordBtt.BackgroundImage = Properties.Resources.eyeUnhideIcon;
                passwordBox.PasswordChar = '\0';
            }
            else // Unhidden password --> Hidden password
            {
                hidePasswordBtt.Text = "";
                hidePasswordBtt.BackgroundImage = Properties.Resources.eyeHiddenIcon;
                passwordBox.PasswordChar = '*';
            }
        }

        private void signUpBtt_Click(object sender, EventArgs e)
        {
            close_by_X_btt = false;
            Close();
            signupForm form = new();
            form.Show();
        }

        private void loginBtt_Click(object sender, EventArgs e)
        {
            /*close_by_X_btt = false;
            Close();
            homePage.homePageInstance.ShowInTaskbar = true;
            homePage.homePageInstance.Visible = true;
            homePage.homePageInstance.AutoScroll = true;*/
        }

        private void loginForm_FormClosedByXBtt(object sender, FormClosedEventArgs e)
        {
            /*if (e.CloseReason == CloseReason.UserClosing && close_by_X_btt == true)
            {
                homePage.homePageInstance.Close();
            }*/
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void minimizeBtt_Click(object sender, EventArgs e)
        {
            loginAnnouncement.Visible = false;
            signInBtt.Visible = true;
            signUpBtt2.Visible = true;
        }

        private void signInBtt_Click(object sender, EventArgs e)
        {
            signInBtt.Visible = false;
            signUpBtt2.Visible = false;
            loginAnnouncement.Visible = true;
        }

        private void signUpBtt2_Click(object sender, EventArgs e)
        {
            close_by_X_btt = false;
            Close();
            signupForm form = new();
            form.Show();
        }
    }
}
