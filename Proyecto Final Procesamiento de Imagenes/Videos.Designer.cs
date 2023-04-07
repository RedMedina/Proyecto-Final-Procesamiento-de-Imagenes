
namespace Proyecto_Final_Procesamiento_de_Imagenes
{
    partial class Videos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Videos));
            this.cmbFiltrosV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicarFiltroV = new System.Windows.Forms.Button();
            this.btnCargarVideo = new System.Windows.Forms.Button();
            this.VideoEE = new AxAXVLC.AxVLCPlugin2();
            this.VideoSS = new AxAXVLC.AxVLCPlugin2();
            this.VideoF1 = new System.Windows.Forms.PictureBox();
            this.VideoF2 = new System.Windows.Forms.PictureBox();
            this.VarGau = new System.Windows.Forms.ProgressBar();
            this.LineaT = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.VideoEE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineaT)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltrosV
            // 
            this.cmbFiltrosV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFiltrosV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.cmbFiltrosV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltrosV.ForeColor = System.Drawing.Color.LightGray;
            this.cmbFiltrosV.FormattingEnabled = true;
            this.cmbFiltrosV.Items.AddRange(new object[] {
            "Inversión de Colores",
            "Tonos Sepia",
            "Escala de Grises",
            "Pixelizado",
            "Circular"});
            this.cmbFiltrosV.Location = new System.Drawing.Point(61, 477);
            this.cmbFiltrosV.Name = "cmbFiltrosV";
            this.cmbFiltrosV.Size = new System.Drawing.Size(270, 24);
            this.cmbFiltrosV.TabIndex = 14;
            this.cmbFiltrosV.Text = "Selecciona un Filtro...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(57, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtros:";
            // 
            // btnAplicarFiltroV
            // 
            this.btnAplicarFiltroV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAplicarFiltroV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAplicarFiltroV.FlatAppearance.BorderSize = 0;
            this.btnAplicarFiltroV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltroV.ForeColor = System.Drawing.Color.LightGray;
            this.btnAplicarFiltroV.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_photo_editing_35;
            this.btnAplicarFiltroV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAplicarFiltroV.Location = new System.Drawing.Point(61, 519);
            this.btnAplicarFiltroV.Name = "btnAplicarFiltroV";
            this.btnAplicarFiltroV.Size = new System.Drawing.Size(270, 55);
            this.btnAplicarFiltroV.TabIndex = 15;
            this.btnAplicarFiltroV.Text = "Aplicar Filtro";
            this.btnAplicarFiltroV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicarFiltroV.UseVisualStyleBackColor = false;
            this.btnAplicarFiltroV.Click += new System.EventHandler(this.btnAplicarFiltroV_Click);
            // 
            // btnCargarVideo
            // 
            this.btnCargarVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCargarVideo.FlatAppearance.BorderSize = 0;
            this.btnCargarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarVideo.ForeColor = System.Drawing.Color.LightGray;
            this.btnCargarVideo.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_upload_25;
            this.btnCargarVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarVideo.Location = new System.Drawing.Point(85, 322);
            this.btnCargarVideo.Name = "btnCargarVideo";
            this.btnCargarVideo.Size = new System.Drawing.Size(211, 55);
            this.btnCargarVideo.TabIndex = 11;
            this.btnCargarVideo.Text = "Cargar Video";
            this.btnCargarVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarVideo.UseVisualStyleBackColor = false;
            this.btnCargarVideo.Click += new System.EventHandler(this.btnCargarVideo_Click);
            // 
            // VideoEE
            // 
            this.VideoEE.Enabled = true;
            this.VideoEE.Location = new System.Drawing.Point(12, -1);
            this.VideoEE.Name = "VideoEE";
            this.VideoEE.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoEE.OcxState")));
            this.VideoEE.Size = new System.Drawing.Size(376, 316);
            this.VideoEE.TabIndex = 22;
            this.VideoEE.Visible = false;
            // 
            // VideoSS
            // 
            this.VideoSS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VideoSS.Enabled = true;
            this.VideoSS.Location = new System.Drawing.Point(574, -1);
            this.VideoSS.Name = "VideoSS";
            this.VideoSS.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoSS.OcxState")));
            this.VideoSS.Size = new System.Drawing.Size(376, 316);
            this.VideoSS.TabIndex = 23;
            this.VideoSS.Visible = false;
            // 
            // VideoF1
            // 
            this.VideoF1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VideoF1.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_video_70;
            this.VideoF1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VideoF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoF1.Location = new System.Drawing.Point(12, -1);
            this.VideoF1.Name = "VideoF1";
            this.VideoF1.Size = new System.Drawing.Size(376, 316);
            this.VideoF1.TabIndex = 29;
            this.VideoF1.TabStop = false;
            // 
            // VideoF2
            // 
            this.VideoF2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VideoF2.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_video_70;
            this.VideoF2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VideoF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoF2.Location = new System.Drawing.Point(574, -1);
            this.VideoF2.Name = "VideoF2";
            this.VideoF2.Size = new System.Drawing.Size(376, 316);
            this.VideoF2.TabIndex = 30;
            this.VideoF2.TabStop = false;
            // 
            // VarGau
            // 
            this.VarGau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VarGau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.VarGau.Location = new System.Drawing.Point(574, 305);
            this.VarGau.Name = "VarGau";
            this.VarGau.Size = new System.Drawing.Size(376, 10);
            this.VarGau.TabIndex = 31;
            this.VarGau.Visible = false;
            // 
            // LineaT
            // 
            this.LineaT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LineaT.Location = new System.Drawing.Point(302, 334);
            this.LineaT.Name = "LineaT";
            this.LineaT.Size = new System.Drawing.Size(374, 56);
            this.LineaT.TabIndex = 32;
            this.LineaT.Scroll += new System.EventHandler(this.LineaT_Scroll);
            // 
            // Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(962, 658);
            this.Controls.Add(this.LineaT);
            this.Controls.Add(this.VarGau);
            this.Controls.Add(this.VideoF2);
            this.Controls.Add(this.VideoF1);
            this.Controls.Add(this.VideoSS);
            this.Controls.Add(this.VideoEE);
            this.Controls.Add(this.btnAplicarFiltroV);
            this.Controls.Add(this.cmbFiltrosV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarVideo);
            this.Name = "Videos";
            this.Text = "Videos";
            ((System.ComponentModel.ISupportInitialize)(this.VideoEE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineaT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAplicarFiltroV;
        private System.Windows.Forms.ComboBox cmbFiltrosV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarVideo;
        private AxAXVLC.AxVLCPlugin2 VideoEE;
        private AxAXVLC.AxVLCPlugin2 VideoSS;
        private System.Windows.Forms.PictureBox VideoF1;
        private System.Windows.Forms.PictureBox VideoF2;
        private System.Windows.Forms.ProgressBar VarGau;
        private System.Windows.Forms.TrackBar LineaT;
    }
}