﻿namespace Parcial_Volquete
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
            dtgAlquileres = new DataGridView();
            lblNombreCuenta = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgAlquileres).BeginInit();
            SuspendLayout();
            // 
            // dtgAlquileres
            // 
            dtgAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlquileres.Location = new Point(0, 53);
            dtgAlquileres.Name = "dtgAlquileres";
            dtgAlquileres.RowTemplate.Height = 25;
            dtgAlquileres.Size = new Size(795, 371);
            dtgAlquileres.TabIndex = 0;
            // 
            // lblNombreCuenta
            // 
            lblNombreCuenta.AutoSize = true;
            lblNombreCuenta.BackColor = SystemColors.ActiveCaptionText;
            lblNombreCuenta.FlatStyle = FlatStyle.Flat;
            lblNombreCuenta.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCuenta.ForeColor = SystemColors.ControlLightLight;
            lblNombreCuenta.Location = new Point(12, 9);
            lblNombreCuenta.Name = "lblNombreCuenta";
            lblNombreCuenta.Size = new Size(103, 29);
            lblNombreCuenta.TabIndex = 1;
            lblNombreCuenta.Text = "Nombre";
            // 
            // Cuenta_Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(796, 396);
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
    }
}