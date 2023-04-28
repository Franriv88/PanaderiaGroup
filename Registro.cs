using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Panadería
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            btn_Registrar.Enabled = false;

            if(label4.Visible == true)
            {
                label9.Text = "Registe Empleado"; //estamos en el registro de empleados
                btn_Empleado.Text = "Cliente"; //para swichear a registro cliente
                label4.Visible = false;
                emailBox.Visible = false;
                label5.Visible = false;
                addressBox.Visible = false;
                label6.Visible = false;
                brithDateBox.Visible = false;
                pictureBox1.Visible = true;
            }
            else
            {
                
                emailBox.Visible = true;
                label5.Visible = true;
                addressBox.Visible = true;
                label6.Visible = true;
                brithDateBox.Visible = true;
                pictureBox1.Visible = false;

                
            }
        }

  
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
