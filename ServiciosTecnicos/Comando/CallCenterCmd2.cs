using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ServiciosTecnicos {
    class CallCenterCmd2 : Order {

        private Receptor receptor;

        public CallCenterCmd2(Receptor receptor) {
            this.receptor = receptor;
        }

        public String name() {
            return "pro";
        }

        public Image execute() {
            return receptor.callPro();
        }

        public Type type() {
            return typeof(CallCenter);
        }
    }
}
