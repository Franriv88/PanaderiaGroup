﻿using System;
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
    public partial class ProductFormView : Form
    {
        public PanaderiaSystem panaderiaSystem;
        public ProductFormView(PanaderiaSystem panaderiaSystem)
        {
            this.panaderiaSystem = panaderiaSystem;
            InitializeComponent();
        }
    }
}