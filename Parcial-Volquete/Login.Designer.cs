namespace Parcial_Volquete
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            lblLogin = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnAcceder = new Button();
            linkPassword = new LinkLabel();
            btnExit = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(122, 0, 204);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 119);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(72, 251);
            label1.Name = "label1";
            label1.Size = new Size(200, 2);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(72, 312);
            label2.Name = "label2";
            label2.Size = new Size(200, 2);
            label2.TabIndex = 2;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(70, 70, 70);
            lblLogin.Location = new Point(114, 139);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(115, 36);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += lblLogin_Click;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(15, 15, 15);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.FromArgb(70, 70, 70);
            txtUser.Location = new Point(72, 220);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(200, 25);
            txtUser.TabIndex = 1;
            txtUser.Text = "Usuario";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(70, 70, 70);
            txtPassword.Location = new Point(72, 281);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 25);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Contraseña";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(70, 70, 70);
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcceder.ForeColor = Color.LightGray;
            btnAcceder.Location = new Point(72, 357);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(200, 30);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // linkPassword
            // 
            linkPassword.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkPassword.AutoSize = true;
            linkPassword.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkPassword.LinkColor = Color.DimGray;
            linkPassword.Location = new Point(81, 399);
            linkPassword.Name = "linkPassword";
            linkPassword.Size = new Size(174, 16);
            linkPassword.TabIndex = 0;
            linkPassword.TabStop = true;
            linkPassword.Text = "¿Ha olvidado su contraseña?";
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(318, 125);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 24);
            btnExit.TabIndex = 6;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(355, 438);
            Controls.Add(btnExit);
            Controls.Add(linkPassword);
            Controls.Add(btnAcceder);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lblLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            MouseDown += Login_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label lblLogin;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnAcceder;
        private LinkLabel linkPassword;
        private Button btnExit;
    }
}