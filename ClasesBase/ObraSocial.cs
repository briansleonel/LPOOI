using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase {
    public class ObraSocial {

        private string os_CUIT;
        public string OS_CUIT  {
            get {
                return os_CUIT;
            }
            set {
                 os_CUIT = value;
            }
        }

        private string os_RazonSocial;
        public string OS_RazonSocial  {
            get {
                return os_RazonSocial;
            }
            set {
                 os_RazonSocial = value;
            }
        }

        private string os_Direccion;
        public string OS_Direccion  {
            get {
                return os_Direccion;
            }
            set {
                 os_Direccion = value;
            }
        }

        private string os_Telefono;
        public string OS_Telefono {
            get {
                return os_Telefono;
            }
            set {
                 os_Telefono = value;
            }
        }
    }
}
