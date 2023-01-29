
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Histograma = new System.Windows.Forms.PictureBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.ImagenSalida = new System.Windows.Forms.PictureBox();
            this.ImagenEntrada = new System.Windows.Forms.PictureBox();
            this.ChartImagen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Histograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(23, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
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
            "Filtro3",
            "Filtro4",
            "Filtro5"});
            this.cmbFiltros.Location = new System.Drawing.Point(23, 333);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(258, 24);
            this.cmbFiltros.TabIndex = 5;
            this.cmbFiltros.Text = "Selecciona un Filtro...";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(406, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Histograma:";
            // 
            // Histograma
            // 
            this.Histograma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Histograma.BackgroundImage = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_histogram_70;
            this.Histograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Histograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Histograma.Location = new System.Drawing.Point(409, 312);
            this.Histograma.Name = "Histograma";
            this.Histograma.Size = new System.Drawing.Size(236, 180);
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
            this.btnAplicarFiltro.Location = new System.Drawing.Point(23, 375);
            this.btnAplicarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(258, 47);
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
            this.btnGuardarImagen.Location = new System.Drawing.Point(454, 222);
            this.btnGuardarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(161, 47);
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
            this.btnCargarImagen.Location = new System.Drawing.Point(69, 222);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(161, 47);
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
            this.ImagenSalida.Location = new System.Drawing.Point(409, 12);
            this.ImagenSalida.Name = "ImagenSalida";
            this.ImagenSalida.Size = new System.Drawing.Size(236, 204);
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
            this.ImagenEntrada.Location = new System.Drawing.Point(34, 12);
            this.ImagenEntrada.Name = "ImagenEntrada";
            this.ImagenEntrada.Size = new System.Drawing.Size(236, 204);
            this.ImagenEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenEntrada.TabIndex = 0;
            this.ImagenEntrada.TabStop = false;
            // 
            // ChartImagen
            // 
            this.ChartImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChartImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ChartImagen.BorderlineColor = System.Drawing.Color.Black;
            this.ChartImagen.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.ChartImagen.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartImagen.Legends.Add(legend1);
            this.ChartImagen.Location = new System.Drawing.Point(311, 312);
            this.ChartImagen.Name = "ChartImagen";
            this.ChartImagen.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series1.Legend = "Legend1";
            series1.Name = "R";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.Name = "G";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "B";
            this.ChartImagen.Series.Add(series1);
            this.ChartImagen.Series.Add(series2);
            this.ChartImagen.Series.Add(series3);
            this.ChartImagen.Size = new System.Drawing.Size(356, 180);
            this.ChartImagen.TabIndex = 9;
            this.ChartImagen.Text = "chart1";
            this.ChartImagen.Visible = false;
            // 
            // Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(679, 506);
            this.Controls.Add(this.ChartImagen);
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
            ((System.ComponentModel.ISupportInitialize)(this.ChartImagen)).EndInit();
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
        public System.Windows.Forms.DataVisualization.Charting.Chart ChartImagen;
    }
}