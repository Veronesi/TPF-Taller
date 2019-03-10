﻿using System;
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
    public partial class Form3 : Form
    {
        private String iNombre;
        private String iDni;
        public Form3(String pNombre, String pDni)
        {
            this.iNombre = pNombre;
            this.iDni = pDni;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.labelNombre.Text = $"Bienvenido {this.iNombre}";
        }

        private void btnBlanqueo_Click(object sender, EventArgs e)
        {
            getJson json = new getJson();
            Products getJson = json.Products(this.iDni);
            if (getJson != null)
            {
                Form4 frm4 = new Form4(getJson.response.product, this.iDni, this.iNombre);
                frm4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Servicio no Disponible", "Error");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
