using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Form4 : Form
    {
        List<Product> iListaPorductos;
        public Form4(List<Product> pListaPorductos)
        {
            this.iListaPorductos = pListaPorductos;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
