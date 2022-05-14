using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas {
    public partial class FrmTabCtrlClientes : Form {
        public FrmTabCtrlClientes() {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (TextBoxVacios()) {
                MessageBox.Show("No se puede guardar con campos vacíos", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                var oResultMsg = MessageBox.Show("¿Guardar datos?", "Guardar", MessageBoxButtons.YesNo);

                if (oResultMsg == DialogResult.Yes) {
                    Cliente oCliente = new Cliente();

                    oCliente.Cli_DNI = txtDNI.Text;
                    oCliente.Cli_Apellido = txtApellido.Text;
                    oCliente.Cli_Nombre = txtNombre.Text;
                    oCliente.Cli_Direccion = txtDireccion.Text;
                    oCliente.Cli_NroCarnet = txtNroCarnet.Text;
                    oCliente.OS_CUIT = txtCUITObraSocial.Text;

                    MessageBox.Show("¡Datos guardados correctamente!\n\n" +
                                    "\nDNI: " + oCliente.Cli_DNI +
                                    "\nApellido y nombre: " + oCliente.Cli_Apellido + ", " + oCliente.Cli_Nombre, "Guardado");

                    limpiarTextBox();
                }
            }
        }

        private bool TextBoxVacios() {
            foreach (Control oControl in this.Controls) {
                //Preguntamos por cada TextBox de los controles del formulario
                if (oControl is TextBox) {
                    TextBox textBox = oControl as TextBox;
                    //Si algún TextBox se encontrase vacío la variable auxiliar se vuelve "true"
                    if (textBox.Text == string.Empty) {
                        return true;
                    }
                }
            }
            return false;
        }

        private void limpiarTextBox() {
            foreach (Control oControls in this.Controls) {
                if (oControls is TextBox) {
                    TextBox textBox = oControls as TextBox;
                    textBox.Text = string.Empty;
                }
            }
        }
    }
}
