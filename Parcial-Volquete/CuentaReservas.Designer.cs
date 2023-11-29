namespace Parcial_Volquete
{
    partial class Cuenta_Reservas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuenta_Reservas));
            dtgAlquileres = new DataGridView();
            lblNombreCuenta = new Label();
            lblAlquileres = new Label();
            btnBaja = new Button();
            btnEditarAlquiler = new Button();
            comboBaja = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgAlquileres).BeginInit();
            SuspendLayout();
            // 
            // dtgAlquileres
            // 
            dataGridViewCellStyle1.BackColor = Color.DarkOrange;
            dtgAlquileres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgAlquileres.BackgroundColor = Color.MediumPurple;
            dtgAlquileres.BorderStyle = BorderStyle.None;
            dtgAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlquileres.GridColor = Color.Black;
            dtgAlquileres.Location = new Point(382, 45);
            dtgAlquileres.Name = "dtgAlquileres";
            dtgAlquileres.RowTemplate.Height = 25;
            dtgAlquileres.Size = new Size(412, 339);
            dtgAlquileres.TabIndex = 0;
            // 
            // lblNombreCuenta
            // 
            lblNombreCuenta.AutoSize = true;
            lblNombreCuenta.BackColor = Color.DarkSlateBlue;
            lblNombreCuenta.FlatStyle = FlatStyle.Flat;
            lblNombreCuenta.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCuenta.ForeColor = SystemColors.ControlLightLight;
            lblNombreCuenta.Location = new Point(12, 9);
            lblNombreCuenta.Name = "lblNombreCuenta";
            lblNombreCuenta.Size = new Size(103, 29);
            lblNombreCuenta.TabIndex = 1;
            lblNombreCuenta.Text = "Nombre";
            // 
            // lblAlquileres
            // 
            lblAlquileres.AutoSize = true;
            lblAlquileres.BackColor = Color.DarkSlateBlue;
            lblAlquileres.FlatStyle = FlatStyle.Flat;
            lblAlquileres.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlquileres.ForeColor = SystemColors.ControlLightLight;
            lblAlquileres.Location = new Point(149, 9);
            lblAlquileres.Name = "lblAlquileres";
            lblAlquileres.Size = new Size(180, 29);
            lblAlquileres.TabIndex = 2;
            lblAlquileres.Text = "Tus alquileres:";
            // 
            // btnBaja
            // 
            btnBaja.BackgroundImage = (Image)resources.GetObject("btnBaja.BackgroundImage");
            btnBaja.BackgroundImageLayout = ImageLayout.Stretch;
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.ForeColor = SystemColors.Control;
            btnBaja.Location = new Point(149, 81);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(200, 28);
            btnBaja.TabIndex = 3;
            btnBaja.Text = "Dar de baja una reserva";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnEditarAlquiler
            // 
            btnEditarAlquiler.BackgroundImage = (Image)resources.GetObject("btnEditarAlquiler.BackgroundImage");
            btnEditarAlquiler.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarAlquiler.FlatStyle = FlatStyle.Flat;
            btnEditarAlquiler.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarAlquiler.ForeColor = SystemColors.Control;
            btnEditarAlquiler.Location = new Point(149, 197);
            btnEditarAlquiler.Name = "btnEditarAlquiler";
            btnEditarAlquiler.Size = new Size(200, 28);
            btnEditarAlquiler.TabIndex = 4;
            btnEditarAlquiler.Text = "Modificar reserva";
            btnEditarAlquiler.UseVisualStyleBackColor = true;
            // 
            // comboBaja
            // 
            comboBaja.FormattingEnabled = true;
            comboBaja.Location = new Point(12, 81);
            comboBaja.Name = "comboBaja";
            comboBaja.Size = new Size(121, 23);
            comboBaja.TabIndex = 5;
            // 
            // Cuenta_Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(796, 396);
            Controls.Add(comboBaja);
            Controls.Add(btnEditarAlquiler);
            Controls.Add(btnBaja);
            Controls.Add(lblAlquileres);
            Controls.Add(lblNombreCuenta);
            Controls.Add(dtgAlquileres);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cuenta_Reservas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cuenta_Reservas";
            Load += Cuenta_Reservas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAlquileres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgAlquileres;
        private Label lblNombreCuenta;
        private Label lblAlquileres;
        private Button btnBaja;
        private Button btnEditarAlquiler;
        private ComboBox comboBaja;
    }
}