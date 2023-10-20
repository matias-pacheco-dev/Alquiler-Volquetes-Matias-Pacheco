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
            menuStrip = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            comercialToolStripMenuItem = new ToolStripMenuItem();
            coberturaToolStripMenuItem = new ToolStripMenuItem();
            buenosAiresToolStripMenuItem = new ToolStripMenuItem();
            capitalFederalToolStripMenuItem = new ToolStripMenuItem();
            córdobaToolStripMenuItem = new ToolStripMenuItem();
            santaFeToolStripMenuItem = new ToolStripMenuItem();
            corrientesToolStripMenuItem = new ToolStripMenuItem();
            entreRíosToolStripMenuItem = new ToolStripMenuItem();
            contáctanosToolStripMenuItem = new ToolStripMenuItem();
            cuentaToolStripMenuItem = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            administradorPanelToolStripMenuItem = new ToolStripMenuItem();
            listaDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.MediumSlateBlue;
            menuStrip.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, comercialToolStripMenuItem, coberturaToolStripMenuItem, contáctanosToolStripMenuItem, cuentaToolStripMenuItem, logOutToolStripMenuItem, administradorPanelToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 26);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(56, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // comercialToolStripMenuItem
            // 
            comercialToolStripMenuItem.Name = "comercialToolStripMenuItem";
            comercialToolStripMenuItem.Size = new Size(92, 22);
            comercialToolStripMenuItem.Text = "Comercial";
            comercialToolStripMenuItem.Click += comercialToolStripMenuItem_Click;
            // 
            // coberturaToolStripMenuItem
            // 
            coberturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buenosAiresToolStripMenuItem, capitalFederalToolStripMenuItem, córdobaToolStripMenuItem, santaFeToolStripMenuItem, corrientesToolStripMenuItem, entreRíosToolStripMenuItem });
            coberturaToolStripMenuItem.Name = "coberturaToolStripMenuItem";
            coberturaToolStripMenuItem.Size = new Size(90, 22);
            coberturaToolStripMenuItem.Text = "Cobertura";
            // 
            // buenosAiresToolStripMenuItem
            // 
            buenosAiresToolStripMenuItem.Name = "buenosAiresToolStripMenuItem";
            buenosAiresToolStripMenuItem.Size = new Size(184, 22);
            buenosAiresToolStripMenuItem.Text = "Buenos Aires";
            // 
            // capitalFederalToolStripMenuItem
            // 
            capitalFederalToolStripMenuItem.Name = "capitalFederalToolStripMenuItem";
            capitalFederalToolStripMenuItem.Size = new Size(184, 22);
            capitalFederalToolStripMenuItem.Text = "Capital Federal";
            // 
            // córdobaToolStripMenuItem
            // 
            córdobaToolStripMenuItem.Name = "córdobaToolStripMenuItem";
            córdobaToolStripMenuItem.Size = new Size(184, 22);
            córdobaToolStripMenuItem.Text = "Córdoba";
            // 
            // santaFeToolStripMenuItem
            // 
            santaFeToolStripMenuItem.Name = "santaFeToolStripMenuItem";
            santaFeToolStripMenuItem.Size = new Size(184, 22);
            santaFeToolStripMenuItem.Text = "Santa Fe";
            // 
            // corrientesToolStripMenuItem
            // 
            corrientesToolStripMenuItem.Name = "corrientesToolStripMenuItem";
            corrientesToolStripMenuItem.Size = new Size(184, 22);
            corrientesToolStripMenuItem.Text = "Corrientes";
            // 
            // entreRíosToolStripMenuItem
            // 
            entreRíosToolStripMenuItem.Name = "entreRíosToolStripMenuItem";
            entreRíosToolStripMenuItem.Size = new Size(184, 22);
            entreRíosToolStripMenuItem.Text = "Entre Ríos";
            // 
            // contáctanosToolStripMenuItem
            // 
            contáctanosToolStripMenuItem.ForeColor = Color.Black;
            contáctanosToolStripMenuItem.Name = "contáctanosToolStripMenuItem";
            contáctanosToolStripMenuItem.Size = new Size(108, 22);
            contáctanosToolStripMenuItem.Text = "Contáctanos";
            contáctanosToolStripMenuItem.Click += contáctanosToolStripMenuItem_Click;
            // 
            // cuentaToolStripMenuItem
            // 
            cuentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reservasToolStripMenuItem });
            cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            cuentaToolStripMenuItem.Size = new Size(70, 22);
            cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(142, 22);
            reservasToolStripMenuItem.Text = "Reservas";
            reservasToolStripMenuItem.Click += reservasToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(75, 22);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // administradorPanelToolStripMenuItem
            // 
            administradorPanelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeUsuariosToolStripMenuItem });
            administradorPanelToolStripMenuItem.Name = "administradorPanelToolStripMenuItem";
            administradorPanelToolStripMenuItem.Size = new Size(118, 22);
            administradorPanelToolStripMenuItem.Text = "Administrador";
            // 
            // listaDeUsuariosToolStripMenuItem
            // 
            listaDeUsuariosToolStripMenuItem.Name = "listaDeUsuariosToolStripMenuItem";
            listaDeUsuariosToolStripMenuItem.Size = new Size(201, 22);
            listaDeUsuariosToolStripMenuItem.Text = "Lista De Usuarios";
            listaDeUsuariosToolStripMenuItem.Click += listaDeUsuariosToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 424);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Menu_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem comercialToolStripMenuItem;
        private ToolStripMenuItem coberturaToolStripMenuItem;
        private ToolStripMenuItem contáctanosToolStripMenuItem;
        private ToolStripMenuItem cuentaToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem buenosAiresToolStripMenuItem;
        private ToolStripMenuItem capitalFederalToolStripMenuItem;
        private ToolStripMenuItem córdobaToolStripMenuItem;
        private ToolStripMenuItem santaFeToolStripMenuItem;
        private ToolStripMenuItem corrientesToolStripMenuItem;
        private ToolStripMenuItem entreRíosToolStripMenuItem;
        private ToolStripMenuItem administradorPanelToolStripMenuItem;
        private ToolStripMenuItem listaDeUsuariosToolStripMenuItem;
    }
}