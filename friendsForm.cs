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
        public friendsForm()
        {
            InitializeComponent();
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


    }
}
