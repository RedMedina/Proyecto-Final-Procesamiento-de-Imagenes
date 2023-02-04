
namespace Proyecto_Final_Procesamiento_de_Imagenes
{
    partial class Imagenes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Histograma = new System.Windows.Forms.PictureBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.ImagenSalida = new System.Windows.Forms.PictureBox();
            this.ImagenEntrada = new System.Windows.Forms.PictureBox();
            this.VarGau = new System.Windows.Forms.ProgressBar();
            this.HistogramaImgR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistogramaImgG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistogramaImgB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Histograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(57, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtros:";
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.cmbFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltros.ForeColor = System.Drawing.Color.LightGray;
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Inversión de Colores",
            "Tonos Sepia",
            "Escala de Grises",
            "Pixelizado",
            "Gaussiano"});
            this.cmbFiltros.Location = new System.Drawing.Point(61, 477);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(270, 24);
            this.cmbFiltros.TabIndex = 5;
            this.cmbFiltros.Text = "Selecciona un Filtro...";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(462, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Histograma:";
            // 
            // Histograma
            // 
            this.Histograma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Histograma.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_histogram_70;
            this.Histograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Histograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Histograma.Location = new System.Drawing.Point(487, 397);
            this.Histograma.Name = "Histograma";
            this.Histograma.Size = new System.Drawing.Size(463, 249);
            this.Histograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Histograma.TabIndex = 7;
            this.Histograma.TabStop = false;
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAplicarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAplicarFiltro.FlatAppearance.BorderSize = 0;
            this.btnAplicarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltro.ForeColor = System.Drawing.Color.LightGray;
            this.btnAplicarFiltro.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_photo_editing_35;
            this.btnAplicarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAplicarFiltro.Location = new System.Drawing.Point(61, 519);
            this.btnAplicarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(270, 55);
            this.btnAplicarFiltro.TabIndex = 6;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicarFiltro.UseVisualStyleBackColor = false;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarImagen.FlatAppearance.BorderSize = 0;
            this.btnGuardarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarImagen.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardarImagen.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_downloads_25;
            this.btnGuardarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarImagen.Location = new System.Drawing.Point(663, 322);
            this.btnGuardarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(211, 55);
            this.btnGuardarImagen.TabIndex = 3;
            this.btnGuardarImagen.Text = "Guardar Imagen";
            this.btnGuardarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarImagen.UseVisualStyleBackColor = false;
            this.btnGuardarImagen.Click += new System.EventHandler(this.btnGuardarImagen_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCargarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCargarImagen.FlatAppearance.BorderSize = 0;
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.ForeColor = System.Drawing.Color.LightGray;
            this.btnCargarImagen.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_upload_25;
            this.btnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarImagen.Location = new System.Drawing.Point(85, 322);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(211, 55);
            this.btnCargarImagen.TabIndex = 2;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // ImagenSalida
            // 
            this.ImagenSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImagenSalida.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_image_70;
            this.ImagenSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImagenSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagenSalida.InitialImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_image_70;
            this.ImagenSalida.Location = new System.Drawing.Point(574, -1);
            this.ImagenSalida.Name = "ImagenSalida";
            this.ImagenSalida.Size = new System.Drawing.Size(376, 316);
            this.ImagenSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenSalida.TabIndex = 1;
            this.ImagenSalida.TabStop = false;
            // 
            // ImagenEntrada
            // 
            this.ImagenEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImagenEntrada.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_image_70;
            this.ImagenEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImagenEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagenEntrada.InitialImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_image_70;
            this.ImagenEntrada.Location = new System.Drawing.Point(12, -1);
            this.ImagenEntrada.Name = "ImagenEntrada";
            this.ImagenEntrada.Size = new System.Drawing.Size(376, 316);
            this.ImagenEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenEntrada.TabIndex = 0;
            this.ImagenEntrada.TabStop = false;
            // 
            // VarGau
            // 
            this.VarGau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VarGau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.VarGau.Location = new System.Drawing.Point(574, 305);
            this.VarGau.Name = "VarGau";
            this.VarGau.Size = new System.Drawing.Size(376, 10);
            this.VarGau.TabIndex = 10;
            this.VarGau.Visible = false;
            // 
            // HistogramaImgR
            // 
            this.HistogramaImgR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HistogramaImgR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.HistogramaImgR.BorderSkin.BackColor = System.Drawing.Color.Gainsboro;
            this.HistogramaImgR.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.HistogramaImgR.BorderSkin.BorderWidth = 0;
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea7.BorderColor = System.Drawing.Color.White;
            chartArea7.Name = "ChartArea1";
            this.HistogramaImgR.ChartAreas.Add(chartArea7);
            legend7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            legend7.HeaderSeparatorColor = System.Drawing.Color.White;
            legend7.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend7.Name = "Legend1";
            this.HistogramaImgR.Legends.Add(legend7);
            this.HistogramaImgR.Location = new System.Drawing.Point(466, 397);
            this.HistogramaImgR.Name = "HistogramaImgR";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Red";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Green";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Blue";
            this.HistogramaImgR.Series.Add(series19);
            this.HistogramaImgR.Series.Add(series20);
            this.HistogramaImgR.Series.Add(series21);
            this.HistogramaImgR.Size = new System.Drawing.Size(484, 91);
            this.HistogramaImgR.TabIndex = 11;
            this.HistogramaImgR.Visible = false;
            // 
            // HistogramaImgG
            // 
            this.HistogramaImgG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HistogramaImgG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.HistogramaImgG.BorderSkin.BackColor = System.Drawing.Color.Gainsboro;
            this.HistogramaImgG.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.HistogramaImgG.BorderSkin.BorderWidth = 0;
            chartArea8.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisX.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisY.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea8.BorderColor = System.Drawing.Color.White;
            chartArea8.Name = "ChartArea1";
            this.HistogramaImgG.ChartAreas.Add(chartArea8);
            legend8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            legend8.HeaderSeparatorColor = System.Drawing.Color.White;
            legend8.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend8.Name = "Legend1";
            this.HistogramaImgG.Legends.Add(legend8);
            this.HistogramaImgG.Location = new System.Drawing.Point(466, 485);
            this.HistogramaImgG.Name = "HistogramaImgG";
            series22.ChartArea = "ChartArea1";
            series22.Legend = "Legend1";
            series22.Name = "Red";
            series23.ChartArea = "ChartArea1";
            series23.Legend = "Legend1";
            series23.Name = "Green";
            series24.ChartArea = "ChartArea1";
            series24.Legend = "Legend1";
            series24.Name = "Blue";
            this.HistogramaImgG.Series.Add(series22);
            this.HistogramaImgG.Series.Add(series23);
            this.HistogramaImgG.Series.Add(series24);
            this.HistogramaImgG.Size = new System.Drawing.Size(484, 91);
            this.HistogramaImgG.TabIndex = 12;
            this.HistogramaImgG.Visible = false;
            // 
            // HistogramaImgB
            // 
            this.HistogramaImgB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HistogramaImgB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.HistogramaImgB.BorderSkin.BackColor = System.Drawing.Color.Gainsboro;
            this.HistogramaImgB.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.HistogramaImgB.BorderSkin.BorderWidth = 0;
            chartArea9.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisX.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea9.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisY.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea9.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea9.BorderColor = System.Drawing.Color.White;
            chartArea9.Name = "ChartArea1";
            this.HistogramaImgB.ChartAreas.Add(chartArea9);
            legend9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            legend9.HeaderSeparatorColor = System.Drawing.Color.White;
            legend9.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend9.Name = "Legend1";
            this.HistogramaImgB.Legends.Add(legend9);
            this.HistogramaImgB.Location = new System.Drawing.Point(466, 567);
            this.HistogramaImgB.Name = "HistogramaImgB";
            series25.ChartArea = "ChartArea1";
            series25.Legend = "Legend1";
            series25.Name = "Red";
            series26.ChartArea = "ChartArea1";
            series26.Legend = "Legend1";
            series26.Name = "Green";
            series27.ChartArea = "ChartArea1";
            series27.Legend = "Legend1";
            series27.Name = "Blue";
            this.HistogramaImgB.Series.Add(series25);
            this.HistogramaImgB.Series.Add(series26);
            this.HistogramaImgB.Series.Add(series27);
            this.HistogramaImgB.Size = new System.Drawing.Size(484, 91);
            this.HistogramaImgB.TabIndex = 13;
            this.HistogramaImgB.Visible = false;
            // 
            // Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(962, 658);
            this.Controls.Add(this.HistogramaImgB);
            this.Controls.Add(this.HistogramaImgG);
            this.Controls.Add(this.HistogramaImgR);
            this.Controls.Add(this.VarGau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Histograma);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.cmbFiltros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarImagen);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.ImagenSalida);
            this.Controls.Add(this.ImagenEntrada);
            this.Name = "Imagenes";
            this.Text = "Imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.Histograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramaImgB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenEntrada;
        private System.Windows.Forms.PictureBox ImagenSalida;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnGuardarImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.PictureBox Histograma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar VarGau;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistogramaImgR;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistogramaImgG;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistogramaImgB;
    }
}