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

namespace Proyecto_Final_Procesamiento_de_Imagenes
{
    public partial class CapturaMovimiento : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private ComboBox cmbVideoDevices;
      
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
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Actualiza el PictureBox con el nuevo frame
            CameraSalida.Image = (System.Drawing.Bitmap)eventArgs.Frame.Clone();
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            image = new Grayscale(0.2125, 0.7154, 0.0721).Apply(image);
            image = new BradleyLocalThresholding().Apply(image);
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 20;
            blobCounter.MinHeight = 20;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;
            blobCounter.ProcessImage(image);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            int faceCount = rects.Length;
            //Console.WriteLine("Se han detectado " + faceCount + " rostros");
        }

        private void btnCloseCam_Click(object sender, EventArgs e)
        {
            // Detiene la transmisión de video
            videoSource.SignalToStop();

            // Libera los recursos
            videoSource.WaitForStop();
            videoSource = null;
            CameraSalida.Image = null;
            btnCloseCam.Visible = false;
        }
    }
}
