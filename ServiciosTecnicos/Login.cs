using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ServiciosTecnicos {
    public partial class Login : Form {

        private String nameRegistered = "Miguel2017";
        private String passRegistered = "santocielo";
        private int px, py;
        private bool mover;
        SoundPlayer simpleSound;
        public Login() {
            simpleSound = new SoundPlayer(ServiciosTecnicos.Properties.Resources.Elevator);
            simpleSound.Play();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            String name = textBox1.Text;
            String pass = textBox2.Text;
            if(name.Equals(nameRegistered) && pass.Equals(passRegistered)) {
                new Menu().Show();
                this.Dispose();
                simpleSound.Stop();
            } else {
                MessageBox.Show("Los datos ingresados como usuario o contraseña son incorrectos.", "DATOS INCORRECTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e) {
            if(MessageBox.Show("¿Seguro que desea salir de la aplicación?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Dispose(true);
                Application.Exit();
            } else {
                e.Cancel = true;
            }
        }
        private void Login_MouseDown(object sender, MouseEventArgs e) {
            px = e.X;
            py = e.Y;
            mover = true;
        }
        private void Login_MouseUp(object sender, MouseEventArgs e) {
            mover = false;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e) {
            if(mover) {
                int x = MousePosition.X - this.Location.X - px;
                int y = MousePosition.Y - this.Location.Y - py;
                Point p = new Point(x, y);
                this.Location = PointToScreen(p);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            pictureBox1.Image = ServiciosTecnicos.Properties.Resources.xx;
            this.Close();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e) {
            pictureBox1.Image = ServiciosTecnicos.Properties.Resources.xy;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e) {
            pictureBox1.Image = ServiciosTecnicos.Properties.Resources.xy_hover;
        }

        
    }
}
