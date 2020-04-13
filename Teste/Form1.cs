using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DesignDiferente();
        }
        private void DesignDiferente()
        {
            pnlEsconde.Visible = false;
        }
        private void Hide()
        {
            if (pnlEsconde.Visible == true)
                pnlEsconde.Visible = false;
        }
        private void Show(Panel pnl)
        {
            if (pnlEsconde.Visible == false)
            {
                Hide();
                pnlEsconde.Visible = true;
            }
            else
            {
                pnlEsconde.Visible = false;
            }
               
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Show(pnlEsconde);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deu bom!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deu bom!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deu bom!");
        }
    }
}
