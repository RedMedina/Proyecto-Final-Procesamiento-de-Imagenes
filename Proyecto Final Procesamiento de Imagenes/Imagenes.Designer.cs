
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
            "Gaussiano",
            "Circular (Ojo de Pez)"});
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
            this.HistogramaImgR.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.HistogramaImgR.Legends.Add(legend1);
            this.HistogramaImgR.Location = new System.Drawing.Point(466, 397);
            this.HistogramaImgR.Name = "HistogramaImgR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Red";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Green";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.HistogramaImgR.Series.Add(series1);
            this.HistogramaImgR.Series.Add(series2);
            this.HistogramaImgR.Series.Add(series3);
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
            this.HistogramaImgG.Location = new System.Drawing.Point(466, 485);
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
            this.HistogramaImgB.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            legend3.HeaderSeparatorColor = System.Drawing.Color.White;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.HistogramaImgB.Legends.Add(legend3);
            this.HistogramaImgB.Location = new System.Drawing.Point(466, 567);
            this.HistogramaImgB.Name = "HistogramaImgB";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Red";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Green";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Blue";
            this.HistogramaImgB.Series.Add(series7);
            this.HistogramaImgB.Series.Add(series8);
            this.HistogramaImgB.Series.Add(series9);
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