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
    public partial class Carga : Form {
        public Carga() {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if(progressBar1.Value < 100) {
                int num = new Random(1).Next(5);
                if(progressBar1.Value + num < 100) {
                    progressBar1.Value += num;
                } else {
                    progressBar1.Value = 100;
                }
                label1.Text = "Cargando :" + progressBar1.Value + "%";
            } else {
                new Login().Show();
                this.Dispose();
            }
        }
    }
}
