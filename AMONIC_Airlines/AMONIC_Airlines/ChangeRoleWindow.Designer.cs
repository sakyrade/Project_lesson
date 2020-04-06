namespace AMONIC_Airlines
{
    partial class ChangeRoleWindow
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
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.cmb_offices = new System.Windows.Forms.ComboBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.radiobtn_user = new System.Windows.Forms.RadioButton();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.lb_first_name = new System.Windows.Forms.Label();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.lb_last_name = new System.Windows.Forms.Label();
            this.lb_office = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.radiobtn_admin = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(38, 42);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(75, 13);
            this.lb_email.TabIndex = 0;
            this.lb_email.Text = "Email address:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(119, 39);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(124, 20);
            this.txt_email.TabIndex = 1;
            // 
            // cmb_offices
            // 
            this.cmb_offices.FormattingEnabled = true;
            this.cmb_offices.Items.AddRange(new object[] {
            "Abu dhabi",
            "Cairo",
            "Bahrain",
            "Doha",
            "Riyadh"});
            this.cmb_offices.Location = new System.Drawing.Point(119, 164);
            this.cmb_offices.Name = "cmb_offices";
            this.cmb_offices.Size = new System.Drawing.Size(124, 21);
            this.cmb_offices.TabIndex = 2;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(44, 293);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // radiobtn_user
            // 
            this.radiobtn_user.AutoSize = true;
            this.radiobtn_user.Location = new System.Drawing.Point(119, 214);
            this.radiobtn_user.Name = "radiobtn_user";
            this.radiobtn_user.Size = new System.Drawing.Size(47, 17);
            this.radiobtn_user.TabIndex = 4;
            this.radiobtn_user.TabStop = true;
            this.radiobtn_user.Text = "User";
            this.radiobtn_user.UseVisualStyleBackColor = true;
            // 
            // txt_first_name
            // 
            this.txt_first_name.Location = new System.Drawing.Point(119, 80);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(124, 20);
            this.txt_first_name.TabIndex = 6;
            // 
            // lb_first_name
            // 
            this.lb_first_name.AutoSize = true;
            this.lb_first_name.Location = new System.Drawing.Point(38, 83);
            this.lb_first_name.Name = "lb_first_name";
            this.lb_first_name.Size = new System.Drawing.Size(58, 13);
            this.lb_first_name.TabIndex = 5;
            this.lb_first_name.Text = "First name:";
            // 
            // txt_last_name
            // 
            this.txt_last_name.Location = new System.Drawing.Point(119, 122);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(124, 20);
            this.txt_last_name.TabIndex = 8;
            // 
            // lb_last_name
            // 
            this.lb_last_name.AutoSize = true;
            this.lb_last_name.Location = new System.Drawing.Point(38, 125);
            this.lb_last_name.Name = "lb_last_name";
            this.lb_last_name.Size = new System.Drawing.Size(59, 13);
            this.lb_last_name.TabIndex = 7;
            this.lb_last_name.Text = "Last name:";
            // 
            // lb_office
            // 
            this.lb_office.AutoSize = true;
            this.lb_office.Location = new System.Drawing.Point(38, 167);
            this.lb_office.Name = "lb_office";
            this.lb_office.Size = new System.Drawing.Size(38, 13);
            this.lb_office.TabIndex = 9;
            this.lb_office.Text = "Office:";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Location = new System.Drawing.Point(44, 216);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(32, 13);
            this.lb_role.TabIndex = 10;
            this.lb_role.Text = "Role:";
            // 
            // radiobtn_admin
            // 
            this.radiobtn_admin.AutoSize = true;
            this.radiobtn_admin.Location = new System.Drawing.Point(119, 237);
            this.radiobtn_admin.Name = "radiobtn_admin";
            this.radiobtn_admin.Size = new System.Drawing.Size(85, 17);
            this.radiobtn_admin.TabIndex = 11;
            this.radiobtn_admin.TabStop = true;
            this.radiobtn_admin.Text = "Administrator";
            this.radiobtn_admin.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(149, 293);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ChangeRoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 341);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.radiobtn_admin);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.lb_office);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.lb_last_name);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.lb_first_name);
            this.Controls.Add(this.radiobtn_user);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cmb_offices);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_email);
            this.Name = "ChangeRoleWindow";
            this.Text = "Edit Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox cmb_offices;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.RadioButton radiobtn_user;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.Label lb_first_name;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.Label lb_last_name;
        private System.Windows.Forms.Label lb_office;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.RadioButton radiobtn_admin;
        private System.Windows.Forms.Button btn_cancel;
    }
}