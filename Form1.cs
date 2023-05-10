using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Panadería {
	public partial class Form1 : Form {
		//views declaration
		Login login;
		Home home;

		public Form1() {
			InitializeComponent();
			this.login = new Login();
			this.login.MdiParent = this;
			this.login.TransfEvento = this.TransfDelegadoHome;
			this.login.Show();
		}

		private void button1_Click(object sender, EventArgs e) {
			RegistroCliente r = new RegistroCliente();
			r.Show();
		}

		public void TransfDelegadoHome() {
			this.login.Close();
			this.home = new Home();
		}
	}
}
