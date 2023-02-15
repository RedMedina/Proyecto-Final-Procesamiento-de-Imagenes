using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Vision.Motion;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Cuda;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace Proyecto_Final_Procesamiento_de_Imagenes
{
    public partial class CapturaMovimiento : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private ComboBox cmbVideoDevices;
        // Create a list to store the rectangles for each frame
        private List<Rectangle> faceRectangles = new List<Rectangle>();
        private bool OpenCamera = true;

        public CapturaMovimiento()
        {
            InitializeComponent();
            cmbVideoDevices = new ComboBox();
            cmbVideoDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVideoDevices.Location = new System.Drawing.Point(12, 12);
            cmbVideoDevices.Name = "cmbVideoDevices";
            cmbVideoDevices.Size = new System.Drawing.Size(260, 21);
            cmbVideoDevices.TabIndex = 0;
            this.Controls.Add(cmbVideoDevices);
        }

        private void btnCameraActiva_Click(object sender, EventArgs e)
        {
            btnCloseCam.Visible = true;
            CantRostros.Visible = true;
            var capture = new VideoCapture(); // Abrir la cámara por defecto
            if (!capture.IsOpened)
            {
                MessageBox.Show("No se encontraron dispositivos de video.");
                return;
            }

            var faceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");

            while (OpenCamera)
            {
                using (var frame = capture.QueryFrame().ToImage<Bgr, byte>())
                {
                    if (frame == null)
                        break;

                    var grayFrame = frame.Convert<Gray, byte>();
                    var faces = faceCascade.DetectMultiScale(grayFrame, 1.1, 3, Size.Empty);

                    foreach (var face in faces)
                    {
                        frame.Draw(face, new Bgr(Color.Red), 2);
                    }

                    //CvInvoke.Imshow("Cámara", frame);

                    CameraSalida.Image = frame.ToBitmap();

                    if (CvInvoke.WaitKey(1) >= 0) // Salir si se presiona una tecla
                        break;

                    int faceCount = faces.Length;
                    Console.WriteLine("Se han detectado " + faceCount + " rostros.");
                    CantRostros.Text = "Se han detectado " + faceCount + " rostros.";
                }
            }

            /*
            // Obtiene la lista de dispositivos de video disponibles
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No se encontraron dispositivos de video.");
                return;
            }
            foreach (FilterInfo device in videoDevices)
            {
                cmbVideoDevices.Items.Add(device.Name);
            }
            cmbVideoDevices.SelectedIndex = 0;

            // Crea una nueva instancia de VideoCaptureDevice utilizando el dispositivo de video seleccionado
            videoSource = new VideoCaptureDevice(videoDevices[cmbVideoDevices.SelectedIndex].MonikerString);

            // Asigna un controlador de eventos para el evento NewFrame
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

            // Inicia la transmisión de video
            videoSource.Start();
             btnCloseCam.Visible = true;
            */
        }

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = new Bitmap((Bitmap)eventArgs.Frame.Clone());
            Image<Bgr, byte> grayImage = bitmap.ToImage<Bgr, byte>();
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);

            // Add the rectangles to the list
            faceRectangles.AddRange(rectangles);

            // Keep only the rectangles from the last 10 frames
            if (faceRectangles.Count > 1)
            {
                faceRectangles.RemoveRange(0, faceRectangles.Count - 1);
            }

            // Calculate the average rectangle
            //Rectangle averageRectangle = GetAverageRectangle(faceRectangles);

            foreach (Rectangle face in faceRectangles)
            {
                using(Graphics graphics = Graphics.FromImage(bitmap)) 
                {
                    using (Pen pen = new Pen(Color.Red, 1)) 
                    {
                        graphics.DrawRectangle(pen,face);
                    }
                }
            }
            // Actualiza el PictureBox con el nuevo frame
            CameraSalida.Image = bitmap;
            // Contar el número de rostros detectados
            int faceCount = rectangles.Length;
            Console.WriteLine("Se han detectado " + faceCount + " rostros.");
        }

        private Rectangle GetAverageRectangle(List<Rectangle> rectangles)
        {
            int left = 0, top = 0, right = 0, bottom = 0;
            int count = rectangles.Count;

            for (int i = 0; i < count; i++)
            {
                left += rectangles[i].Left;
                top += rectangles[i].Top;
                right += rectangles[i].Right;
                bottom += rectangles[i].Bottom;
            }

            left /= count;
            top /= count;
            right /= count;
            bottom /= count;

            return new Rectangle(left, top, right - left, bottom - top);
        }

        private void btnCloseCam_Click(object sender, EventArgs e)
        {
            /*
            // Detiene la transmisión de video
            videoSource.SignalToStop();
            // Libera los recursos
            videoSource.WaitForStop();
            videoSource = null;
            */
            OpenCamera = false;
            CameraSalida.Image = null;
            btnCloseCam.Visible = false;
            CantRostros.Visible = false;
        }
    }
}
