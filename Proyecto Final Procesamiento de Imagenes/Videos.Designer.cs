
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltrosV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HistogramaV = new System.Windows.Forms.PictureBox();
            this.btnAplicarFiltroV = new System.Windows.Forms.Button();
            this.btnCargarVideo = new System.Windows.Forms.Button();
            this.VideoEntrada = new System.Windows.Forms.PictureBox();
            this.VideoEntrada1 = new AForge.Controls.VideoSourcePlayer();
            this.VideoSalida = new AForge.Controls.VideoSourcePlayer();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(417, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Histograma:";
            // 
            // cmbFiltrosV
            // 
            this.cmbFiltrosV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFiltrosV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.cmbFiltrosV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltrosV.ForeColor = System.Drawing.Color.LightGray;
            this.cmbFiltrosV.FormattingEnabled = true;
            this.cmbFiltrosV.Items.AddRange(new object[] {
            "Filtro1",
            "Filtro2",
            "Filtro3",
            "Filtro4",
            "Filtro5"});
            this.cmbFiltrosV.Location = new System.Drawing.Point(23, 333);
            this.cmbFiltrosV.Name = "cmbFiltrosV";
            this.cmbFiltrosV.Size = new System.Drawing.Size(258, 24);
            this.cmbFiltrosV.TabIndex = 14;
            this.cmbFiltrosV.Text = "Selecciona un Filtro...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(23, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtros:";
            // 
            // HistogramaV
            // 
            this.HistogramaV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HistogramaV.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_histogram_70;
            this.HistogramaV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HistogramaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistogramaV.Location = new System.Drawing.Point(420, 313);
            this.HistogramaV.Name = "HistogramaV";
            this.HistogramaV.Size = new System.Drawing.Size(236, 180);
            this.HistogramaV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HistogramaV.TabIndex = 16;
            this.HistogramaV.TabStop = false;
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
            this.btnAplicarFiltroV.Location = new System.Drawing.Point(23, 375);
            this.btnAplicarFiltroV.Name = "btnAplicarFiltroV";
            this.btnAplicarFiltroV.Size = new System.Drawing.Size(258, 47);
            this.btnAplicarFiltroV.TabIndex = 15;
            this.btnAplicarFiltroV.Text = "Aplicar Filtro";
            this.btnAplicarFiltroV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicarFiltroV.UseVisualStyleBackColor = false;
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
            this.btnCargarVideo.Location = new System.Drawing.Point(80, 223);
            this.btnCargarVideo.Name = "btnCargarVideo";
            this.btnCargarVideo.Size = new System.Drawing.Size(161, 47);
            this.btnCargarVideo.TabIndex = 11;
            this.btnCargarVideo.Text = "Cargar Video";
            this.btnCargarVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarVideo.UseVisualStyleBackColor = false;
            this.btnCargarVideo.Click += new System.EventHandler(this.btnCargarVideo_Click);
            // 
            // VideoEntrada
            // 
            this.VideoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VideoEntrada.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_video_70;
            this.VideoEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VideoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoEntrada.Location = new System.Drawing.Point(45, 13);
            this.VideoEntrada.Name = "VideoEntrada";
            this.VideoEntrada.Size = new System.Drawing.Size(236, 204);
            this.VideoEntrada.TabIndex = 9;
            this.VideoEntrada.TabStop = false;
            this.VideoEntrada.Visible = false;
            // 
            // VideoEntrada1
            // 
            this.VideoEntrada1.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_video_70;
            this.VideoEntrada1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VideoEntrada1.Location = new System.Drawing.Point(45, 13);
            this.VideoEntrada1.Name = "VideoEntrada1";
            this.VideoEntrada1.Size = new System.Drawing.Size(236, 204);
            this.VideoEntrada1.TabIndex = 18;
            this.VideoEntrada1.Text = "videoSourcePlayer1";
            this.VideoEntrada1.VideoSource = null;
            // 
            // VideoSalida
            // 
            this.VideoSalida.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_video_70;
            this.VideoSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VideoSalida.Location = new System.Drawing.Point(420, 13);
            this.VideoSalida.Name = "VideoSalida";
            this.VideoSalida.Size = new System.Drawing.Size(236, 204);
            this.VideoSalida.TabIndex = 19;
            this.VideoSalida.Text = "videoSourcePlayer1";
            this.VideoSalida.VideoSource = null;
            // 
            // Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(679, 506);
            this.Controls.Add(this.VideoSalida);
            this.Controls.Add(this.VideoEntrada1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HistogramaV);
            this.Controls.Add(this.btnAplicarFiltroV);
            this.Controls.Add(this.cmbFiltrosV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarVideo);
            this.Controls.Add(this.VideoEntrada);
            this.Name = "Videos";
            this.Text = "Videos";
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox HistogramaV;
        private System.Windows.Forms.Button btnAplicarFiltroV;
        private System.Windows.Forms.ComboBox cmbFiltrosV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarVideo;
        private System.Windows.Forms.PictureBox VideoEntrada;
        private AForge.Controls.VideoSourcePlayer VideoEntrada1;
        private AForge.Controls.VideoSourcePlayer VideoSalida;
    }
}