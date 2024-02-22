namespace Parcial_Volquete
{
    partial class EnviarMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarMensaje));
            lblNombreUsuario = new Label();
            lblTo = new Label();
            richTextBox = new RichTextBox();
            btnEnviar = new Button();
            btnExit = new Button();
            comboBox = new ComboBox();
            SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.DarkOrange;
            lblNombreUsuario.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(26, 16);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(74, 22);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Usuario";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.BackColor = Color.DarkOrange;
            lblTo.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTo.Location = new Point(160, 15);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(48, 22);
            lblTo.TabIndex = 1;
            lblTo.Text = "Para";
            // 
            // richTextBox
            // 
            richTextBox.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox.Location = new Point(26, 57);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(377, 193);
            richTextBox.TabIndex = 3;
            richTextBox.Text = "";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.DarkOrange;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.ForeColor = Color.Black;
            btnEnviar.Location = new Point(106, 264);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(200, 30);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(403, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 24);
            btnExit.TabIndex = 7;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(250, 15);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 23);
            comboBox.TabIndex = 8;
            // 
            // EnviarMensaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(440, 306);
            Controls.Add(comboBox);
            Controls.Add(btnExit);
            Controls.Add(btnEnviar);
            Controls.Add(richTextBox);
            Controls.Add(lblTo);
            Controls.Add(lblNombreUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnviarMensaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnviarMensaje";
            Load += EnviarMensaje_Load;
            MouseDown += EnviarMensaje_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreUsuario;
        private Label lblTo;
        private RichTextBox richTextBox;
        private Button btnEnviar;
        private Button btnExit;
        private ComboBox comboBox;
    }
}