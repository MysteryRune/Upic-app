﻿using System;
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
    public partial class messagesForm : Form
    {
        public messagesForm()
        {
            InitializeComponent();
        }


        private void panel_bg_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void btn_add_image_Click(object sender, EventArgs e)
        {

        }
    }
}
