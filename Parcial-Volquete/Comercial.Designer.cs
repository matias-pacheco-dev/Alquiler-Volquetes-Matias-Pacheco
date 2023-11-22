namespace Parcial_Volquete
{
    partial class Comercial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comercial));
            btnChico = new Button();
            btnMediano = new Button();
            btnGrande = new Button();
            btnConfirmar = new Button();
            btnCarrito = new Button();
            SuspendLayout();
            // 
            // btnChico
            // 
            btnChico.BackColor = Color.SandyBrown;
            btnChico.FlatStyle = FlatStyle.Flat;
            btnChico.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnChico.Location = new Point(57, 276);
            btnChico.Name = "btnChico";
            btnChico.Size = new Size(140, 36);
            btnChico.TabIndex = 0;
            btnChico.Text = "Reservar";
            btnChico.UseVisualStyleBackColor = false;
            btnChico.Click += btnChico_Click;
            // 
            // btnMediano
            // 
            btnMediano.BackColor = Color.SandyBrown;
            btnMediano.FlatStyle = FlatStyle.Flat;
            btnMediano.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMediano.Location = new Point(305, 276);
            btnMediano.Name = "btnMediano";
            btnMediano.Size = new Size(140, 36);
            btnMediano.TabIndex = 1;
            btnMediano.Text = "Reservar";
            btnMediano.UseVisualStyleBackColor = false;
            btnMediano.Click += btnMediano_Click;
            // 
            // btnGrande
            // 
            btnGrande.BackColor = Color.SandyBrown;
            btnGrande.FlatStyle = FlatStyle.Flat;
            btnGrande.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrande.Location = new Point(543, 276);
            btnGrande.Name = "btnGrande";
            btnGrande.Size = new Size(140, 36);
            btnGrande.TabIndex = 2;
            btnGrande.Text = "Reservar";
            btnGrande.UseVisualStyleBackColor = false;
            btnGrande.Click += btnGrande_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SandyBrown;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(254, 334);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(247, 35);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCarrito
            // 
            btnCarrito.BackgroundImage = (Image)resources.GetObject("btnCarrito.BackgroundImage");
            btnCarrito.BackgroundImageLayout = ImageLayout.Stretch;
            btnCarrito.Location = new Point(700, 12);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(72, 63);
            btnCarrito.TabIndex = 4;
            btnCarrito.UseVisualStyleBackColor = true;
            // 
            // Comercial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(796, 396);
            Controls.Add(btnCarrito);
            Controls.Add(btnConfirmar);
            Controls.Add(btnGrande);
            Controls.Add(btnMediano);
            Controls.Add(btnChico);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Comercial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Comercial";
            ResumeLayout(false);
        }

        #endregion

        private Button btnChico;
        private Button btnMediano;
        private Button btnGrande;
        private Button btnConfirmar;
        private Button btnCarrito;
    }
}