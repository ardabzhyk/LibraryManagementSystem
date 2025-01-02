namespace LibraryManagementSystem__
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            buttonLogin = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.WindowText;
            buttonLogin.Font = new Font("Bell MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.Control;
            buttonLogin.Location = new Point(278, 223);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(108, 31);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(261, 108);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(173, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(261, 164);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(173, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(114, 106);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 3;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(120, 164);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Info;
            ClientSize = new Size(691, 416);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            Text = "Library Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
    }
}
