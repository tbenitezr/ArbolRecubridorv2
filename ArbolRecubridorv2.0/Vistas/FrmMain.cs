using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//


namespace ArbolRecubridorv2._0
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmUno_Load(object sender, EventArgs e)
        {
            lblNodes.Visible = false;
            tbxNodes.Visible = false;
            lblPath.Visible = false;
            tbxPath.Visible = false;
            rbnRuta.Checked = false;
            rbnOther.Checked = false;
            llbSearch.Visible = false;


        }

        private void rbnRuta_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnRuta.Checked == true)
            {
                lblNodes.Visible = true;
                tbxNodes.Visible = true;
                lblPath.Visible = true;
                tbxPath.Visible = true;
                llbSearch.Visible = true;
            }
        }

        private void rbnOther_CheckedChanged(object sender, EventArgs e)
        {
            lblNodes.Visible = false;
            tbxNodes.Visible = false;
            lblPath.Visible = false;
            tbxPath.Visible = false;
            llbSearch.Visible = false;
        }

        private void tbxNodes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxNodes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta números.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxPath_TextChanged(object sender, EventArgs e)
        {
            btnAcept.Enabled = true;
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (rbnRuta.Checked = true && tbxPath.Text.Length > 0 && tbxNodes.Text.Length > 0)
            {
                if(tbxPath.Text.Length < 0 || tbxPath.Text == " ")
                {
                    MessageBox.Show("La ruta es incorrecta");
                }
                else if (Convert.ToInt64(tbxNodes.Text) < 0 )
                {
                    MessageBox.Show("El número de nodos no aceptado");
                }
                else
                {
                    //Redireccionar 
                    Files file = new Files(tbxPath.Text, tbxNodes.Text);
                    file.Create();
                    this.Hide();
                    new FrmGraph().Show();
                }
            }
        }

        //Falta hacerlo manualmente

        
    }
}
