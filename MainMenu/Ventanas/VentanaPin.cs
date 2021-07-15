using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainMenu.Ventanas;

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
            this.CenterToScreen();
        }

        /* Botones Numericos */
        private void btnNum1_Click(object sender, EventArgs e)
        {
            this.setNumber("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            this.setNumber("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            this.setNumber("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            this.setNumber("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            this.setNumber("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            this.setNumber("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            this.setNumber("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            this.setNumber("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            this.setNumber("9");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            this.setNumber("0");
        }
        /* Botones de Borrar y OK */
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            /* Borramos el campo DNI */
            this.textBoxPdw.Text = "";
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            VentanaCargando ventanaCargando = new VentanaCargando();
            try
            {
                if (this.textBoxPdw.TextLength != this.textBoxPdw.MaxLength)
                    throw new LengthPinException();
                
                ventanaCargando.Show();
                /* Verificamos si el Dni y pin coinciden */
                getJson json = new getJson();
                JsonClient getJson = json.Clients(this.iDni, this.textBoxPdw.Text);
                ventanaCargando.Hide();
                if (getJson == null)
                    throw new AuthenticationException();

                OperationRegister.pin(this.iDni);
                VentanaMenuPrincipal ventanaMenuPrincipal = new VentanaMenuPrincipal(getJson.response.client.name, getJson.id);
                ventanaMenuPrincipal.Show();
                this.Hide();
            }
            catch (AuthenticationException)
            {
                OperationRegister.pin(this.iDni, false);
                MessageBox.Show("Problemas en la autentificación", "Error");
                VentanaDni ventanaDni = new VentanaDni();
                ventanaDni.Show();
                this.Hide();
            }
            catch (LengthPinException)
            {
                MessageBox.Show($"El pin debe ser de {this.textBoxPdw.MaxLength} caracteres", "Error");
            }
            catch (Exception err)
            {
                ventanaCargando.Hide();
                Log.save(err);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaDni ventanaDni = new VentanaDni();
            ventanaDni.Show();
            this.Hide();
        }
        /// <summary>
        /// Agrega un caracter al campo textBoxPdw
        /// </summary>
        /// <param name="pNumero">Numero presionado</param>
        private void setNumber(string pNumero)
        {
            if (this.textBoxPdw.TextLength < this.textBoxPdw.MaxLength)
                this.textBoxPdw.Text += pNumero;
        }

        private void VentanaPin_Load(object sender, EventArgs e)
        {

        }
    }
}
