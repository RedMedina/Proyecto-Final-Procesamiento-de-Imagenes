using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
using WMPLib;

namespace Proyecto_Final_Procesamiento_de_Imagenes
{
    
    public partial class Videos : Form
    {

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
                try 
                {
                    EntradaDeVideo.URL = openFileDialog.FileName;
                    //EntradaDeVideo.Ctlcontrols.play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al reproducir el vídeo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //EntradaDeVideo.URL = URLVideo;
            EntradaDeVideo.Ctlcontrols.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            EntradaDeVideo.Ctlcontrols.pause();
        }
    }
}
