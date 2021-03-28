﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appE3_SGDE.Datoss;

namespace appE3_SGDE.Vistaa
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmListarClientes_Load(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();
            List<clCliente> listClientes = new List<clCliente>();
            listClientes = objCliente.mtdListarCliente();
            dgvListarClientes.DataSource = listClientes;
        }

        public void mtdCargarGrind()
        {
            clCliente objClientes = new clCliente();
            List<clCliente> listClientes = new List<clCliente>();
            listClientes = objClientes.mtdListarCliente();
            dgvListarClientes.DataSource = listClientes;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            clCliente objCliente = new clCliente();
            objCliente.nombre = txtNombre.Text;
            objCliente.apellido = txtApellido.Text;
            objCliente.direccion = txtDireccion.Text;
            objCliente.telefono = txtTelefono.Text;
            objCliente.email = txtEmail.Text;
            objCliente.nombreEmpresa = txtNombreEmpresa.Text;

            int cantidadRegistros = objCliente.mtdRegistrar();
            if (cantidadRegistros > 0)
            {
                mtdCargarGrind();
                MessageBox.Show("Cliente Registrado", "SGDE", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error Al Registrar", "SGDE", MessageBoxButtons.OK);
            }

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNombreEmpresa.Text = "";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNombreEmpresa.Text = "";
        }

        int idCLienteBorrar = 0;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();
            objCliente.idCliente = idCLienteBorrar;

            if (objCliente.mtdEliminar() > 0)
            {
                MessageBox.Show("Cliente Eliminado");
                mtdCargarGrind();

            }
            else
            {
                MessageBox.Show("Error, no se pudo eliminar el cliente");
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

            frmBuscarCliente objBuscarCliente = new frmBuscarCliente();
            objBuscarCliente.ShowDialog();
        }
    }
}

