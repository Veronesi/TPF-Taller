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
    public partial class VentanaMenuPrincipal : Form
    {
        private String iNombre;
        private String iDni;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pNombre">Nombre del Cliente</param>
        /// <param name="pDni">Dni del cliente</param>
        public VentanaMenuPrincipal(String pNombre, String pDni)
        {
            this.iNombre = pNombre;
            this.iDni = pDni;
            InitializeComponent();
        }

        private void VentanaMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Mostramos el nombre del cliente 
            this.labelNombre.Text = $"Bienvenido {this.iNombre}";
        }

        private void btnBlanqueo_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos la lista de productos 
                getJson json = new getJson();
                JsonProduct getJson = json.Products(this.iDni);
                if (getJson == null)
                    throw new JsonNullException();

                VentanaProductosDelCliente ventanaProductosDelCliente = new VentanaProductosDelCliente(getJson.response.product, this.iDni, this.iNombre);
                ventanaProductosDelCliente.Show();
                this.Hide();
            }
            catch (JsonNullException)
            {
                MessageBox.Show("Servicio no Disponible", "Error");
            }
            catch (Exception err)
            {
                Log.save(err);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            VentanaDni ventanaDni = new VentanaDni();
            ventanaDni.Show();
            this.Hide();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            VentanaUltimosMovimientos ventanaUltimosMovimientos = new VentanaUltimosMovimientos(this.iNombre,this.iDni);
            ventanaUltimosMovimientos.Show();
            this.Hide();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                /* Obtenemos el saldo de la cuenta corriente */
                getJson json = new getJson();
                JsonBalance getJson = json.Balance(this.iDni);
                if (getJson == null)
                    throw new JsonNullException();
                /* Mostramos el saldo */
                MessageBox.Show($"Saldo de cuenta corriente: {getJson.response.balance}", $"{this.iNombre}");
            }
            catch(JsonNullException)
            {
                MessageBox.Show("Servicio no Disponible", "Error");
            }
            catch (Exception err)
            {
                Log.save(err);
            }
        }
    }
}
