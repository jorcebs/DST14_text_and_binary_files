using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Archivos_de_texto_y_archivos_binarios
{
    public partial class Agenda : Form
    {

        XmlHandler handler;

        public Agenda()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Archivos XML (*.xml)|*.xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(fileDialog.FileName, FileMode.Create); stream.Close();
                handler = new XmlHandler(fileDialog.FileName);
                handler.escribeEncabezado();
                enableControls();
                txtNum.Text = (handler.getRegistros() + 1).ToString();
                actualizaNavegación();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            handler.escribeContacto(new Contacto(handler.getRegistros() + 1, txtNombre.Text, Convert.ToInt32(txtEdad.Text), txtCorreo.Text, txtCelular.Text, (rdbSí.Checked) ? true : false));
            btnAgregar.Enabled = false;
        }

        private void enableControls()
        {
            lblNombre.Enabled = true;
            lblEdad.Enabled = true;
            lblCorreo.Enabled = true;
            lblCelular.Enabled = true;
            lblSoltero.Enabled = true;
            lblNum.Enabled = true;

            txtNombre.Enabled = true;
            txtEdad.Enabled = true;
            txtCorreo.Enabled = true;
            txtCelular.Enabled = true;

            rdbSí.Enabled = true;
            rdbNo.Enabled = true;

            btnNuevoRegistro.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
        }

        private void limpiarControles()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
            txtCelular.Clear();
            rdbSí.Checked = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Contacto[] contactos = handler.leerContactos();
            txtNombre.Text = contactos[Convert.ToInt32(txtNum.Text) - 2].nombre;
            txtEdad.Text = contactos[Convert.ToInt32(txtNum.Text) - 2].edad.ToString();
            txtCorreo.Text = contactos[Convert.ToInt32(txtNum.Text) - 2].correo;
            txtCelular.Text = contactos[Convert.ToInt32(txtNum.Text) - 2].celular;
            if (contactos[Convert.ToInt32(txtNum.Text) - 2].soltero)
                rdbSí.Checked = true;
            else
                rdbNo.Checked = true;
            txtNum.Text = (Convert.ToInt32(txtNum.Text) - 1).ToString();
            actualizaNavegación();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Contacto[] contactos = handler.leerContactos();
            txtNombre.Text = contactos[Convert.ToInt32(txtNum.Text)].nombre;
            txtEdad.Text = contactos[Convert.ToInt32(txtNum.Text)].edad.ToString();
            txtCorreo.Text = contactos[Convert.ToInt32(txtNum.Text)].correo;
            txtCelular.Text = contactos[Convert.ToInt32(txtNum.Text)].celular;
            if (contactos[Convert.ToInt32(txtNum.Text)].soltero)
                rdbSí.Checked = true;
            else
                rdbNo.Checked = true;
            txtNum.Text = (Convert.ToInt32(txtNum.Text) + 1).ToString();
            actualizaNavegación();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivos XML (*.xml)|*.xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                handler = new XmlHandler(fileDialog.FileName);
                enableControls();
                txtNum.Text = (handler.getRegistros() + 1).ToString();
                actualizaNavegación();
            }
        }

        private void actualizaNavegación()
        {
            btnAgregar.Enabled = false;
            int pos = Convert.ToInt32(txtNum.Text);
            if (pos == 1)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = (handler.getRegistros() <= 1)? false : true;
            }
            else if(pos > 1)
            {
                btnPrevious.Enabled = true;
                btnNext.Enabled = (handler.getRegistros() > pos) ? true : false;
            }

        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            limpiarControles();
            txtNum.Text = (handler.getRegistros() + 1).ToString();
            actualizaNavegación();
            btnAgregar.Enabled = true;
        }
    }
}