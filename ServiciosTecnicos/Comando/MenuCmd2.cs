using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ServiciosTecnicos {
    class MenuCmd2 : Order {

        private Receptor receptor;

        public MenuCmd2(Receptor receptor) {
            this.receptor = receptor;
        }

        public String name() {
            return "pro";
        }

        public Image execute() {
            return receptor.MenuPro();
        }

        public Type type() {
            return typeof(Menu);
        }
    }
}
