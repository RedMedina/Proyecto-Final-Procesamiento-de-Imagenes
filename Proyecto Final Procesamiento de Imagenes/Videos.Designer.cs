
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltrosV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.HistogramaV = new System.Windows.Forms.PictureBox();
            this.btnAplicarFiltroV = new System.Windows.Forms.Button();
            this.btnCargarVideo = new System.Windows.Forms.Button();
            this.EntradaDeVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDeVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(711, 446);
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
            this.cmbFiltrosV.Location = new System.Drawing.Point(317, 486);
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
            this.label1.Location = new System.Drawing.Point(317, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtros:";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_stop_circled_25;
            this.btnStop.Location = new System.Drawing.Point(394, 48);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 20;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_start_25;
            this.btnStart.Location = new System.Drawing.Point(394, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(30, 30);
            this.btnStart.TabIndex = 19;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // HistogramaV
            // 
            this.HistogramaV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HistogramaV.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_histogram_70;
            this.HistogramaV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HistogramaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistogramaV.Location = new System.Drawing.Point(714, 466);
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
            this.btnAplicarFiltroV.Location = new System.Drawing.Point(317, 528);
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
            this.btnCargarVideo.Location = new System.Drawing.Point(93, 334);
            this.btnCargarVideo.Name = "btnCargarVideo";
            this.btnCargarVideo.Size = new System.Drawing.Size(211, 55);
            this.btnCargarVideo.TabIndex = 11;
            this.btnCargarVideo.Text = "Cargar Video";
            this.btnCargarVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarVideo.UseVisualStyleBackColor = false;
            this.btnCargarVideo.Click += new System.EventHandler(this.btnCargarVideo_Click);
            // 
            // EntradaDeVideo
            // 
            this.EntradaDeVideo.Enabled = true;
            this.EntradaDeVideo.Location = new System.Drawing.Point(12, 12);
            this.EntradaDeVideo.Name = "EntradaDeVideo";
            this.EntradaDeVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("EntradaDeVideo.OcxState")));
            this.EntradaDeVideo.Size = new System.Drawing.Size(376, 316);
            this.EntradaDeVideo.TabIndex = 21;
            // 
            // Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(962, 658);
            this.Controls.Add(this.EntradaDeVideo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HistogramaV);
            this.Controls.Add(this.btnAplicarFiltroV);
            this.Controls.Add(this.cmbFiltrosV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarVideo);
            this.Name = "Videos";
            this.Text = "Videos";
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDeVideo)).EndInit();
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
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private AxWMPLib.AxWindowsMediaPlayer EntradaDeVideo;
    }
}