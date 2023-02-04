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

        unsafe private void GeneraHistograma(Bitmap image) 
        {
            BitmapData data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];

            byte* ptr = (byte*)data.Scan0.ToPointer();

            for (int i = 0; i < data.Height; i++)
            {
                for (int j = 0; j < data.Width; j++)
                {
                    red[ptr[2]]++;
                    green[ptr[1]]++;
                    blue[ptr[0]]++;
                    ptr += 3;
                }
                ptr += data.Stride - data.Width * 3;
            }

            image.UnlockBits(data);

            HistogramaImgR.Visible = true;
            HistogramaImgR.Series.Clear();

            HistogramaImgG.Visible = true;
            HistogramaImgG.Series.Clear();

            HistogramaImgB.Visible = true;
            HistogramaImgB.Series.Clear();

            Series serieR = new Series("Red");
            serieR.ChartType = SeriesChartType.Column;
            HistogramaImgR.Series.Add(serieR);

            Series serieG = new Series("Green");
            serieG.ChartType = SeriesChartType.Column;
            HistogramaImgG.Series.Add(serieG);

            Series serieB = new Series("Blue");
            serieB.ChartType = SeriesChartType.Column;
            HistogramaImgB.Series.Add(serieB);

            HistogramaImgR.Series["Red"].Points.DataBindY(red);
            HistogramaImgR.Series["Red"].Color = Color.Red;
            HistogramaImgR.Series["Red"].BorderWidth = 5;

            HistogramaImgG.Series["Green"].Points.DataBindY(green);
            HistogramaImgG.Series["Green"].Color = Color.Green;
            HistogramaImgG.Series["Green"].BorderWidth = 5;

            HistogramaImgB.Series["Blue"].Points.DataBindY(blue);
            HistogramaImgB.Series["Blue"].Color = Color.Blue;
            HistogramaImgB.Series["Blue"].BorderWidth = 5;
        }

        unsafe private void OptimizedInvertColors() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap imgOriginal;
            imgOriginal = new Bitmap(ImagenAEditar);
            BitmapData bmpData = imgOriginal.LockBits(new Rectangle(0, 0, imgOriginal.Width, imgOriginal.Height), ImageLockMode.ReadWrite, imgOriginal.PixelFormat);
            int bytesPerPixel = Bitmap.GetPixelFormatSize(imgOriginal.PixelFormat) / 8;
            int heightInPixels = bmpData.Height;
            int widthInBytes = bmpData.Width * bytesPerPixel;
            byte* PtrFirstPixel = (byte*)bmpData.Scan0;

            VarGau.Visible = true;
            VarGau.Maximum = heightInPixels;
            VarGau.Value = 0;

            for (int y = 0; y < heightInPixels; y++)
            {
                byte* currentLine = PtrFirstPixel + (y * bmpData.Stride);
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    currentLine[x] = (byte)(255 - currentLine[x]); // blue
                    currentLine[x + 1] = (byte)(255 - currentLine[x + 1]); // green
                    currentLine[x + 2] = (byte)(255 - currentLine[x + 2]); // red
                }
                VarGau.Value++;
            }

            imgOriginal.UnlockBits(bmpData);
            VarGau.Visible = false;
            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = imgOriginal;

            GeneraHistograma(imgOriginal);
        } 

        private void InvertirColores() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap imgOriginal;
            imgOriginal = new Bitmap(ImagenAEditar);

            VarGau.Visible = true;
            VarGau.Maximum = imgOriginal.Width;
            VarGau.Value = 0;

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
                VarGau.Value++;
            }
            VarGau.Visible = false;
            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = imgOriginal;
        }

        unsafe private void OptimizedTonoSepia() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap imgOriginal = new Bitmap(ImagenAEditar);

            int height = imgOriginal.Height;
            int width = imgOriginal.Width;

            VarGau.Visible = true;
            VarGau.Maximum = imgOriginal.Height;
            VarGau.Value = 0;

            BitmapData sourceData = imgOriginal.LockBits(new Rectangle(0, 0, width, height),
                                                  ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte* ptrFirstPixel = (byte*)sourceData.Scan0;

            Parallel.For(0, height, y =>
            {
                byte* currentLine = ptrFirstPixel + (y * sourceData.Stride);
                for (int x = 0; x < width; x++)
                {
                    int index = x * 4;
                    int blue = currentLine[index];
                    int green = currentLine[index + 1];
                    int red = currentLine[index + 2];

                    int sepiaRed = (int)(0.393 * red + 0.769 * green + 0.189 * blue);
                    int sepiaGreen = (int)(0.349 * red + 0.686 * green + 0.168 * blue);
                    int sepiaBlue = (int)(0.272 * red + 0.534 * green + 0.131 * blue);

                    if (sepiaRed > 255)
                    {
                        sepiaRed = 255;
                    }
                    if (sepiaGreen > 255)
                    {
                        sepiaGreen = 255;
                    }
                    if (sepiaBlue > 255)
                    {
                        sepiaBlue = 255;
                    }
                    currentLine[index] = (byte)sepiaBlue;
                    currentLine[index + 1] = (byte)sepiaGreen;
                    currentLine[index + 2] = (byte)sepiaRed;
                   
                }
            });
            imgOriginal.UnlockBits(sourceData);

            VarGau.Visible = false;
            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = imgOriginal;

            GeneraHistograma(imgOriginal);
        }

        private void TonoSepia() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap imgOriginal = new Bitmap(ImagenAEditar);

            VarGau.Visible = true;
            VarGau.Maximum = imgOriginal.Width;
            VarGau.Value = 0;

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
                VarGau.Value++;
            }
            VarGau.Visible = false;
            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = imgOriginal;
        }

        private void EscalaDeGrises() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap imgOriginal = new Bitmap(ImagenAEditar);

            VarGau.Visible = true;
            VarGau.Maximum = imgOriginal.Width;
            VarGau.Value = 0;

            for (int x = 0; x < imgOriginal.Width; x++)
            {
                for (int y = 0; y < imgOriginal.Height; y++)
                {
                    Color pixelColor = imgOriginal.GetPixel(x, y);
                    int grayScale = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    imgOriginal.SetPixel(x, y, newColor);
                }
                VarGau.Value++;
            }
            VarGau.Visible = false;
            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = imgOriginal;
        }


        unsafe private void OptimizedGrayScale() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap imgOriginal = new Bitmap(ImagenAEditar);

            BitmapData bmData = imgOriginal.LockBits(new Rectangle(0, 0, imgOriginal.Width, imgOriginal.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            IntPtr scan0 = bmData.Scan0;

            int nWidth = imgOriginal.Width;
            int nHeight = imgOriginal.Height;

            VarGau.Visible = true;
            VarGau.Maximum = nHeight;
            VarGau.Value = 0;

            byte* p = (byte*)scan0.ToPointer();

            for (int y = 0; y < nHeight; ++y)
            {
                for (int x = 0; x < nWidth; ++x)
                {
                    int idx = y * stride + x * 3;

                    byte gray = (byte)(0.299 * p[idx + 2] + 0.587 * p[idx + 1] + 0.114 * p[idx]);

                    p[idx + 2] = p[idx + 1] = p[idx] = gray;
                }
                VarGau.Value++;
            }
            imgOriginal.UnlockBits(bmData);

            VarGau.Visible = false;
            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = imgOriginal;

            GeneraHistograma(imgOriginal);
        }

        unsafe private static Color GetAverageColor(int* sourcePointer, int x, int y, int blockSize, int width, int height)
        {
            unsafe 
            {
                int sumR = 0, sumG = 0, sumB = 0;
                int count = 0;

                for (int i = y; i < y + blockSize && i < height; i++)
                {
                    for (int j = x; j < x + blockSize && j < width; j++)
                    {
                        Color pixel = Color.FromArgb(*(sourcePointer + i * width + j));

                        sumR += pixel.R;
                        sumG += pixel.G;
                        sumB += pixel.B;
                        count++;
                    }
                }
            
                int avgR = sumR / count;
                int avgG = sumG / count;
                int avgB = sumB / count;
            
                return Color.FromArgb(avgR, avgG, avgB);
            }
        }

        private void Pixelizado() 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap sourceBitmap = new Bitmap(ImagenAEditar);
            int width = sourceBitmap.Width;
            int height = sourceBitmap.Height;

            Bitmap resultBitmap = new Bitmap(width, height);

            int blockSize = 10;
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData sourceData = sourceBitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData resultData = resultBitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            unsafe
            {

                VarGau.Visible = true;
                VarGau.Maximum = height;
                VarGau.Value = 0;

                int* sourcePointer = (int*)sourceData.Scan0;
                int* resultPointer = (int*)resultData.Scan0;

                for (int y = 0; y < height; y += blockSize)
                {
                    for (int x = 0; x < width; x += blockSize)
                    {
                        Color avgColor = GetAverageColor(sourcePointer, x, y, blockSize, width, height);

                        for (int i = y; i < y + blockSize && i < height; i++)
                        {
                            for (int j = x; j < x + blockSize && j < width; j++)
                            {
                                *(resultPointer + i * width + j) = avgColor.ToArgb();
                            }
                        }
                    }
                    VarGau.Value++;
                }
            }

            sourceBitmap.UnlockBits(sourceData);
            resultBitmap.UnlockBits(resultData);

            VarGau.Visible = false;
            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = resultBitmap;

            GeneraHistograma(resultBitmap);

        }

        unsafe private void Gaussiano(int size) 
        {
            ImagenAEditar = ImagenEntrada.Image;
            Bitmap sourceBitmap = new Bitmap(ImagenAEditar);
            int width = sourceBitmap.Width;
            int height = sourceBitmap.Height;

            Bitmap resultBitmap = new Bitmap(width, height);
            Rectangle rect = new Rectangle(0, 0, width, height);

            BitmapData sourceData = sourceBitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData resultData = resultBitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            int[] sourceBuffer = new int[width * height];
            int[] resultBuffer = new int[width * height];

            int* sourcePointer = (int*)sourceData.Scan0;
            int* resultPointer = (int*)resultData.Scan0;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sourceBuffer[i * width + j] = *(sourcePointer++);
                }
            }

            VarGau.Visible = true;
            VarGau.Maximum = height;
            VarGau.Value = 0;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int sumA = 0, sumR = 0, sumG = 0, sumB = 0;
                    int count = 0;

                    for (int m = -size / 2; m <= size / 2; m++)
                    {
                        for (int n = -size / 2; n <= size / 2; n++)
                        {
                            int indexX = j + n;
                            int indexY = i + m;

                            if (indexX >= 0 && indexX < width && indexY >= 0 && indexY < height)
                            {
                                Color pixel = Color.FromArgb(sourceBuffer[indexY * width + indexX]);

                                sumA += pixel.A;
                                sumR += pixel.R;
                                sumG += pixel.G;
                                sumB += pixel.B;
                                count++;
                            }
                        }
                    }

                    sumA /= count;
                    sumR /= count;
                    sumG /= count;
                    sumB /= count;

                    resultBuffer[i * width + j] = (int)((sumA << 24) | (sumR << 16) | (sumG << 8) | sumB);
                }
                VarGau.Value++;
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    *(resultPointer++) = resultBuffer[i * width + j];
                }
            }

            sourceBitmap.UnlockBits(sourceData);
            resultBitmap.UnlockBits(resultData);

            VarGau.Visible = false;

            ImagenAEditar = null;
            ImagenSalida.Image = null;
            ImagenSalida.Image = resultBitmap;

            GeneraHistograma(resultBitmap);
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            
            int selectedIndex = cmbFiltros.SelectedIndex;
            if (ImagenEntrada.Image != null) 
            {
                switch (selectedIndex)
                {
                    case 0: //Invertir colores
                        //InvertirColores();
                        OptimizedInvertColors();
                        break;
                    case 1: //Tono Sepia
                        //TonoSepia();
                        OptimizedTonoSepia();
                        break;
                    case 2: //Escala de Grises
                        //EscalaDeGrises();
                        OptimizedGrayScale();
                        break;
                    case 3: //Pixelizado
                        Pixelizado();
                        break;
                    case 4: //Gaussiano
                        string Size = Interaction.InputBox("Ingrese el tamaño de desenfoque","Tamaño de desenfoque", "5");
                        Gaussiano(Int32.Parse(Size));
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
