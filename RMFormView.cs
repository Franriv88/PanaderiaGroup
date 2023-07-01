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
    public partial class RMFormView : Form
    {
        public PanaderiaSystem panaderiaSystem;
        public TransfDelegate BackToAdminViewTransfDelegate;

        public delegate void TransfDelegate();
        public RMFormView(PanaderiaSystem panaderiaSystem)
        {
            this.panaderiaSystem = panaderiaSystem;
            InitializeComponent();
        }

        private void rmButtonSave_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error: unity no selected");
                return;
            }
            string rawMaterialName = this.listBox1.SelectedItem.ToString();
            RawMaterial rawMaterial = new RawMaterial(this.rmNameInput.Text, rawMaterialName);
            this.panaderiaSystem.saveRawMaterial(rawMaterial);
            this.BackToAdminViewTransfDelegate();
        }

        private void rmBackButton_Click(object sender, EventArgs e)
        {
            this.BackToAdminViewTransfDelegate();
        }
    }
}
