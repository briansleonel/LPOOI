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
    public partial class FrmLogin : Form {

        /*
        private Usuario[] Usuarios;

        private Rol[] Roles;
         * 
         * */


        public FrmLogin() {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {

        }

        private void btnIngresar_Click(object sender, EventArgs e) {
            //Cargar Roles
            Rol rol1 = new Rol(1, "Administrador");
            Rol rol2 = new Rol(2, "Operador");
            Rol rol3 = new Rol(3, "Auditor");

            //Cargar Usuarios
            Usuario usr1 = new Usuario(1, "pepe", "pepe", "Pepe Saenz", 1);
            Usuario usr2 = new Usuario(2, "laura", "laura", "Laura Gomez", 2);
            Usuario usr3 = new Usuario(3, "carlos", "carlos", "Carlos Martinez", 3);

            bool userFound = false;

            if (txtUsername.Text == "" || txtPassword.Text == "") {
                MessageBox.Show("Debe ingresar un nombre de usuario y/o una contraseña", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                if (usr1.Usu_NombreUsuario == txtUsername.Text && usr1.Usu_Contrasenia == txtPassword.Text) {
                    userFound = true;
                } else if (usr2.Usu_NombreUsuario == txtUsername.Text && usr2.Usu_Contrasenia == txtPassword.Text) {
                    userFound = true;
                } else if (usr3.Usu_NombreUsuario == txtUsername.Text && usr3.Usu_Contrasenia == txtPassword.Text) {
                    userFound = true;
                }

                if (userFound) {
                    //MessageBox.Show("Bienvenido/a: " + txtUsername.Text);

                    this.Hide();
                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                    this.Close();
                } else {
                    MessageBox.Show("Nombre de usuario y/o contraseña incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarTextBox();
                }
            }
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e) {
            btnIngresar.BackColor = Color.FromArgb(46, 110, 229);
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 110, 229);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e) {
            btnIngresar.BackColor = Color.FromArgb(27, 97, 226);
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 62, 164);
            //btnIngresar.BackColor = Color.FromArgb(27, 97, 226);
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
