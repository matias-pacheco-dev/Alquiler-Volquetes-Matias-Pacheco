namespace Parcial_Volquete
{
    partial class VentanaEliminarUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEliminarUsuario));
            button1 = new Button();
            lblIngreseIdDB = new Label();
            txtIdDB = new TextBox();
            btnConfirmar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(165, -2);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblIngreseIdDB
            // 
            lblIngreseIdDB.AutoSize = true;
            lblIngreseIdDB.BackColor = Color.Silver;
            lblIngreseIdDB.FlatStyle = FlatStyle.Flat;
            lblIngreseIdDB.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngreseIdDB.Location = new Point(12, 30);
            lblIngreseIdDB.Name = "lblIngreseIdDB";
            lblIngreseIdDB.Size = new Size(168, 17);
            lblIngreseIdDB.TabIndex = 1;
            lblIngreseIdDB.Text = "Ingrese IdDB del usuario";
            // 
            // txtIdDB
            // 
            txtIdDB.BackColor = Color.DarkOrange;
            txtIdDB.BorderStyle = BorderStyle.None;
            txtIdDB.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdDB.Location = new Point(44, 85);
            txtIdDB.Name = "txtIdDB";
            txtIdDB.Size = new Size(100, 17);
            txtIdDB.TabIndex = 2;
            txtIdDB.KeyPress += txtIdDB_KeyPress;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.DimGray;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.Black;
            btnConfirmar.Location = new Point(44, 129);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 29);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // VentanaEliminarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(199, 188);
            Controls.Add(btnConfirmar);
            Controls.Add(txtIdDB);
            Controls.Add(lblIngreseIdDB);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaEliminarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana Eliminar Usuario";
            Load += VentanaEliminarUsuario_Load;
            MouseDown += VentanaEliminarUsuario_MouseDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblIngreseIdDB;
        private TextBox txtIdDB;
        private Button btnConfirmar;
        private ErrorProvider errorProvider1;
    }
}