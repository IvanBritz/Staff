namespace Staff
{
    partial class AddForm
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
            label2 = new Label();
            label3 = new Label();
            lbUsername = new Label();
            lbPassworld = new Label();
            tbStaffName = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            cbRole = new ComboBox();
            button1 = new Button();
            tbBaseSalary = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 101);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Staff Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 66);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(39, 162);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(70, 20);
            lbUsername.TabIndex = 4;
            lbUsername.Text = "Username";
            // 
            // lbPassworld
            // 
            lbPassworld.AutoSize = true;
            lbPassworld.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassworld.Location = new Point(39, 200);
            lbPassworld.Name = "lbPassworld";
            lbPassworld.Size = new Size(68, 20);
            lbPassworld.TabIndex = 5;
            lbPassworld.Text = "Password";
            // 
            // tbStaffName
            // 
            tbStaffName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStaffName.Location = new Point(115, 95);
            tbStaffName.Name = "tbStaffName";
            tbStaffName.Size = new Size(132, 26);
            tbStaffName.TabIndex = 6;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(115, 159);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(132, 26);
            tbUsername.TabIndex = 7;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(115, 197);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '•';
            tbPassword.Size = new Size(132, 26);
            tbPassword.TabIndex = 8;
            // 
            // cbRole
            // 
            cbRole.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(115, 61);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(132, 28);
            cbRole.TabIndex = 10;
            cbRole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(115, 239);
            button1.Name = "button1";
            button1.Size = new Size(82, 36);
            button1.TabIndex = 11;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbBaseSalary
            // 
            tbBaseSalary.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBaseSalary.Location = new Point(115, 127);
            tbBaseSalary.Name = "tbBaseSalary";
            tbBaseSalary.Size = new Size(132, 26);
            tbBaseSalary.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 133);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 12;
            label4.Text = "Base Salary";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 287);
            Controls.Add(tbBaseSalary);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(cbRole);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbStaffName);
            Controls.Add(lbPassworld);
            Controls.Add(lbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbUsername;
        private Label lbPassworld;
        private TextBox tbStaffName;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private ComboBox cbRole;
        private Button button1;
        private TextBox tbBaseSalary;
        private Label label4;
    }
}