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
    public partial class VentanaDni : Form
    {
        public VentanaDni()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void VentanaDni_Load(object sender, EventArgs e)
        {

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
            this.textBoxDni.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxDni.Text == "")
                    throw new DniNullException();

                OperationRegister.dni(this.textBoxDni.Text);

                VentanaPin ventanaPin = new VentanaPin(this.textBoxDni.Text);
                ventanaPin.Show();
                this.Hide();
            }
            catch(DniNullException)
            {
                MessageBox.Show("Por favor ingrese un DNI.", "Error");
            }
            catch (Exception err)
            {
                Log.save(err);
            }
        }

        private void setNumber(String pNumber)
        {
            this.textBoxDni.Text += pNumber;
        }
        private void VentanaDni_Click(object sender, EventArgs e)
        {

        }
    }
}
