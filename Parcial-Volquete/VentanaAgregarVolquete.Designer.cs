namespace Parcial_Volquete
{
    partial class VentanaAgregarVolquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregarVolquete));
            btnAgregarVolquete = new Button();
            label1 = new Label();
            comboBoxTipo = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAgregarVolquete
            // 
            btnAgregarVolquete.BackgroundImage = (Image)resources.GetObject("btnAgregarVolquete.BackgroundImage");
            btnAgregarVolquete.FlatStyle = FlatStyle.Flat;
            btnAgregarVolquete.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarVolquete.ForeColor = SystemColors.Control;
            btnAgregarVolquete.Location = new Point(44, 239);
            btnAgregarVolquete.Name = "btnAgregarVolquete";
            btnAgregarVolquete.Size = new Size(209, 35);
            btnAgregarVolquete.TabIndex = 2;
            btnAgregarVolquete.Text = "Agregar Volquete";
            btnAgregarVolquete.UseVisualStyleBackColor = true;
            btnAgregarVolquete.Click += btnAgregarVolquete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 49);
            label1.Name = "label1";
            label1.Size = new Size(186, 19);
            label1.TabIndex = 4;
            label1.Text = "Elegir Tipo De volquete";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(81, 102);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 30);
            comboBoxTipo.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(260, 12);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VentanaAgregarVolquete
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(303, 300);
            Controls.Add(button1);
            Controls.Add(comboBoxTipo);
            Controls.Add(label1);
            Controls.Add(btnAgregarVolquete);
            Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "VentanaAgregarVolquete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Volquete";
            Load += VentanaAgregarVolquete_Load;
            MouseDown += VentanaAgregarVolquete_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnAgregarVolquete;
        private Label label1;
        private ComboBox comboBoxTipo;
        private Button button1;
    }
}