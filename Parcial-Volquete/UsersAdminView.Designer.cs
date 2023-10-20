namespace Parcial_Volquete
{
    partial class UsersAdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersAdminView));
            dtgListaUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dtgListaUsuarios
            // 
            dtgListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaUsuarios.Location = new Point(21, 24);
            dtgListaUsuarios.Name = "dtgListaUsuarios";
            dtgListaUsuarios.RowTemplate.Height = 25;
            dtgListaUsuarios.Size = new Size(752, 344);
            dtgListaUsuarios.TabIndex = 0;
            // 
            // UsersAdminView
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(796, 396);
            Controls.Add(dtgListaUsuarios);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersAdminView";
            Text = "UsersAdminView";
            FormClosed += UsersAdminView_FormClosed;
            Load += UsersAdminView_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgListaUsuarios;
    }
}