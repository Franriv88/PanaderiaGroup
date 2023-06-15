using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Panadería
{
    public partial class Login : Form
    {
        public PanaderiaSystem panaderiaSystem;
        public TransfDelegado TransfEvento;

        public delegate void TransfDelegado();
        public Login(PanaderiaSystem panaderiaSystem)
        {
            InitializeComponent();
            this.panaderiaSystem = panaderiaSystem;

            /*
            //Estabelcemos el estilo del control PictureBox para lograr la transparencia
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);

            //Hacemo que el formulario tenga fondo translúcido
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            */
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string psw = PswInputText.Text;
            string userName = userNameInputText.Text;
            if (string.IsNullOrEmpty(psw) || string.IsNullOrEmpty(userName)) {
                MessageBox.Show("Login Error: 1");
                return;
            }

            if (!this.panaderiaSystem.loginUser(userName, psw)) {
                MessageBox.Show("Login Error: 2");
                return;
            }

            MessageBox.Show("Login Success");
            this.TransfEvento();
        }

        /*
        private void ConfigurePswInputText()
        {
            //creamos un RichTextoBox
            RichTextBox richTextBox = new RichTextBox();

            //establecemos el colo de fondo transparente
            richTextBox.BackColor = Color.Transparent;

            //ajustamos otras porpiedades
            richTextBox.BorderStyle = BorderStyle.None;

            //agregamos el RichTextBox al formulario
            this.Controls.Add(richTextBox);
        }
        */
        /*
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Establecemos la opacidad del PictureBox
            float opacity = 0.5f; 

            Color transparentColor = Color.FromArgb((int)(opacity*255), BackColor);
            Brush brush = new SolidBrush(transparentColor);

            e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }
        */
    }
}
