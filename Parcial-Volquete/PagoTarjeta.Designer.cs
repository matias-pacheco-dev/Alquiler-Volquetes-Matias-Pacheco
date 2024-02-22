namespace Parcial_Volquete
{
    partial class PagoTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoTarjeta));
            label1 = new Label();
            txtNumTarjeta = new TextBox();
            txtExpiration = new TextBox();
            txtCVV = new TextBox();
            txtName = new TextBox();
            btnPagar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblPrecio = new Label();
            lblProgreso = new Label();
            btnRandom = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(236, 33);
            label1.TabIndex = 0;
            label1.Text = "Detalles de pago";
            // 
            // txtNumTarjeta
            // 
            txtNumTarjeta.BackColor = Color.FromArgb(15, 15, 15);
            txtNumTarjeta.BorderStyle = BorderStyle.None;
            txtNumTarjeta.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumTarjeta.ForeColor = Color.FromArgb(70, 70, 70);
            txtNumTarjeta.Location = new Point(76, 142);
            txtNumTarjeta.Name = "txtNumTarjeta";
            txtNumTarjeta.Size = new Size(265, 25);
            txtNumTarjeta.TabIndex = 3;
            txtNumTarjeta.Text = "**** **** **** ****";
            txtNumTarjeta.TextChanged += txtNumTarjeta_TextChanged;
            txtNumTarjeta.Enter += txtNumTarjeta_Enter;
            txtNumTarjeta.KeyPress += txtNumTarjeta_KeyPress;
            txtNumTarjeta.Leave += txtNumTarjeta_Leave;
            // 
            // txtExpiration
            // 
            txtExpiration.BackColor = Color.FromArgb(15, 15, 15);
            txtExpiration.BorderStyle = BorderStyle.None;
            txtExpiration.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtExpiration.ForeColor = Color.FromArgb(70, 70, 70);
            txtExpiration.Location = new Point(76, 207);
            txtExpiration.Name = "txtExpiration";
            txtExpiration.Size = new Size(78, 27);
            txtExpiration.TabIndex = 4;
            txtExpiration.Text = "MM/YY";
            txtExpiration.Enter += txtExpiration_Enter;
            txtExpiration.Leave += txtExpiration_Leave;
            // 
            // txtCVV
            // 
            txtCVV.BackColor = Color.FromArgb(15, 15, 15);
            txtCVV.BorderStyle = BorderStyle.None;
            txtCVV.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCVV.ForeColor = Color.FromArgb(70, 70, 70);
            txtCVV.Location = new Point(235, 211);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(106, 23);
            txtCVV.TabIndex = 5;
            txtCVV.Text = "***";
            txtCVV.Enter += txtCVV_Enter;
            txtCVV.Leave += txtCVV_Leave;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(15, 15, 15);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(70, 70, 70);
            txtName.Location = new Point(76, 285);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 25);
            txtName.TabIndex = 6;
            txtName.Text = "John Doe";
            txtName.Enter += txtName_Enter;
            txtName.Leave += txtName_Leave;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(70, 70, 70);
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.LightGray;
            btnPagar.Location = new Point(76, 357);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(265, 30);
            btnPagar.TabIndex = 7;
            btnPagar.Text = "Pagar ahora";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(70, 70, 70);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.LightGray;
            btnCancelar.Location = new Point(76, 429);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(265, 30);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(76, 106);
            label2.Name = "label2";
            label2.Size = new Size(162, 22);
            label2.TabIndex = 9;
            label2.Text = "Numero de tarjeta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(76, 187);
            label3.Name = "label3";
            label3.Size = new Size(141, 17);
            label3.TabIndex = 10;
            label3.Text = "Fecha de expiracion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(235, 187);
            label4.Name = "label4";
            label4.Size = new Size(35, 17);
            label4.TabIndex = 11;
            label4.Text = "CVV";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(76, 247);
            label5.Name = "label5";
            label5.Size = new Size(80, 22);
            label5.TabIndex = 12;
            label5.Text = "Nombre ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(361, 32);
            label6.Name = "label6";
            label6.Size = new Size(65, 22);
            label6.TabIndex = 13;
            label6.Text = "TOTAL";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.ForeColor = SystemColors.ButtonFace;
            lblPrecio.Location = new Point(361, 81);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(42, 22);
            lblPrecio.TabIndex = 14;
            lblPrecio.Text = "****";
            // 
            // lblProgreso
            // 
            lblProgreso.AutoSize = true;
            lblProgreso.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProgreso.ForeColor = SystemColors.Control;
            lblProgreso.Location = new Point(142, 485);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(113, 17);
            lblProgreso.TabIndex = 16;
            lblProgreso.Text = "Esperando pago";
            // 
            // btnRandom
            // 
            btnRandom.BackgroundImage = (Image)resources.GetObject("btnRandom.BackgroundImage");
            btnRandom.FlatStyle = FlatStyle.Flat;
            btnRandom.ForeColor = SystemColors.Control;
            btnRandom.Location = new Point(379, 491);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(134, 23);
            btnRandom.TabIndex = 22;
            btnRandom.Text = "Generar datos";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // PagoTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 23, 30);
            ClientSize = new Size(525, 526);
            Controls.Add(btnRandom);
            Controls.Add(lblProgreso);
            Controls.Add(lblPrecio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagar);
            Controls.Add(txtName);
            Controls.Add(txtCVV);
            Controls.Add(txtExpiration);
            Controls.Add(txtNumTarjeta);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PagoTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagoTarjeta";
            Load += PagoTarjeta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumTarjeta;
        private TextBox txtExpiration;
        private TextBox txtCVV;
        private TextBox txtName;
        private Button btnPagar;
        private Button btnCancelar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblPrecio;
        private Label lblProgreso;
        private Button btnRandom;
    }
}