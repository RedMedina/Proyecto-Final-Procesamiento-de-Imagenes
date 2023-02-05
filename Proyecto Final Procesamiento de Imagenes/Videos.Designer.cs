
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbFiltrosV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicarFiltroV = new System.Windows.Forms.Button();
            this.btnCargarVideo = new System.Windows.Forms.Button();
            this.VideoEE = new AxAXVLC.AxVLCPlugin2();
            this.VideoSS = new AxAXVLC.AxVLCPlugin2();
            this.HistogramaImgB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistogramaImgG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistogramaImgR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.Histograma = new System.Windows.Forms.PictureBox();
            this.VideoF1 = new System.Windows.Forms.PictureBox();
            this.VideoF2 = new System.Windows.Forms.PictureBox();
            this.VarGau = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.VideoEE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoF2)).BeginInit();
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
            this.VideoEE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VideoEE.Enabled = true;
            this.VideoEE.Location = new System.Drawing.Point(12, -1);
            this.VideoEE.Name = "VideoEE";
            this.VideoEE.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoEE.OcxState")));
            this.VideoEE.Size = new System.Drawing.Size(376, 316);
            this.VideoEE.TabIndex = 22;
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
            // 
            // HistogramaImgB
            // 
            this.HistogramaImgB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HistogramaImgB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.HistogramaImgB.BorderSkin.BackColor = System.Drawing.Color.Gainsboro;
            this.HistogramaImgB.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.HistogramaImgB.BorderSkin.BorderWidth = 0;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.HistogramaImgB.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.HistogramaImgB.Legends.Add(legend1);
            this.HistogramaImgB.Location = new System.Drawing.Point(466, 557);
            this.HistogramaImgB.Name = "HistogramaImgB";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Red";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Green";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.HistogramaImgB.Series.Add(series1);
            this.HistogramaImgB.Series.Add(series2);
            this.HistogramaImgB.Series.Add(series3);
            this.HistogramaImgB.Size = new System.Drawing.Size(484, 91);
            this.HistogramaImgB.TabIndex = 28;
            this.HistogramaImgB.Visible = false;
            // 
            // HistogramaImgG
            // 
            this.HistogramaImgG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HistogramaImgG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.HistogramaImgG.BorderSkin.BackColor = System.Drawing.Color.Gainsboro;
            this.HistogramaImgG.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.HistogramaImgG.BorderSkin.BorderWidth = 0;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.HistogramaImgG.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            legend2.HeaderSeparatorColor = System.Drawing.Color.White;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.HistogramaImgG.Legends.Add(legend2);
            this.HistogramaImgG.Location = new System.Drawing.Point(466, 475);
            this.HistogramaImgG.Name = "HistogramaImgG";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Red";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Green";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Blue";
            this.HistogramaImgG.Series.Add(series4);
            this.HistogramaImgG.Series.Add(series5);
            this.HistogramaImgG.Series.Add(series6);
            this.HistogramaImgG.Size = new System.Drawing.Size(484, 91);
            this.HistogramaImgG.TabIndex = 27;
            this.HistogramaImgG.Visible = false;
            // 
            // HistogramaImgR
            // 
            this.HistogramaImgR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HistogramaImgR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.HistogramaImgR.BorderSkin.BackColor = System.Drawing.Color.Gainsboro;
            this.HistogramaImgR.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.HistogramaImgR.BorderSkin.BorderWidth = 0;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.HistogramaImgR.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            legend3.HeaderSeparatorColor = System.Drawing.Color.White;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.HistogramaImgR.Legends.Add(legend3);
            this.HistogramaImgR.Location = new System.Drawing.Point(466, 387);
            this.HistogramaImgR.Name = "HistogramaImgR";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Red";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Green";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Blue";
            this.HistogramaImgR.Series.Add(series7);
            this.HistogramaImgR.Series.Add(series8);
            this.HistogramaImgR.Series.Add(series9);
            this.HistogramaImgR.Size = new System.Drawing.Size(484, 91);
            this.HistogramaImgR.TabIndex = 26;
            this.HistogramaImgR.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(462, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Histograma:";
            // 
            // Histograma
            // 
            this.Histograma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Histograma.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_histogram_70;
            this.Histograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Histograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Histograma.Location = new System.Drawing.Point(487, 387);
            this.Histograma.Name = "Histograma";
            this.Histograma.Size = new System.Drawing.Size(463, 249);
            this.Histograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Histograma.TabIndex = 24;
            this.Histograma.TabStop = false;
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
            // Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(962, 658);
            this.Controls.Add(this.VarGau);
            this.Controls.Add(this.VideoF2);
            this.Controls.Add(this.VideoF1);
            this.Controls.Add(this.HistogramaImgB);
            this.Controls.Add(this.HistogramaImgG);
            this.Controls.Add(this.HistogramaImgR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Histograma);
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
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoF2)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart HistogramaImgB;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistogramaImgG;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistogramaImgR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Histograma;
        private System.Windows.Forms.PictureBox VideoF1;
        private System.Windows.Forms.PictureBox VideoF2;
        private System.Windows.Forms.ProgressBar VarGau;
    }
}