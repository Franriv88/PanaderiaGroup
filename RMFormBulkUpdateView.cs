using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Panadería
{
    public partial class RMFormBulkUpdateView : Form
    {
        PanaderiaSystem panaderiaSystem;
        List<RawMaterial> rawMaterials;


        public TransfDelegate BackToAdminViewTransfDelegate;
        
        public delegate void TransfDelegate();
        public RMFormBulkUpdateView(PanaderiaSystem panaderiaSystem)
        {
            this.panaderiaSystem = panaderiaSystem;
            InitializeComponent();
        }

        private void rmBulkButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                this.rawMaterials = ReadCSV(filePath);
                DisplayRawMaterials(this.rawMaterials);
            }
        }
        private List<RawMaterial> ReadCSV(string filePath)
        {
            List<RawMaterial> rawMaterials = new List<RawMaterial>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    if (fields.Length == 3)
                    {
                        int id = int.Parse(fields[0]);
                        string name = fields[1];
                        int amount = int.Parse(fields[2]);
                        RawMaterial material = new RawMaterial(id, name, amount);
                        rawMaterials.Add(material);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading csv");
            }

            return rawMaterials;
        }

        private void DisplayRawMaterials(List<RawMaterial> rawMaterials)
        {
            dataGridView1.Rows.Clear();

            foreach (RawMaterial material in rawMaterials)
            {
                dataGridView1.Rows.Add(material.id.ToString(), material.name, material.amount.ToString());
            }
        }

        private void rmBulkButtonConfirm_Click(object sender, EventArgs e)
        {
            this.panaderiaSystem.bulkUploadRawMaterial(this.rawMaterials);
            this.BackToAdminViewTransfDelegate();
        }

        private void rmBulkButtonBack_Click(object sender, EventArgs e)
        {
            this.BackToAdminViewTransfDelegate();
        }
    }
}
