namespace Report_Tracking_System___Practice_1
{
    partial class Menu
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
            this.tMenu = new System.Windows.Forms.TabControl();
            this.tRegister = new System.Windows.Forms.TabPage();
            this.chboxRShowPassword = new System.Windows.Forms.CheckBox();
            this.txtRPassword = new System.Windows.Forms.TextBox();
            this.txtRUsername = new System.Windows.Forms.TextBox();
            this.txtRSurname = new System.Windows.Forms.TextBox();
            this.txtRName = new System.Windows.Forms.TextBox();
            this.btnRCancel = new System.Windows.Forms.Button();
            this.btnRRegister = new System.Windows.Forms.Button();
            this.lRPassword = new System.Windows.Forms.Label();
            this.lRUsername = new System.Windows.Forms.Label();
            this.lRSurname = new System.Windows.Forms.Label();
            this.lRName = new System.Windows.Forms.Label();
            this.lRDetails = new System.Windows.Forms.Label();
            this.lRegister = new System.Windows.Forms.Label();
            this.tLogin = new System.Windows.Forms.TabPage();
            this.chboxLShowPassword = new System.Windows.Forms.CheckBox();
            this.txtLPassword = new System.Windows.Forms.TextBox();
            this.txtLUsername = new System.Windows.Forms.TextBox();
            this.btnLCancel = new System.Windows.Forms.Button();
            this.btnLLogin = new System.Windows.Forms.Button();
            this.lLPassword = new System.Windows.Forms.Label();
            this.lLUsername = new System.Windows.Forms.Label();
            this.lLDetails = new System.Windows.Forms.Label();
            this.lLLogin = new System.Windows.Forms.Label();
            this.tCreateReport = new System.Windows.Forms.TabPage();
            this.lCRDetails = new System.Windows.Forms.Label();
            this.lCRCreateReport = new System.Windows.Forms.Label();
            this.tMenu.SuspendLayout();
            this.tRegister.SuspendLayout();
            this.tLogin.SuspendLayout();
            this.tCreateReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tMenu
            // 
            this.tMenu.AccessibleName = "tMenu";
            this.tMenu.Controls.Add(this.tRegister);
            this.tMenu.Controls.Add(this.tLogin);
            this.tMenu.Controls.Add(this.tCreateReport);
            this.tMenu.Location = new System.Drawing.Point(4, 1);
            this.tMenu.Name = "tMenu";
            this.tMenu.SelectedIndex = 0;
            this.tMenu.Size = new System.Drawing.Size(797, 448);
            this.tMenu.TabIndex = 0;
            this.tMenu.Click += new System.EventHandler(this.tMenu_Click);
            // 
            // tRegister
            // 
            this.tRegister.AccessibleName = "tRegister";
            this.tRegister.Controls.Add(this.chboxRShowPassword);
            this.tRegister.Controls.Add(this.txtRPassword);
            this.tRegister.Controls.Add(this.txtRUsername);
            this.tRegister.Controls.Add(this.txtRSurname);
            this.tRegister.Controls.Add(this.txtRName);
            this.tRegister.Controls.Add(this.btnRCancel);
            this.tRegister.Controls.Add(this.btnRRegister);
            this.tRegister.Controls.Add(this.lRPassword);
            this.tRegister.Controls.Add(this.lRUsername);
            this.tRegister.Controls.Add(this.lRSurname);
            this.tRegister.Controls.Add(this.lRName);
            this.tRegister.Controls.Add(this.lRDetails);
            this.tRegister.Controls.Add(this.lRegister);
            this.tRegister.Location = new System.Drawing.Point(4, 29);
            this.tRegister.Name = "tRegister";
            this.tRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tRegister.Size = new System.Drawing.Size(789, 415);
            this.tRegister.TabIndex = 0;
            this.tRegister.Text = "Register";
            this.tRegister.UseVisualStyleBackColor = true;
            // 
            // chboxRShowPassword
            // 
            this.chboxRShowPassword.AccessibleName = "chboxRShowPassword";
            this.chboxRShowPassword.AutoSize = true;
            this.chboxRShowPassword.Location = new System.Drawing.Point(413, 209);
            this.chboxRShowPassword.Name = "chboxRShowPassword";
            this.chboxRShowPassword.Size = new System.Drawing.Size(148, 24);
            this.chboxRShowPassword.TabIndex = 12;
            this.chboxRShowPassword.Text = "Show Password";
            this.chboxRShowPassword.UseVisualStyleBackColor = true;
            this.chboxRShowPassword.CheckedChanged += new System.EventHandler(this.chboxRShowPassword_CheckedChanged);
            // 
            // txtRPassword
            // 
            this.txtRPassword.AccessibleName = "txtRPassword";
            this.txtRPassword.Location = new System.Drawing.Point(176, 207);
            this.txtRPassword.Name = "txtRPassword";
            this.txtRPassword.Size = new System.Drawing.Size(216, 26);
            this.txtRPassword.TabIndex = 11;
            this.txtRPassword.UseSystemPasswordChar = true;
            // 
            // txtRUsername
            // 
            this.txtRUsername.AccessibleName = "txtRUsername";
            this.txtRUsername.Location = new System.Drawing.Point(176, 172);
            this.txtRUsername.Name = "txtRUsername";
            this.txtRUsername.Size = new System.Drawing.Size(216, 26);
            this.txtRUsername.TabIndex = 10;
            // 
            // txtRSurname
            // 
            this.txtRSurname.AccessibleName = "txtRSurname";
            this.txtRSurname.Location = new System.Drawing.Point(176, 135);
            this.txtRSurname.Name = "txtRSurname";
            this.txtRSurname.Size = new System.Drawing.Size(216, 26);
            this.txtRSurname.TabIndex = 9;
            // 
            // txtRName
            // 
            this.txtRName.AccessibleName = "txtRName";
            this.txtRName.Location = new System.Drawing.Point(176, 99);
            this.txtRName.Name = "txtRName";
            this.txtRName.Size = new System.Drawing.Size(216, 26);
            this.txtRName.TabIndex = 8;
            // 
            // btnRCancel
            // 
            this.btnRCancel.AccessibleName = "btnRCancel";
            this.btnRCancel.BackColor = System.Drawing.Color.LightBlue;
            this.btnRCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRCancel.Location = new System.Drawing.Point(310, 265);
            this.btnRCancel.Name = "btnRCancel";
            this.btnRCancel.Size = new System.Drawing.Size(128, 45);
            this.btnRCancel.TabIndex = 7;
            this.btnRCancel.Text = "Cancel";
            this.btnRCancel.UseVisualStyleBackColor = false;
            // 
            // btnRRegister
            // 
            this.btnRRegister.AccessibleName = "btnRRegister";
            this.btnRRegister.BackColor = System.Drawing.Color.LightBlue;
            this.btnRRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRRegister.Location = new System.Drawing.Point(146, 265);
            this.btnRRegister.Name = "btnRRegister";
            this.btnRRegister.Size = new System.Drawing.Size(128, 45);
            this.btnRRegister.TabIndex = 6;
            this.btnRRegister.Text = "Register";
            this.btnRRegister.UseVisualStyleBackColor = false;
            this.btnRRegister.Click += new System.EventHandler(this.btnRRegister_Click);
            // 
            // lRPassword
            // 
            this.lRPassword.AccessibleName = "lRPassword";
            this.lRPassword.AutoSize = true;
            this.lRPassword.Location = new System.Drawing.Point(55, 213);
            this.lRPassword.Name = "lRPassword";
            this.lRPassword.Size = new System.Drawing.Size(82, 20);
            this.lRPassword.TabIndex = 5;
            this.lRPassword.Text = "Password:";
            // 
            // lRUsername
            // 
            this.lRUsername.AccessibleName = "lRUsername";
            this.lRUsername.AutoSize = true;
            this.lRUsername.Location = new System.Drawing.Point(55, 172);
            this.lRUsername.Name = "lRUsername";
            this.lRUsername.Size = new System.Drawing.Size(87, 20);
            this.lRUsername.TabIndex = 4;
            this.lRUsername.Text = "Username:";
            // 
            // lRSurname
            // 
            this.lRSurname.AccessibleName = "lRSurname";
            this.lRSurname.AutoSize = true;
            this.lRSurname.Location = new System.Drawing.Point(55, 135);
            this.lRSurname.Name = "lRSurname";
            this.lRSurname.Size = new System.Drawing.Size(78, 20);
            this.lRSurname.TabIndex = 3;
            this.lRSurname.Text = "Surname:";
            // 
            // lRName
            // 
            this.lRName.AccessibleName = "lRName";
            this.lRName.AutoSize = true;
            this.lRName.Location = new System.Drawing.Point(55, 99);
            this.lRName.Name = "lRName";
            this.lRName.Size = new System.Drawing.Size(55, 20);
            this.lRName.TabIndex = 2;
            this.lRName.Text = "Name:";
            // 
            // lRDetails
            // 
            this.lRDetails.AccessibleName = "lRDetails";
            this.lRDetails.AutoSize = true;
            this.lRDetails.Location = new System.Drawing.Point(51, 62);
            this.lRDetails.Name = "lRDetails";
            this.lRDetails.Size = new System.Drawing.Size(259, 20);
            this.lRDetails.TabIndex = 1;
            this.lRDetails.Text = "Pleas enter your details to Register:";
            // 
            // lRegister
            // 
            this.lRegister.AccessibleName = "lRegister";
            this.lRegister.AutoSize = true;
            this.lRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRegister.Location = new System.Drawing.Point(22, 22);
            this.lRegister.Name = "lRegister";
            this.lRegister.Size = new System.Drawing.Size(83, 25);
            this.lRegister.TabIndex = 0;
            this.lRegister.Text = "Register";
            // 
            // tLogin
            // 
            this.tLogin.AccessibleName = "tLogin";
            this.tLogin.Controls.Add(this.chboxLShowPassword);
            this.tLogin.Controls.Add(this.txtLPassword);
            this.tLogin.Controls.Add(this.txtLUsername);
            this.tLogin.Controls.Add(this.btnLCancel);
            this.tLogin.Controls.Add(this.btnLLogin);
            this.tLogin.Controls.Add(this.lLPassword);
            this.tLogin.Controls.Add(this.lLUsername);
            this.tLogin.Controls.Add(this.lLDetails);
            this.tLogin.Controls.Add(this.lLLogin);
            this.tLogin.Location = new System.Drawing.Point(4, 29);
            this.tLogin.Name = "tLogin";
            this.tLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tLogin.Size = new System.Drawing.Size(789, 415);
            this.tLogin.TabIndex = 1;
            this.tLogin.Text = "Login";
            this.tLogin.UseVisualStyleBackColor = true;
            // 
            // chboxLShowPassword
            // 
            this.chboxLShowPassword.AccessibleName = "chboxLShowPassword";
            this.chboxLShowPassword.AutoSize = true;
            this.chboxLShowPassword.Location = new System.Drawing.Point(430, 129);
            this.chboxLShowPassword.Name = "chboxLShowPassword";
            this.chboxLShowPassword.Size = new System.Drawing.Size(148, 24);
            this.chboxLShowPassword.TabIndex = 21;
            this.chboxLShowPassword.Text = "Show Password";
            this.chboxLShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtLPassword
            // 
            this.txtLPassword.AccessibleName = "txtLPassword";
            this.txtLPassword.Location = new System.Drawing.Point(193, 127);
            this.txtLPassword.Name = "txtLPassword";
            this.txtLPassword.Size = new System.Drawing.Size(216, 26);
            this.txtLPassword.TabIndex = 20;
            this.txtLPassword.UseSystemPasswordChar = true;
            // 
            // txtLUsername
            // 
            this.txtLUsername.AccessibleName = "txtLUsername";
            this.txtLUsername.Location = new System.Drawing.Point(193, 92);
            this.txtLUsername.Name = "txtLUsername";
            this.txtLUsername.Size = new System.Drawing.Size(216, 26);
            this.txtLUsername.TabIndex = 19;
            // 
            // btnLCancel
            // 
            this.btnLCancel.AccessibleName = "btnLCancel";
            this.btnLCancel.BackColor = System.Drawing.Color.LightBlue;
            this.btnLCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLCancel.Location = new System.Drawing.Point(327, 185);
            this.btnLCancel.Name = "btnLCancel";
            this.btnLCancel.Size = new System.Drawing.Size(128, 45);
            this.btnLCancel.TabIndex = 18;
            this.btnLCancel.Text = "Cancel";
            this.btnLCancel.UseVisualStyleBackColor = false;
            // 
            // btnLLogin
            // 
            this.btnLLogin.AccessibleName = "btnLLogin";
            this.btnLLogin.BackColor = System.Drawing.Color.LightBlue;
            this.btnLLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLLogin.Location = new System.Drawing.Point(163, 185);
            this.btnLLogin.Name = "btnLLogin";
            this.btnLLogin.Size = new System.Drawing.Size(128, 45);
            this.btnLLogin.TabIndex = 17;
            this.btnLLogin.Text = "Login";
            this.btnLLogin.UseVisualStyleBackColor = false;
            // 
            // lLPassword
            // 
            this.lLPassword.AccessibleName = "lLPassword";
            this.lLPassword.AutoSize = true;
            this.lLPassword.Location = new System.Drawing.Point(72, 133);
            this.lLPassword.Name = "lLPassword";
            this.lLPassword.Size = new System.Drawing.Size(82, 20);
            this.lLPassword.TabIndex = 16;
            this.lLPassword.Text = "Password:";
            // 
            // lLUsername
            // 
            this.lLUsername.AccessibleName = "lLUsername";
            this.lLUsername.AutoSize = true;
            this.lLUsername.Location = new System.Drawing.Point(72, 92);
            this.lLUsername.Name = "lLUsername";
            this.lLUsername.Size = new System.Drawing.Size(87, 20);
            this.lLUsername.TabIndex = 15;
            this.lLUsername.Text = "Username:";
            // 
            // lLDetails
            // 
            this.lLDetails.AccessibleName = "lLDetails";
            this.lLDetails.AutoSize = true;
            this.lLDetails.Location = new System.Drawing.Point(56, 58);
            this.lLDetails.Name = "lLDetails";
            this.lLDetails.Size = new System.Drawing.Size(238, 20);
            this.lLDetails.TabIndex = 14;
            this.lLDetails.Text = "Pleas enter your details to Login:";
            // 
            // lLLogin
            // 
            this.lLLogin.AccessibleName = "lLLogin";
            this.lLLogin.AutoSize = true;
            this.lLLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLLogin.Location = new System.Drawing.Point(27, 18);
            this.lLLogin.Name = "lLLogin";
            this.lLLogin.Size = new System.Drawing.Size(60, 25);
            this.lLLogin.TabIndex = 13;
            this.lLLogin.Text = "Login";
            // 
            // tCreateReport
            // 
            this.tCreateReport.AccessibleName = "tCreateReport";
            this.tCreateReport.Controls.Add(this.lCRDetails);
            this.tCreateReport.Controls.Add(this.lCRCreateReport);
            this.tCreateReport.Location = new System.Drawing.Point(4, 29);
            this.tCreateReport.Name = "tCreateReport";
            this.tCreateReport.Padding = new System.Windows.Forms.Padding(3);
            this.tCreateReport.Size = new System.Drawing.Size(789, 415);
            this.tCreateReport.TabIndex = 2;
            this.tCreateReport.Text = "Create A Report ";
            this.tCreateReport.UseVisualStyleBackColor = true;
            // 
            // lCRDetails
            // 
            this.lCRDetails.AccessibleName = "lCRDetails";
            this.lCRDetails.AutoSize = true;
            this.lCRDetails.Location = new System.Drawing.Point(48, 53);
            this.lCRDetails.Name = "lCRDetails";
            this.lCRDetails.Size = new System.Drawing.Size(278, 20);
            this.lCRDetails.TabIndex = 1;
            this.lCRDetails.Text = "Please enter the New Report\'s details:";
            // 
            // lCRCreateReport
            // 
            this.lCRCreateReport.AccessibleName = "tCreateReport";
            this.lCRCreateReport.AutoSize = true;
            this.lCRCreateReport.Location = new System.Drawing.Point(33, 19);
            this.lCRCreateReport.Name = "lCRCreateReport";
            this.lCRCreateReport.Size = new System.Drawing.Size(145, 20);
            this.lCRCreateReport.TabIndex = 0;
            this.lCRCreateReport.Text = "Create New Report";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.tMenu.ResumeLayout(false);
            this.tRegister.ResumeLayout(false);
            this.tRegister.PerformLayout();
            this.tLogin.ResumeLayout(false);
            this.tLogin.PerformLayout();
            this.tCreateReport.ResumeLayout(false);
            this.tCreateReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tMenu;
        private System.Windows.Forms.TabPage tRegister;
        private System.Windows.Forms.TabPage tLogin;
        private System.Windows.Forms.Label lRegister;
        private System.Windows.Forms.Label lRDetails;
        private System.Windows.Forms.Label lRName;
        private System.Windows.Forms.Label lRSurname;
        private System.Windows.Forms.Label lRUsername;
        private System.Windows.Forms.Label lRPassword;
        private System.Windows.Forms.Button btnRCancel;
        private System.Windows.Forms.Button btnRRegister;
        private System.Windows.Forms.CheckBox chboxRShowPassword;
        private System.Windows.Forms.TextBox txtRPassword;
        private System.Windows.Forms.TextBox txtRUsername;
        private System.Windows.Forms.TextBox txtRSurname;
        private System.Windows.Forms.TextBox txtRName;
        private System.Windows.Forms.CheckBox chboxLShowPassword;
        private System.Windows.Forms.TextBox txtLPassword;
        private System.Windows.Forms.TextBox txtLUsername;
        private System.Windows.Forms.Button btnLCancel;
        private System.Windows.Forms.Button btnLLogin;
        private System.Windows.Forms.Label lLPassword;
        private System.Windows.Forms.Label lLUsername;
        private System.Windows.Forms.Label lLDetails;
        private System.Windows.Forms.Label lLLogin;
        private System.Windows.Forms.TabPage tCreateReport;
        private System.Windows.Forms.Label lCRCreateReport;
        private System.Windows.Forms.Label lCRDetails;
    }
}

