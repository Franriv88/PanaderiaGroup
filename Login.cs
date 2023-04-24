using System;
using System.Collections.Generic;

namespace Panaderia {
	public partial class Login : Form {
		public BackendService backendService;

		public Login(BackendService backendService) {
			InitializeComponent();
			this.backendService = backendService;
		}

		private void loginButton_Click(object sender, EventArgs e) {
			
		}
	}
}
