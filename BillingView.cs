using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transitions;
using System.Windows.Forms;

namespace Proyecto_Panadería
{
    public partial class BillingView : Form
    {
        public BillingView()
        {
            InitializeComponent();
        }
        
        //Transición de icónos PDF-Check
        private void sendButton_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(10));
            t.add(pdfPictureBox, "Left", -300);
            t.add(okPictureBox, "Left", 389);
            t.run();
        }
    }
}
