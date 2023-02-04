
namespace Proyecto_Final_Procesamiento_de_Imagenes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.PanelSubMenuDeteccion = new System.Windows.Forms.Panel();
            this.btnDeteccionP = new System.Windows.Forms.Button();
            this.btnDeteccion = new System.Windows.Forms.Button();
            this.PanelSubMenuFiltros = new System.Windows.Forms.Panel();
            this.btnVideoFIltro = new System.Windows.Forms.Button();
            this.btnImgFiltro = new System.Windows.Forms.Button();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureMaximize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.FotoLogoCentro = new System.Windows.Forms.PictureBox();
            this.PanelSideMenu.SuspendLayout();
            this.PanelSubMenuDeteccion.SuspendLayout();
            this.PanelSubMenuFiltros.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoLogoCentro)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.AutoScroll = true;
            this.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PanelSideMenu.Controls.Add(this.btnClose);
            this.PanelSideMenu.Controls.Add(this.PanelSubMenuDeteccion);
            this.PanelSideMenu.Controls.Add(this.btnDeteccion);
            this.PanelSideMenu.Controls.Add(this.PanelSubMenuFiltros);
            this.PanelSideMenu.Controls.Add(this.btnFiltros);
            this.PanelSideMenu.Controls.Add(this.PanelLogo);
            this.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(235, 705);
            this.PanelSideMenu.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_cancel_25;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(0, 660);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(235, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar Aplicación";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // PanelSubMenuDeteccion
            // 
            this.PanelSubMenuDeteccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSubMenuDeteccion.Controls.Add(this.btnDeteccionP);
            this.PanelSubMenuDeteccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuDeteccion.Location = new System.Drawing.Point(0, 277);
            this.PanelSubMenuDeteccion.Name = "PanelSubMenuDeteccion";
            this.PanelSubMenuDeteccion.Size = new System.Drawing.Size(235, 43);
            this.PanelSubMenuDeteccion.TabIndex = 4;
            // 
            // btnDeteccionP
            // 
            this.btnDeteccionP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeteccionP.FlatAppearance.BorderSize = 0;
            this.btnDeteccionP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeteccionP.ForeColor = System.Drawing.Color.LightGray;
            this.btnDeteccionP.Location = new System.Drawing.Point(0, 0);
            this.btnDeteccionP.Name = "btnDeteccionP";
            this.btnDeteccionP.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeteccionP.Size = new System.Drawing.Size(235, 40);
            this.btnDeteccionP.TabIndex = 0;
            this.btnDeteccionP.Text = "Deteccion de Personas";
            this.btnDeteccionP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeteccionP.UseVisualStyleBackColor = true;
            this.btnDeteccionP.Click += new System.EventHandler(this.btnDeteccionP_Click);
            // 
            // btnDeteccion
            // 
            this.btnDeteccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeteccion.FlatAppearance.BorderSize = 0;
            this.btnDeteccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeteccion.ForeColor = System.Drawing.Color.Silver;
            this.btnDeteccion.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_camera_25;
            this.btnDeteccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeteccion.Location = new System.Drawing.Point(0, 232);
            this.btnDeteccion.Name = "btnDeteccion";
            this.btnDeteccion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeteccion.Size = new System.Drawing.Size(235, 45);
            this.btnDeteccion.TabIndex = 3;
            this.btnDeteccion.Text = "Deteccion de Camara";
            this.btnDeteccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeteccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeteccion.UseVisualStyleBackColor = true;
            this.btnDeteccion.Click += new System.EventHandler(this.btnDeteccion_Click);
            this.btnDeteccion.MouseLeave += new System.EventHandler(this.btnDeteccion_MouseLeave);
            this.btnDeteccion.MouseHover += new System.EventHandler(this.btnDeteccion_MouseHover);
            // 
            // PanelSubMenuFiltros
            // 
            this.PanelSubMenuFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSubMenuFiltros.Controls.Add(this.btnVideoFIltro);
            this.PanelSubMenuFiltros.Controls.Add(this.btnImgFiltro);
            this.PanelSubMenuFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuFiltros.Location = new System.Drawing.Point(0, 145);
            this.PanelSubMenuFiltros.Name = "PanelSubMenuFiltros";
            this.PanelSubMenuFiltros.Size = new System.Drawing.Size(235, 87);
            this.PanelSubMenuFiltros.TabIndex = 2;
            // 
            // btnVideoFIltro
            // 
            this.btnVideoFIltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVideoFIltro.FlatAppearance.BorderSize = 0;
            this.btnVideoFIltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoFIltro.ForeColor = System.Drawing.Color.LightGray;
            this.btnVideoFIltro.Location = new System.Drawing.Point(0, 40);
            this.btnVideoFIltro.Name = "btnVideoFIltro";
            this.btnVideoFIltro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVideoFIltro.Size = new System.Drawing.Size(235, 40);
            this.btnVideoFIltro.TabIndex = 1;
            this.btnVideoFIltro.Text = "Videos";
            this.btnVideoFIltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideoFIltro.UseVisualStyleBackColor = true;
            this.btnVideoFIltro.Click += new System.EventHandler(this.btnVideoFIltro_Click);
            // 
            // btnImgFiltro
            // 
            this.btnImgFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImgFiltro.FlatAppearance.BorderSize = 0;
            this.btnImgFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgFiltro.ForeColor = System.Drawing.Color.LightGray;
            this.btnImgFiltro.Location = new System.Drawing.Point(0, 0);
            this.btnImgFiltro.Name = "btnImgFiltro";
            this.btnImgFiltro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnImgFiltro.Size = new System.Drawing.Size(235, 40);
            this.btnImgFiltro.TabIndex = 0;
            this.btnImgFiltro.Text = "Imagenes";
            this.btnImgFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImgFiltro.UseVisualStyleBackColor = true;
            this.btnImgFiltro.Click += new System.EventHandler(this.btnImgFiltro_Click);
            // 
            // btnFiltros
            // 
            this.btnFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiltros.FlatAppearance.BorderSize = 0;
            this.btnFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltros.ForeColor = System.Drawing.Color.Silver;
            this.btnFiltros.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_filter_25;
            this.btnFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltros.Location = new System.Drawing.Point(0, 100);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFiltros.Size = new System.Drawing.Size(235, 45);
            this.btnFiltros.TabIndex = 1;
            this.btnFiltros.Text = "Filtros";
            this.btnFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            this.btnFiltros.MouseLeave += new System.EventHandler(this.btnFiltros_MouseLeave);
            this.btnFiltros.MouseHover += new System.EventHandler(this.btnFiltros_MouseHover);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.Logo);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(235, 100);
            this.PanelLogo.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(235, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.PanelContenedor.Controls.Add(this.PanelTitulo);
            this.PanelContenedor.Controls.Add(this.FotoLogoCentro);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(235, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(980, 705);
            this.PanelContenedor.TabIndex = 1;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PanelTitulo.Controls.Add(this.pictureMinimize);
            this.PanelTitulo.Controls.Add(this.pictureMaximize);
            this.PanelTitulo.Controls.Add(this.pictureClose);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(980, 29);
            this.PanelTitulo.TabIndex = 1;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_minimize_window_20;
            this.pictureMinimize.Location = new System.Drawing.Point(905, 6);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(20, 20);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinimize.TabIndex = 2;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.pictureMinimize_Click);
            // 
            // pictureMaximize
            // 
            this.pictureMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMaximize.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_maximize_window_20;
            this.pictureMaximize.Location = new System.Drawing.Point(931, 6);
            this.pictureMaximize.Name = "pictureMaximize";
            this.pictureMaximize.Size = new System.Drawing.Size(20, 20);
            this.pictureMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMaximize.TabIndex = 1;
            this.pictureMaximize.TabStop = false;
            this.pictureMaximize.Click += new System.EventHandler(this.pictureMaximize_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_close_window_20;
            this.pictureClose.Location = new System.Drawing.Point(957, 6);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(20, 20);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 0;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // FotoLogoCentro
            // 
            this.FotoLogoCentro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FotoLogoCentro.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.logo;
            this.FotoLogoCentro.Location = new System.Drawing.Point(358, 221);
            this.FotoLogoCentro.Name = "FotoLogoCentro";
            this.FotoLogoCentro.Size = new System.Drawing.Size(281, 258);
            this.FotoLogoCentro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoLogoCentro.TabIndex = 0;
            this.FotoLogoCentro.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1215, 705);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Final Procesamiento Imagenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelSideMenu.ResumeLayout(false);
            this.PanelSubMenuDeteccion.ResumeLayout(false);
            this.PanelSubMenuFiltros.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoLogoCentro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSideMenu;
        private System.Windows.Forms.Panel PanelSubMenuDeteccion;
        private System.Windows.Forms.Button btnDeteccionP;
        private System.Windows.Forms.Button btnDeteccion;
        private System.Windows.Forms.Panel PanelSubMenuFiltros;
        private System.Windows.Forms.Button btnVideoFIltro;
        private System.Windows.Forms.Button btnImgFiltro;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox FotoLogoCentro;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMaximize;
        private System.Windows.Forms.PictureBox pictureMinimize;
    }
}

