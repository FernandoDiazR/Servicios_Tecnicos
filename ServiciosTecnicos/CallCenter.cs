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
    public partial class CallCenter : Form {

        private String cod, nom, ape, pais, tipo, fecha, inicio, final, comment;
        public CallCenter() {
            InitializeComponent();
            removerItem(this);
            admVent.piel(this, contextMenuStrip1);
        }

        private void changeAMPM(object sender, EventArgs e){
            Button b = (Button)sender;
            if(b.Text.Equals("AM")) {
                b.Text = "PM";
            } else {
                b.Text = "PM";
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            capturar();
            bool b1 = (cod != String.Empty && nom != String.Empty && ape != String.Empty);
            bool b2 = (pais != String.Empty && tipo != String.Empty && fecha != String.Empty);
            bool b3 = (inicio != String.Empty && final != String.Empty && comment != String.Empty);
            if(b1 && b2 && b3) {
                dataGridView1.Rows.Add(new String[] { cod, nom, ape, pais, tipo, fecha, inicio, final, comment });
                limpiar();
            } else {
                MessageBox.Show("Algunos datos no se han ingresado.", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void CallCenter_FormClosing(object sender, FormClosingEventArgs e) {
            if(MessageBox.Show("¿Seguro que desea volver al menú?", "VOLVIENDO AL MENÚ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                new Menu().Show();
                Dispose(true);
            } else {
                e.Cancel = true;
            }
        }

        private void capturar() {
            cod = textBox1.Text;
            nom = textBox2.Text;
            ape = textBox3.Text;
            pais = textBox4.Text;
            tipo = textBox5.Text;
            fecha = dateTimePicker1.Text;
            DateTime dt1 = new DateTime(), dt2 = new DateTime();
            inicio = (DateTime.TryParse(maskedTextBox1.Text, out dt1)) ? dt1.ToString("hh:mm:ss") + " " + button1.Text : "";
            final = (DateTime.TryParse(maskedTextBox2.Text, out dt2)) ? dt2.ToString("hh:mm:ss") + " " + button2.Text : "";
            if(inicio == String.Empty || final == String.Empty || dt1.Hour > 12 || dt2.Hour > 12) {
                MessageBox.Show("Formato de hora de inicio o final es incorrecto.");
                return;
            }
            comment = richTextBox1.Text;
        }

       

        private void button4_Click(object sender, EventArgs e) {
            limpiar();
        }

        private void limpiar() {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = richTextBox1.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            maskedTextBox1.Text = maskedTextBox2.Text = "__:__:__";
            cod = nom = ape = pais = tipo = fecha = inicio = final = comment = "";
        }

        private void button6_Click(object sender, EventArgs e) {
            dataGridView1.SelectAll();
            foreach(DataGridViewRow dr in dataGridView1.SelectedRows) {
                dataGridView1.Rows.Remove(dr);
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            foreach(DataGridViewRow dr in dataGridView1.SelectedRows) {
                dataGridView1.Rows.Remove(dr);
            }
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
