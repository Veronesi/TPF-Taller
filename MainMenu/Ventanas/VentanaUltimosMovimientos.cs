﻿using System;
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
    public partial class VentanaUltimosMovimientos : Form
    {
        public String iNombre;
        public String iDni;
        public VentanaUltimosMovimientos(String pNombre, String pDni)
        {
            this.iNombre = pNombre;
            this.iDni = pDni;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void VentanaUltimosMovimientos_Load(object sender, EventArgs e)
        {
            VentanaCargando ventanaCargando = new VentanaCargando();
            /* Obtenemos los ultimos movimientos */
            try
            {
                ventanaCargando.Show();
                getJson json = new getJson();
                JsonMovement getJson = json.UltimosMovimientos(this.iDni);
                ventanaCargando.Hide();
                if (getJson == null)
                    throw new JsonNullException();

                if (getJson.response.movements.Count == 0)
                    throw new MovementsNullException();

                foreach (Movement movimiento in getJson.response.movements)
                {
                    dataGridMovimientos.Rows.Add(movimiento.date, movimiento.ammount);
                }
            }
            catch(JsonNullException)
            {
                MessageBox.Show("Servicio no Disponible", "Error");
            }
            catch (MovementsNullException)
            {
                MessageBox.Show("No posee movimientos", "Error");
            }
            catch (Exception err)
            {
                ventanaCargando.Hide();
                Log.save(err);
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
