namespace Parcial_Volquete
{
    partial class UsersAdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersAdminView));
            dtgListaUsuarios = new DataGridView();
            btnEdicion = new Button();
            btnGuardarCambios = new Button();
            btnEliminarUsuario = new Button();
            btnAdministrarAlquileres = new Button();
            dtgAlquileres = new DataGridView();
            btnAgregarVolquete = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgListaUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgAlquileres).BeginInit();
            SuspendLayout();
            // 
            // dtgListaUsuarios
            // 
            dtgListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaUsuarios.Location = new Point(336, 7);
            dtgListaUsuarios.Name = "dtgListaUsuarios";
            dtgListaUsuarios.RowHeadersVisible = false;
            dtgListaUsuarios.RowTemplate.Height = 25;
            dtgListaUsuarios.Size = new Size(448, 174);
            dtgListaUsuarios.TabIndex = 0;
            // 
            // btnEdicion
            // 
            btnEdicion.BackgroundImage = (Image)resources.GetObject("btnEdicion.BackgroundImage");
            btnEdicion.FlatStyle = FlatStyle.Flat;
            btnEdicion.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdicion.ForeColor = SystemColors.Control;
            btnEdicion.Location = new Point(91, 80);
            btnEdicion.Name = "btnEdicion";
            btnEdicion.Size = new Size(209, 30);
            btnEdicion.TabIndex = 1;
            btnEdicion.Text = "Habilitar Edicion Usuarios";
            btnEdicion.UseVisualStyleBackColor = true;
            btnEdicion.Click += btnEdicion_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackgroundImage = (Image)resources.GetObject("btnGuardarCambios.BackgroundImage");
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCambios.ForeColor = SystemColors.Control;
            btnGuardarCambios.Location = new Point(91, 294);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(209, 57);
            btnGuardarCambios.TabIndex = 2;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackgroundImage = (Image)resources.GetObject("btnEliminarUsuario.BackgroundImage");
            btnEliminarUsuario.FlatStyle = FlatStyle.Flat;
            btnEliminarUsuario.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarUsuario.ForeColor = SystemColors.Control;
            btnEliminarUsuario.Location = new Point(91, 188);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(209, 30);
            btnEliminarUsuario.TabIndex = 3;
            btnEliminarUsuario.Text = "Eliminar usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnAdministrarAlquileres
            // 
            btnAdministrarAlquileres.BackgroundImage = (Image)resources.GetObject("btnAdministrarAlquileres.BackgroundImage");
            btnAdministrarAlquileres.FlatStyle = FlatStyle.Flat;
            btnAdministrarAlquileres.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdministrarAlquileres.ForeColor = SystemColors.Control;
            btnAdministrarAlquileres.Location = new Point(91, 137);
            btnAdministrarAlquileres.Name = "btnAdministrarAlquileres";
            btnAdministrarAlquileres.Size = new Size(209, 30);
            btnAdministrarAlquileres.TabIndex = 4;
            btnAdministrarAlquileres.Text = "Administrar Alquileres";
            btnAdministrarAlquileres.UseVisualStyleBackColor = true;
            btnAdministrarAlquileres.Click += btnAdministrarAlquileres_Click;
            // 
            // dtgAlquileres
            // 
            dtgAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlquileres.Location = new Point(336, 188);
            dtgAlquileres.Name = "dtgAlquileres";
            dtgAlquileres.RowHeadersVisible = false;
            dtgAlquileres.RowTemplate.Height = 25;
            dtgAlquileres.Size = new Size(448, 196);
            dtgAlquileres.TabIndex = 5;
            // 
            // btnAgregarVolquete
            // 
            btnAgregarVolquete.BackgroundImage = (Image)resources.GetObject("btnAgregarVolquete.BackgroundImage");
            btnAgregarVolquete.FlatStyle = FlatStyle.Flat;
            btnAgregarVolquete.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarVolquete.ForeColor = SystemColors.Control;
            btnAgregarVolquete.Location = new Point(91, 234);
            btnAgregarVolquete.Name = "btnAgregarVolquete";
            btnAgregarVolquete.Size = new Size(209, 30);
            btnAgregarVolquete.TabIndex = 6;
            btnAgregarVolquete.Text = "Agregar Volquete";
            btnAgregarVolquete.UseVisualStyleBackColor = true;
            btnAgregarVolquete.Click += btnAgregarVolquete_Click;
            // 
            // UsersAdminView
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(796, 396);
            Controls.Add(btnAgregarVolquete);
            Controls.Add(dtgAlquileres);
            Controls.Add(btnAdministrarAlquileres);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnEdicion);
            Controls.Add(dtgListaUsuarios);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersAdminView";
            Text = "UsersAdminView";
            Load += UsersAdminView_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListaUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgAlquileres).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgListaUsuarios;
        private Button btnEdicion;
        private Button btnGuardarCambios;
        private Button btnEliminarUsuario;
        private Button btnAdministrarAlquileres;
        private DataGridView dtgAlquileres;
        private Button btnAgregarVolquete;
    }
}