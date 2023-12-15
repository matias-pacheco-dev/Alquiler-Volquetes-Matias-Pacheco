namespace Parcial_Volquete
{
    partial class BuzonAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuzonAdmin));
            listViewMensajes = new ListView();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listViewMensajes
            // 
            listViewMensajes.Location = new Point(12, 58);
            listViewMensajes.Name = "listViewMensajes";
            listViewMensajes.Size = new Size(447, 275);
            listViewMensajes.TabIndex = 0;
            listViewMensajes.UseCompatibleStateImageBehavior = false;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(434, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 24);
            btnExit.TabIndex = 7;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 12);
            label1.Name = "label1";
            label1.Size = new Size(269, 33);
            label1.TabIndex = 8;
            label1.Text = "Buzon de mensajes";
            // 
            // BuzonAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(471, 345);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(listViewMensajes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuzonAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += BuzonAdmin_Load;
            MouseDown += BuzonAdmin_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewMensajes;
        private Button btnExit;
        private Label label1;
    }
}