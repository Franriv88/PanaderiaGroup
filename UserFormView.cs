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
    public partial class UserFormView : Form
    {
        public PanaderiaSystem panaderiaSystem;
        public TransfDelegate BackToAdminViewTransfDelegate;

        public delegate void TransfDelegate();
        public UserFormView(PanaderiaSystem panaderiaSystem)
        {
            this.panaderiaSystem = panaderiaSystem;
            InitializeComponent();
        }

        private void userSaveButton_Click(object sender, EventArgs e)
        {
            string name = this.userNameTextBox.Text;
            string lastName = this.userLastNameTextBox.Text;
            string userName = this.userUserNameTextBox.Text;
            string psw = this.userPswTextBox.Text;
            bool isAdmin = this.userIsAdminCheckBox.Checked;
            User user = new User(name, lastName, userName, psw, isAdmin);
            this.panaderiaSystem.saveUser(user);
            this.BackToAdminViewTransfDelegate();

        }

        private void userBackButton_Click(object sender, EventArgs e)
        {
            this.BackToAdminViewTransfDelegate();
        }
    }
}
