namespace Parcial_Volquete
{
    partial class VentanaEmergente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEmergente));
            lblTitulo = new Label();
            lblMensaje = new Label();
            btnAcceder = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.LightGray;
            lblTitulo.Location = new Point(86, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(54, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "titulo";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.ForeColor = Color.LightGray;
            lblMensaje.Location = new Point(12, 50);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(40, 22);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "msj";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.SlateBlue;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcceder.ForeColor = Color.LightGray;
            btnAcceder.Location = new Point(61, 115);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(134, 41);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Aceptar";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // VentanaEmergente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(122, 0, 204);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(263, 168);
            Controls.Add(btnAcceder);
            Controls.Add(lblMensaje);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaEmergente";
            StartPosition = FormStartPosition.CenterScreen;
            Load += VentanaEmergente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblMensaje;
        private Button btnAcceder;
    }
}