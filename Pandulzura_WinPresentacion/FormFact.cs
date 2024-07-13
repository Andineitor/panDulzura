using Pandulzura_AccesoDatos.Entidades;
using Pandulzura_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandulzura_WinPresentacion
{
    public partial class FormFact : Form
    {

        private FacturaLogica factLogica;
        private Factura nuevaFac;

        public FormFact()
        {
            InitializeComponent();
            factLogica = new FacturaLogica();
            nuevaFac = new Factura();
        }

        //Listar
        public void listarRol()
        {
            
        }

        //Insertar
        public void insertar()
        {
            
        }
        private void LimpiarCampos()
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
