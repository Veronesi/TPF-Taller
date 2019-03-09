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
    public partial class Form2 : Form
    {
        private String iDni;
        public Form2(String pDni)
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
            if (this.textBoxPdw.TextLength == this.textBoxPdw.MaxLength)
            {
                getJson json = new getJson();
                Clients getJson = json.Clients(this.iDni, this.textBoxPdw.Text);
                if (getJson != null)
                {
                    Form3 frm3 = new Form3(getJson.response.client.name, getJson.id);
                    frm3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El DNI o el PIN es incorrecto", "Error");
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("El pin debe ser de "+this.textBoxPdw.MaxLength+" caracteres", "Error");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
        private void ingresarNumero(string pNumero)
        {
            if (this.textBoxPdw.TextLength < this.textBoxPdw.MaxLength)
                this.textBoxPdw.Text += pNumero;
        }
    }
}
