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
    public partial class ServiciosCorporativos : Form {

        private String cod, nom, tipo, tec;
        private int cant;
        private double sub, total;
        public ServiciosCorporativos() {
            InitializeComponent();
            removerItem(this);
            admVent.piel(this, contextMenuStrip1);
            comboBox1.SelectedIndex = 0;
        }
        private void ServiciosCorporativos_FormClosing(object sender, FormClosingEventArgs e) {
            if(MessageBox.Show("¿Seguro que desea volver al menú?", "VOLVIENDO AL MENÚ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                new Menu().Show();
                Dispose(true);
            } else {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            limpiar();
        }
     
        private void button1_Click(object sender, EventArgs e) {
            cod = nom = tipo = tec = String.Empty;
            cant = 0; sub = total = 0;
            capturar();
            if(cod == "" || nom == "" || tipo == "" || tec == String.Empty || cant == 0) {
                MessageBox.Show("No se han ingresado algunos datos.");
                return;
            }
            calcular();
        }

        private void limpiar() {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            comboBox1.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            cod = nom = tipo = tec = String.Empty;
            cant = 0;
            sub = total = 0;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if(!char.IsNumber(c) && !((Keys) c == Keys.Back)) {
                e.Handled = true;
            }
        }

        private void calcular() {
            int montoTipo = 0;
            switch(tipo) {
                case "Soporte Tics":
                    montoTipo = 500;
                    break;
                case "Redes locales":
                    montoTipo = 650;
                    break;
                case "Fibra óptica":
                    montoTipo = 4500;
                    break;
                case "Desarrollo":
                    montoTipo = 2000;
                    break;
            }
            sub = cant * montoTipo;
            textBox5.Text = sub.ToString();
            total = sub * 1.13;
            textBox6.Text = total.ToString();
        }

        private void capturar() {
            cod = textBox1.Text;
            nom = textBox2.Text;
            tipo = comboBox1.SelectedItem.ToString();
            int.TryParse(textBox3.Text, out cant);
            tec = textBox4.Text;
        }

        public void abrirOpcion(object sender, EventArgs e) {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            if(t == menuPrincipalToolStripMenuItem) {
                new Menu().Visible = true;
            } else if(t == serviciosEspecializadosToolStripMenuItem) {
                new ServiciosEspecializados().Visible = true;
            } else if(t == serviciosCorporativosToolStripMenuItem) {
                new ServiciosCorporativos().Visible = true;
            } else if(t == callCenterToolStripMenuItem) {
                new CallCenter().Visible = true;
            } else if(t == salirToolStripMenuItem) {
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
            } else
            if(f.GetType().Equals(typeof(Menu))) {
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

    }

}
