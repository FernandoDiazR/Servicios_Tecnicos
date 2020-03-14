using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ServiciosTecnicos {
    class BackEspCmd1 : Order {

        private Receptor receptor;

        public BackEspCmd1(Receptor receptor) {
            this.receptor = receptor;
        }

        public String name() {
            return "anime";
        }

        public Image execute() {
            return receptor.backEspAnime();
        }

        public Type type() {
            return typeof(ServiciosEspecializados);
        }
    }
}
