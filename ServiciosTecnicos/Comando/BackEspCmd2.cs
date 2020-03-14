using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ServiciosTecnicos {
    class BackEspCmd2 : Order {

        private Receptor receptor;

        public BackEspCmd2(Receptor receptor) {
            this.receptor = receptor;
        }

        public String name() {
            return "pro";
        }

        public Image execute() {
            return receptor.backEspPro();
        }

        public Type type() {
            return typeof(ServiciosEspecializados);
        }
    }
}
