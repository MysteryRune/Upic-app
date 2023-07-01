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
        }
    }
}
