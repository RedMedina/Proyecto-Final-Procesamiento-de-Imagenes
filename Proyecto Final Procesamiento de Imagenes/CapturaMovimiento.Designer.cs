
namespace Proyecto_Final_Procesamiento_de_Imagenes
{
    partial class CapturaMovimiento
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
            this.btnCameraActiva = new System.Windows.Forms.Button();
            this.CameraSalida = new System.Windows.Forms.PictureBox();
            this.btnCloseCam = new System.Windows.Forms.Button();
            this.CantRostros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CameraSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCameraActiva
            // 
            this.btnCameraActiva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCameraActiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCameraActiva.FlatAppearance.BorderSize = 0;
            this.btnCameraActiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCameraActiva.ForeColor = System.Drawing.Color.LightGray;
            this.btnCameraActiva.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_compact_camera_25;
            this.btnCameraActiva.Location = new System.Drawing.Point(388, 588);
            this.btnCameraActiva.Name = "btnCameraActiva";
            this.btnCameraActiva.Size = new System.Drawing.Size(184, 59);
            this.btnCameraActiva.TabIndex = 1;
            this.btnCameraActiva.Text = "Activar";
            this.btnCameraActiva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCameraActiva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCameraActiva.UseVisualStyleBackColor = false;
            this.btnCameraActiva.Click += new System.EventHandler(this.btnCameraActiva_Click);
            // 
            // CameraSalida
            // 
            this.CameraSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CameraSalida.Location = new System.Drawing.Point(12, 12);
            this.CameraSalida.Name = "CameraSalida";
            this.CameraSalida.Size = new System.Drawing.Size(938, 570);
            this.CameraSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CameraSalida.TabIndex = 0;
            this.CameraSalida.TabStop = false;
            // 
            // btnCloseCam
            // 
            this.btnCloseCam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCloseCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCloseCam.FlatAppearance.BorderSize = 0;
            this.btnCloseCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCam.ForeColor = System.Drawing.Color.LightGray;
            this.btnCloseCam.Image = global::Proyecto_Final_Procesamiento_de_Imagenes.Properties.Resources.icons8_no_camera_25;
            this.btnCloseCam.Location = new System.Drawing.Point(578, 588);
            this.btnCloseCam.Name = "btnCloseCam";
            this.btnCloseCam.Size = new System.Drawing.Size(60, 59);
            this.btnCloseCam.TabIndex = 2;
            this.btnCloseCam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseCam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseCam.UseVisualStyleBackColor = false;
            this.btnCloseCam.Visible = false;
            this.btnCloseCam.Click += new System.EventHandler(this.btnCloseCam_Click);
            // 
            // CantRostros
            // 
            this.CantRostros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CantRostros.AutoSize = true;
            this.CantRostros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantRostros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.CantRostros.Location = new System.Drawing.Point(662, 602);
            this.CantRostros.Name = "CantRostros";
            this.CantRostros.Size = new System.Drawing.Size(27, 25);
            this.CantRostros.TabIndex = 3;
            this.CantRostros.Text = "...";
            this.CantRostros.Visible = false;
            // 
            // CapturaMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(962, 658);
            this.Controls.Add(this.CantRostros);
            this.Controls.Add(this.btnCloseCam);
            this.Controls.Add(this.btnCameraActiva);
            this.Controls.Add(this.CameraSalida);
            this.Name = "CapturaMovimiento";
            this.Text = "CapturaMovimiento";
            ((System.ComponentModel.ISupportInitialize)(this.CameraSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CameraSalida;
        private System.Windows.Forms.Button btnCameraActiva;
        private System.Windows.Forms.Button btnCloseCam;
        private System.Windows.Forms.Label CantRostros;
    }
}