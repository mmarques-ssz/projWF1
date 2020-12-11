using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projWF1
{
    public partial class frmContador : Form
    {
        private Contador contador;

        public frmContador()
        {
            InitializeComponent();
            contador = new Contador(100);
            atualiza_interface();
        }

        public void atualiza_interface()
        {
            lblValor.Text = contador.getValor().ToString();
        }

        private void clicou_no_subtrair(object sender, EventArgs e)
        {
            if (txtIncremento.Text == "")
            {
                contador.subtrair();
            }
            else
            {
                contador.subtrair(int.Parse(txtIncremento.Text));
            }
            atualiza_interface();
        }

        private void clicou_no_zerar(object sender, EventArgs e)
        {
            contador.zerar();
            atualiza_interface();
        }

        private void clicou_no_adicionar(object sender, EventArgs e)
        {
            if (txtIncremento.Text == "")
            {
                contador.adicionar();
            }
            else
            {
                contador.adicionar(int.Parse(txtIncremento.Text));
            }
            atualiza_interface();
        }

    }
}
