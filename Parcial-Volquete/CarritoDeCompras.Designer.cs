﻿namespace Parcial_Volquete
{
    partial class CarritoDeCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarritoDeCompras));
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(163, 19);
            label1.TabIndex = 22;
            label1.Text = "Carrito de compras:";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DarkOrange;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(12, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(163, 207);
            listBox1.TabIndex = 23;
            // 
            // CarritoDeCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(187, 296);
            Controls.Add(listBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarritoDeCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarritoDeCompras";
            Load += CarritoDeCompras_Load;
            MouseDown += CarritoDeCompras_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox listBox1;
    }
}