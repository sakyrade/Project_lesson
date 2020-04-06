namespace AMONIC_Airlines
{
    partial class AddUserWindow
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
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_first_name = new System.Windows.Forms.Label();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.lb_last_name = new System.Windows.Forms.Label();
            this.lb_offices = new System.Windows.Forms.Label();
            this.txt_birthdate = new System.Windows.Forms.TextBox();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(35, 43);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(75, 13);
            this.lb_email.TabIndex = 0;
            this.lb_email.Text = "Email address:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(116, 40);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(134, 20);
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
            this.cmb_offices.Location = new System.Drawing.Point(116, 156);
            this.cmb_offices.Name = "cmb_offices";
            this.cmb_offices.Size = new System.Drawing.Size(134, 21);
            this.cmb_offices.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(48, 290);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_first_name
            // 
            this.lb_first_name.AutoSize = true;
            this.lb_first_name.Location = new System.Drawing.Point(35, 82);
            this.lb_first_name.Name = "lb_first_name";
            this.lb_first_name.Size = new System.Drawing.Size(58, 13);
            this.lb_first_name.TabIndex = 4;
            this.lb_first_name.Text = "First name:";
            // 
            // txt_first_name
            // 
            this.txt_first_name.Location = new System.Drawing.Point(116, 79);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(134, 20);
            this.txt_first_name.TabIndex = 5;
            // 
            // txt_last_name
            // 
            this.txt_last_name.Location = new System.Drawing.Point(116, 117);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(134, 20);
            this.txt_last_name.TabIndex = 7;
            // 
            // lb_last_name
            // 
            this.lb_last_name.AutoSize = true;
            this.lb_last_name.Location = new System.Drawing.Point(35, 120);
            this.lb_last_name.Name = "lb_last_name";
            this.lb_last_name.Size = new System.Drawing.Size(59, 13);
            this.lb_last_name.TabIndex = 6;
            this.lb_last_name.Text = "Last name:";
            // 
            // lb_offices
            // 
            this.lb_offices.AutoSize = true;
            this.lb_offices.Location = new System.Drawing.Point(35, 159);
            this.lb_offices.Name = "lb_offices";
            this.lb_offices.Size = new System.Drawing.Size(38, 13);
            this.lb_offices.TabIndex = 8;
            this.lb_offices.Text = "Office:";
            // 
            // txt_birthdate
            // 
            this.txt_birthdate.Location = new System.Drawing.Point(116, 195);
            this.txt_birthdate.Name = "txt_birthdate";
            this.txt_birthdate.Size = new System.Drawing.Size(134, 20);
            this.txt_birthdate.TabIndex = 10;
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.Location = new System.Drawing.Point(35, 198);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(52, 13);
            this.lb_birthdate.TabIndex = 9;
            this.lb_birthdate.Text = "Birthdate:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(116, 231);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(134, 20);
            this.txt_password.TabIndex = 12;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(35, 234);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(56, 13);
            this.lb_password.TabIndex = 11;
            this.lb_password.Text = "Password:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(148, 290);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 339);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.txt_birthdate);
            this.Controls.Add(this.lb_birthdate);
            this.Controls.Add(this.lb_offices);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.lb_last_name);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.lb_first_name);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_offices);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_email);
            this.Name = "AddUserWindow";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox cmb_offices;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lb_first_name;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.Label lb_last_name;
        private System.Windows.Forms.Label lb_offices;
        private System.Windows.Forms.TextBox txt_birthdate;
        private System.Windows.Forms.Label lb_birthdate;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_cancel;
    }
}