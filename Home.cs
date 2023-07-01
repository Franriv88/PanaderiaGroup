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
		ProductFormView productFormView;
		RMFormView rmFormView;
        UserFormView userFormView;
		RMFormBulkUpdateView rmFormBulkUpdateView;

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
            this.adminView.AddProductTransfDelegate += this.loadProductFormView;
			this.adminView.AddRMTransfDelegate += this.loadRMFormView;
            this.adminView.AddUserTransfDelegate += this.loadUserFormView;
            this.adminView.BulkUpdateRMTransfDelegate += this.loadRMFormBulkUpdateView;
            this.adminView.Show();
        }

		public void loadProductFormView() {
			this.adminView.Close();
			this.productFormView = new ProductFormView(this.panaderiaSystem);
			this.productFormView.MdiParent = this;
			this.productFormView.Show();	
		}

		public void loadRMFormView()
		{
			this.adminView.Close();
			this.rmFormView = new RMFormView(this.panaderiaSystem);
			this.rmFormView.MdiParent = this;
            this.rmFormView.BackToAdminViewTransfDelegate += this.rmToAdminview;
            this.rmFormView.Show();
        }

        public void rmToAdminview()
        {
            this.rmFormView.Close();
            this.loadAdminView();
        }
        public void loadUserFormView()
        {
            this.adminView.Close();
            this.userFormView = new UserFormView(this.panaderiaSystem);
            this.userFormView.MdiParent = this;
            this.userFormView.BackToAdminViewTransfDelegate += this.userToAdminview;
            this.userFormView.Show();
        }

        public void userToAdminview()
        {
            this.userFormView.Close();
            this.loadAdminView();
        }

        public void loadRMFormBulkUpdateView()
        {
            this.adminView.Close();
			this.rmFormBulkUpdateView = new RMFormBulkUpdateView(this.panaderiaSystem);
            this.rmFormBulkUpdateView.MdiParent = this;
            this.rmFormBulkUpdateView.BackToAdminViewTransfDelegate += this.rmBulkUpdateToAdminview;
            this.rmFormBulkUpdateView.Show();
        }
        public void rmBulkUpdateToAdminview()
        {
            this.rmFormBulkUpdateView.Close();
            this.loadAdminView();
        }

    }
}
