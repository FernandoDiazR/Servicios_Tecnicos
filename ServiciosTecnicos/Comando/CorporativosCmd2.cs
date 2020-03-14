using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ServiciosTecnicos {
    class CorporativosCmd2 : Order {

        private Receptor receptor;

        public CorporativosCmd2(Receptor receptor) {
            this.receptor = receptor;
        }

        public String name() {
            return "pro";
        }

        public Image execute() {
            return receptor.corpPro();
        }

        public Type type() {
            return typeof(ServiciosCorporativos);
        }
    }
}
