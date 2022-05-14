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
    public partial class FrmTabCtrlObrasSociales : Form {
        public FrmTabCtrlObrasSociales() {
            InitializeComponent();
        }

        private void FrmTabCtrlObrasSociales_Load(object sender, EventArgs e) {

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

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (TextBoxVacios()) {
                MessageBox.Show("No se puede guardar con campos vacíos", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                var oResultMsg = MessageBox.Show("¿Guardar datos?", "Guardar", MessageBoxButtons.YesNo);

                if (oResultMsg == DialogResult.Yes) {
                    ObraSocial oObraSocial = new ObraSocial();

                    oObraSocial.OS_CUIT = txtCUIT.Text;
                    oObraSocial.OS_RazonSocial = txtRazonSocial.Text;
                    oObraSocial.OS_Direccion = txtDireccion.Text;
                    oObraSocial.OS_Telefono = txtTelefono.Text;

                    MessageBox.Show("¡Datos guardados correctamente!\n\n" +
                                    "\nCUIT: " + oObraSocial.OS_CUIT +
                                    "\nRazón Social: " + oObraSocial.OS_RazonSocial, "Guardado");
                    
                    limpiarTextBox();
                }
            }
        }
    }
}
