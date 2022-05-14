using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas {
    public partial class FrmMain : Form {

        //creo variable para almacenar el formulario activo
        private Form activeForm = null;

        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            //Abrir el panel de sistema al inicio siempre
            btnSistema_Click(null, e);
        }

        private void AbrirFormularioHijoOptimizado(Form formularioHijo) {
            //Pregunto si hay un formulario abierto, en el caso de que lo haya, lo cierro
            if (activeForm != null) {
                activeForm.Close();
            }

            this.activeForm = formularioHijo;    //seteo el formulario hijo a la variable
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            this.pnlContenedorFormHijo.Controls.Add(formularioHijo);
            this.pnlContenedorFormHijo.Tag = formularioHijo;
            formularioHijo.Show();

        }

        #region Botones

        private void btnSistema_Click(object sender, EventArgs e) {
            AbrirFormularioHijoOptimizado(new FrmTabCtrlInicio());
        }

        private void btnProductos_Click(object sender, EventArgs e) {
            AbrirFormularioHijoOptimizado(new FrmTabCtrlProductos());
        }

        private void btnClientes_Click(object sender, EventArgs e) {
            AbrirFormularioHijoOptimizado(new FrmTabCtrlClientes());
        }

        private void btnObrasSociales_Click(object sender, EventArgs e) {
            AbrirFormularioHijoOptimizado(new FrmTabCtrlObrasSociales());
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            var oResultMsg = MessageBox.Show("¿Cerrar sesión?", "Salir", MessageBoxButtons.YesNo);
            if (oResultMsg == DialogResult.Yes) {
                //FrmMain.ActiveForm.Hide();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Activate();
                frmLogin.Show();
                this.Close();
            }
        }

        #endregion

    }
}
