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
    public partial class notificationsForm : Form
    {
        public notificationsForm()
        {
            InitializeComponent();
        }

        private void panel_bg_Paint(object sender, PaintEventArgs e)
        {
            ActiveControl = null;
        }
    }
}
