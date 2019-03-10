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
    public partial class VentanaPin : Form
    {
        private String iDni;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDni">Dni ingresado en la anterior ventana</param>
        public VentanaPin(String pDni)
        {
            this.iDni = pDni;
            InitializeComponent();
        }

        /* Botones Numericos */
        private void btnNum1_Click(object sender, EventArgs e)
        {
            this.ingresarNumero("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            this.ingresarNumero("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            this.ingresarNumero("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            this.ingresarNumero("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            this.ingresarNumero("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            this.ingresarNumero("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            this.ingresarNumero("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            this.ingresarNumero("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            this.ingresarNumero("9");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            this.ingresarNumero("0");
        }
        /* Botones de Borrar y OK */
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            /* Borramos el campo DNI */
            this.textBoxPdw.Text = "";
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxPdw.TextLength != this.textBoxPdw.MaxLength)
                    throw new LengthPinException();

                /* Verificamos si el Dni y pin coinciden */
                getJson json = new getJson();
                Clients getJson = json.Clients(this.iDni, this.textBoxPdw.Text);
                if (getJson == null)
                    throw new AuthenticationException();

                VentanaMenuPrincipal frm3 = new VentanaMenuPrincipal(getJson.response.client.name, getJson.id);
                frm3.Show();
                this.Hide();
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("Problemas en la autentificación", "Error");
                VentanaDni frm1 = new VentanaDni();
                frm1.Show();
                this.Hide();
            }
            catch (LengthPinException)
            {
                MessageBox.Show($"El pin debe ser de {this.textBoxPdw.MaxLength} caracteres", "Error");
            } 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaDni frm1 = new VentanaDni();
            frm1.Show();
            this.Hide();
        }
        /// <summary>
        /// Agrega un caracter al campo textBoxPdw
        /// </summary>
        /// <param name="pNumero">Numero presionado</param>
        private void ingresarNumero(string pNumero)
        {
            if (this.textBoxPdw.TextLength < this.textBoxPdw.MaxLength)
                this.textBoxPdw.Text += pNumero;
        }

        private void VentanaPin_Load(object sender, EventArgs e)
        {

        }
    }
}
