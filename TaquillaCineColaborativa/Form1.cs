using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaquillaCineColaborativa
{
    public partial class frmCine : Form
    {
        public frmCine()
        {
            InitializeComponent();
            cmbTipoBoleto.SelectedIndex = 0;
            this.Text = "🎬 Taquilla de Cine - Sistema de Ventas";
        }

        private void frmCine_Load(object sender, EventArgs e)
        {

        }
    }
}
