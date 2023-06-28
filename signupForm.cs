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
    public partial class signupForm : Form
    {
        private bool close_by_X_btt;
        public signupForm()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(SignUpForm_FormClosed);
            close_by_X_btt = true;
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && close_by_X_btt == true)
            {
                loginForm form = new();
                form.Show();
            }
        }

        private void hidePasswordBtt_Click(object sender, EventArgs e)
        {
            // "" Hidding password
            // " " Unhidding password
            if (hidePasswordBtt.Text == "") // Hidden password --> Unhidden password
            {
                hidePasswordBtt.Text = " ";
                hidePasswordBtt.BackgroundImage = global::Upic.Properties.Resources.eyeUnhideIcon;
                passwordBox.PasswordChar = '\0';
            }
            else // Unhidden password --> Hidden password
            {
                hidePasswordBtt.Text = "";
                hidePasswordBtt.BackgroundImage = global::Upic.Properties.Resources.eyeHiddenIcon;
                passwordBox.PasswordChar = '*';
            }
        }

        private void nextBtt_Click(object sender, EventArgs e)
        {
            signUpPanel1.Visible = false;
            signUpPanel2.Visible = true;
        }

        private void signUpContinuos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maleGender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void facebookSignUp_Click(object sender, EventArgs e)
        {
            /*close_by_X_btt = false;
            Close();
            facebookLogin form = new();
            form.Show();*/
        }

        private void googleSignUp_Click(object sender, EventArgs e)
        {
            /*close_by_X_btt = false;
            Close();
            googleLogin form = new();
            form.Show();*/
        }

        private void loginBtt1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backBtt_Click(object sender, EventArgs e)
        {
            signUpPanel2.Visible = false;
            signUpPanel1.Visible = true;
        }

        private void finishBtt_Click(object sender, EventArgs e)
        {
            /*close_by_X_btt = false;
            Close();
            homePage.homePageInstance.ShowInTaskbar = true;
            homePage.homePageInstance.Visible = true;
            homePage.homePageInstance.AutoScroll = true;*/
        }

        private void loginBtt2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void signupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
