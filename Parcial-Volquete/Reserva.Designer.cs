namespace Parcial_Volquete
{
    partial class Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
            lblInfo = new Label();
            lblNombre = new Label();
            label1 = new Label();
            label2 = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            label3 = new Label();
            lblDireccion = new Label();
            label4 = new Label();
            lblFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBoxPlazo = new ComboBox();
            lblPago = new Label();
            comboBoxPago = new ComboBox();
            btnConfirmar = new Button();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.FlatStyle = FlatStyle.Flat;
            lblInfo.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.ControlLightLight;
            lblInfo.Location = new Point(106, 24);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(285, 33);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Informacion de pago";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.FlatStyle = FlatStyle.Flat;
            lblNombre.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(12, 109);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(96, 24);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(128, 131);
            label1.Name = "label1";
            label1.Size = new Size(200, 2);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(128, 177);
            label2.Name = "label2";
            label2.Size = new Size(200, 2);
            label2.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.FlatStyle = FlatStyle.Flat;
            lblEmail.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(12, 155);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 24);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.FlatStyle = FlatStyle.Flat;
            lblTelefono.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.ForeColor = SystemColors.ControlLightLight;
            lblTelefono.Location = new Point(12, 208);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(103, 24);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Telefono:";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(128, 230);
            label3.Name = "label3";
            label3.Size = new Size(200, 2);
            label3.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.FlatStyle = FlatStyle.Flat;
            lblDireccion.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDireccion.ForeColor = SystemColors.ControlLightLight;
            lblDireccion.Location = new Point(12, 259);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(112, 24);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Direccion:";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(128, 281);
            label4.Name = "label4";
            label4.Size = new Size(200, 2);
            label4.TabIndex = 8;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.FlatStyle = FlatStyle.Flat;
            lblFecha.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.ControlLightLight;
            lblFecha.Location = new Point(12, 312);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(79, 24);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = Color.IndianRed;
            dateTimePicker1.CalendarTitleForeColor = Color.Black;
            dateTimePicker1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(128, 315);
            dateTimePicker1.MinDate = new DateTime(2023, 10, 19, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 21);
            dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 364);
            label5.Name = "label5";
            label5.Size = new Size(72, 24);
            label5.TabIndex = 11;
            label5.Text = "Plazo:";
            // 
            // comboBoxPlazo
            // 
            comboBoxPlazo.BackColor = Color.White;
            comboBoxPlazo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlazo.FlatStyle = FlatStyle.Flat;
            comboBoxPlazo.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxPlazo.FormattingEnabled = true;
            comboBoxPlazo.Items.AddRange(new object[] { "24hs", "48hs", "72hs", "1 semana", "2 semanas", "1 mes" });
            comboBoxPlazo.Location = new Point(128, 362);
            comboBoxPlazo.Name = "comboBoxPlazo";
            comboBoxPlazo.Size = new Size(163, 26);
            comboBoxPlazo.TabIndex = 12;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.BackColor = Color.Transparent;
            lblPago.FlatStyle = FlatStyle.Flat;
            lblPago.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPago.ForeColor = SystemColors.ControlLightLight;
            lblPago.Location = new Point(12, 426);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(166, 24);
            lblPago.TabIndex = 13;
            lblPago.Text = "Medio de Pago:";
            // 
            // comboBoxPago
            // 
            comboBoxPago.BackColor = Color.White;
            comboBoxPago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPago.FlatStyle = FlatStyle.Flat;
            comboBoxPago.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxPago.FormattingEnabled = true;
            comboBoxPago.Location = new Point(184, 426);
            comboBoxPago.Name = "comboBoxPago";
            comboBoxPago.Size = new Size(163, 26);
            comboBoxPago.TabIndex = 14;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackgroundImage = (Image)resources.GetObject("btnConfirmar.BackgroundImage");
            btnConfirmar.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(128, 474);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(179, 28);
            btnConfirmar.TabIndex = 15;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.DimGray;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(128, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 22);
            txtNombre.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.DimGray;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(128, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 22);
            txtEmail.TabIndex = 17;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.DimGray;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(128, 208);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 22);
            txtTelefono.TabIndex = 18;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.DimGray;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(128, 259);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 22);
            txtDireccion.TabIndex = 19;
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(532, 514);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(btnConfirmar);
            Controls.Add(comboBoxPago);
            Controls.Add(lblPago);
            Controls.Add(comboBoxPlazo);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFecha);
            Controls.Add(label4);
            Controls.Add(lblDireccion);
            Controls.Add(label3);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(lblInfo);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reserva";
            Load += Reserva_Load;
            MouseDown += Reserva_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblInfo;
        private Label lblNombre;
        private Label label1;
        private Label label2;
        private Label lblEmail;
        private Label lblTelefono;
        private Label label3;
        private Label lblDireccion;
        private Label label4;
        private Label lblFecha;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBoxPlazo;
        private Label lblPago;
        private ComboBox comboBoxPago;
        private Button btnConfirmar;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
    }
}