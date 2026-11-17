using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginComInterface
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(string usuario)
        {
            InitializeComponent();

            lblUsuarioLogado.Text = usuario;
        }
    }
}
