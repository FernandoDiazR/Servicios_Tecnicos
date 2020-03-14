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
    public partial class ServiciosEspecializados : Form {

        private String cod, nom, tipo = "", tec;
        private int cant, total, montoTipo = 0;
        public ServiciosEspecializados() {
            InitializeComponent();
            removerItem(this);
            admVent.piel(this, contextMenuStrip1);
        }

        private void button1_Click(object sender, EventArgs e) {
            cod = nom = tipo = tec = "";
            cant = total = montoTipo = 0;
            capturar();
            if(cod == "" || nom == "" || tipo == "" || tec == "" || cant == 0) {
                MessageBox.Show("No se han ingresado algunos datos.");
                return;
            }
            calcular();
        }

        private void button3_Click(object sender, EventArgs e) {
            foreach(DataGridViewRow v in dataGridView1.SelectedRows) {
                dataGridView1.Rows.Remove(v);
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            dataGridView1.SelectAll();
            foreach(DataGridViewRow v in dataGridView1.SelectedRows) {
                dataGridView1.Rows.Remove(v);
            }
        }

        private void ServiciosEspecializados_FormClosing(object sender, FormClosingEventArgs e) {
            if(MessageBox.Show("¿Seguro que desea volver al menú?", "VOLVIENDO AL MENÚ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                new Menu().Show();
                this.Dispose();
            } else {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            limpiar();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if(!Char.IsDigit(c) && !((Keys)c == Keys.Back)) {
                e.Handled = true;
            }
        }

        private void limpiar() {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox6.Text = "";
            cod = nom = tipo = tec = "";
            cant = total = montoTipo = 0;
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = false;
        }
        private void capturar() {
            cod = textBox1.Text;
            nom = textBox2.Text;
            if(checkBox1.Checked) {
                tipo += checkBox1.Text;
            }
            if(checkBox2.Checked) {
                tipo += "/" + checkBox2.Text;
            }
            if(checkBox3.Checked) {
                tipo += "/" + checkBox3.Text;
            }
            Int32.TryParse(textBox3.Text, out cant);
            tec = textBox4.Text;
        }
        private void calcular() {
            if(checkBox1.Checked) {
                montoTipo += 3000;
            }
            if(checkBox2.Checked) {
                montoTipo += 8000;
            }
            if(checkBox3.Checked) {
                montoTipo += 5000;
            }
            total = montoTipo * cant;
            textBox6.Text = total.ToString();
            dataGridView1.Rows.Add(new String[] { cod, nom, tipo, cant.ToString(), tec, total.ToString() });
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
