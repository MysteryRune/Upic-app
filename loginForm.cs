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
            InitializeComponent();

            close_by_X_btt = true;

#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            FormClosed += new FormClosedEventHandler(loginForm_FormClosedByXBtt);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            loginAnnouncement.AutoScroll = false;
            loginAnnouncement.VerticalScroll.Maximum = 0;
            loginAnnouncement.HorizontalScroll.Maximum = 0;
            loginAnnouncement.AutoScroll = true;
            loginAnnouncement.Visible = false;
            loginBtt.Visible = true;
            signUpBtt.Visible = true;
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
            loginAnnouncement.Visible = false;
            signUpPanel1.Visible = true;
        }

        private void loginBtt_Click(object sender, EventArgs e)
        {
            close_by_X_btt = false;
            Close();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            testForm.testFireCloudInstance.ShowInTaskbar = true;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            testForm.testFireCloudInstance.Visible = true;
            testForm.testFireCloudInstance.AutoScroll = true;
        }

        private void loginForm_FormClosedByXBtt(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && close_by_X_btt == true)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                testForm.testFireCloudInstance.Close();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }

        private void minimizeBtt_Click(object sender, EventArgs e)
        {
            loginAnnouncement.Visible = false;
            loginBtt.Visible = true;
            signUpBtt.Visible = true;
        }

        private void signInBtt_Click(object sender, EventArgs e)
        {
            loginBtt.Visible = false;
            signUpBtt.Visible = false;
            loginAnnouncement.Visible = true;
        }

        private void signUpBtt2_Click(object sender, EventArgs e)
        {
            loginAnnouncement.Visible = false;
            signUpPanel1.Visible = true;
        }

        private void nextBtt_Click(object sender, EventArgs e)
        {
            signUpPanel1.Visible = false;
            signUpPanel2.Visible = true;
        }

        private void minimizeBtt2_Click(object sender, EventArgs e)
        {
            signUpPanel1.Visible = false;
            loginBtt.Visible = true;
            signUpBtt.Visible = true;
        }

        private void loginPanelBtt1_Click(object sender, EventArgs e)
        {
            signUpPanel1.Visible = false;
            loginAnnouncement.Visible = true;
        }

        private void minimizeBtt3_Click(object sender, EventArgs e)
        {
            signUpPanel2.Visible = false;
            loginBtt.Visible = true;
            signUpBtt.Visible = true;
        }

        private void backBtt_Click(object sender, EventArgs e)
        {
            signUpPanel2.Visible = false;
            signUpPanel1.Visible = true;
        }

        private void loginPanelBtt2_Click(object sender, EventArgs e)
        {
            signUpPanel2.Visible = false;
            loginAnnouncement.Visible = true;
        }
    }
}
