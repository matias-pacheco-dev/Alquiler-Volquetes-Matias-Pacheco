namespace Parcial_Volquete
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            comercialToolStripMenuItem = new ToolStripMenuItem();
            coberturaToolStripMenuItem = new ToolStripMenuItem();
            contáctanosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, comercialToolStripMenuItem, coberturaToolStripMenuItem, contáctanosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // comercialToolStripMenuItem
            // 
            comercialToolStripMenuItem.Name = "comercialToolStripMenuItem";
            comercialToolStripMenuItem.Size = new Size(73, 20);
            comercialToolStripMenuItem.Text = "Comercial";
            // 
            // coberturaToolStripMenuItem
            // 
            coberturaToolStripMenuItem.Name = "coberturaToolStripMenuItem";
            coberturaToolStripMenuItem.Size = new Size(72, 20);
            coberturaToolStripMenuItem.Text = "Cobertura";
            // 
            // contáctanosToolStripMenuItem
            // 
            contáctanosToolStripMenuItem.Name = "contáctanosToolStripMenuItem";
            contáctanosToolStripMenuItem.Size = new Size(86, 20);
            contáctanosToolStripMenuItem.Text = "Contáctanos";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem comercialToolStripMenuItem;
        private ToolStripMenuItem coberturaToolStripMenuItem;
        private ToolStripMenuItem contáctanosToolStripMenuItem;
    }
}