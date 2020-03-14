using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ServiciosTecnicos {
    class CorporativosCmd1 : Order {

        private Receptor receptor;

        public CorporativosCmd1(Receptor receptor) {
            this.receptor = receptor;
        }

        public String name() {
            return "anime";
        }

        public Image execute() {
            return receptor.corpAnime();
        }

        public Type type() {
            return typeof(ServiciosCorporativos);
        }
    }
}
