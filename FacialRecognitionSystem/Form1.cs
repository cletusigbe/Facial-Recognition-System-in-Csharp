using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace FacialRecognitionSystem
{
    public partial class Form1 : Form
    {
        FaceRec faceRec = new FaceRec();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pictureBoxCamara, pictureBoxCaptured);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(txtName.Text.ToUpper());
            lblmsg.ForeColor = System.Drawing.Color.Green;
            lblmsg.Text = "Saved";
        }

        private void btnDetectFace_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
            faceRec.getPersonName(lblName);
        }
    }
}
