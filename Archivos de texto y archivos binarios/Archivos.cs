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
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Archivos BMP (*.bmp)|*.bmp|Todos los archivos|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                lblVerifica.Visible = true;

                if (isBMP(fd.FileName))
                {
                    lblVerifica.Text = "Archivo BMP encontrado";
                    enableControls(true);
                    fillInfo(fd.FileName);
                }
                else
                {
                    lblVerifica.Text = "El archivo seleccionado no es un BMP";
                    enableControls(false);
                }
            }
        }

        private void enableControls(bool mode)
        {
            if (mode)
            {
                lblTamaño.Enabled = true;
                lblAncho.Enabled = true;
                lblAlto.Enabled = true;
                lblBits.Enabled = true;
                txtTamaño.Enabled = true;
                txtAncho.Enabled = true;
                txtAlto.Enabled = true;
                txtBits.Enabled = true;
                lblTamañoMedida.Enabled = true;
                lblAnchoMedida.Enabled = true;
                lblAltoMedida.Enabled = true;
                lblBitsMedida.Enabled = true;
            }
            else
            {
                lblTamaño.Enabled = false;
                lblAncho.Enabled = false;
                lblAlto.Enabled = false;
                lblBits.Enabled = false;
                txtTamaño.Enabled = false;
                txtAncho.Enabled = false;
                txtAlto.Enabled = false;
                txtBits.Enabled = false;
                lblTamañoMedida.Enabled = false;
                lblAnchoMedida.Enabled = false;
                lblAltoMedida.Enabled = false;
                lblBitsMedida.Enabled = false;
                txtTamaño.Clear();
                txtAncho.Clear();
                txtAlto.Clear();
                txtBits.Clear();
            }
        }

        private Int16 get2ByteData(string file, int startPoint)
        {
            Int16 data;
            FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);

            stream.Position = startPoint;
            data = br.ReadInt16();

            br.Close();
            stream.Close();
            return data;
        }

        private bool isBMP(string file)
        {
            return (get2ByteData(file, 0) == 19778) ? true : false;
        }

        private Int32 get4ByteData(string file, int startPoint)
        {
            Int32 data;
            FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);

            stream.Position = startPoint;
            data = br.ReadInt32();

            br.Close();
            stream.Close();
            return data;
        }

        private Int32 getSize(string file)
        {
            return get4ByteData(file, 2);
        }

        private Int32 getWidth(string file)
        {
            return get4ByteData(file, 18);
        }

        private Int32 getHeight(string file)
        {
            return get4ByteData(file, 22);
        }

        private Int16 getBitDepth(string file)
        {
            return get2ByteData(file, 28);
        }

        private void fillInfo(string file)
        {
            txtTamaño.Text = getSize(file).ToString();
            txtAlto.Text = getHeight(file).ToString();
            txtAncho.Text = getWidth(file).ToString();
            txtBits.Text = getBitDepth(file).ToString();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            new Agenda().ShowDialog();
        }

        private void Archivos_Load(object sender, EventArgs e)
        {

        }
    }
}