using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;

namespace Proyecto_Final_Procesamiento_de_Imagenes
{
    public partial class Imagenes : Form
    {
        public Imagenes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private System.Drawing.Image ImagenAEditar = null;
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                ImagenEntrada.Image = Image.FromFile(openFileDialog1.FileName);
                ImagenAEditar = ImagenEntrada.Image;
            }
        }

        private void InvertirColores() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap imgOriginal;
            imgOriginal = new Bitmap(ImagenAEditar);
            for (int i = 0; i < imgOriginal.Width; i++)
            {
                for (int j = 0; j < imgOriginal.Height; j++)
                {
                    Color pixelColor = imgOriginal.GetPixel(i, j);
                    int r, g, b;
                    r = 255 - pixelColor.R;
                    g = 255 - pixelColor.G;
                    b = 255 - pixelColor.B;
                    imgOriginal.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = imgOriginal;

            //Histograma
            //HistoGramImg.Visible = true;
            //ChartImagen.Series.Clear();
        }

        private void TonoSepia() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap imgOriginal = new Bitmap(ImagenAEditar);
            for (int x = 0; x < imgOriginal.Width; x++)
            {
                for (int y = 0; y < imgOriginal.Height; y++)
                {
                    Color pixel = imgOriginal.GetPixel(x, y);
                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    if (tr > 255) tr = 255;
                    if (tg > 255) tg = 255;
                    if (tb > 255) tb = 255;

                    imgOriginal.SetPixel(x, y, Color.FromArgb(tr, tg, tb));
                }
            }
            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = imgOriginal;
        }

        private void EscalaDeGrises() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap imgOriginal = new Bitmap(ImagenAEditar);
            for (int x = 0; x < imgOriginal.Width; x++)
            {
                for (int y = 0; y < imgOriginal.Height; y++)
                {
                    Color pixelColor = imgOriginal.GetPixel(x, y);
                    int grayScale = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    imgOriginal.SetPixel(x, y, newColor);
                }
            }
            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = imgOriginal;
        }

        private void Pixelizado() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap sourceBitmap = new Bitmap(ImagenAEditar);

            int blockSize = 10;


            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = sourceBitmap;

        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            
            int selectedIndex = cmbFiltros.SelectedIndex;
            if (ImagenEntrada.Image != null) 
            {
                switch (selectedIndex)
                {
                    case 0: //Invertir colores
                        InvertirColores();
                        break;
                    case 1: //Tono Sepia
                        TonoSepia();
                        break;
                    case 2: //Escala de Grises
                        EscalaDeGrises();
                        break;
                    case 3: //Pixelizado
                        Pixelizado();
                        break;
                    case 4: //Gaussiano
                       // Textura();
                        break;
                    default:
                        MessageBox.Show("Por favor seleccione un filtro.");
                        break;
                }
            }
            else 
            {
                MessageBox.Show("Necesita cargar una imagen primero.");
            }
        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            if (ImagenSalida.Image != null) 
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Guarda la imagen en la ruta especificada
                    ImagenSalida.Image.Save(saveFileDialog1.FileName);
                }
            }
            else
            {
                MessageBox.Show("Use un filtro primero antes de guardar.");
            }
            
        }
    }
}
