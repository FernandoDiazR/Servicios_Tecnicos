using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace ServiciosTecnicos {
    class Invocador {

        private Dictionary<String, Order> ordenes;

        public Invocador() {
            this.ordenes = new Dictionary<String, Order>();

        }

        public void add(Order orden) {
            ordenes.Add(orden.type().ToString()+orden.name(), orden);
        }

        public Image execute(String o) {
            return this.ordenes[o].execute();
        }

    }
}
