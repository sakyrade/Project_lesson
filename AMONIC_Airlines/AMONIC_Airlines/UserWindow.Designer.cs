namespace AMONIC_Airlines
{
    partial class UserWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_user = new System.Windows.Forms.MenuStrip();
            this.menu_strip_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.dgv_users_audit = new System.Windows.Forms.DataGridView();
            this.lb_full_time = new System.Windows.Forms.Label();
            this.lb_num_of_crashes = new System.Windows.Forms.Label();
            this.menu_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_audit)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_user
            // 
            this.menu_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_strip_exit});
            this.menu_user.Location = new System.Drawing.Point(0, 0);
            this.menu_user.Name = "menu_user";
            this.menu_user.Size = new System.Drawing.Size(779, 24);
            this.menu_user.TabIndex = 0;
            this.menu_user.Text = "menuStrip1";
            // 
            // menu_strip_exit
            // 
            this.menu_strip_exit.Name = "menu_strip_exit";
            this.menu_strip_exit.Size = new System.Drawing.Size(37, 20);
            this.menu_strip_exit.Text = "Exit";
            this.menu_strip_exit.Click += new System.EventHandler(this.menu_strip_exit_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Location = new System.Drawing.Point(12, 46);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(0, 13);
            this.lb_welcome.TabIndex = 1;
            // 
            // dgv_users_audit
            // 
            this.dgv_users_audit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users_audit.Location = new System.Drawing.Point(12, 138);
            this.dgv_users_audit.Name = "dgv_users_audit";
            this.dgv_users_audit.Size = new System.Drawing.Size(755, 265);
            this.dgv_users_audit.TabIndex = 2;
            // 
            // lb_full_time
            // 
            this.lb_full_time.AutoSize = true;
            this.lb_full_time.Location = new System.Drawing.Point(274, 63);
            this.lb_full_time.Name = "lb_full_time";
            this.lb_full_time.Size = new System.Drawing.Size(0, 13);
            this.lb_full_time.TabIndex = 3;
            // 
            // lb_num_of_crashes
            // 
            this.lb_num_of_crashes.AutoSize = true;
            this.lb_num_of_crashes.Location = new System.Drawing.Point(522, 63);
            this.lb_num_of_crashes.Name = "lb_num_of_crashes";
            this.lb_num_of_crashes.Size = new System.Drawing.Size(0, 13);
            this.lb_num_of_crashes.TabIndex = 4;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 434);
            this.Controls.Add(this.lb_num_of_crashes);
            this.Controls.Add(this.lb_full_time);
            this.Controls.Add(this.dgv_users_audit);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.menu_user);
            this.MainMenuStrip = this.menu_user;
            this.Name = "UserWindow";
            this.Text = "UserWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserWindow_FormClosed);
            this.menu_user.ResumeLayout(false);
            this.menu_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_audit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_user;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_exit;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.DataGridView dgv_users_audit;
        private System.Windows.Forms.Label lb_full_time;
        private System.Windows.Forms.Label lb_num_of_crashes;
    }
}