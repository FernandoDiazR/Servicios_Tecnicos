using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiciosTecnicos {
    public partial class Menu : Form {

        public Menu() {
            InitializeComponent();
            removerItem(this);
            admVent.piel(this, contextMenuStrip1);
            if(!admVent.primeraVez) {
                MessageBox.Show("Bienvenido al menú del proyecto de Programación IV", "BIENVENIDO");
                admVent.primeraVez = true;
            }
        }

        private void especializadosToolStripMenuItem_Click(object sender, EventArgs e) {
            new ServiciosEspecializados().Show();
            Dispose();
        }

        private void callCenterToolStripMenuItem1_Click(object sender, EventArgs e) {
            new CallCenter().Show();
            Dispose();
        }

        private void corporativosToolStripMenuItem_Click(object sender, EventArgs e) {
            new ServiciosCorporativos().Show();
            Dispose();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e) {
            if(MessageBox.Show("¿Seguro que desea salir de la aplicación?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Dispose(true);
                Application.Exit();
            } else {
                e.Cancel = true;
            }
        }

        public void abrirOpcion(object sender, EventArgs e) {
            ToolStripMenuItem t = (ToolStripMenuItem) sender;
            if(t == menuPrincipalToolStripMenuItem) {
                new Menu().Visible = true;
            } else if(t == serviciosEspecializadosToolStripMenuItem) {
                new ServiciosEspecializados().Visible = true;
            } else if(t == serviciosCorporativosToolStripMenuItem) {
                new ServiciosCorporativos().Visible = true;
            } else if (t == callCenterToolStripMenuItem) {
                new CallCenter().Visible = true;
            } else if (t == salirToolStripMenuItem){
                if(MessageBox.Show("¿Seguro que desea salir de la aplicación?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    Dispose(true);
                    Application.Exit();
                } else {
                    return;
                }
            }
            Dispose();
        }

        public void removerItem(Form f) {
            ToolStripMenuItem i;
            if(f.GetType().Equals(typeof(CallCenter))) {
                i = callCenterToolStripMenuItem;
            } else if(f.GetType().Equals(typeof(Menu))) {
                i = menuPrincipalToolStripMenuItem;
            } else if(f.GetType().Equals(typeof(ServiciosCorporativos))) {
                i = serviciosCorporativosToolStripMenuItem;
            } else if(f.GetType().Equals(typeof(ServiciosEspecializados))) {
                i = serviciosEspecializadosToolStripMenuItem;
            } else {
                return;
            }
            contextMenuStrip1.Items.Remove(i);
        }

        private void animeToolStripMenuItem_Click(object sender, EventArgs e) {
            admVent.pielPro = false;
            admVent.piel(this, contextMenuStrip1);
        }

        private void profesionalToolStripMenuItem_Click(object sender, EventArgs e) {
            admVent.pielPro = true;
            admVent.piel(this, contextMenuStrip1);
        }

        
    }
}
