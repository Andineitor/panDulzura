﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pandulzura_AccesoDatos.Entidades;
using Pandulzura_LogicaNegocio;

namespace Pandulzura_WinPresentacion
{
    
    public partial class FormRol : Form
    {
        private RolLogica rolLogica;
        private Rol nuevoRol;

        public FormRol()
        {
            InitializeComponent();
            rolLogica = new RolLogica();
            nuevoRol = new Rol();
        }

        //Listar
        public void listarRol()
        {
            dgvRol.DataSource = rolLogica.ListarRol();
        }

        //Insertar
        public void insertarRol()
        {
            nuevoRol.IdRol = txtRol.Text;
            nuevoRol.NombreRol = txtNombre.Text;
            if (rolLogica.InsertarRol(nuevoRol))
            {
                MessageBox.Show("EL registro se Inserto correctamente");
                listarRol();
            }
            else
            {
                MessageBox.Show("Error al insertar");

            }
        }
        private void LimpiarCampos()
        {
            // Limpiar el contenido de los TextBox u otros controles que desees limpiar
            txtRol.Clear();
            txtNombre.Clear();
            // Agrega más líneas para limpiar otros campos si es necesario
        }
        private void FormRol_Load(object sender, EventArgs e)
        {
            listarRol();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listarRol();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insertarRol();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
