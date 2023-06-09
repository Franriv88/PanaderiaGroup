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
    public partial class Login : Form
    {
        public PanaderiaSystem panaderiaSystem;
        public TransfDelegado TransfEvento;

        public delegate void TransfDelegado();
        public Login(PanaderiaSystem panaderiaSystem)
        {
            InitializeComponent();
            this.panaderiaSystem = panaderiaSystem;
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
    }
}
