using System;
using System.Windows.Forms;

namespace TIENDA_DE_ACTIVIDADES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTipoUsuario.SelectedIndex = 0;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelPrincipal.BackColor = colorDialog1.Color;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string mensaje = "CONFIGURACIÓN GUARDADA\n\n";
            mensaje += "Notificaciones: " + (chkNotificaciones.Checked ? "Sí" : "No") + "\n";
            mensaje += "Recordatorios: " + (chkRecordatorios.Checked ? "Sí" : "No") + "\n";
            mensaje += "Tipo de usuario: " + cmbTipoUsuario.SelectedItem.ToString() + "\n";
            mensaje += "Actividades seleccionadas:\n";

            if (clbActividades.CheckedItems.Count == 0)
            {
                mensaje += "- Ninguna actividad seleccionada\n";
            }
            else
            {
                foreach (object actividad in clbActividades.CheckedItems)
                {
                    mensaje += "- " + actividad.ToString() + "\n";
                }
            }

            lblResumen.Text = mensaje;
            MessageBox.Show(mensaje, "Mis preferencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            chkNotificaciones.Checked = true;
            chkRecordatorios.Checked = true;
            for (int i = 0; i < clbActividades.Items.Count; i++)
            {
                clbActividades.SetItemChecked(i, false);
            }
            cmbTipoUsuario.SelectedIndex = 0;
            panelPrincipal.BackColor = System.Drawing.Color.AliceBlue;
            lblResumen.Text = "Tus preferencias aparecen aqui";
        }

        private void elegirColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnColor_Click(sender, e);
        }

        private void restablecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRestablecer_Click(sender, e);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}