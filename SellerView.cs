using iText.Svg.Renderers.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Panadería.panaderiaDataSet;

namespace Proyecto_Panadería
{
    public partial class SellerView : Form
    {
        public PanaderiaSystem panaderiaSystem;
        public SellerView(PanaderiaSystem panaderiaSystem)
        {
            this.panaderiaSystem = panaderiaSystem;
            InitializeComponent();
            rellenar();
        }

        
        private void listSellerView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //------------ DataGridView ------------------//

       
        private void rellenar()
        {
            // Crea una nueva fila
            DataGridViewRow row = new DataGridViewRow();

            // Crea las celdas para la fila
            DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
            DataGridViewImageCell imageCell = new DataGridViewImageCell();
            DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();

            // Establece los valores de las celdas
            nameCell.Value = "Nombre del producto";

            // Aquí debes cargar manualmente la imagen del producto en la celda de imagen
            // Por ejemplo
            //String img = @"C:\Users\SRV\Desktop\DaVinci\Cuatrimestre 6\Plataformas de Desarrollo\Mulitmedia\Productos\Donas.jpg";
            //imageCell.Value = Image.FromFile(@"C:\Users\SRV\Desktop\DaVinci\Cuatrimestre 6\Plataformas de Desarrollo\Mulitmedia\Productos\Donas.jpg");
           
            buttonCell.Value = "Agregar";

            // Agrega las celdas a la fila
            row.Cells.Add(nameCell);
            row.Cells.Add(imageCell);
            row.Cells.Add(buttonCell);

            // Agrega la fila al control DataGridView
            dataGridView.Rows.Add(row);
        }
       
    }
}
