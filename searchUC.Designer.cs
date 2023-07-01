namespace Upic
{
    partial class searchUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_search_user = new Panel();
            pictureBox1 = new PictureBox();
            lbl_search_name = new Label();
            lbl_search_username = new Label();
            flp_search = new FlowLayoutPanel();
            panel_search_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flp_search.SuspendLayout();
            SuspendLayout();
            // 
            // panel_search_user
            // 
            panel_search_user.BackColor = Color.White;
            panel_search_user.Controls.Add(lbl_search_username);
            panel_search_user.Controls.Add(lbl_search_name);
            panel_search_user.Controls.Add(pictureBox1);
            panel_search_user.Location = new Point(3, 3);
            panel_search_user.Name = "panel_search_user";
            panel_search_user.Size = new Size(432, 82);
            panel_search_user.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.accountIcon;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_search_name
            // 
            lbl_search_name.AutoSize = true;
            lbl_search_name.Font = new Font("Be Vietnam Pro SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_search_name.Location = new Point(91, 17);
            lbl_search_name.Name = "lbl_search_name";
            lbl_search_name.Size = new Size(201, 28);
            lbl_search_name.TabIndex = 1;
            lbl_search_name.Text = "Tên hồ sơ người dùng";
            // 
            // lbl_search_username
            // 
            lbl_search_username.AutoSize = true;
            lbl_search_username.Font = new Font("Be Vietnam Pro", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_search_username.ForeColor = Color.FromArgb(86, 101, 115);
            lbl_search_username.Location = new Point(100, 45);
            lbl_search_username.Name = "lbl_search_username";
            lbl_search_username.Size = new Size(97, 23);
            lbl_search_username.TabIndex = 5;
            lbl_search_username.Text = "@username\r\n";
            // 
            // flp_search
            // 
            flp_search.BackColor = Color.White;
            flp_search.Controls.Add(panel_search_user);
            flp_search.Location = new Point(3, 3);
            flp_search.Name = "flp_search";
            flp_search.Size = new Size(457, 396);
            flp_search.TabIndex = 5;
            // 
            // searchUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flp_search);
            Name = "searchUC";
            Size = new Size(464, 405);
            panel_search_user.ResumeLayout(false);
            panel_search_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flp_search.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_search_user;
        private Label lbl_search_username;
        private Label lbl_search_name;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flp_search;
    }
}
