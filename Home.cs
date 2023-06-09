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
		AdminView adminView;

		public Home() {
			InitializeComponent();
			this.panaderiaSystem = new PanaderiaSystem();
            this.login = new Login(this.panaderiaSystem);
            this.login.MdiParent = this;
            this.login.TransfEvento = this.TransfDelegadoLoginSuccess;
            this.login.Show();
        }

		public void TransfDelegadoLoginSuccess() {
			this.login.Close();
			bool isAdmin = this.panaderiaSystem.currentUser.isAdmin;
			if (isAdmin) {
				this.loadAdminView();
				return;
			}
			//this.loadSellerView();
		}

		public void loadAdminView() {
			this.adminView = new AdminView(this.panaderiaSystem);
			this.adminView.MdiParent = this;
            this.adminView.Show();
        }
	}
}
