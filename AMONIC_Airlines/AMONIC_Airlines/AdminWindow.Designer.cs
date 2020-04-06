namespace AMONIC_Airlines
{
    partial class AdminWindow
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
            this.admin_ms = new System.Windows.Forms.MenuStrip();
            this.add_user_admin_ms = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_admin_ms = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_offices = new System.Windows.Forms.Label();
            this.cmb_offices = new System.Windows.Forms.ComboBox();
            this.dgv_offices = new System.Windows.Forms.DataGridView();
            this.btn_enable_disable_login = new System.Windows.Forms.Button();
            this.btn_change_role = new System.Windows.Forms.Button();
            this.admin_ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_offices)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_ms
            // 
            this.admin_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_user_admin_ms,
            this.exit_admin_ms});
            this.admin_ms.Location = new System.Drawing.Point(0, 0);
            this.admin_ms.Name = "admin_ms";
            this.admin_ms.Size = new System.Drawing.Size(779, 24);
            this.admin_ms.TabIndex = 0;
            this.admin_ms.Text = "menuStrip1";
            // 
            // add_user_admin_ms
            // 
            this.add_user_admin_ms.Name = "add_user_admin_ms";
            this.add_user_admin_ms.Size = new System.Drawing.Size(66, 20);
            this.add_user_admin_ms.Text = "Add user";
            this.add_user_admin_ms.Click += new System.EventHandler(this.add_user_admin_ms_Click);
            // 
            // exit_admin_ms
            // 
            this.exit_admin_ms.Name = "exit_admin_ms";
            this.exit_admin_ms.Size = new System.Drawing.Size(37, 20);
            this.exit_admin_ms.Text = "Exit";
            this.exit_admin_ms.Click += new System.EventHandler(this.exit_admin_ms_Click);
            // 
            // lb_offices
            // 
            this.lb_offices.AutoSize = true;
            this.lb_offices.Location = new System.Drawing.Point(12, 54);
            this.lb_offices.Name = "lb_offices";
            this.lb_offices.Size = new System.Drawing.Size(38, 13);
            this.lb_offices.TabIndex = 1;
            this.lb_offices.Text = "Office:";
            // 
            // cmb_offices
            // 
            this.cmb_offices.FormattingEnabled = true;
            this.cmb_offices.Items.AddRange(new object[] {
            "All offices",
            "Abu dhabi",
            "Cairo",
            "Bahrain",
            "Doha",
            "Riyadh"});
            this.cmb_offices.Location = new System.Drawing.Point(56, 51);
            this.cmb_offices.Name = "cmb_offices";
            this.cmb_offices.Size = new System.Drawing.Size(121, 21);
            this.cmb_offices.TabIndex = 2;
            this.cmb_offices.SelectedIndexChanged += new System.EventHandler(this.cmb_offices_SelectedIndexChanged);
            // 
            // dgv_offices
            // 
            this.dgv_offices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_offices.Location = new System.Drawing.Point(15, 103);
            this.dgv_offices.Name = "dgv_offices";
            this.dgv_offices.Size = new System.Drawing.Size(752, 270);
            this.dgv_offices.TabIndex = 3;
            // 
            // btn_enable_disable_login
            // 
            this.btn_enable_disable_login.Location = new System.Drawing.Point(158, 396);
            this.btn_enable_disable_login.Name = "btn_enable_disable_login";
            this.btn_enable_disable_login.Size = new System.Drawing.Size(127, 23);
            this.btn_enable_disable_login.TabIndex = 4;
            this.btn_enable_disable_login.Text = "Enable/Disable Login";
            this.btn_enable_disable_login.UseVisualStyleBackColor = true;
            this.btn_enable_disable_login.Click += new System.EventHandler(this.btn_enable_disable_login_Click);
            // 
            // btn_change_role
            // 
            this.btn_change_role.Location = new System.Drawing.Point(15, 396);
            this.btn_change_role.Name = "btn_change_role";
            this.btn_change_role.Size = new System.Drawing.Size(127, 23);
            this.btn_change_role.TabIndex = 5;
            this.btn_change_role.Text = "Change Role";
            this.btn_change_role.UseVisualStyleBackColor = true;
            this.btn_change_role.Click += new System.EventHandler(this.btn_change_role_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 434);
            this.Controls.Add(this.btn_change_role);
            this.Controls.Add(this.btn_enable_disable_login);
            this.Controls.Add(this.dgv_offices);
            this.Controls.Add(this.cmb_offices);
            this.Controls.Add(this.lb_offices);
            this.Controls.Add(this.admin_ms);
            this.MainMenuStrip = this.admin_ms;
            this.Name = "AdminWindow";
            this.Text = "AMONIC Airlines Automatic System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminWindow_FormClosed);
            this.admin_ms.ResumeLayout(false);
            this.admin_ms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_offices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip admin_ms;
        private System.Windows.Forms.ToolStripMenuItem add_user_admin_ms;
        private System.Windows.Forms.ToolStripMenuItem exit_admin_ms;
        private System.Windows.Forms.Label lb_offices;
        private System.Windows.Forms.ComboBox cmb_offices;
        private System.Windows.Forms.DataGridView dgv_offices;
        private System.Windows.Forms.Button btn_enable_disable_login;
        private System.Windows.Forms.Button btn_change_role;
    }
}