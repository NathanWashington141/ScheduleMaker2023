namespace Final_Project
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
            this.tcLogin = new System.Windows.Forms.TabControl();
            this.tpSign = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtPasswordAgain = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tcLogin.SuspendLayout();
            this.tpSign.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLogin
            // 
            this.tcLogin.Controls.Add(this.tpSign);
            this.tcLogin.Controls.Add(this.tpLogin);
            this.tcLogin.Location = new System.Drawing.Point(9, 10);
            this.tcLogin.Name = "tcLogin";
            this.tcLogin.SelectedIndex = 0;
            this.tcLogin.Size = new System.Drawing.Size(798, 445);
            this.tcLogin.TabIndex = 0;
            // 
            // tpSign
            // 
            this.tpSign.Controls.Add(this.lblError);
            this.tpSign.Controls.Add(this.txtLast);
            this.tpSign.Controls.Add(this.txtFirst);
            this.tpSign.Controls.Add(this.txtPasswordAgain);
            this.tpSign.Controls.Add(this.txtPassword1);
            this.tpSign.Controls.Add(this.txtEmail);
            this.tpSign.Controls.Add(this.btnSubmit);
            this.tpSign.Controls.Add(this.label5);
            this.tpSign.Controls.Add(this.label4);
            this.tpSign.Controls.Add(this.label3);
            this.tpSign.Controls.Add(this.label2);
            this.tpSign.Controls.Add(this.label1);
            this.tpSign.Location = new System.Drawing.Point(4, 24);
            this.tpSign.Name = "tpSign";
            this.tpSign.Padding = new System.Windows.Forms.Padding(3);
            this.tpSign.Size = new System.Drawing.Size(790, 417);
            this.tpSign.TabIndex = 0;
            this.tpSign.Text = "Sign Up";
            this.tpSign.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(293, 373);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 11;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(292, 288);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(161, 23);
            this.txtLast.TabIndex = 10;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(292, 222);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(161, 23);
            this.txtFirst.TabIndex = 9;
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.Location = new System.Drawing.Point(292, 168);
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.Size = new System.Drawing.Size(161, 23);
            this.txtPasswordAgain.TabIndex = 8;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(292, 109);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(161, 23);
            this.txtPassword1.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(292, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(292, 328);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Password Again";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.lblLoginError);
            this.tpLogin.Controls.Add(this.label8);
            this.tpLogin.Controls.Add(this.label7);
            this.tpLogin.Controls.Add(this.txtPassword2);
            this.tpLogin.Controls.Add(this.txtUsername);
            this.tpLogin.Controls.Add(this.btnLogin);
            this.tpLogin.Controls.Add(this.label6);
            this.tpLogin.Location = new System.Drawing.Point(4, 24);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(790, 417);
            this.tpLogin.TabIndex = 1;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
            this.lblLoginError.Location = new System.Drawing.Point(332, 310);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(0, 15);
            this.lblLoginError.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(315, 187);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(146, 23);
            this.txtPassword2.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(315, 122);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(332, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Please Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 467);
            this.Controls.Add(this.tcLogin);
            this.Name = "Form1";
            this.Text = "Login";
            this.tcLogin.ResumeLayout(false);
            this.tpSign.ResumeLayout(false);
            this.tpSign.PerformLayout();
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcLogin;
        private TabPage tpSign;
        private TabPage tpLogin;
        private TextBox txtLast;
        private TextBox txtFirst;
        private TextBox txtPasswordAgain;
        private TextBox txtPassword1;
        private TextBox txtEmail;
        private Button btnSubmit;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private TextBox txtPassword2;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label label6;
        private Label lblError;
        private Label lblLoginError;
    }
}