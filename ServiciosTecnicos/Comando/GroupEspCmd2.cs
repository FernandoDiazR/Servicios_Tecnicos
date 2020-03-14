using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ServiciosTecnicos {
    class GroupEspCmd2 : Order {

        private Receptor receptor;

        public GroupEspCmd2(Receptor receptor) {
            this.receptor = receptor;
        }

        public String name() {
            return "pro";
        }

        public Image execute() {
            return receptor.groupEspPro();
        }

        public Type type() {
            return typeof(GroupBox);
        }
    }
}
