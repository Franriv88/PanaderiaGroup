using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Panadería {
	public partial class Home : Form {
		//System Declaration
		PanaderiaSystem panaderiaSystem;

		//Views Declaration
		Login login;

		public Home() {
			InitializeComponent();
			this.panaderiaSystem = new PanaderiaSystem();
            this.login = new Login();
            this.login.MdiParent = this;
            this.login.TransfEvento = this.TransfDelegadoHome;
            this.login.Show();
        }

		public void TransfDelegadoHome() {
			//this.login.Close();
		}
	}
}
