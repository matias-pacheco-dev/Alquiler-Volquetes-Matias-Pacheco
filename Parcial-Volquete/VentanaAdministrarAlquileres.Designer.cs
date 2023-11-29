namespace Parcial_Volquete
{
    partial class VentanaAdministrarAlquileres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAdministrarAlquileres));
            btnVaciarVolquetes = new Button();
            txtVaciarVolquetes = new TextBox();
            btnEliminarAlquiler = new Button();
            txtEliminarAlquiler = new TextBox();
            errorVaciarVolquetes = new ErrorProvider(components);
            btnCerrar = new Button();
            errorEliminarAlquiler = new ErrorProvider(components);
            lblIngresa = new Label();
            ((System.ComponentModel.ISupportInitialize)errorVaciarVolquetes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorEliminarAlquiler).BeginInit();
            SuspendLayout();
            // 
            // btnVaciarVolquetes
            // 
            btnVaciarVolquetes.BackgroundImage = (Image)resources.GetObject("btnVaciarVolquetes.BackgroundImage");
            btnVaciarVolquetes.FlatStyle = FlatStyle.Flat;
            btnVaciarVolquetes.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVaciarVolquetes.ForeColor = SystemColors.Control;
            btnVaciarVolquetes.Location = new Point(12, 110);
            btnVaciarVolquetes.Name = "btnVaciarVolquetes";
            btnVaciarVolquetes.Size = new Size(219, 30);
            btnVaciarVolquetes.TabIndex = 2;
            btnVaciarVolquetes.Text = "Vaciar volquetes de un alquiler";
            btnVaciarVolquetes.UseVisualStyleBackColor = true;
            btnVaciarVolquetes.Click += btnVaciarVolquetes_Click;
            // 
            // txtVaciarVolquetes
            // 
            txtVaciarVolquetes.BackColor = Color.DarkOrange;
            txtVaciarVolquetes.BorderStyle = BorderStyle.None;
            txtVaciarVolquetes.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtVaciarVolquetes.Location = new Point(255, 115);
            txtVaciarVolquetes.Name = "txtVaciarVolquetes";
            txtVaciarVolquetes.Size = new Size(105, 25);
            txtVaciarVolquetes.TabIndex = 3;
            txtVaciarVolquetes.KeyPress += txtVaciarVolquetes_KeyPress;
            // 
            // btnEliminarAlquiler
            // 
            btnEliminarAlquiler.BackgroundImage = (Image)resources.GetObject("btnEliminarAlquiler.BackgroundImage");
            btnEliminarAlquiler.FlatStyle = FlatStyle.Flat;
            btnEliminarAlquiler.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarAlquiler.ForeColor = SystemColors.Control;
            btnEliminarAlquiler.Location = new Point(12, 190);
            btnEliminarAlquiler.Name = "btnEliminarAlquiler";
            btnEliminarAlquiler.Size = new Size(219, 30);
            btnEliminarAlquiler.TabIndex = 4;
            btnEliminarAlquiler.Text = "Eliminar alquiler";
            btnEliminarAlquiler.UseVisualStyleBackColor = true;
            btnEliminarAlquiler.Click += btnEliminarAlquiler_Click;
            // 
            // txtEliminarAlquiler
            // 
            txtEliminarAlquiler.BackColor = Color.DarkOrange;
            txtEliminarAlquiler.BorderStyle = BorderStyle.None;
            txtEliminarAlquiler.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtEliminarAlquiler.Location = new Point(255, 190);
            txtEliminarAlquiler.Name = "txtEliminarAlquiler";
            txtEliminarAlquiler.Size = new Size(105, 25);
            txtEliminarAlquiler.TabIndex = 5;
            txtEliminarAlquiler.KeyPress += txtEliminarAlquiler_KeyPress;
            // 
            // errorVaciarVolquetes
            // 
            errorVaciarVolquetes.ContainerControl = this;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(364, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 29);
            btnCerrar.TabIndex = 6;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // errorEliminarAlquiler
            // 
            errorEliminarAlquiler.ContainerControl = this;
            // 
            // lblIngresa
            // 
            lblIngresa.AutoSize = true;
            lblIngresa.BackColor = Color.DarkOrange;
            lblIngresa.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresa.Location = new Point(87, 24);
            lblIngresa.Name = "lblIngresa";
            lblIngresa.Size = new Size(187, 30);
            lblIngresa.TabIndex = 7;
            lblIngresa.Text = "Ingresa el idDB";
            // 
            // VentanaAdministrarAlquileres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(395, 275);
            Controls.Add(lblIngresa);
            Controls.Add(btnCerrar);
            Controls.Add(txtEliminarAlquiler);
            Controls.Add(btnEliminarAlquiler);
            Controls.Add(txtVaciarVolquetes);
            Controls.Add(btnVaciarVolquetes);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaAdministrarAlquileres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar Alquileres";
            Load += VentanaAdministrarAlquileres_Load;
            MouseDown += VentanaAdministrarAlquileres_MouseDown;
            ((System.ComponentModel.ISupportInitialize)errorVaciarVolquetes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorEliminarAlquiler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVaciarVolquetes;
        private TextBox txtVaciarVolquetes;
        private Button btnEliminarAlquiler;
        private TextBox txtEliminarAlquiler;
        private ErrorProvider errorVaciarVolquetes;
        private Button btnCerrar;
        private ErrorProvider errorEliminarAlquiler;
        private Label lblIngresa;
    }
}