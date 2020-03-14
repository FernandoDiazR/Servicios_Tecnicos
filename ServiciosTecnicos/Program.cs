using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ServiciosTecnicos {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new admVent());
        }
    }

    class admVent : System.Windows.Forms.ApplicationContext {

        private static Receptor r;
        public static bool pielPro = true;
        public static bool primeraVez;
        public static Invocador inv;
        public admVent() {
            r = new Receptor();
            inv = new Invocador();
            inv.add(new ContextCmd1(r));
            inv.add(new ContextCmd2(r));
            inv.add(new MenuCmd1(r));
            inv.add(new MenuCmd2(r));
            inv.add(new CorporativosCmd1(r));
            inv.add(new CorporativosCmd2(r));
            inv.add(new BackEspCmd1(r));
            inv.add(new BackEspCmd2(r));
            inv.add(new GroupEspCmd1(r));
            inv.add(new GroupEspCmd2(r));
            inv.add(new CallCenterCmd1(r));
            inv.add(new CallCenterCmd2(r));
            new Carga().Show();
        }
		
        public static void piel(Form f, ContextMenuStrip c) {
            if(!admVent.pielPro) {
                GroupBox gp;
                foreach(Control ct in f.Controls) {
                    if(ct.GetType() == typeof(GroupBox)) {
                        gp = (GroupBox) ct;
                        ct.BackgroundImage = admVent.inv.execute(typeof(GroupBox).ToString() + "anime");
                        break;
                    }
                }
                c.BackgroundImage = admVent.inv.execute(typeof(ContextMenuStrip).ToString() + "anime");
                f.BackgroundImage = admVent.inv.execute(f.GetType().ToString() + "anime");
            } else {
                GroupBox gp;
                foreach(Control ct in f.Controls) {
                    if(ct.GetType() == typeof(GroupBox)) {
                        gp = (GroupBox)ct;
                        ct.BackgroundImage = admVent.inv.execute(typeof(GroupBox).ToString() + "pro");
                        break;
                    }
                }
                c.BackgroundImage = admVent.inv.execute(typeof(ContextMenuStrip).ToString() + "pro");
                f.BackgroundImage = admVent.inv.execute(f.GetType().ToString() + "pro");
            }
        }
    }
}
