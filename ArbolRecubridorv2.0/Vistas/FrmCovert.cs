using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolRecubridorv2._0.Vistas
{
    public partial class FrmCovert : Form
    {
        public FrmCovert()
        {
            InitializeComponent();
        }

        private void FrmCovert_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(15000); // Delay por 5 seg.
            this.Close();
        }
    }
}
