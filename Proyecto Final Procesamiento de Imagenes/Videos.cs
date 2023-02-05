using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;
using FFmpeg.AutoGen;

namespace Proyecto_Final_Procesamiento_de_Imagenes
{

    public partial class Videos : Form
    {

        private string VideoActual = "";
        private string NombreVActual = "";
        
        public Videos()
        {
            InitializeComponent();
            
        }

        private void btnCargarVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de video (*.mp4, *.mp3, *.avi, *.mkv, ...)|*.mp4;*.mp3;*.avi;*.mkv;...";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                VideoEE.playlist.items.clear();
                VideoEE.playlist.add(@"file:///" + openFileDialog.FileName);
                VideoEE.playlist.play();
                VideoF1.Visible = false;
                VideoActual = openFileDialog.FileName;
                NombreVActual = openFileDialog.SafeFileName;
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

       unsafe private void BitmapToMP4(string Name, Bitmap[] framess) 
        {
            Bitmap[] frames = framess;

           
        }

        private Bitmap[] VideoToBitmap(string videoFilePath) 
        {
            BitmapDecoder decoder = BitmapDecoder.Create(new Uri(videoFilePath), BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            int frameCount = decoder.Frames.Count;
            Bitmap[] frames = new Bitmap[frameCount];

            for (int i = 0; i < frameCount; i++)
            {
                BitmapSource source = decoder.Frames[i];
                using (MemoryStream stream = new MemoryStream())
                {
                    BitmapEncoder encoder = new BmpBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(source));
                    encoder.Save(stream);
                    frames[i] = new Bitmap(stream);
                }
            }

            return frames;
        }

        unsafe private void InvertirColores() 
        {   
            Bitmap[] imgOriginal = VideoToBitmap(VideoActual);
            for (int v = 0; v < imgOriginal.Length; v++)
            {
                BitmapData bmpData = imgOriginal[v].LockBits(new Rectangle(0, 0, imgOriginal[v].Width, imgOriginal[v].Height), ImageLockMode.ReadWrite, imgOriginal[v].PixelFormat);
                int bytesPerPixel = Bitmap.GetPixelFormatSize(imgOriginal[v].PixelFormat) / 8;
                int heightInPixels = bmpData.Height;
                int widthInBytes = bmpData.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bmpData.Scan0;

                VarGau.Visible = true;
                VarGau.Maximum = imgOriginal.Length;
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
                    
                }
                VarGau.Value++;
                imgOriginal[v].UnlockBits(bmpData);
            }
           
            VarGau.Visible = false;
        }

        private void btnAplicarFiltroV_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbFiltrosV.SelectedIndex;
            if (VideoEE.playlist.items.count > 0) 
            {
                switch (selectedIndex)
                {
                    case 0: //Invertir colores
                        InvertirColores();
                        break;
                    case 1: //Tono Sepia
                        
                        break;
                    case 2: //Escala de Grises
                        
                        break;
                    case 3: //Pixelizado
                        
                        break;
                    case 4: //
                       
                        break;
                    default:
                        MessageBox.Show("Por favor seleccione un filtro.");
                        break;
                }
            }
        }
    }
}
