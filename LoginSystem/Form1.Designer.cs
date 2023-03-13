namespace LoginSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            signupPanel = new Panel();
            sErrorLbl = new Label();
            loginPanel = new Panel();
            lErrorbl = new Label();
            loginlink = new Label();
            label2 = new Label();
            label1 = new Label();
            loginBtn = new Button();
            panel4 = new Panel();
            passwordTxt = new TextBox();
            panel3 = new Panel();
            emailTxt = new TextBox();
            panel9 = new Panel();
            sEmailTxt = new TextBox();
            panel8 = new Panel();
            sPasswordTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            signupBtn = new Button();
            panel6 = new Panel();
            sPasswordCTxt = new TextBox();
            panel7 = new Panel();
            sNameTxt = new TextBox();
            panel1.SuspendLayout();
            signupPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(signupPanel);
            panel1.Controls.Add(loginPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // signupPanel
            // 
            signupPanel.BackColor = Color.FromArgb(5, 18, 37);
            signupPanel.Controls.Add(sErrorLbl);
            signupPanel.Controls.Add(panel9);
            signupPanel.Controls.Add(sEmailTxt);
            signupPanel.Controls.Add(panel8);
            signupPanel.Controls.Add(sPasswordTxt);
            signupPanel.Controls.Add(label3);
            signupPanel.Controls.Add(label4);
            signupPanel.Controls.Add(label5);
            signupPanel.Controls.Add(signupBtn);
            signupPanel.Controls.Add(panel6);
            signupPanel.Controls.Add(sPasswordCTxt);
            signupPanel.Controls.Add(panel7);
            signupPanel.Controls.Add(sNameTxt);
            signupPanel.Location = new Point(337, 27);
            signupPanel.Name = "signupPanel";
            signupPanel.Size = new Size(268, 336);
            signupPanel.TabIndex = 1;
            // 
            // sErrorLbl
            // 
            sErrorLbl.AutoSize = true;
            sErrorLbl.ForeColor = Color.Brown;
            sErrorLbl.Location = new Point(64, 39);
            sErrorLbl.Name = "sErrorLbl";
            sErrorLbl.Size = new Size(81, 15);
            sErrorLbl.TabIndex = 12;
            sErrorLbl.Text = "error message";
            sErrorLbl.Visible = false;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.FromArgb(5, 18, 37);
            loginPanel.Controls.Add(lErrorbl);
            loginPanel.Controls.Add(loginlink);
            loginPanel.Controls.Add(label2);
            loginPanel.Controls.Add(label1);
            loginPanel.Controls.Add(loginBtn);
            loginPanel.Controls.Add(panel4);
            loginPanel.Controls.Add(passwordTxt);
            loginPanel.Controls.Add(panel3);
            loginPanel.Controls.Add(emailTxt);
            loginPanel.Location = new Point(371, 53);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(234, 289);
            loginPanel.TabIndex = 0;
            loginPanel.Paint += panel2_Paint;
            // 
            // lErrorbl
            // 
            lErrorbl.AutoSize = true;
            lErrorbl.ForeColor = Color.Brown;
            lErrorbl.Location = new Point(83, 42);
            lErrorbl.Name = "lErrorbl";
            lErrorbl.Size = new Size(81, 15);
            lErrorbl.TabIndex = 13;
            lErrorbl.Text = "error message";
            lErrorbl.Visible = false;
            lErrorbl.Click += label6_Click;
            // 
            // loginlink
            // 
            loginlink.AutoSize = true;
            loginlink.ForeColor = Color.FromArgb(128, 128, 255);
            loginlink.Location = new Point(165, 231);
            loginlink.Name = "loginlink";
            loginlink.Size = new Size(47, 15);
            loginlink.TabIndex = 7;
            loginlink.Text = "Sign up";
            loginlink.Click += loginlink_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(11, 226);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 6;
            label2.Text = "Not have an account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(83, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 5;
            label1.Text = "Sign In";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Teal;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.GhostWhite;
            loginBtn.Location = new Point(44, 178);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(154, 32);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Location = new Point(44, 158);
            panel4.Name = "panel4";
            panel4.Size = new Size(169, 1);
            panel4.TabIndex = 3;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.FromArgb(5, 18, 37);
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxt.Location = new Point(44, 127);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Size = new Size(170, 25);
            passwordTxt.TabIndex = 2;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(43, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(169, 1);
            panel3.TabIndex = 1;
            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.FromArgb(5, 18, 37);
            emailTxt.BorderStyle = BorderStyle.None;
            emailTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            emailTxt.Location = new Point(43, 72);
            emailTxt.Name = "emailTxt";
            emailTxt.PlaceholderText = "Email";
            emailTxt.Size = new Size(170, 25);
            emailTxt.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Gray;
            panel9.Location = new Point(42, 150);
            panel9.Name = "panel9";
            panel9.Size = new Size(169, 1);
            panel9.TabIndex = 11;
            // 
            // sEmailTxt
            // 
            sEmailTxt.BackColor = Color.FromArgb(5, 18, 37);
            sEmailTxt.BorderStyle = BorderStyle.None;
            sEmailTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            sEmailTxt.ForeColor = SystemColors.Window;
            sEmailTxt.Location = new Point(42, 119);
            sEmailTxt.Name = "sEmailTxt";
            sEmailTxt.PlaceholderText = "Email";
            sEmailTxt.Size = new Size(170, 25);
            sEmailTxt.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gray;
            panel8.Location = new Point(42, 196);
            panel8.Name = "panel8";
            panel8.Size = new Size(169, 1);
            panel8.TabIndex = 9;
            // 
            // sPasswordTxt
            // 
            sPasswordTxt.BackColor = Color.FromArgb(5, 18, 37);
            sPasswordTxt.BorderStyle = BorderStyle.None;
            sPasswordTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            sPasswordTxt.ForeColor = SystemColors.Window;
            sPasswordTxt.Location = new Point(39, 165);
            sPasswordTxt.Name = "sPasswordTxt";
            sPasswordTxt.PlaceholderText = "Password";
            sPasswordTxt.Size = new Size(170, 25);
            sPasswordTxt.TabIndex = 8;
            sPasswordTxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(200, 292);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Sign in";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(11, 287);
            label4.Name = "label4";
            label4.Size = new Size(183, 21);
            label4.TabIndex = 6;
            label4.Text = "Already have an account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(86, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 5;
            label5.Text = "Sign Up";
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.Teal;
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.FlatStyle = FlatStyle.Flat;
            signupBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            signupBtn.ForeColor = Color.GhostWhite;
            signupBtn.Location = new Point(43, 247);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(154, 32);
            signupBtn.TabIndex = 4;
            signupBtn.Text = "Sign Up";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += signupBtn_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gray;
            panel6.Location = new Point(43, 234);
            panel6.Name = "panel6";
            panel6.Size = new Size(169, 1);
            panel6.TabIndex = 3;
            // 
            // sPasswordCTxt
            // 
            sPasswordCTxt.BackColor = Color.FromArgb(5, 18, 37);
            sPasswordCTxt.BorderStyle = BorderStyle.None;
            sPasswordCTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            sPasswordCTxt.ForeColor = SystemColors.Window;
            sPasswordCTxt.Location = new Point(42, 203);
            sPasswordCTxt.Name = "sPasswordCTxt";
            sPasswordCTxt.PlaceholderText = "Confirm Password";
            sPasswordCTxt.Size = new Size(170, 25);
            sPasswordCTxt.TabIndex = 2;
            sPasswordCTxt.UseSystemPasswordChar = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gray;
            panel7.Location = new Point(43, 103);
            panel7.Name = "panel7";
            panel7.Size = new Size(169, 1);
            panel7.TabIndex = 1;
            // 
            // sNameTxt
            // 
            sNameTxt.BackColor = Color.FromArgb(5, 18, 37);
            sNameTxt.BorderStyle = BorderStyle.None;
            sNameTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            sNameTxt.ForeColor = SystemColors.Window;
            sNameTxt.Location = new Point(43, 72);
            sNameTxt.Name = "sNameTxt";
            sNameTxt.PlaceholderText = "Full Name";
            sNameTxt.Size = new Size(170, 25);
            sNameTxt.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Welcome Screen";
            panel1.ResumeLayout(false);
            signupPanel.ResumeLayout(false);
            signupPanel.PerformLayout();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel loginPanel;
        private TextBox emailTxt;
        private Panel panel3;
        private Button loginBtn;
        private Panel panel4;
        private TextBox passwordTxt;
        private Label label1;
        private Label loginlink;
        private Label label2;
        private Panel signupPanel;
        private Panel panel9;
        private TextBox sEmailTxt;
        private Panel panel8;
        private TextBox sPasswordTxt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button signupBtn;
        private Panel panel6;
        private TextBox sPasswordCTxt;
        private Panel panel7;
        private TextBox sNameTxt;
        private Label sErrorLbl;
        private Label lErrorbl;
    }
}