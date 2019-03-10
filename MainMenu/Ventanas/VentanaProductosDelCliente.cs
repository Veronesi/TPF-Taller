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
    public partial class VentanaProductosDelCliente : Form
    {
        String iNombre;
        List<Product> iListaPorductos;
        String iDni;
        public VentanaProductosDelCliente(List<Product> pListaPorductos,String pDni, String pNombre)
        {
            this.iNombre = pNombre;
            this.iDni = pDni;
            this.iListaPorductos = pListaPorductos;
            InitializeComponent();
        }

        private void VentanaProductosDelCliente_Load(object sender, EventArgs e)
        {
            /* Agregamos las tarjeas a la tabla */
            List<string> _items = new List<string>();
            foreach (Product producto in iListaPorductos)
            {
                _items.Add($"{producto.number} [ {producto.name} ] <{producto.type}>");
            }
            listBoxTarjetas.DataSource = _items;
        }

        private void btnBlanquear_Click(object sender, EventArgs e)
        {
            int tarjeta = listBoxTarjetas.SelectedIndex;
            DialogResult result = MessageBox.Show($"Seguro que dese Blanquear la tarjeta {this.iListaPorductos[tarjeta].number}?", "Blanqueo de tarjeta", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                getJson json = new getJson();
                JsonErrorRest getJson = json.ProductReset(this.iListaPorductos[tarjeta].number);

                if(getJson.response.error == "0")
                    MessageBox.Show($"Se ha blanqueado con exito!\n Numero tarjeta: {getJson.number}", "Éxito");
                else
                    MessageBox.Show($"Servicio no Disponible\n {getJson.response.errorDescription}", "Error");
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaMenuPrincipal ventanaMenuPrincipal = new VentanaMenuPrincipal(iNombre, this.iDni);
            ventanaMenuPrincipal.Show();
            this.Hide();
        }
    }
}
