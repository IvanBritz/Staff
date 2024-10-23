namespace Staff
{
    partial class StaffDetailsForm
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
            label1 = new Label();
            lblStaffID = new Label();
            lblStaffName = new Label();
            lblRoleName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            label2 = new Label();
            lbAccount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 25);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Information";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffID.Location = new Point(28, 62);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(50, 20);
            lblStaffID.TabIndex = 1;
            lblStaffID.Text = "Staff ID";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffName.Location = new Point(28, 100);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(73, 20);
            lblStaffName.TabIndex = 2;
            lblStaffName.Text = "Staff Name";
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleName.Location = new Point(28, 137);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(74, 20);
            lblRoleName.TabIndex = 3;
            lblRoleName.Text = "Role name";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(28, 196);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(84, 20);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "lblUsername";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(28, 226);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(68, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(297, 9);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 6;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // lbAccount
            // 
            lbAccount.AutoSize = true;
            lbAccount.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAccount.Location = new Point(127, 173);
            lbAccount.Name = "lbAccount";
            lbAccount.Size = new Size(60, 20);
            lbAccount.TabIndex = 7;
            lbAccount.Text = "Account";
            // 
            // StaffDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 281);
            Controls.Add(lbAccount);
            Controls.Add(label2);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblRoleName);
            Controls.Add(lblStaffName);
            Controls.Add(lblStaffID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDetailsForm";
            Load += StaffDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStaffID;
        private Label lblStaffName;
        private Label lblRoleName;
        private Label lblUsername;
        private Label lblPassword;
        private Label label2;
        private Label lbAccount;
    }
}