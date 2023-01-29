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
